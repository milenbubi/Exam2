using OpenQA.Selenium;

namespace Exam.Pages.DemoQaPage
{
    public partial class DemoQaPage
    {
        public IWebElement SliderSection => ElementBy("id", "menu-item-97");

        public IWebElement AccordionSection => ElementBy("id", "menu-item-144");
    }
}