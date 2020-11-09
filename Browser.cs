using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using OpenQA.Selenium.Interactions;

namespace SeleniumTestTool
{
    class Browser
    {
        public static IWebDriver driver;
        public static Actions act;

        public static void Main()
        {
            
            driver =  new ChromeDriver();
            driver.Manage().Window.Maximize();

            act = new Actions(driver);


            Thread.Sleep(2000);
            

        }
        public static void Quit()
        {
            driver.Quit();  //Firefox için tanımlanmadı.

            driver.Dispose();
        }

        public static void AcceptAlert()
        {
            try
            {
                driver.SwitchTo().Alert().Accept();
            }
            catch
            {
                Console.WriteLine("Alert bulunmadı!");
            }

        }


        public static string GetAlertText()
        {
            try
            {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                return alertText;
            }
            catch
            {
                Console.WriteLine("Alert bulunamadı!");
                return string.Empty;
            }
        }


        public static void ScrollVertical(int pixel)
        {
            JavaScriptExecutor("scroll(0," + pixel + ")");
           
        }

        public static void JavaScriptExecutor(string script)
        {
            IJavaScriptExecutor js = driver as IJavaScriptExecutor;

            js.ExecuteScript(script);
        }

    }
}

