using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SeleniumCSharp
{
    public class SetuPDockerGrid
    {
        [TestInitialize]
        public void StartDockerGrid()
        {
            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles\\Start_DockerGrid.bat");
            Thread.Sleep(20000);
        }

        [TestCleanup]
        public void StopDockerGrid()
        {
            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles\\Stop_DockerGrid.bat");
            Thread.Sleep(20000);

            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles");
        }
    }
}