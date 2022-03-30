// NUnit 3 tests
// See documentation : https://github.com/nunit/docs/wiki/NUnit-Documentation


using NUnit.Framework;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace NUnit.TestsSauss1
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://www.saucedemo.com/";
            IWebElement usernameTexField = driver.FindElement(By.XPath("*.//*[@id='user-name']"));
            usernameTexField.SendKeys("Selenium C#");
            driver.Quit();
        }
    }
}
