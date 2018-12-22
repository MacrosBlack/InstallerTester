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
        public string LogPath { get; private set; }

        public InstallInfo(string msiPath)
        {
            if (!File.Exists(msiPath))
            {
                throw new FileNotFoundException(msiPath);
            }

            var fi = new FileInfo(msiPath);

            LogPath = Path.Combine(Config.LogPathRoot, $"{fi.Name}.log");
            MsiPath = msiPath;
        }
    }
}