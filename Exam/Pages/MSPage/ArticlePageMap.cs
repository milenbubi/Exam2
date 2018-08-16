using OpenQA.Selenium;
using System.Collections.Generic;

namespace Exam.Pages.MSPage
{
    public partial class ArticlePage
    {
        public IEnumerable<IWebElement> ArticleNavigations => WaitForElementsBy("xpath", "//nav[@id='side-doc-outline']/ol/li/a");

        public IWebElement ElementWith(string sectionID)
        {
            IWebElement sectionName = WaitForElementBy("id", sectionID);
            return sectionName;
        }
    }
}