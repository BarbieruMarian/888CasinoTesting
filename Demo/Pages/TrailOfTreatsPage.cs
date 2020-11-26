using Demo.Extensions;
using Demo.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Drawing;
using System.Threading;

namespace Demo.Pages
{
    public class TrailOfTreatsPage : WebPageCommonActions
    {
        private static string DemoSilderSelector = "//*[@id=\"cgp_overlay2\"]/div/div/div[1]/div/nav/div[1]/div[2]/div/div[2]/div/ul/li[3]";
        private static string IframeForCanvasSelector = "//*[@id=\"cgp_overlay3\"]/div/div/div[2]/div/iframe";
        private static string GameCanvasSelector = "//*[@id=\"gameCanvas\"]";
        private static string SpinButtonSelector = "spin_button";

        public void ClickDemoSlider()
        {
            var closeFormElement = Browser.Driver.FindElement(By.XPath(DemoSilderSelector), 10);
            closeFormElement.Click();

            Browser.Driver.SwitchTo().Frame(Browser.Driver.FindElement(By.XPath(IframeForCanvasSelector)));
            var okelement = Browser.Driver.FindElement(By.XPath(GameCanvasSelector), 10);

            Thread.Sleep(20000);

            Actions action = new Actions(Browser.Driver);
            action.MoveToElement(okelement, 650, 607).Click().DoubleClick().Build().Perform();
        }

        public void ClickSpinButton()
        {
            var spinButtonElement = Browser.Driver.FindElement(By.Id(SpinButtonSelector), 10);
            spinButtonElement.Click();

            //Just to show that the spin is working 
            Thread.Sleep(5000);
        }
    }
}
