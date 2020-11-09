using OpenQA.Selenium.Support.PageObjects;
using System.Threading;
using SeleniumTestTool;
namespace SeleniumTestTool
{
    static class TopMenu
    {
        private static T GetPage<T>() where T : new() //***Getpage***
        {
            var page = new T();


            PageFactory.InitElements(Browser.driver, page);
            return page;
        }

        public static Menu_Sayfalar Menu_Sayfalar
        {

            get { return GetPage<Menu_Sayfalar>(); }

        }

        public static Menu_Anasayfa Menu_Anasayfa
        {

            get { return GetPage<Menu_Anasayfa>(); }

        }

        public static Menu_Dashboard Menu_Dashboard
        {

            get { return GetPage<Menu_Dashboard>(); }

        }

        public static Menu_Arama Menu_Arama
        {

            get { return GetPage<Menu_Arama>(); }

        }

        public static Menu_Harita Menu_Harita
        {

            get { return GetPage<Menu_Harita>(); }

        }

        public static Menu_Ayarlar Menu_Ayarlar
        {
            get { return GetPage<Menu_Ayarlar>(); }
        }

    

    }
}
