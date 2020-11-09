using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTool
{
    class Sub_Tanimlamalar
    {
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Fen İşleri')]")]
        public IWebElement menu_FenIsleri { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Tanımlamalar')]")]
        protected IWebElement sub_Tanimlamalar { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İmalat Türü Ekleme')]")]
        public IWebElement sub2_ImalatTuruEkleme { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İş Türü Ekleme')]")]
        public IWebElement sub2_IsTuruEkleme { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_querySimpleForm_F_1790092966__ntb']")]
        public IWebElement txt_IsTuruEklemeAdi { get; set; }
        public void GoToImalatTuruEkleme()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_Tanimlamalar.WaitforVisibility(10);

            sub_Tanimlamalar.Click();

            sub2_ImalatTuruEkleme.WaitforVisibility(10);

            sub2_ImalatTuruEkleme.Click();
        }
        public void GoToIsTuruEkleme()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_Tanimlamalar.WaitforVisibility(10);

            sub_Tanimlamalar.Click();

            sub2_IsTuruEkleme.WaitforVisibility(10);

            sub2_IsTuruEkleme.Click();
        }
    }
}
