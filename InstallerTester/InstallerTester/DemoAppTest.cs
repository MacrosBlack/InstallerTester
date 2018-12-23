using InstallerTester.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstallerTester
{
    [TestClass]
    public class DemoAppTest
    {
        [TestMethod]
        public void Install_Returns_Zero()
        {
            Assert.IsTrue(Admin.IsAdmin(), "This test must be executed with elevated permissions (Run as administrator)");
            using (var installer = new Installer(Config.DemoAppInstallPath))
            {
                Assert.IsTrue(installer.Install());
            }
        }
    }
}
