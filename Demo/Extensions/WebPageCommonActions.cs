using Demo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Demo.Extensions
{
    public class WebPageCommonActions
    {
        public void TypeInField(string textToType, IWebElement element)
        {
            var actions = SelectElement(element);
            actions.SendKeys(textToType);
            actions.Build().Perform();
        }

        public Actions SelectElement(IWebElement element)
        {
            var driver = Browser.Driver;
            var actions = new Actions(driver);
            actions.MoveToElement(element);
            actions.Click();
            return actions;
        }
    }
}
