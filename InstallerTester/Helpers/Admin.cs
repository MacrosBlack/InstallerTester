using System.Security.Principal;

namespace InstallerTester.Helpers
{
    internal class Admin
    {
        internal static bool IsAdmin()
        {
            var id = WindowsIdentity.GetCurrent();
            var principal = new WindowsPrincipal(id);
            return principal.IsInRole(WindowsBuiltInRole.Administrator);
        }
    }
}
