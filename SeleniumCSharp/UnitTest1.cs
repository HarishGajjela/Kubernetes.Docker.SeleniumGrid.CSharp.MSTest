using Microsoft.Edge.SeleniumTools;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace SeleniumCSharp
{
    [TestClass]
    public class Tests
    {
        [TestMethod]
        public void EdgeTest()
        {
            var options = new EdgeOptions();
            options.UseChromium = true;
            options.AddArgument("-inprivate");
            IWebDriver driver = new EdgeDriver(options);
            driver.Url = "https://demoqa.com/";
            driver.Quit();
        }
    }
}