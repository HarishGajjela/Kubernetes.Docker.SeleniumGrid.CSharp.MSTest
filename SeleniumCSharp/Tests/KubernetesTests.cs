using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;

//[assembly: Parallelize(Workers = 3, Scope = ExecutionScope.MethodLevel)]
namespace SeleniumCSharp
{
    [TestClass]
    public class KubernetesTests
    {
        IWebDriver driver;
        public string HubUrl = "127.0.0.1:51639";
        [TestMethod]
        public void RemoteChromeTest1()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            driver = new RemoteWebDriver(new Uri("http://" + HubUrl + "/wd/hub"), options);
            driver.Url="https://opensource-demo.orangehrmlive.com/";
            Console.WriteLine("title :" + driver.Title);
            driver.Quit();
        }
        [TestMethod]
        public void RemoteChromeTest2()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            driver = new RemoteWebDriver(new Uri("http://" + HubUrl + "/wd/hub"), options);
            driver.Url = "https://www.linkedin.com/";
            Console.WriteLine("title :" + driver.Title);
            driver.Quit();
        }
        [TestMethod]
        public void RemoteChromeTest3()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("disable-infobars");
            driver = new RemoteWebDriver(new Uri("http://" + HubUrl + "/wd/hub"), options);
            driver.Url = "https://www.flipkart.com/";
            Console.WriteLine("title :" + driver.Title);
            driver.Quit();
        }
        [TestMethod]
        public void RemoteFirefoxTest4()
        {
            FirefoxOptions options = new FirefoxOptions();
            options.AddArguments("disable-infobars");
            driver = new RemoteWebDriver(new Uri("http://" + HubUrl + "/wd/hub"), options);
            driver.Url = "https://www.youtube.com/";
            Console.WriteLine("title :" + driver.Title);
            driver.Quit();
        }
    }
}