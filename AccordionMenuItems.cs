using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTool
{
    class Menu_HaritaNumarataj
    {
        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/a/span")]
        public IWebElement menu_KadastroNum { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/ul/li[1]/a/span")]
        public IWebElement sub_Mahalleler { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='dmyQueryButton']")]
        
        public IWebElement button_Sorgu { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/ul/li[2]/a/span")]
        public IWebElement sub_Yollar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/ul/li[3]/a/span")]
        public IWebElement sub_Parseller { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/ul/li[4]/a/span")]
        public IWebElement sub_Yapilar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/ul/li[5]/a/span")]
        public IWebElement sub_Kapilar { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[2]/ul/li[6]/a/span")]
        public IWebElement sub_BagimsizBolumler { get; set; }


        public void GoToYollar()
        {
            menu_KadastroNum.WaitforVisibility(10);

            menu_KadastroNum.Click();

            sub_Yollar.WaitforVisibility(10);

            sub_Yollar.Click();
        }
        public void GoToParseller()
        {
            
            menu_KadastroNum.WaitforVisibility(10);

            menu_KadastroNum.Click();

            sub_Parseller.WaitforVisibility(10);

            sub_Parseller.Click();


        }
        public void GoToKapilar()
        {
            menu_KadastroNum.WaitforVisibility(10);

            menu_KadastroNum.Click();

            sub_Kapilar.WaitforVisibility(10);

            sub_Kapilar.Click();
        }
        public void GoToYapilar()
        {
            menu_KadastroNum.WaitforVisibility(10);

            menu_KadastroNum.Click();

            sub_Yapilar.WaitforVisibility(10);

            sub_Yapilar.Click();
        }
        public void GoToBagimsizBolumler()
        {
            menu_KadastroNum.WaitforVisibility(10);

            menu_KadastroNum.Click();

            sub_BagimsizBolumler.WaitforVisibility(10);

            sub_BagimsizBolumler.Click();
        }

    }
class Menu_FenIsleri
    {
        [FindsBy(How = How.XPath, Using = "//div[@class='selectize-input items not-full has-options firepath-matching-node focus input-active']")]
        public IWebElement dene { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Fen İşleri')]")]
        public IWebElement menu_FenIsleri { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İhale Kayıt & Sorgulama')]")]
        public IWebElement sub_IhaleKayitSorgulama { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='GenelSorgu.aspx?Adi=Standartgeofenis_isSorgusuSayfasi&MID=27']")]
        public IWebElement sub_Isler { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İmalatlar')]")]
        public IWebElement sub_Imalatlar { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Yol Kaplama')]")]
        public IWebElement sub_YolKaplama { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Yol Envanter')]")]
        public IWebElement sub_YolEnvanter { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Tanımlamalar')]")]
        public IWebElement sub_Tanimlamalar { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İmalat Türü Ekleme')]")]
        public IWebElement sub2_ImalatTuruEkleme { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İş Türü Ekleme')]")]
        public IWebElement sub2_IsTuruEkleme { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İş Takibi')]")]
        public IWebElement sub_IsTakibi { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Günü Geçen')]")]
        public IWebElement sub2_GunuGecen { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[contains(.,'Bugün Biten')]")]
        public IWebElement sub2_BugunBiten { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Devam Eden')]")]
        public IWebElement sub2_DevamEden { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Hatalı Tarih Girişleri')]")]
        public IWebElement sub2_HataliTarihGirisleri { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='dmyQueryButton']")]
        public IWebElement button_Sorgu { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_querySimpleForm']/div/div/div[1]/div/div[2]/div[1]/div/div[2]/div[1]/div/div[1]/input")]
        public IWebElement txt_mahalleAdi { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_QueryGridView_QueryGridView_DataTablesGrid']/tbody/tr[3]/td[12]/div/div/a")]
        public IWebElement label_ImalatBilgisi { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_DataEntryForm1']/div/div/div[1]/div/div[2]/div[12]/div/div[2]/div[1]/div/div[1]/input")]
        public IWebElement txt_aciklama { get; set; }

        [FindsBy(How = How.XPath, Using = "..//*[@id='ctl00_ContentPlaceHolder1_DataEntryForm1_F_N736933783']")]
        public IWebElement txt_imalatYogunlugu { get; set; }


        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_ContentPlaceHolder1_QueryGridView_QueryGridView_DataTablesGrid']/tbody/tr[3]/td[13]/div/div/a")]
        public IWebElement label_Harita { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_contentFrameLink']/i")]
        public IWebElement button_HaritadanGeriDon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_masterMenu']/div[4]/div/a/span[2]")]
        public IWebElement button_ImalatSorgusunaGeriDon { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='btnAdd']")]
        public IWebElement button_Kaydet { get; set; }

        private T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.driver, page);
            return page;
        }

        public void GoToIhaleKayitSorgulama()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_IhaleKayitSorgulama.WaitforVisibility(10);

            sub_IhaleKayitSorgulama.Click();
        }

        public void GoToIsler()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_Isler.WaitforVisibility(10);

            sub_Isler.Click();
        }

        public void GoToImalatlar()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_Imalatlar.WaitforVisibility(10);

            sub_Imalatlar.Click();
        }

        public void GoToYolKaplama()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_YolKaplama.WaitforVisibility(10);

            sub_YolKaplama.Click();
        }

        public void GoToYolEnvanter()
        {
            menu_FenIsleri.WaitforVisibility(10);

            menu_FenIsleri.Click();

            sub_YolEnvanter.WaitforVisibility(10);

            sub_YolEnvanter.Click();
        }

        public Sub_Tanimlamalar Sub_Tanimlamalar
        {

            get { return GetPage<Sub_Tanimlamalar>(); }

        }
     public void func_GoToSorgu(int x, int y)
        {

            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/a")).Click();

            }

            Thread.Sleep(1000);
            Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span")).Click();

        }

    }

    class Menu_ParkBahceler
    {

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Park Bahçeler')]")]
        public IWebElement menu_ParkBahceler { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'İhale Kayıt ve Sorgulama')]")]
        public IWebElement sub_IhaleKayitSorgulama { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='GenelSorgu.aspx?Adi=Standartgeopark_isSorgusuSayfasi&MID=38']")]
        public IWebElement sub_Isler { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mid='39']")]
        public IWebElement sub_Parklar { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Park İç Alanları')]")]
        public IWebElement sub_ParkIcAlanlari { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Park Elemanları')]")]
        public IWebElement sub_ParkElemanlari { get; set; }

        [FindsBy(How = How.XPath, Using = "//input[@id='dmyQueryButton']")]
        public IWebElement button_Sorgu { get; set; }

    }

    class Menu_YapiFormlari
    {

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/a/span")]
        public IWebElement menu_YapiFormlari { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/a/span")]
        public IWebElement sub_YapiRuhsati { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[1]/a/span")]
        public IWebElement sub2_Sorgulama { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[1]/ul/li[1]/a/span")]
        public IWebElement sub3_EslesenYapıRuhsatlari { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[1]/ul/li[2]/a]")]
        public IWebElement sub3_SerbestSorgu { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Raporlama')]")]
        public IWebElement sub2_Raporlama { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='Genelsorgu.aspx?QueryGroup=YAPI_RUHSATI.Yil_Bazli&Template=YAPI_RUHSATI.Yıl+Bazlı&MID=42&MID=44']")]
        public IWebElement sub3_YilBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@href='Genelsorgu.aspx?QueryGroup=YAPI_RUHSATI.Ay_Bazli&Template=YAPI_RUHSATI.AyBazli&MID=45']")]
        public IWebElement sub3_AyBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mid='46']")]
        public IWebElement sub3_MahalleAyYilBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mid='47']")]
        public IWebElement sub3_ToplamArsaMaliyetiBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mid='48']")]
        public IWebElement sub3_VerilisAmaciBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Diğer Veriliş Amacı Bazlı')]")]
        public IWebElement sub3_DigerVerilisAmaciBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Harç Bazlı')]")]
        public IWebElement sub3_HarcBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mid='51']")]
        public IWebElement sub3_ParselKullanimAmaciBazli { get; set; }

        [FindsBy(How = How.XPath, Using = "//a[@mid='52']")]
        public IWebElement sub3_5YiliGecen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[3]/a/span")]
        public IWebElement sub2_EslesmeSorgulari { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[3]/ul/li[1]/a/span")]
        public IWebElement sub3_ParselEslesmeyen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[3]/ul/li[2]/a/span")]
        public IWebElement sub3_ParseliKapisiEslesmeyen { get; set; }

        [FindsBy(How = How.XPath, Using = ".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[5]/ul/li[1]/ul/li[4]/a/span")]
        public IWebElement sub2_Ekleme { get; set; }

        //Yapı Ruhsatı sadece.


        [FindsBy(How = How.XPath, Using = "//input[@id='dmyQueryButton']")]
        public IWebElement button_Sorgu { get; set; }



        public void func_GoToSorgu(int x, int y, int z, int w)
        {


            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/a")).Click();

            }

            Thread.Sleep(1000);

            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/ul/li[" + z + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span")).Click();
            }

            Thread.Sleep(1000);
            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/ul/li[" + z + "]/ul/li[" + 2 + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/ul/li[" + z + "]/a/span")).Click();
            }

            Thread.Sleep(1000);

            Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/ul/li[" + z + "]/ul/li[" + w + "]/a/span")).Click();

            Thread.Sleep(4000);



        }

        public void func_GoToSorgu(int x, int y, int z)
        {
            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/a")).Click();

            }

            Thread.Sleep(1000);

            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/ul/li[" + z + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span")).Click();
            }

            Thread.Sleep(1000);
         Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/ul/li[" + z + "]/a")).Click();

            Thread.Sleep(2000);

            button_Sorgu.Click();
            Thread.Sleep(4000);

        }

        public void func_GoToSorgu(int x, int y)
        {

            if (!Extensions.IsElementVisible(Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span"))))
            {
                Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/a")).Click();

            }

            Thread.Sleep(1000);

            Browser.driver.FindElement(By.XPath(".//*[@id='ctl00_MenuWebUserControl_NetigmaSiteMenu1']/li[" + x + "]/ul/li[" + y + "]/a/span")).Click();

            Thread.Sleep(1000);

        }

    }


}
