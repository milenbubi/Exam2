using Exam.Pages.AccordionPage;
using Exam.Pages.DemoQaPage;
using Exam.Utilities;
using NUnit.Framework;
using System.Linq;

namespace Exam.Tests.Task2.Tests
{
    [TestFixture]
    class AccordionTests : DefaultFixture
    {
        private DemoQaPage demoQaMainPage;
        private AccordionPage accordionPage;

        [SetUp]
        public void ArrangeTests()
        {
            demoQaMainPage = PageFactory.Get<DemoQaPage>();
            accordionPage = PageFactory.Get<AccordionPage>();

            demoQaMainPage.Load();
            demoQaMainPage.OpenAccordionSection();
            accordionPage.OpenCustomizeIconsSubSection();
        } 

        [Test]
        [Property("Task2", 1)]
        public void ClickToggleButton_EverySectionHasAnArrowInFrontOfName()
        {
            //Act
            accordionPage.ClickToggleButton();

            //Assert
            foreach (var section in accordionPage.Sections)
            {
                string classAttribute = section.GetAttribute("class");
                Assert.IsTrue(classAttribute.Contains("ui-accordion-icons"));
            }
        }

        [Test]
        [Property("Task2", 2)]
        public void ClickAnySection_OnlyThisSectionIsOpenAndCanBeReaded([Range(0, 3, 1)]int position)
        {
            //Act
            accordionPage.OpenSectionAt(position);
            accordionPage.DelayForSeconds(0.9);

            string textStyleAttribute = accordionPage
                .SectionTexts
                .ElementAt(position)
                .GetAttribute("style");

            //Assert
            StringAssert.Contains("block", textStyleAttribute);
            Assert.IsTrue(accordionPage.SectionTexts.Count(st => st.GetAttribute("style").Contains("block")) == 1);
        }
    }
}