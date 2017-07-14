using GFYCatSharp.Objects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GFYCat_Tests.SingleImages
{
    [TestClass]
    public class GetImageUrlByIdTests : BaseTestClass
    {
        [TestMethod]
        public void Should_ThrowArgumentNullException_When_gfyIdIsNull()
        {
            bool result = ArgumentNullException(() =>
            {
                new GFYCatSharp.GfyCatSharp(Agent).GetImageUrlById(null, EImageType.Gif100Px);
            }, "gfyId");

            Assert.IsTrue(result);
        }

        [TestMethod]
        public void Should_ReturnImageById()
        {
            GfyItem result = new GFYCatSharp.GfyCatSharp(Agent).GetImageUrlById("NeedyGargantuanIbizanhound", EImageType.Gif100Px);

            Assert.IsNotNull(result);
            Assert.IsNotNull(result.Item);
        }

        [TestMethod]
        public void Should_ThrowImageException_When_ImageIsNotFound()
        {
            const string id = "NeedyGargantuanIbnhound";

            bool result = ImageException_DoesNotExists(() =>
            {
                new GFYCatSharp.GfyCatSharp(Agent).GetImageUrlById(id, EImageType.Gif100Px);
            }, id.ToLower());

            Assert.IsTrue(result);
        }
    }
}