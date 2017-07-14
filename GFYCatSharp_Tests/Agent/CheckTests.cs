using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFYCat_Tests.Agent
{
    [TestClass]
    public class CheckTests : BaseTestClass
    {
        [TestMethod]
        public void Should_ThrowArgumentNull_When_ClientIdIsEmpty()
        {
            Assert.IsTrue(ArgumentNullException(() => { new GFYCatSharp.Agent(string.Empty, ClientSecret); }, "clientId"));
        }

        [TestMethod]
        public void Should_ThrowArgumentNull_When_ClientIdIsNull()
        {
            Assert.IsTrue(ArgumentNullException(() => { new GFYCatSharp.Agent(null, ClientSecret); }, "clientId"));
        }

        [TestMethod]
        public void Should_ThrowArgumentNull_When_ClientSecretIsNull()
        {
            Assert.IsTrue(ArgumentNullException(() => { new GFYCatSharp.Agent(ClientId, null); }, "clientSecret"));
        }

        [TestMethod]
        public void Should_ThrowException_When_ClientIdIsIncorrect()
        {
            Assert.IsTrue(OathException(() => { new GFYCatSharp.Agent("Helloworld", ClientSecret); }, "InvalidClient"));
        }

        [TestMethod]
        public void Should_ThrowException_When_ClientSecretIsIncorrect()
        {
            Assert.IsTrue(OathException(() => { new GFYCatSharp.Agent(ClientId, "HelloWorld"); }, "InvalidClient"));
        }
    }
}