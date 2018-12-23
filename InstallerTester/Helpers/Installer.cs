using InstallerTester.Msi;
using System;
using System.Diagnostics;
using System.IO;

namespace InstallerTester.Helpers
{
    public class Installer : IDisposable
    {
        public InstallInfo InstallInfo;

        public Installer(string msiPath)
        {
            InstallInfo = new InstallInfo(msiPath);
            var list = MsiTableProperty.GetAllRecords(msiPath);
            if (list.TryGetValue(PropertyName.ProductCode.ToString(), out MsiTableProperty productCode))
            {
                InstallInfo.ProductCode = productCode.Value;
            }

            if (list.TryGetValue(PropertyName.UpgradeCode.ToString(), out MsiTableProperty upgradeCode))
            {
                InstallInfo.UpgradeCode = upgradeCode.Value;
            }

            if (list.TryGetValue(PropertyName.Manufacturer.ToString(), out MsiTableProperty manufacturerInfo))
            {
                InstallInfo.Manufacturer = manufacturerInfo.Value;
            }

            if (list.TryGetValue(PropertyName.ProductVersion.ToString(), out MsiTableProperty productVersion))
            {
                InstallInfo.ProductVersion = productVersion.Value;
            }
        }

        public void Dispose()
        {
            if (InstallInfo.IsInstalled)
            {
                Uninstall();
            }
        }

        public bool Install()
        {
            using (var p = new Process())
            {
                p.StartInfo.CreateNoWindow = true;
                var msiExec = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "msiexec.exe");
                p.StartInfo.Arguments = $"/i {InstallInfo.MsiPath} /qn /l*v {InstallInfo.LogPathInstall}";
                p.StartInfo.FileName = msiExec;
                p.Start();
                var result = p.WaitForExit(Config.WaitTimeInSeconds);
                InstallInfo.ExitCode = p.ExitCode;
                if (result)
                {
                    if (ExitCodeHelper.IsSuccess(InstallInfo.ExitCode))
                    {
                        Trace.WriteLine($"The install of product:{InstallInfo.ProductName} ({InstallInfo.ProductCode}) succeeded with ExitCode:{InstallInfo.ExitCode}. LogFile:'{InstallInfo.LogPathInstall}'");
                        Trace.WriteLine(File.ReadAllText(InstallInfo.LogPathInstall));
                        InstallInfo.IsInstalled = true;
                        return true;
                    }
                    else
                    {
                        Trace.WriteLine($"The install of product:{InstallInfo.ProductName} ({InstallInfo.ProductCode}) failed with exitcode:{InstallInfo.ExitCode}. LogFile:'{InstallInfo.LogPathInstall}'");
                        Trace.WriteLine(File.ReadAllText(InstallInfo.LogPathInstall));
                        return false;
                    }
                }
                else
                {
                    Trace.WriteLine($"The install of product:{InstallInfo.ProductName} ({InstallInfo.ProductCode}) timed out. LogFile:'{InstallInfo.LogPathInstall}'");
                }

                return result;
            }
        }

        public bool Uninstall()
        {
            if (!InstallInfo.IsInstalled || string.IsNullOrEmpty(InstallInfo.ProductCode))
            {
                return true;
            }

            using (var p = new Process())
            {
                p.StartInfo.CreateNoWindow = true;
                var msiExec = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "msiexec.exe");
                p.StartInfo.Arguments = $"/x {InstallInfo.ProductCode} /qn /l*v {InstallInfo.LogPathUninstall}";
                p.StartInfo.FileName = msiExec;
                p.Start();
                var result = p.WaitForExit(Config.WaitTimeInSeconds);
                InstallInfo.ExitCode = p.ExitCode;
                if (result)
                {
                    if (ExitCodeHelper.IsSuccess(InstallInfo.ExitCode))
                    {
                        InstallInfo.IsInstalled = false;
                        Trace.WriteLine($"The uninstall of product:{InstallInfo.ProductName} ({InstallInfo.ProductCode}) succeeded. ExitCode:{InstallInfo.ExitCode}. LogFile:'{InstallInfo.LogPathUninstall}'");
                        Trace.WriteLine(File.ReadAllText(InstallInfo.LogPathUninstall));
                        return true;
                    }
                    else
                    {
                        Trace.WriteLine($"The uninstall of product:{InstallInfo.ProductName} ({InstallInfo.ProductCode}) failed with exitcode:{InstallInfo.ExitCode}. LogFile:'{InstallInfo.LogPathUninstall}'");
                        Trace.WriteLine(File.ReadAllText(InstallInfo.LogPathUninstall));
                        return false;
                    }
                }
                else
                {
                    Trace.WriteLine($"The uninstall of product:{InstallInfo.ProductName} ({InstallInfo.ProductCode}) timed out:{InstallInfo.ExitCode}.");
                }

                return result;
            }
        }
    }
}