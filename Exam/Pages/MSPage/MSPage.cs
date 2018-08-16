
namespace Exam.Pages.MSPage
{
    public partial class MSPage : DefaultPage
    {
        public MSPage() : base(@"https://docs.microsoft.com/en-us/dotnet/csharp")
        {
        }

        public void OpenIntroductionToNetAndDockerArticle()
        {
            NetCoreGuide.Click();
            Docker.Click();
            IntroductionToNetAndDocker.Click();
        }
    }
}