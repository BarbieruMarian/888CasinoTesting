using Demo.Config;
using Demo.Pages;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace Demo.Steps
{
    [Binding]
    public class Casino888SpinWheelSteps
    {
        private HomePage homePage;
        private LoginPage loginPage;
        private TrailOfTreatsPage trailOfTreatsPage;

        [Given(@"I go to (.*)Casino Home Page")]
        public void GivenIGoToCasinoHomePage(int p0)    
        {
            homePage = new HomePage();
            homePage.Navigate(Settings.URL);
        }

        [Given(@"I type my authentication data as below")]
        public void AnddITypeMyAuthenticationDataAsBelow(Table table)
        {
            loginPage = homePage.GotoLoginPage();
            dynamic data = table.CreateDynamicInstance();
            loginPage.Authenticate((string)data.Username, (string)data.Password);
        }

        [Then(@"I verify that the login succeeded")]
        public void ThenIVerifyThatTheLoginSucceeded()
        {
            homePage.VerifyLogin(Settings.Username);
        }

        [Then(@"I open the ""(.*)"" game")]
        public void ThenIOpenTheGame(string gameName)
        {
            homePage.SearchForAGame(gameName);
            trailOfTreatsPage = homePage.GotoTrailOfTreatsPage();
        }

        [Then(@"I Switch to Demo Mode")]
        public void ThenISwitchToDemoMode()
        {
            trailOfTreatsPage.ClickDemoSlider();
        }

        [Then(@"I click the Spin Button")]
        public void ThenIClickTheSpinButton()
        {
            trailOfTreatsPage.ClickSpinButton();
        }
    }
}
