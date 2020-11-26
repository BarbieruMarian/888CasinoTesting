using Demo.Utilities;
using Demo.Extensions;
using OpenQA.Selenium;
using NUnit.Framework;

namespace Demo.Pages
{
    public class HomePage : WebPageCommonActions
    {
        private static string LoginSelector = "login_buttons_login_text";
        private static string LoggedUserSelector = "profile-name";
        private static string SearchGameSelector = "cy-game-search-input";
        private static string FirstGameSearchResults = "//*[@id=\"orbit-container\"]/div[5]/nav/div[1]/div[1]/div/div/span[1]/ul/li/a/span";

        public void Navigate(string URL)
        {
            Browser.Start().Navigate().GoToUrl(URL);
        }

        public LoginPage GotoLoginPage()
        {
            ClickLoginButton();
            return new LoginPage();
        }

        public TrailOfTreatsPage GotoTrailOfTreatsPage()
        {
            return new TrailOfTreatsPage();
        }

        private void ClickLoginButton()
        { 
            var loginElement = Browser.Driver.FindElement(By.ClassName(LoginSelector), 20);
            loginElement.Click();
        }

        public void VerifyLogin(string expectedUsername)
        {
            var loggedUserElement = Browser.Driver.FindElement(By.ClassName(LoggedUserSelector), 10);
            if (loggedUserElement.Text != expectedUsername)
            {
                Assert.Fail($"Expected user on the webpage was: {expectedUsername}, but instead we see {loggedUserElement.Text}");
            }

        }

        public void SearchForAGame(string textToSearch)
        {
            var searchGameElement = Browser.Driver.FindElement(By.ClassName(SearchGameSelector), 10);
            TypeInField(textToSearch, searchGameElement);
            var firstGameResultElement = Browser.Driver.FindElement(By.XPath(FirstGameSearchResults), 10);
            firstGameResultElement.Click();

        }
    }
}
