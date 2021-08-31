using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
namespace ECCI_IS_Lab01_WebApp.Selenium
{
    [TestClass]
    public class Selenium
    {
        IWebDriver driver;
        [TestCleanup]
        public void TearDown()
        {
            if (driver != null)
                driver.Quit();
        }
        [TestMethod]
        public void PruebaIngresoChrome()
        {
            ///Arrange
            /// Crea el driver de Chrome
            driver = new ChromeDriver();
            PruebaIngreso();
        }
        [TestMethod]
        public void PruebaIngresoFirefox()
        {
            ///Arrange
            ////// Crea el driver de Chrome
            driver = new FirefoxDriver();
            PruebaIngreso();
        }
        private void PruebaIngreso()
        {
            ///Arrange
            /// Pone la pantalla en full screen
            driver.Manage().Window.Maximize();
            ///Act
            /// Se va a la URL de la aplicacion
            driver.Url = "http://localhost/ECCI_IS_Lab01_WebApp/";
            ///Assert
            Assert.AreEqual(driver.FindElement(By.XPath("//h1")).Text, "ASP.NET");
        }
    }
}