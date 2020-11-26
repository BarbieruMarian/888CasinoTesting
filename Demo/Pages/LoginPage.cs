using Demo.Extensions;
using Demo.Utilities;
using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace Demo.Pages
{
    public class LoginPage
    {

        private static string UsernameSelector = "rlLoginUsername";
        private static string PasswordSelector = "rlLoginPassword";
        private static string SubmitLoginSelector = "rlLoginSubmit";
        private static string CloseFormSelector = "cy-modal-x-button";
        

        public void Authenticate(string username, string password)
        {
            FillUsernameAndPassword(username, password);
            ClickSubmitLoginButton();
            ClickCloseFormButton();
        }
        private void FillUsernameAndPassword(string username, string password)
        {
            var usernameElement = Browser.Driver.FindElement(By.Id(UsernameSelector), 10);
            var passwordElement = Browser.Driver.FindElement(By.Id(PasswordSelector), 10);
            usernameElement.SendKeys(username);
            passwordElement.SendKeys(password);
        }

        private void ClickSubmitLoginButton()
        {
            var submitButtonElement = Browser.Driver.FindElement(By.Id(SubmitLoginSelector), 10);
            submitButtonElement.Click();
        }

        private void ClickCloseFormButton()
        {
            var closeFormElement = Browser.Driver.FindElement(By.ClassName(CloseFormSelector), 10);
            closeFormElement.Click();
        }
    }
}
