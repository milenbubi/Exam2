using OpenQA.Selenium;

namespace Exam.Pages.MSPage
{
    public partial class MSPage
    {
        public IWebElement NetCoreGuide => WaitForElementBy("xpath", "//a[contains(text(),'.NET Core Guide')]");
        public IWebElement Docker => WaitForElementBy("xpath", "//li[@aria-expanded='false']/a[contains(@href,'dotnet/core/docker')]");
        public IWebElement IntroductionToNetAndDocker => WaitForElementBy("xpath", "//ul[@role='tree']//a[contains(text(),'Introduction to .NET and Docker')]");
    }
}