using NUnit.Framework;
using PageLayoutService.Models;

namespace PageLayoutServiceTests.Models {
    [TestFixture()]
    public class PageLayoutHandlerTests {
        private IPageLayoutHandler pageLayoutHandler;

        [OneTimeSetUp]
        public void OneTimeSetUp() {
            pageLayoutHandler = new PageLayoutHandler();
        }

        [Test()]
        public void Umbrechen_TextMitMaxLaenge_Textumbruch() {
            Assert.Fail();
        }
    }
}