using OpenQA.Selenium;
using NUnit.Framework;
using System.Threading;


namespace SeleniumTestTool
{
    
    class Anamodul_Genel:BaseTest
    {
        [Test]
        public void MahallelerSorgula()//OK 
        {
            Page.Dashboard.skip_button.Click();

            Page.Dashboard.KadastroNum.Click();

            Thread.Sleep(2000);
         
            Page.Dashboard.sub_Mahalleler.Click();

            Thread.Sleep(2000);

            Page.Dashboard.button_Sorgu.Click();

            Thread.Sleep(2000);

            

        }

        [Test]
        public void YapiSorgula()//OK
        {
            //AccordionMenu.Menu_YapiFormlari.sub_YapiRuhsati... şeklinde
            //menüye gidiş eklendi. Aşağıdaki sorgu yöntemiyle de gidilebilir.
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(4, 1);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 4);

            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 1, 1);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 1, 2);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 1);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 2);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 3);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 4);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 5);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 6);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 7);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 8);
            Thread.Sleep(2000);
            AccordionMenu.Menu_YapiFormlari.func_GoToSorgu(5, 1, 2, 9);
            Thread.Sleep(2000);
            
        }

        [Test]
        public void ParsellerSorgula()//OK
        {
            Page.Dashboard.skip_button.Click();
            AccordionMenu.Menu_HaritaNumarataj.GoToParseller();
            Thread.Sleep(3000);
            Page.Dashboard.button_Sorgu.Click();
        }

        [Test]
        public void KapilarSorgula() //tamam
        {
            Page.Dashboard.skip_button.Click();
            AccordionMenu.Menu_HaritaNumarataj.GoToKapilar();
            Thread.Sleep(3000);
            AccordionMenu.Menu_FenIsleri.txt_mahalleAdi.Netigmadropdown("CEBECI");
            Page.Dashboard.button_Sorgu.Click();

        }

        [Test]
        public void IsTuruEkle()//tamam
        {
            Page.Dashboard.skip_button.Click();
            AccordionMenu.Menu_FenIsleri.Sub_Tanimlamalar.sub2_IsTuruEkleme.Click();
            AccordionMenu.Menu_FenIsleri.Sub_Tanimlamalar.txt_IsTuruEklemeAdi.Netigmadropdown("AAççğİIıiŞÇçş0131235241");
            Page.Dashboard.button_Sorgu.Click();
        }


        [Test]
        public void ImalatSorgula()
        {
            Page.Dashboard.skip_button.Click();
            Thread.Sleep(2000);
            
            AccordionMenu.Menu_FenIsleri.func_GoToSorgu(3, 3);
            AccordionMenu.Menu_FenIsleri.txt_mahalleAdi.Netigmadropdown("50");
            AccordionMenu.Menu_FenIsleri.button_Sorgu.Click();

            Thread.Sleep(2000);

            AccordionMenu.Menu_FenIsleri.label_ImalatBilgisi.Click();
            Thread.Sleep(1000);
            AccordionMenu.Menu_FenIsleri.txt_aciklama.Clear();


            Browser.act.MoveToElement(AccordionMenu.Menu_FenIsleri.txt_aciklama).SendKeys(Keys.Control+ "a").SendKeys(Keys.Backspace).SendKeys("aa").Build().Perform();
   

            Thread.Sleep(1000);
            AccordionMenu.Menu_FenIsleri.button_Kaydet.Click();
            Thread.Sleep(1000);
            AccordionMenu.Menu_FenIsleri.button_ImalatSorgusunaGeriDon.Click();
            Thread.Sleep(1000);
            AccordionMenu.Menu_FenIsleri.label_Harita.Click();
            Thread.Sleep(3000);
            AccordionMenu.Menu_FenIsleri.button_HaritadanGeriDon.Click();


            Thread.Sleep(2000);

        }

        [Test]
        public void YollarSorgula()
        {
            Page.Dashboard.KadastroNum.Click();

            Thread.Sleep(2000);

            Page.Dashboard.sub_Yollar.Click();

            Thread.Sleep(2000);

            Page.Dashboard.button_Sorgu.Click();
        }

 
        [Test]
        public void anasayfa_VarsayilanDuzeneDonTest() //OK
        {

            Thread.Sleep(3000);

            Browser.ScrollVertical(-500);

            TopMenu.Menu_Sayfalar.GoToYeni(1, 7);

            Thread.Sleep(3000);

            Assertion.EsitMi(Browser.GetAlertText(), "Varsayılan düzene dönmek istediğinize emin misiniz?");

            Browser.AcceptAlert();

            Thread.Sleep(2000);


        }

        [Test]
        public void BannerAcKapa()//OK
        {
            TopMenu.Menu_Ayarlar.func_banner_AcKapa(true);

            Assertion.EsitMi(false, Page.Dashboard.banner.IsElementVisible());


            Thread.Sleep(3000);

            TopMenu.Menu_Ayarlar.func_banner_AcKapa(false);

            Thread.Sleep(2000);

            Assertion.EsitMi(true, Page.Dashboard.banner.IsElementVisible());
        }


    }
}
