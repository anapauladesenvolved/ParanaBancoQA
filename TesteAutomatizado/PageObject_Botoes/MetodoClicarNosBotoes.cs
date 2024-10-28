using OpenQA.Selenium;
using TesteAutomatizado.PageObject_Navegadores;

namespace TesteAutomatizado.PageObject_Botoes
{
    public class MetodoClicarNosBotoes 
    {
        private readonly IWebDriver _webDriver;
        public MetodoClicarNosBotoes(IWebDriver webdriver)
        {
            _webDriver = webdriver;
        }

        public IWebElement BotaoUm => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/a[1]"));
        public IWebElement BotaoDois => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/a[2]"));
        public IWebElement BotaoTres => _webDriver.FindElement(By.XPath("//*[@id='content']/div/div/div/div[1]/a[3]"));


        public void ClicarNosBotoes()
        {
           
            //Este metodo clica nos três botoes apresentados na tela
            BotaoUm.Click();
            BotaoDois.Click();
            BotaoTres.Click();
        }
    }
}
