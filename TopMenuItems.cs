using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SeleniumTestTool
{
    class Menu_Sayfalar
    {

        public void GoToYeni(int menuTip, int sayfa)
        {

            string MenuTip = menuTip.ToString();

            string Sayfa = sayfa.ToString();

            Browser.driver.FindElement(By.XPath("//*[contains(@id,'masterMenu')]/div[" + MenuTip + "]/div[1]/button[1]")).WaitforVisibility(5);

            Browser.driver.FindElement(By.XPath("//*[contains(@id,'masterMenu')]/div[" + MenuTip + "]/div[1]/button[1]")).Click();

            Thread.Sleep(2000);

            Browser.driver.FindElement(By.XPath("//*[contains(@id,'masterMenu')]/div[" + MenuTip + "]/div[1]/ul[1]/li[" + Sayfa + "]/a[1]")).Click();

            Thread.Sleep(2000);           

        }


    }

    class Menu_Gecmis
    {


        [FindsBy(How = How.XPath, Using = "//*[@id='historynav']/a")]
        protected IWebElement btnGecmis { get; set; }

        public void GecmiseGit(int sira)
        {
            btnGecmis.Click();

            Browser.driver.FindElement(By.XPath("//*[@id='main-navbar-notifications']/div[" + sira + "]/div[1]/a")).Click();

        }

        public string GecmisKontrol(int sira)
        {
            string val = string.Empty;

            btnGecmis.Click();

            Thread.Sleep(2000);

            val = Browser.driver.FindElement(By.XPath("//*[@id='main-navbar-notifications']/div[" + sira + "]/div[1]/a")).Text;

            btnGecmis.Click();

            return val;
        }
        
    }


    class Menu_Anasayfa
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='dashboardCnt']")]
        protected IWebElement btnAnasayfa { get; set; }



        public void GoTo()
        {
            btnAnasayfa.Click();

            Thread.Sleep(2000);
        }



    }

    class Menu_Dashboard
    {
        //Button Anasayfa
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_aDashboard']")]
        protected IWebElement btnDashboard { get; set; }



        public void GoTo()
        {
            btnDashboard.Click();

            Thread.Sleep(2000);
        }

  
    }


    class Menu_Arama
    {

        [FindsBy(How = How.XPath, Using = "//*[@id='autosearchcont']")]
        public IWebElement txtArama { get; set; }

        [FindsBy(How = How.CssSelector, Using = "div.input-group")]
        public IWebElement txtAra { get; set; }


       
        public void GenelArama(string prm)
        {
            IJavaScriptExecutor js = Browser.driver as IJavaScriptExecutor;

            js.ExecuteScript("$('#autosearchcont').triggerHandler(\"focus\");");

            txtArama.Clear();

            txtArama.SendKeys(prm);

            Thread.Sleep(1000);

            txtArama.SendKeys(Keys.Enter);

        }



        

        public string GenelAramaResimClassAl(int element)
        {

            return Browser.driver.FindElement(By.XPath("//*[@id='searchScroll']/ul/li[" + element + "]/span")).GetAttribute("class");
        }


    }



    class Menu_Harita
    {
        //Button Harita
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_masterMenu']/li[1]/a")]
        protected IWebElement btnHarita { get; set; }

    }

    class Menu_Uyarilar
    {
        //Button Uyarılar
        [FindsBy(How = How.XPath, Using = "//*[@id='main-navbar-collapse']/div/div/ul/li[1]/a")]
        protected IWebElement btnUyarilar { get; set; }

    }

    class Menu_Kullanici
    {

        //Button Kullanici
        [FindsBy(How = How.XPath, Using = "//i[@class='nav-icon fa fa-user']")]
        protected IWebElement btnKullanici { get; set; }


        //Button Kullanici
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Yönet - Meta Dili')]")]
        protected IWebElement btnYonetMetaDili { get; set; }

        //Button Kullanici
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'English (United States)')]")]
        protected IWebElement btnİngilizce { get; set; }

        //Button Kullanici
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Türkçe (Türkiye)')]")]
        protected IWebElement btnTurkce { get; set; }

        //Button Kullanici
        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Çıkış')]")]
        protected IWebElement btnÇıkış { get; set; }
        

    }

    
    class Menu_Ayarlar
    {
        
        [FindsBy(How = How.CssSelector, Using = "i.nav-icon.fa.fa-cogs")]
        protected IWebElement btnAyarlar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='demo-settings-list']/li[3]/div/div/div[2]")]
        protected IWebElement btn_Banner { get; set; }

       public void func_banner_AcKapa(bool durum)
        {
            btnAyarlar.Click();

            Thread.Sleep(2000);

            btn_Banner.Click();


            btnAyarlar.Click();

        }


    }

}
