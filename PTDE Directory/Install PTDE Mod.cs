using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Unpack_Dark_Souls_For_Modding_CSharp;

namespace PTDE_Installer
{
    public partial class InstallerForm : Form
    {
        private static IProgress<(double value, string status)> Progress;
        private static string EXEPath;

        public InstallerForm()
        {
            InitializeComponent();
            Progress = new Progress<(double value, string status)>(ProgressReport);
        }

        private void ProgressReport((double value, string status) obj)
        {
            double percent = obj.value * 100;
            progressBar.Value = (int)percent;
            progressUpdate.Text = obj.status;
        }

        private void browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog fbd = new OpenFileDialog { };
            if (fbd.ShowDialog() == DialogResult.OK)
            installPathBox.Text = fbd.FileName; //Get's browse path from Install class. 
            
        }

        public static string passInstallPath;
        private void install_Click(object sender, EventArgs e)
        {
            EXEPath = installPathBox.Text;
            if (!EXEPath.EndsWith("DARKSOULS.exe"))
                EXEPath += @"\DATA\DARKSOULS.exe";

            bool fileExists = File.Exists(EXEPath);

            if (!fileExists)
            {
                Progress.Report((0, "Incorrect Folder Selected"));
                MessageBox.Show("Please Select DARKSOULS.exe", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            passInstallPath = installPathBox.Text; //passes installPathBox to Install class. Needed for copy paste functionality.
            if (!backgroundWorker.IsBusy)
            {
                backgroundWorker.RunWorkerAsync();
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                var error = Unpacker.Unpack(EXEPath, Progress);

                if (error != null)
                {
                    if (error != "Dark Souls is already unpacked!")
                        ShowError(error);
                }

                error = Install.InstallMod(EXEPath, Progress);

                if (error != null)
                    ShowError(error);
            }
            catch (UnauthorizedAccessException a)
            {
                Progress.Report((0, $"The folder you are trying to unpack requires additional priviledges."));
                ShowError($"{a.Message}\r\n\r\nThe folder you are trying to unpack requires additional priviledges. \r\n\r\nRun the installer as Admin");
                return;
            }
            catch (Exception a)
            {
                ShowError(a.Message);
                throw;
            }
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
        }

        private static void ShowError(string error)
        {
            MessageBox.Show(error, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void InstallerForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (backgroundWorker.IsBusy) // Keep people from exiting while the backgroundWorker is running
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you wish to exit? Mod installer is still installing", "WARNING", MessageBoxButtons.YesNo, MessageBoxIcon.Warning ,MessageBoxDefaultButton.Button2);
                if (dialogResult == DialogResult.Yes)
                {
                    e.Cancel = false;
                }
                else if (dialogResult == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void installPathBox_Click(object sender, EventArgs e)
        {
            installPathBox.SelectAll();
            installPathBox.Focus();
        }
    }

}
