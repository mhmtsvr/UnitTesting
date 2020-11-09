using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SeleniumTestTool
{
    class LoginPage
    {
       
        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'txtKullAdi')]")]
        public IWebElement txtKullanici { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'TxtSifre')]")]
        public IWebElement txtSifre { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//input[contains(@id,'btnGiris')]")]
        public IWebElement btnGiris { get; set; }

        public void login(string user, string password)
        {
            txtKullanici.SendKeys(user);
            txtSifre.SendKeys(password);


            btnGiris.Click();

            Thread.Sleep(2000);
        }


    }
}
