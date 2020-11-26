using Demo.Config;
using Demo.Utilities;
using TechTalk.SpecFlow;

namespace Demo.Hooks
{
    [Binding]
    public class TestIntialize
    {
        [AfterScenario]
        public void AfterTest()
        {
            Browser.Stop();
        }

        [BeforeScenario]
        public void BeforeTest()
        {
            ConfigReader.InitializeSettings("DemoBranch");
            Browser.KillChromeProcesses();
        }
    }
}
