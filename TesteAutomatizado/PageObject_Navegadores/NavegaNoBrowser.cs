using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TesteAutomatizado.PageObject_Navegadores
{
    public class NavegaNoBrowser
    {
        protected readonly IWebDriver _webDriver;

        public NavegaNoBrowser()
        {
            string path = "C:\\Users\\bruno\\source\\repos\\anapauladesenvolved\\CaseParanaBanco\\TesteAutomatizado\\PageObject_Navegadores\\chromedriver.exe";
            _webDriver = new ChromeDriver(path);
            _webDriver.Manage().Window.Maximize();
            _webDriver.Navigate().GoToUrl("https://the-internet.herokuapp.com/challenging_dom");
        }

    }
}
