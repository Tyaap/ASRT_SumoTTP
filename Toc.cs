using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumoTTP
{
    public struct tocEntryStruct
    {
        public bool isFolder;
        public string name;
        public uint container;
        public uint offset;
        public uint length;
        public uint nameChecksum;
    }
    public class Toc
    {
        public static readonly byte[] tocIdentifier = new byte[] { 0x83, 0xab, 0xb0, 0x79, 0xcd, 0x14, 0x13, 0x5d, 0xf1, 0x3a, 0xe8, 0xe2, 0x9e, 0x60, 0xeb, 0xd3 };
        private StreamWriter textFile;

        public string name;
        public uint containerCount;
        public uint tableOffset;
        public uint namesOffset;
        public tocEntryStruct[] entries;

        public Toc(string name, long entryCount)
        {
            this.name = name;
            containerCount = 0;
            entries = new tocEntryStruct[entryCount];
            tableOffset = 0x1c;
            namesOffset = 0x1c + (uint)entryCount * 24;
        }

        public Toc(string name, byte[] rawToc)
        {
            this.name = name;
            ReadRawToc(rawToc);
        }

        public void ReadRawToc(byte[] rawToc)
        {
            containerCount = ByteTools.ReadUInt(rawToc, 0x10);
            if (containerCount > 0xFFFF)
            {
                ByteTools.bigEndian = true;
                containerCount = ByteTools.ReadUInt(rawToc, 0x10);
            }

            tableOffset = ByteTools.ReadUInt(rawToc, 0x14);
            namesOffset = ByteTools.ReadUInt(rawToc, 0x18);

            string[] entryNames = Encoding.ASCII.GetString(rawToc, (int)namesOffset, (int)(rawToc.Length - namesOffset)).Split(new char[] { (char)0 });

            entries = new tocEntryStruct[entryNames.Length];

            for (int i = 0; i < entries.Length; i++)
            {
                tocEntryStruct newTocEntry = new tocEntryStruct
                {
                    nameChecksum = ByteTools.ReadUInt(rawToc, (int)(tableOffset + i * 24 + 0)),
                    isFolder = ByteTools.ReadBoolean(rawToc, (int)(tableOffset + i * 24 + 4)),
                    container = ByteTools.ReadUInt(rawToc, (int)(tableOffset + i * 24 + 8)),
                    offset = ByteTools.ReadUInt(rawToc, (int)(tableOffset + i * 24 + 12)),
                    length = ByteTools.ReadUInt(rawToc, (int)tableOffset + i * 24 + 16),
                    name = entryNames[i]
                };

                entries[i] = newTocEntry;
            }
        }

        public byte[] CreateRawToc()
        {
            int nameStringLength = entries.Length - 1;
            foreach (tocEntryStruct tocEntry in entries)
            {
                nameStringLength += tocEntry.name.Length;
            }

            byte[] rawToc = new byte[namesOffset + nameStringLength];
            ByteTools.WriteBytes(rawToc, 0, tocIdentifier);
            ByteTools.WriteUInt(rawToc, 0x10, containerCount);
            ByteTools.WriteUInt(rawToc, 0x14, tableOffset);
            ByteTools.WriteUInt(rawToc, 0x18, namesOffset);

            string namesString = "";
            for (int i = 0; i < entries.Length; i++)
            {
                tocEntryStruct tocEntry = entries[i];
                ByteTools.WriteUInt(rawToc, tableOffset + i * 24 + 0, tocEntry.nameChecksum);
                ByteTools.WriteUInt(rawToc, tableOffset + i * 24 + 4, tocEntry.isFolder ? 1u : 0u);
                ByteTools.WriteUInt(rawToc, tableOffset + i * 24 + 8, tocEntry.container);
                ByteTools.WriteUInt(rawToc, tableOffset + i * 24 + 12, tocEntry.offset);
                ByteTools.WriteUInt(rawToc, tableOffset + i * 24 + 16, tocEntry.length);
                ByteTools.WriteUInt(rawToc, tableOffset + i * 24 + 20, (uint)(namesString.Length));

                namesString += tocEntry.name;
                if (i < entries.Length - 1)
                {
                    namesString += (char)0;
                };
            }

            ByteTools.WriteString(rawToc, namesOffset, namesString);

            return rawToc;
        }

        public void PrintToFile(string filePath)
        {
            textFile = new StreamWriter(filePath);
            textFile.WriteLine("File Path\tContainer\tOffset\tLength\tName Checksum");
            PrintToFile(0, ".");
            textFile.Close();
        }

        private void PrintToFile(long tocIndex, string currentPath)
        {
            tocEntryStruct tocEntry = entries[tocIndex];

            if (!tocEntry.isFolder)
            {
                textFile.WriteLine("{0}{1}\tM{2:00}\t{3:X}\t{4}\t{5:X}", currentPath, tocEntry.name, tocEntry.container, tocEntry.offset, tocEntry.length, tocEntry.nameChecksum);
            }
            else
            {
                for (int i = 0; i < tocEntry.length; i++)
                {
                    PrintToFile(tocEntry.offset + i, currentPath + tocEntry.name + "/");
                }
            }
        }
    }
}
