using OpenQA.Selenium.Interactions;
using System;

namespace Exam.Pages.SliderPage
{
    public partial class SliderPage : DefaultPage
    {
        public SliderPage() : base("")
        {
        }

        public void MoveSliderTo(int position)
        {
            int singleMoveLength = SliderBar.Size.Width / 9;

            new Actions(driver)
                .ClickAndHold(Slider)
                .MoveToElement(SliderBar, singleMoveLength * (position - 1), 0)
                .Perform();
        }

        public int AmountBarValue()
        {
            int value = Convert.ToInt32(AmountBar.GetAttribute("value"));
            return value;
        }
    }
}