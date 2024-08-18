using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SumoTTP
{
    static class PackerTools
    {
        private static ToolStripProgressBar _toolStripProgressBar;
        private static ToolStripStatusLabel _toolStripStatusLabel;
        private static SynchronizationContext _synchronizationContext;

        private static long packageSize;
        private static long progress;
        public static bool abort;
        private static bool overwriteFiles;
        private static int inDirectoryPathLength;

        public static readonly string[] specialUnpackFiles = new string[] {  "racers.zat", "weaponpodallocation.zat" };
        public static readonly string[] specialPackFiles = new string[] { "racers.dat", "weaponpodallocation.dat" };

        public static void Init(ToolStripProgressBar toolStripProgressBar, ToolStripStatusLabel toolStripStatusLabel, SynchronizationContext synchronizationContext)
        {
            _toolStripProgressBar = toolStripProgressBar;
            _toolStripStatusLabel = toolStripStatusLabel;
            _synchronizationContext = synchronizationContext;
        }

        public static void Pack(string inDirectoryPath, string outDirectoryPath)
        {
            abort = false;
            overwriteFiles = false;
            SetProgressBarValue(0);
            progress = 0;

            DirectoryInfo inDirectory = new DirectoryInfo(inDirectoryPath);
            inDirectoryPathLength = inDirectory.FullName.Length;
            packageSize = GetDirectorySize(inDirectory);
            long entryCount = GetDirectoryItemCount(inDirectory) + 1;


            Toc toc = new Toc(inDirectory.Name, entryCount);
            Pack(toc, 0, 1, inDirectory, outDirectoryPath);

            if (!abort)
            {
                byte[] rawToc = toc.CreateRawToc();
                CryptTools.TocDecryptEncrypt(rawToc);
                SafeFileWrite(JoinPaths(outDirectoryPath, toc.name + ".toc"), rawToc);
            }


            if (abort)
            {
                SetProgressBarValue(0);
                SetStatusText("Aborted!");
            }
            else
            {
                SetStatusText("Finished!");
            }
        }

        public static uint Pack(Toc toc, uint tocIndex, uint tocOffset, DirectoryInfo currentInDirectory, string outDirectoryPath)
        {
            if (abort)
            {
                return 0;
            }

            DirectoryInfo[] subDirectories = currentInDirectory.GetDirectories();
            FileInfo[] files = currentInDirectory.GetFiles();
            uint itemCount = (uint)(subDirectories.Length + files.Length);

            tocEntryStruct tocEntry = new tocEntryStruct()
            {
                isFolder = true,
                length = itemCount,
                offset = tocOffset
            };

            if (tocIndex == 0)
            {
                tocEntry.name = "";
                tocEntry.nameChecksum = 0;
                tocEntry.container = uint.MaxValue;
            }
            else
            {
                tocEntry.name = currentInDirectory.Name;
                tocEntry.nameChecksum = CryptTools.GetNameChecksum(currentInDirectory.Name);
            }

            toc.entries[tocIndex] = tocEntry;

            uint i = 0;
            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                itemCount += Pack(toc, tocOffset + i, tocOffset + itemCount, subDirectory, outDirectoryPath);
                toc.entries[tocOffset + i].container = tocIndex;
                i++;
            }
            foreach (FileInfo file in files)
            {
                SetStatusText(file.FullName.Substring(inDirectoryPathLength, file.FullName.Length - inDirectoryPathLength));

                string outFilePath = JoinPaths(outDirectoryPath, string.Format("{0}.M{1:00}", toc.name, toc.containerCount - 1));
                if (toc.containerCount == 0 || (new FileInfo(outFilePath).Length) + file.Length > uint.MaxValue)
                {
                    toc.containerCount++;
                    outFilePath = JoinPaths(outDirectoryPath, string.Format("{0}.M{1:00}", toc.name, toc.containerCount - 1));

                    SafeFileWrite(outFilePath, new byte[0]);
                    if (abort)
                    {
                        return 0;
                    }
                }

                byte[] fileBytes = File.ReadAllBytes(file.FullName);
                string inFilePath = file.FullName;
                
                if (file.Extension == ".xml")
                {
                    CryptTools.ZEncrypt(fileBytes);
                    inFilePath = JoinPaths(file.DirectoryName, Path.GetFileNameWithoutExtension(file.Name) + ".zml");
                }
                else if (Array.IndexOf(specialPackFiles, file.Name) != -1)
                {
                    CryptTools.ZEncrypt(fileBytes);
                    inFilePath = JoinPaths(file.DirectoryName, Path.GetFileNameWithoutExtension(file.Name) + ".zat");
                }

                toc.entries[tocOffset + i] = new tocEntryStruct()
                {
                    isFolder = false,
                    length = (uint)file.Length,
                    name = Path.GetFileName(inFilePath),
                    nameChecksum = CryptTools.GetNameChecksum(Path.GetFileName(inFilePath)),
                    offset = (uint)(new FileInfo(outFilePath).Length),
                    container = toc.containerCount - 1
                };

                AppendFile(outFilePath, fileBytes);

                progress += file.Length;
                SetProgressBarValue((int)((100 * progress) / packageSize));
                i++;
            }

            return itemCount;
        }

        public static void Unpack(string tocFilePath, string outDirectoryPath)
        {
            abort = false;
            overwriteFiles = false;
            SetProgressBarValue(0);
            progress = 0;

            byte[] rawToc = File.ReadAllBytes(tocFilePath);
            CryptTools.TocDecryptEncrypt(rawToc);

            Toc toc = new Toc(Path.GetFileNameWithoutExtension(tocFilePath), rawToc);
            packageSize = GetPackageSize(toc, 0);

            Unpack(toc, 0, "", Path.GetDirectoryName(tocFilePath), outDirectoryPath);

            if (abort)
            {
                SetProgressBarValue(0);
                SetStatusText("Aborted!");
            }
            else
            {
                SetStatusText("Finished!");
            }
        }

        public static void Unpack(Toc toc, uint tocIndex, string packagePath, string inDirectoryPath, string outDirectoryPath)
        {
            if (abort)
            {
                return;
            }

            tocEntryStruct tocEntry = toc.entries[tocIndex];

            if (tocEntry.isFolder)
            {
                if (tocIndex != 0)
                {
                    packagePath = JoinPaths(packagePath, tocEntry.name);
                    Directory.CreateDirectory(JoinPaths(outDirectoryPath, packagePath));
                }
                for (uint i = 0; i < tocEntry.length; i++)
                {
                    Unpack(toc, tocEntry.offset + i, packagePath, inDirectoryPath, outDirectoryPath);
                }
            }
            else
            {
                SetStatusText(JoinPaths(packagePath, tocEntry.name));

                string inFilePath = string.Format("{0}/{1}.M{2:00}", inDirectoryPath, toc.name, tocEntry.container);
                string outFilePath = JoinPaths(outDirectoryPath, packagePath, Path.GetFileNameWithoutExtension(tocEntry.name));

                CheckFileExists(inFilePath);
                if (abort)
                {
                    return;
                }

                byte[] fileBytes = ExtractFile(inFilePath, tocEntry.offset, tocEntry.length);

                
                if (Path.GetExtension(tocEntry.name) == ".zml")
                {
                    CryptTools.ZDecrypt(fileBytes);
                    SafeFileWrite(outFilePath + ".xml", fileBytes);
                }
                else if (Array.IndexOf(specialUnpackFiles, tocEntry.name) != -1)
                {
                    CryptTools.ZDecrypt(fileBytes);
                    SafeFileWrite(outFilePath + ".dat", fileBytes);
                }
                
                else if (Path.GetExtension(tocEntry.name) == ".stz")
                {
                    Stz StzFile = new Stz(Path.GetFileNameWithoutExtension(tocEntry.name), fileBytes);
                    SafeFileWrite(outFilePath + ".dat", StzFile.data[3]);
                    if(!abort)
                    {
                        SafeFileWrite(outFilePath + ".rel", StzFile.data[4]);
                    }
                }
                else
                {
                    SafeFileWrite(outFilePath + Path.GetExtension(tocEntry.name), fileBytes);
                }

                progress += tocEntry.length;
                SetProgressBarValue((int)((100 * progress) / packageSize));
            }

        }

        public static byte[] ExtractFile(string inFile, uint offset, uint length)
        {
            using (BinaryReader reader = new BinaryReader(new FileStream(inFile, FileMode.Open)))
            {
                byte[] fileBytes = new byte[length];
                reader.BaseStream.Seek(offset, SeekOrigin.Begin);
                reader.Read(fileBytes, 0, (int)length);

                return fileBytes;
            }
        }

        public static void AppendFile(string appendedFilePath, byte[] appendeeFileBytes)
        {
            using (var stream = new FileStream(appendedFilePath, FileMode.Append))
            {
                stream.Write(appendeeFileBytes, 0, appendeeFileBytes.Length);
            }
        }

        public static long GetPackageSize(Toc toc, uint tocIndex)
        {
            tocEntryStruct tocEntry = toc.entries[tocIndex];
            if (tocEntry.isFolder)
            {
                long size = 0;
                for (uint i = 0; i < tocEntry.length; i++)
                {
                    size += GetPackageSize(toc, tocEntry.offset + i);
                }
                return size;
            }
            else
            {
                return tocEntry.length;
            }
        }

        public static long GetDirectorySize(DirectoryInfo directory)
        {
            long size = 0;
            FileInfo[] files = directory.GetFiles();
            DirectoryInfo[] subDirectories = directory.GetDirectories();

            foreach (DirectoryInfo subDirectory in subDirectories)
            {
                size += GetDirectorySize(subDirectory);
            }

            foreach (FileInfo file in files)
            {
                size += file.Length;
            }

            return size;
        }

        public static long GetDirectoryItemCount(DirectoryInfo directoryInfo)
        {
            long count = directoryInfo.GetFiles().Length;

            DirectoryInfo[] subDirectoryInfos = directoryInfo.GetDirectories();
            foreach (DirectoryInfo subDirectoryInfo in subDirectoryInfos)
            {
                count += 1 + GetDirectoryItemCount(subDirectoryInfo);
            }

            return count;
        }

        public static void SetProgressBarValue(int value)
        {
            _synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                _toolStripProgressBar.Value = (int)o;
            }), value);
        }

        public static void SetStatusText(string text)
        {
            _synchronizationContext.Post(new SendOrPostCallback(o =>
            {
                _toolStripStatusLabel.Text = (string)o;
            }), text);
        }

        public static string JoinPaths(params string[] paths)
        {
            return string.Join("/", paths);
        }

        public static void CheckFileOverwrite(string filePath)
        {
            if (!overwriteFiles && File.Exists(filePath))
            {
                DialogResult result = MessageBox.Show("Files already exist in output folder, do you wish to overwrite them?", "File exists", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    overwriteFiles = true;
                    return;
                }
                abort = true;
            }
        }

        public static void CheckFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("This file does not exist!\n\n" + filePath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                abort = true;
            }
        }

        public static void SafeFileWrite(string filePath, byte[] bytes)
        {
            CheckFileOverwrite(filePath);
            if (!abort)
            {
                File.WriteAllBytes(filePath, bytes);
            }
        }
    }
}
