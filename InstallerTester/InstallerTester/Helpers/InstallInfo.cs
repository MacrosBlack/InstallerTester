using InstallerTester.Msi;
using System.IO;

namespace InstallerTester.Helpers
{
    public class InstallInfo
    {
        public string MsiPath { get; }
        public bool IsInstalled { get; set; }
        public string ProductCode { get; set; }
        public string UpgradeCode { get; set; }
        public string Manufacturer { get; set; }
        public string ProductName { get; set; }
        public string Version { get; set; }

        private MsiTableProperty _propertyTable { get; }
        public string LogPathInstall { get; private set; }
        public string LogPathUninstall { get; private set; }

        public InstallInfo(string msiPath)
        {
            if (!File.Exists(msiPath))
            {
                throw new FileNotFoundException(msiPath);
            }

            var fi = new FileInfo(msiPath);

            LogPathInstall = Path.Combine(Config.LogPathRoot, $"{fi.Name}.log");
            LogPathUninstall = Path.Combine(Config.LogPathRoot, $"{fi.Name}.uninstall.log");
            MsiPath = msiPath;
        }
    }
}