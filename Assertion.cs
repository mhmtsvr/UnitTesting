using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace SeleniumTestTool
{
    class Assertion
    {
        public static StringBuilder verificationErrors;

        public static void EsitMi(String beklenen, string deger)
        {
            try
            {
                Assert.AreEqual(beklenen, deger);
            }catch(AssertionException e)
             {
                verificationErrors.Append(e.Message);
             }
        }

        public static void EsitMi(bool beklenen, bool deger)
        {
            try
            {
                Assert.AreEqual(beklenen, deger);
            }
            catch (AssertionException e)
            {
            verificationErrors.Append(e.Message);
            }
        }

        public static void EsitMi(int beklenen, int deger)
        {
            Assert.AreEqual(beklenen, deger);
        }

        public static void EsitDegilMi(string beklenen, string deger)
        {
            try
            {
                Assert.AreNotEqual(beklenen, deger);
            }catch(AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }


        public static void YanlisMi(bool durum)
        {
            try
            {
                Assert.IsFalse(durum);
            }catch(AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }

        }

        public static void DogruMu(bool durum)
        {
            try
            {
                Assert.IsTrue(durum);
            }catch(AssertionException e)
            {
                verificationErrors.Append(e.Message);
            }
        }



    }
}


