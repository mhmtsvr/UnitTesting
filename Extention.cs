using System;
using OpenQA.Selenium;
using System.Threading;
using NUnit.Framework;
using System.Collections.ObjectModel;

namespace SeleniumTestTool 
{
    public static class Extensions
    {
        // namespace deki .Extensions ı silince Page.Dash.. erişimi çözüldü
        public static void WaitforVisibility(this IWebElement element, int duration)
        {

            for (int second = 0; ; second++)
            {
                if (second >= duration)
                {

                    Assert.Fail("timeout");
                }
                try
                {
                    if (IsElementVisible(element)) break;
                }
                catch (Exception)
                {
                }
                Thread.Sleep(1000);
            }

        }

        public static bool IsElementVisible(this IWebElement element)
        {

            return element.Displayed;
        }


        public static bool Exists(this IWebElement element)
        {

            try
            {
                var text = element.Text;

                return true;

            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }


        public static bool IsElementPresent(IWebElement element)
        {

            try
            {
                var text = element.Text;
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }

        }

        public static void Netigmadropdown(this IWebElement input, string search)
        {

            input.Click();
            input.SendKeys(search);
            Thread.Sleep(3000);
            IWebElement select = Browser.driver.FindElement(By.ClassName("selectize-dropdown-content"));
            

            select.FindElement(By.XPath("//div[contains(@class,'option active')]")).Click();

        }




        public static void Devexpressdropdown(string search)
        {
            string Etext = string.Empty;

            Browser.driver.FindElement(By.XPath("//*[contains(@id, '_cp_ce_st_B-1')]")).Click();

            ReadOnlyCollection<IWebElement> elements = Browser.driver.FindElements(By.ClassName("dxeListBoxItem"));

            Thread.Sleep(1000);

            foreach (IWebElement element in elements)
            {
                Etext = element.Text;

                if (Etext == search)
                {
                    element.Click();
                    break;
                }

            }

        }



     

    }
}

