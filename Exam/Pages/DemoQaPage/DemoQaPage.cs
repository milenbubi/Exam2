namespace Exam.Pages.DemoQaPage
{
    public partial class DemoQaPage : DefaultPage
    {
        public DemoQaPage() : base(@"http://demoqa.com/")
        {
        }

        public void OpenSliderSection()
        {
            SliderSection.Click();
        }

        public void OpenAccordionSection()
        {
            AccordionSection.Click();
        }
    }
}