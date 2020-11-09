using System;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace SeleniumTestTool
{
    class BaseTest
    {
        public static string testName;
        public static string className;
        public static string baseUrl;
        

        [SetUp]
        public void SetUpTest()
        {

            Tanımla();
            
            switch (className)
            {

                case "Anamodul_Anasayfa":

                    Baslat();
                    break;
                case "Anamodul_Formlar":


                    Baslat();
                    break;
                case "Anamodul_Genel":


                    Baslat();
                    break;
                case "Anamodul_Gorsellik":

                    Baslat();
                    break;
                case "Anamodul_Sorgu":


                    Baslat();
                    break;
  

                default:

                    Console.WriteLine("Base Class SetUp problem var!");

                    break;
            }


        }

        [TearDown]
        public void TearDownTest()
        {

            switch (className)
            {

                case "Anamodul_Genel":

                    Browser.Quit();

                    break;


                default:
                    Console.WriteLine("Base Class TearDown problem var!");

                    break;
            }

            DogrulamaKontrol();

        }

        public void Tanımla()
        {
            int splitCnt = TestContext.CurrentContext.Test.FullName.Split('.').Count();
            
            className = TestContext.CurrentContext.Test.FullName.Split('.')[splitCnt - 2];
            testName = TestContext.CurrentContext.Test.Name;
            baseUrl = "http://192.168.1.224/belnet" + "/ ";
            Assertion.verificationErrors = new StringBuilder();

        }

        public void Baslat()
        {
            Browser.Main ();

            Browser.driver.Navigate().GoToUrl(baseUrl);

           
            Page.LoginPage.login("netadmin", "1");


        }


        public void DogrulamaKontrol()
        {

            Console.WriteLine(Assertion.verificationErrors.ToString());

            Assert.AreEqual("", Assertion.verificationErrors.ToString());

        }


    }
}
