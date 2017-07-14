using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFYCat_Tests.GfyCat_General
{
    [TestClass]
    public class ConstructorTests : BaseTestClass
    {
        [TestMethod]
        public void Should_ThrowArgumentNull_When_AgentIsNull()
        {
            Assert.IsTrue(ArgumentNullException(() => { new GFYCatSharp.GfyCatSharp(null); }, "agent"));
        }
    }
}