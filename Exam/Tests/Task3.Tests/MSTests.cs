using Exam.Pages.MSPage;
using Exam.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Linq;

namespace Exam.Tests.Task3.Tests
{
    [TestFixture]
    class MSTests : DefaultFixture
    {
        private static readonly int[] blogNumbers = { 0, 1, 2 };


        // [TestCaseSource(nameof(blogNumbers))]
        [Test]
        [Property("Task3", 1)]
        public void OpenArticle_SectionsLinkTextsAreSameAsSectionsNames()
        {
            //Arrange
            MSPage mainPage = PageFactory.Get<MSPage>();
            ArticlePage articlePage = PageFactory.Get<ArticlePage>();

            mainPage.Load();
            mainPage.OpenIntroductionToNetAndDockerArticle();

            //Act
            foreach (IWebElement navigation in articlePage.ArticleNavigations)
            {
                string navigationHref = navigation.GetAttribute("href");
                string sectionID = navigationHref.Substring(navigationHref.IndexOf('#') + 1);

                navigation.FindAndClick();

                IWebElement section = articlePage.ElementWith(sectionID);

                //Assert
                Assert.IsTrue(section.Text == navigation.Text);
                Assert.IsTrue(section.Displayed);
            }
        }
    }
}