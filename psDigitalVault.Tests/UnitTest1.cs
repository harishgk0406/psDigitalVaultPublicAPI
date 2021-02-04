using NUnit.Framework;
using psDigitalVault.Controllers;

namespace psDigitalVault.Tests
{
    public class Tests
    {
        psDigitalVaultWithoutCrudHomeController controller = new psDigitalVaultWithoutCrudHomeController();
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            var returnValue = controller.Get(1);
            Assert.AreEqual("HarishGK", returnValue.Value);

        }
    }
}