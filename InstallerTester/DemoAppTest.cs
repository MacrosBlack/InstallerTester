using InstallerTester.Helpers;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace InstallerTester
{
    [TestClass]
    public class DemoAppTest
    {
        [DeploymentItem(@"..\..\..\DemoApp\bin\Release\DemoApp.msi")]
        [DeploymentItem(@"..\..\..\DemoAppv2\bin\Release\DemoAppv2.msi")]
        [TestMethod]
        public void Install_Returns_True()
        {
            Assert.IsTrue(Admin.IsAdmin(), "This test must be executed with elevated permissions (Run as administrator)");
            using (var installer = new Installer("DemoApp.msi"))
            using (var installerv2 = new Installer("DemoAppv2.msi"))
            {
                Assert.IsTrue(installer.Install());
                Assert.IsTrue(installerv2.Install());
            }
        }
    }
}
