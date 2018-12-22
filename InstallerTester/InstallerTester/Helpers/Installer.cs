﻿using Microsoft.Win32;
using System;
using System.IO;
using System.Reflection;

namespace InstallerTester.Helpers
{
    public class Installer : IDisposable
    {
        public InstallInfo InstallInfo;

        public Installer(string msiPath)
        {
            InstallInfo = new InstallInfo(msiPath);
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
            InstallInfo.IsInstalled = true;
            return true;
        }

        public bool Uninstall()
        {
            if( !InstallInfo.IsInstalled )
            {
                return true;
            }

            using (var p = new System.Diagnostics.Process())
            {
                p.StartInfo.CreateNoWindow = true;
                var msiExec = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.System), "msiexec.exe");
                p.StartInfo.Arguments = $"{msiExec} /x {InstallInfo.ProductCode} /qn /l*v {InstallInfo.LogPath}";
                p.StartInfo.FileName = GetPsExecPath();
                p.Start();
                var result = p.WaitForExit(Config.WaitTimeInSeconds);
                if (result)
                {
                    InstallInfo.IsInstalled = false;
                }

                return result;
            }
        }

        private string GetPsExecPath()
        {
            var eulaAccepted = (int)Registry.GetValue(@"HKEY_CURRENT_USER\Software\Sysinternals\PsExec", "EulaAccepted", 0);
            if (eulaAccepted == 0)
            {
                Registry.SetValue(@"HKEY_CURRENT_USER\Software\Sysinternals\PsExec", "EulaAccepted", 1);
            }

            var codeBase = Assembly.GetExecutingAssembly().CodeBase;
            var uri = new UriBuilder(codeBase);
            var path = Uri.UnescapeDataString(uri.Path);
            path = Path.GetDirectoryName(path);
            return Path.Combine(path, "Tools", "PSExec.exe");
        }
    }
}