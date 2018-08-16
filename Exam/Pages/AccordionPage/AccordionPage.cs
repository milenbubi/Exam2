using OpenQA.Selenium.Interactions;
using System.Linq;

namespace Exam.Pages.AccordionPage
{
    public partial class AccordionPage : DefaultPage
    {
        public AccordionPage() : base("")
        {
        }

        public void OpenCustomizeIconsSubSection()
        {
            CustomizeIconsSubSection.Click();
        }

        public void ClickToggleButton()
        {
            Actions builder = new Actions(driver);

            builder.Click(ToggleButton).Build();
            builder.Perform();
            builder.Perform();
        }

        public void OpenSectionAt(int position)
        {
            Sections.ElementAt(position).Click();
        }
    }
}