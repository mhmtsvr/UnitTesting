using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System.Threading;

namespace SeleniumTestTool
{
    class DashboardPage
    {
        //*Menu_Sayfalar
        [FindsBy(How = How.XPath, Using = "//a[@class='introjs-button introjs-skipbutton']")]
        public IWebElement skip_button { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Kadastro/Numarataj')]")]
        public IWebElement KadastroNum { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Mahalleler')]")]
        public IWebElement sub_Mahalleler { get; set; }
        [FindsBy(How = How.XPath, Using = "//input[@id='dmyQueryButton']")]
         // [FindsBy(How = How.LinkText, Using = "Sorgula")]
        public IWebElement button_Sorgu { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Yollar')]")]
        public IWebElement sub_Yollar { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Parseller')]")]
        public IWebElement sub_Parseller { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Yapılar')]")]
        public IWebElement sub_Yapilar { get; set; }
        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Kapılar')]")]
        public IWebElement sub_Kapilar { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[contains(.,'Bağımsız Bölümler')]")]
        public IWebElement sub_BagimsizBolumler { get; set; }






        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_1_dockPanel_0']/div[1]/div/div/button")]
        public IWebElement webpartprop_default { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_1_dockPanel_0_Content']")]
        public IWebElement webpartcontent_default { get; set; }


        [FindsBy(How = How.Id, Using = "searchScroll")]
        public IWebElement panel_SearchScroll { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='cbpWidgetContent']/div[1]/div[6]/div/div[1]/input")]
        public IWebElement dd_HavaDurumu { get; set; }

        [FindsBy(How = How.XPath, Using = "//div[contains(@id,'tblbanner')]")]

        public IWebElement banner { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_popUpWidget__ba_treeWidgets_P__tree']/ul[2]/li/ul/li[1]/span/span[3]")]
        public IWebElement tree_AktifKullanici { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[contains(.,'Beklenmeyen bir hata oluştu')]")]
        public IWebElement lbl_Security1 { get; set; }

        [FindsBy(How = How.XPath, Using = "//td[contains(.,'Detaylar için Log Sunucusunu ziyaret edin')]")]
        public IWebElement lbl_Security2 { get; set; }



        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_popUp__ba_popUpTextboxName")]
        public IWebElement txt_PopupYeniSayfaEkle { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_popUp__fa_popUpBtnSave")]
        public IWebElement btn_PopupYeniSayfaKaydet { get; set; }

        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_popUpWidget__fa_btnWidgetSave")]
        public IWebElement btn_PopupAlanKaydet { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_popUpWidget__ba_treeWidgets_R_D']/span[2]/span")]
        public IWebElement btn_AlanEkleUcgen { get; set; }

        [FindsBy(How = How.XPath, Using = "//span[@class='fancytree-expander']")]
        public IWebElement btn_AlanEkleTreeAc { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_popUpWidget__ba_lblAlan']")]
        public IWebElement lbl_AlanAdi { get; set; }


        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_0_dockPanel_3']/div[1]/div")]
        public IWebElement dock_Zone0_3 { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_1_dockPanel_0']/div[1]/div")]
        public IWebElement dock_Zone1_0 { get; set; }


        //Alan 


        [FindsBy(How = How.Id, Using = "ReportName")]
        public IWebElement txt_ReportName { get; set; }

        [FindsBy(How = How.Id, Using = "Title")]
        public IWebElement txt_Title { get; set; }

        [FindsBy(How = How.Id, Using = "Url")]
        public IWebElement txt_Url { get; set; }

        [FindsBy(How = How.Id, Using = "Sablon")]
        public IWebElement txt_Sablon { get; set; }

        [FindsBy(How = How.Id, Using = "ListName")]
        public IWebElement txt_ListName { get; set; }

        [FindsBy(How = How.Id, Using = "Width")]
        public IWebElement txt_Width { get; set; }

        [FindsBy(How = How.XPath, Using = "//*[@id='_ba']")]
        public IWebElement lbl_AlanUyari { get; set; }

        [FindsBy(How = How.CssSelector, Using = "button.close")]
        public IWebElement btn_AlanPencereKapat { get; set; }


        //Görünüm Tipleri
        [CacheLookup]
        [FindsBy(How = How.Id, Using = "ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_0__EPH")]
        public IWebElement dock_Zone0 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_2__EPH']")]
        public IWebElement dock_Zone2 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_3__EPH']")]
        public IWebElement dock_Zone3 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_4__EPH']")]
        public IWebElement dock_Zone4 { get; set; }

        [CacheLookup]
        [FindsBy(How = How.XPath, Using = "//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_5__EPH']")]
        public IWebElement dock_Zone5 { get; set; }


        public void func_AlanSec(int treeSatir)
        {

            btn_AlanEkleUcgen.Click();

            Thread.Sleep(2000);

            btn_AlanEkleTreeAc.Click();

            Thread.Sleep(2000);


            {
                Browser.driver.FindElement(By.XPath("//*[@id='ctl00_ContentPlaceHolder1_popUpWidget__ba_treeWidgets_P__tree']/ul[2]/li/ul/li[" + treeSatir + "]/span/span[3]")).Click();
            }
            Thread.Sleep(2000);

            lbl_AlanAdi.Click();

            Thread.Sleep(1000);

        }


        public void func_WebpartIslem(int islem)
        {
            webpartprop_default.Click();

            Browser.driver.FindElement(By.XPath("//*[@id='ctl00_ContentPlaceHolder1_cbpDockManager_dockManager_zone_1_dockPanel_0']/div[1]/div/div/div/li[" + islem + "]/a")).Click();

        }

    }
}



