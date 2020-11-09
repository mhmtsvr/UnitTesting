using OpenQA.Selenium.Support.PageObjects;

namespace SeleniumTestTool
{
    static class Page
    {
        private static T GetPage<T>() where T : new()
        {
            var page = new T();
            PageFactory.InitElements(Browser.driver, page);
            return page;
        }

        public static BaseTest BaseTest
        {

            get { return GetPage<BaseTest>(); }

        }
        public static DashboardPage Dashboard
        {

            get { return GetPage<DashboardPage>(); }

        }

        public static LoginPage LoginPage
        {

            get { return GetPage<LoginPage>(); }

        }
        


    }
}
