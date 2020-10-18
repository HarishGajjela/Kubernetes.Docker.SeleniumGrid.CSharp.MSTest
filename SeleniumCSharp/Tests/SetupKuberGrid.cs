using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading;

namespace SeleniumCSharp
{
    public class SetUpKubeGrid
    {
        [TestInitialize]
        public void StartDockerGrid()
        {
            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles\\StartMinukube.bat");
            Thread.Sleep(10000);
            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles\\Start_KubeGrid.bat");
        }

        [TestCleanup]
        public void StopDockerGrid()
        {
            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles\\StopMinikube.bat");
            Thread.Sleep(20000);

            System.Diagnostics.Process.Start("D:\\Selenium\\Project\\SeleniumCSharp\\SeleniumCSharp\\Yml_BatFiles");
        }
    }
}