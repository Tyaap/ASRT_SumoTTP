using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SumoTTP
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            PackerTools.Init(toolStripProgressBar, toolStripStatusLabel, SynchronizationContext.Current);
        }

        private void ButtonUnpackTocPath_Click(object sender, System.EventArgs e)
        {
            using(OpenFileDialog fileDialog = new OpenFileDialog() { DefaultExt = "toc", AddExtension = true, Filter = "TOC Files|*.toc", Multiselect = false })
            {
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxUnpackTocPath.Text = fileDialog.FileName;
                };
            }
        }

        private void ButtonUnpackOutPath_Click(object sender, System.EventArgs e)
        {
            using(FolderBrowserDialog folderDialog = new FolderBrowserDialog() { Description = "Choose an output folder" })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxUnpackOutPath.Text = folderDialog.SelectedPath;
                };
            }
        }

        private async void ButtonUnpackStart_ClickAsync(object sender, System.EventArgs e)
        {
            if (CheckFileExists(textBoxUnpackTocPath.Text) && CheckFolderExists(textBoxUnpackOutPath.Text))
            {
                buttonUnpackCancel.Enabled = true;
                buttonUnpackStart.Enabled = false;
                buttonPackStart.Enabled = false;
                await Task.Run(() =>
                {
                    PackerTools.Unpack(textBoxUnpackTocPath.Text, textBoxUnpackOutPath.Text);
                });
            }
        }

        private void ButtonUnpackCancel_Click(object sender, System.EventArgs e)
        {
            PackerTools.abort = true;
        }

        private void ToolStripStatusLabel_TextChanged(object sender, System.EventArgs e)
        {
            if (toolStripStatusLabel.Text == "Finished!" || toolStripStatusLabel.Text == "Aborted!")
            {
                buttonUnpackCancel.Enabled = false;
                buttonUnpackStart.Enabled = true;
                buttonPackCancel.Enabled = false;
                buttonPackStart.Enabled = true;
            }
        }

        private void ButtonPackInFolder_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog() { Description = "Select a folder to pack" })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPackInPath.Text = folderDialog.SelectedPath;
                };
            }
        }

        private void ButtonPackOutFolder_Click(object sender, System.EventArgs e)
        {
            using (FolderBrowserDialog folderDialog = new FolderBrowserDialog() { Description = "Select an output folder" })
            {
                if (folderDialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxPackOutPath.Text = folderDialog.SelectedPath;
                };
            }
        }

        private async void ButtonPackStart_ClickAsync(object sender, System.EventArgs e)
        {
            if (CheckFolderExists(textBoxPackInPath.Text) && CheckFolderExists(textBoxPackOutPath.Text))
            {
                buttonPackCancel.Enabled = true;
                buttonUnpackStart.Enabled = false;
                buttonPackStart.Enabled = false;

                await Task.Run(() =>
                {
                    PackerTools.Pack(textBoxPackInPath.Text, textBoxPackOutPath.Text);
                });
            }
        }

        private void ButtonPackCancel_Click(object sender, System.EventArgs e)
        {
            PackerTools.abort = true;
        }

        public static bool CheckFolderExists(string folderPath)
        {
            if (!Directory.Exists(folderPath))
            {
                MessageBox.Show("This folder does not exist!\n\n" + folderPath, "Folder Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        public static bool CheckFileExists(string filePath)
        {
            if (!File.Exists(filePath))
            {
                MessageBox.Show("This file does not exist!\n\n" + filePath, "File Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
    }
}
