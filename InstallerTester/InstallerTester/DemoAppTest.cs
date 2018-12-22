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
            using (var installer = new Installer(Config.DemoAppInstallPath))
            {
                Assert.IsTrue(installer.Install());
                Assert.IsTrue(installer.Uninstall());
            }
        }
    }
}
