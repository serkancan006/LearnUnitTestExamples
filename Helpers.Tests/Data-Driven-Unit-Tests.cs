using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Data;
using System.Threading.Tasks;

namespace Helpers.Tests
{
    [TestClass]
    public class Data_Driven_Unit_Test
    {
        public TestContext TestContext { get; set; }
      
        // [DataSource("Microsoft.VisualStudio.TestTolls.DataSource.CSV")] // exel
        // veri tipi = ilk parametre
        //verileri sıralı işle =  sonra paratmere
        //connection string = 2. paramtre
        //Sütun ismi veya xml için Kullanici oldu = 3. parametre
        //XML deki veri kadar bu aşağıdaki test çalışır
        [DataSource("Microsoft.VisualStudio.TestTolls.DataSource.XML", @"D:\Yazilim - Proje - ve - Uygulamalari\Asp.Net Projeleri\TestStartedLearning\LearnTesting\Helpers.Tests\Kullaniciliar.xml", "Kullanici", DataAccessMethod.Sequential)] //veri temelli hale ggetiriyoruz
        [TestMethod]
        public void DataTest()
        {
            //normalde bu şekilde fakat DataROw kısmı gelmedi bun bir araştır.
            //var ad = TestContext.DataRow["ad"].ToString();
            //var telefon = TestContext.DataRow["telefon"].ToString(); 
            //var email = TestContext.DataRow["email"].ToString(); 

            //var sonuc = KullaniciEkle(ad, telefon, email);

            var manager = new KullaniciManager();
            var sonuc = manager.KullaniciEkle("", "", "");
            Assert.IsTrue(sonuc);
        }

        //[DataSource("MyDataSource"), TestMethod] // My Data source app.config içine eklenmiş burayı tekrar izle
        //public void DataTest2()
        //{
        //     islem = new IslemManager()
        //     var gerceklese = islem.Topla(2,3);
        //    //benzer işlemler yukarıdaki gibi TestCOntext.DataROw[""] ile elde edip fonksiyonu çağır
        //}

    }

    public class KullaniciManager
    {
        public bool KullaniciEkle(string ad, string tel, string email)
        {
            if (ad.Length < 4) return false;
            if (!Regex.IsMatch(tel, "[0-9]")) return false;
            if (!email.Contains("@")) return false;

            return true;
        }
    }
    public class IslemManager
    {
        public int Topla(int x, int y)
        {
            return x + y;
        }
    }
}
