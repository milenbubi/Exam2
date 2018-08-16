using OpenQA.Selenium;
using System.Collections.Generic;

namespace Exam.Pages.AccordionPage
{
    public partial class AccordionPage
    {
        public IWebElement CustomizeIconsSubSection => ElementBy("id", "ui-id-2");

        public IWebElement ToggleButton => ElementBy("id", "toggle");

        public IEnumerable<IWebElement> Sections => ElementsBy("xpath", "//*[@id='accordion_icons']/h3");

        public IEnumerable<IWebElement> SectionTexts => ElementsBy("xpath", "//*[@id='accordion_icons']/h3/following-sibling::div");
    }
}