using System;

namespace InstallerTester.Helpers
{
    public static class Config
    {
        public static string LogPathRoot { get; set; }

        public static string DemoAppInstallPath
        {
            get
            {
                return ExpandMacros("$(DemoAppInstallTargetPath)");
            }
        }

        public static int WaitTimeInSeconds => (int)TimeSpan.FromMinutes(15).TotalSeconds;

        static Config()
        {
            LogPathRoot = Environment.GetEnvironmentVariable("TEMP");
        }

        private static string ExpandMacros(string macro)
        {
            macro = macro.Replace("$(DemoAppInstallTargetPath)", @"d:\temp\Orca-x86_en-us.msi");
            return macro;
        }
    }
}