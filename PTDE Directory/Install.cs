using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace PTDE_Installer
{
    public class Install
    {
        static string PTDEInstall;
        static readonly string CurrentDirectory = Environment.CurrentDirectory;
        private static int Copied;


        public static string InstallMod(string exePath, IProgress<(double, string)> progress)
        {
            Copied = 0;
            PTDEInstall = exePath.Replace(@"\DATA\DARKSOULS.exe", "");

            progress.Report((0, "Initial Check"));

            if (CheckForInstaller(progress)) //Check user hasn't put installer in the wrong folder
            {
                progress.Report((0, "Error: Installer unpacked to Dark Souls directory"));

                MessageBox.Show("You have unpacked mod files to your Dark Souls install directory\r\n" +
                                "Please remove installer from PTDE install folder,\r\n" + 
                                "unpack mod files and installer to unique folder and run installer from there", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;

            }

            if (CheckForNoMod(progress)) //Make sure user isn't trying to run EXE on dry folder.
            {
                progress.Report((0, "No mod files found in EXE location"));
                MessageBox.Show(@"There are no mod files in the location of this EXE", "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return null;
            }

            Files = Directory.GetFiles($@"{CurrentDirectory}\DATA", "*", SearchOption.AllDirectories);
            progress.Report((0, "Updating mod"));
            ModUpdate(progress);

            InstallDSCM(progress);

            progress.Report((1, "Updating complete"));

            return "Mod Update Complete";
        }

        public static bool CheckForInstaller(IProgress<(double, string)> progress)
        {
            var process = Process.GetCurrentProcess();
            string exeName = process.MainModule.ModuleName;
            string modInstallerDATA = PTDEInstall + @"\DATA\" + exeName;
            string modInstallerRoot = PTDEInstall + @"\" + exeName;
            // Check if the installer is in PTDE install directory or DATA folder

            progress.Report((0 , "Checking Installer Location"));
            if (File.Exists(modInstallerDATA))
            {
                return true;
            }
            else if (File.Exists(modInstallerRoot))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool CheckForNoMod(IProgress<(double, string)> progress)
        {
            string exePath = AppDomain.CurrentDomain.BaseDirectory;
            string modDATA = exePath + @"\DATA\";

            progress.Report((0, "Checking for mod files"));
            if (Directory.Exists(modDATA))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private static void ModUpdate(IProgress<(double, string)> progress)
        {
            var sourceDirectoryInfo = new DirectoryInfo(Path.Combine(CurrentDirectory, "DATA"));
            var targetDirectoryInfo = new DirectoryInfo(Path.Combine(PTDEInstall + @"\DATA"));

            BackupSettings(progress);
            CopyFiles(sourceDirectoryInfo, targetDirectoryInfo, progress);
            RestoreSettings(progress);
        }


        private static string[] Files;

        private static void CopyFiles(DirectoryInfo source, DirectoryInfo target, IProgress<(double, string)> progress)
        {

            //Directory.CreateDirectory(target.FullName);

            foreach (var file in source.GetFiles())
            {
                Copied++;
                file.CopyTo(Path.Combine(target.FullName, file.Name), true);
                progress.Report(((double)Copied / Files.Length, @"Copying:" + file.Name));
            }

            foreach (var sourceSubdirectory in source.GetDirectories())
            {
                var targetSubdirectory = target.CreateSubdirectory(sourceSubdirectory.Name);
                CopyFiles(sourceSubdirectory, targetSubdirectory, progress);
            }
        }

        private static void BackupSettings(IProgress<(double, string)> progress)
        {
            string iniDSFix = PTDEInstall + @"\DATA\DSfix.ini";
            string iniDSFixKeys = PTDEInstall + @"\DATA\DSfixKeys.ini";
            string inid3d9_Mod = PTDEInstall + @"\DATA\d3d9_Mod.ini";

            progress.Report((0 , "Backing Up INIs"));

            if (File.Exists(iniDSFix))
            {
                progress.Report((0, @"Backing up DSFix.ini"));
                if(!File.Exists(iniDSFix + @".bak"))
                    File.Move(iniDSFix, Path.ChangeExtension(iniDSFix, "ini.bak"));
            }

            if (File.Exists(iniDSFixKeys))
            {
                progress.Report((0 , @"Backing up DSFixKeys.ini"));
                if (!File.Exists(iniDSFixKeys + @".bak"))
                    File.Move(iniDSFixKeys, Path.ChangeExtension(iniDSFixKeys, "ini.bak"));
            }

            if (File.Exists(inid3d9_Mod))
            {
                progress.Report((0 , @"Backing up inid3d9_Mod.ini"));
                if (!File.Exists(inid3d9_Mod + @".bak"))
                    File.Move(inid3d9_Mod, Path.ChangeExtension(inid3d9_Mod, "ini.bak"));
            }
        }

        private static void RestoreSettings(IProgress<(double, string)> progress)
        {
            string iniDSFix = PTDEInstall + @"\DATA\DSfix.ini";
            string iniDSFixKeys = PTDEInstall + @"\DATA\DSfixKeys.ini";
            string inid3d9_Mod = PTDEInstall + @"\DATA\d3d9_Mod.ini";

            progress.Report((1, "Restoring INIs"));


            if (File.Exists(iniDSFix + @".bak"))
            {
                progress.Report((1, @"Restoring DSFix.ini"));
                File.Delete(iniDSFix);
                File.Move(iniDSFix + @".bak", Path.ChangeExtension(iniDSFix, "ini"));
            }

            if (File.Exists(iniDSFixKeys + @".bak"))
            {
                progress.Report((1, @"Restoring DSFixKeys.ini"));
                File.Delete(iniDSFixKeys);
                File.Move(iniDSFixKeys + @".bak", Path.ChangeExtension(iniDSFixKeys, "ini"));
            }

            if (File.Exists(inid3d9_Mod + @".bak"))
            {
                progress.Report((1, @"Restoring inid3d9_Mod.ini"));
                File.Delete(inid3d9_Mod);
                File.Move(inid3d9_Mod + @".bak", Path.ChangeExtension(inid3d9_Mod, "ini"));
            }
        }

        private static void InstallDSCM(IProgress<(double, string)> progress)
        {
            string dscmSource = CurrentDirectory + @"\DSCM.exe";
            string dscmDest = PTDEInstall + @"\DSCM.exe";
            bool dscmInstalled = File.Exists(dscmDest);
            bool dscmIncluded = File.Exists(dscmSource);

            if (dscmIncluded)
            {
                if (!dscmInstalled)
                {

                    progress.Report((0, "Installing DSCM"));
                    File.Copy(dscmSource, dscmDest, true);
                }
            }
        }
    }
}
