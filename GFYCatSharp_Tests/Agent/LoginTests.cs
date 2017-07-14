using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFYCat_Tests.Agent
{
    [TestClass]
    public class LoginTests: BaseTestClass
    {
        [TestMethod]
        public void Should_BeActivated()
        {
            GFYCatSharp.Agent agent = new GFYCatSharp.Agent(ClientId, ClientSecret);
            Assert.IsTrue(agent.Activated);
        }

        [TestMethod]
        public void Should_HaveASessionToken()
        {
            GFYCatSharp.Agent agent = new GFYCatSharp.Agent(ClientId, ClientSecret);
            Assert.IsTrue(!string.IsNullOrEmpty(agent.Session.access_token));
        }
    }
}