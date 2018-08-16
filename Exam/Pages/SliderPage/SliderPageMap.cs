using OpenQA.Selenium;

namespace Exam.Pages.SliderPage
{
    public partial class SliderPage
    {
        public IWebElement SliderBar => ElementBy("id", "slider-range-max");

        public IWebElement Slider=>ElementBy("xpath", "//*[@id='slider-range-max']/span");

        public IWebElement AmountBar => ElementBy("id", "amount1");
    }
}