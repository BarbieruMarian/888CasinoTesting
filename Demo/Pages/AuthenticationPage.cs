using Demo.Extensions;
using Demo.Utilities;

namespace Demo.Pages
{
    public class AuthenticationPage : WebPageCommonActions
    {
        private static string UsernameSelector = "email";

        public void TypeEmailAdress(string emailAdress)
        {
            var usernameElement = Browser.Driver.FindElementById(UsernameSelector);
            usernameElement.SendKeys(emailAdress);
        }

    }
}
