using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTool
{
    static class AccordionMenu
    {

        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.driver, page);
            return page;
        }


        public static Menu_HaritaNumarataj Menu_HaritaNumarataj
        {

            get { return GetPage<Menu_HaritaNumarataj>(); }

        }


        public static Menu_FenIsleri Menu_FenIsleri
        {

            get { return GetPage<Menu_FenIsleri>(); }

        }

        public static Menu_ParkBahceler Menu_ParkBahceler
        {

            get { return GetPage<Menu_ParkBahceler>(); }

        }

        public static Menu_YapiFormlari Menu_YapiFormlari
        {

            get { return GetPage<Menu_YapiFormlari>(); }

        }


    }



}
