using System.Linq;
using GFYCatSharp.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFYCat_Tests.Tags
{
    [TestClass]
    public class GetItemsByTagTests : BaseTestClass
    {
        [TestMethod]
        public void Should_ThrowArgumentNullException_When_TagIsNull()
        {
            bool result = ArgumentNullException(() =>
            {
                new GFYCatSharp.GfyCatSharp(Agent).GetItemsByTag(null);
            }, "tag");

            Assert.IsTrue(result);
        }
        
        [TestMethod]
        public void Should_ThrowArgumentNullException_When_TagIsEmpty()
        {
            bool result = ArgumentNullException(() =>
            {
                new GFYCatSharp.GfyCatSharp(Agent).GetItemsByTag(string.Empty);
            }, "tag");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Should_Return10Items()
        {
            GfyItem result = new GFYCatSharp.GfyCatSharp(Agent).GetItemsByTag("funny");

            Assert.AreEqual(10, result.Gfycats.Count());
        }

        [TestMethod]
        public void Should_Return50Items()
        {
            GfyItem result = new GFYCatSharp.GfyCatSharp(Agent).GetItemsByTag("funny", 50);

            Assert.AreEqual(50, result.Gfycats.Count());
        }
    }
}