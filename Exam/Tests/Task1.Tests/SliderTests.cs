using Exam.Pages.DemoQaPage;
using Exam.Pages.SliderPage;
using Exam.Utilities;
using NUnit.Framework;

namespace Exam.Tests.Task1.Tests
{
    [TestFixture]
    class SliderTests : DefaultFixture
    {
        [Test]
        [Property("Task1", 1)]
        public void MoveSlider_InputIncreasesRespectively()
        {
            //Arrange
            DemoQaPage demoQaMainPage = PageFactory.Get<DemoQaPage>();
            SliderPage sliderPage = PageFactory.Get<SliderPage>();

            demoQaMainPage.Load();
            demoQaMainPage.OpenSliderSection();

            //Act
            for (int position = 1; position <= 10; position++)
            {
                sliderPage.MoveSliderTo(position);
                sliderPage.DelayForSeconds(0.25);

                int sliderPositionValue = sliderPage.AmountBarValue();

                //Assert
                Assert.AreEqual(position, sliderPositionValue);
            }
        }
    }
}