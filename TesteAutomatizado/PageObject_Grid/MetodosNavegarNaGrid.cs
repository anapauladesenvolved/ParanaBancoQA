using OpenQA.Selenium;
using TesteAutomatizado.PageObject_Navegadores;

namespace TesteAutomatizado.PageObject_Grid
{
    public class MetodosNavegarNaGrid
    {
        private readonly IWebDriver _webDriver;
        public MetodosNavegarNaGrid(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public IWebElement Linha0Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[1]/td[7]/a[1]"));
        public IWebElement Linha0Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[1]/td[7]/a[1]"));
        public IWebElement Linha1Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[2]/td[7]/a[1]"));
        public IWebElement Linha1Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[2]/td[7]/a[1]"));
        public IWebElement Linha2Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha2Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha3Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha3Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha4Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha4Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha5Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha5Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha6Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha6Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha7Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha7Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha8Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha8Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));
        public IWebElement Linha9Edit => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[4]/td[7]/a[1]"));
        public IWebElement Linha9Delete => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[2]/table/tbody/tr[3]/td[7]/a[1]"));

        public void NavegarNaGrid()
        {

            Linha0Edit.Click();
            Linha0Delete.Click();

            Linha1Edit.Click();
            Linha1Delete.Click();

            Linha2Edit.Click();
            Linha2Delete.Click();

            Linha3Edit.Click();
            Linha3Delete.Click();

            Linha4Edit.Click();
            Linha4Delete.Click();

            Linha5Edit.Click();
            Linha5Delete.Click();

            Linha6Edit.Click();
            Linha6Delete.Click();

            Linha7Edit.Click();
            Linha7Delete.Click();

            Linha8Edit.Click();
            Linha8Delete.Click();

            Linha9Edit.Click();
            Linha9Delete.Click();
        }
    }
}
