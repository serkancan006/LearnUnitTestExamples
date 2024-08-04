using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helpers.Tests.Notes
{
    class Notes
    {
    }

    #region Test seviyeleri (TestInitialize,ClassInitialize)
    // Initialize ve Cleanup: Test yaşam döngüleridir.
    // bunlar 3 seviyede uygulanır Test Level, Class Level, Assembly Level
    // tek olan nesneleri kullandığımız yerlerde olabilir veritabanı bağlantı nesneleri gibi...

    // TestInitialize
    // her testten yani [TestMethoddan] önce çalışır  [TestCleanup] ise her test metodundan sonra çalışır örneğin _cartManager.Clear() ----- sadece tek test için yapılıp sonlanır sonra diğer test için yapılıp sonralınrlar.

    //ClassInitialize
    //[ClassInitialize]
    //[ClassCleanup]
    //Methoddakinin aynısı: ([TestInitialize daki örneğin aynısı üzerinden yapabilirsin]),
    //her class için sadece birer tane test ve class initialize olabilir.

    //AssemblyLevel - AssemblyInitialize ve AssemblyClenup
    //Bütün unitest projesi boyunca bir defaya mahsus olacak şekilde çalışır. bütün projede sadece birer tane olurlar.

    //yaşam döngüsü örneği DemoAssemblyLevel a bakabilirsin.
    #endregion

    #region Demo ExpectedException
    // bazı durumlarda hata vermek için kullanılabilir.
    // hata olduğunda neden testten geçmediğini gösterir. fakat bunun gözükmesini istemeyebilirim ve testten geçmesi gerekmesi gerekebilir
    //[ExpectedException(typeof(ArgumentException))] bunu yapınca ArgumentException hatası veriyor ise hata verse bile işlemler testten geçebilecektir. tip olarak direk Exception verir isem test başarısız olur. çünkü birebir tiplere bakar. eğer her hata durumu fark etmeksizizin ise kalıtım durumlarında geçerli olması için
    // [ExpectedException(typeof(ArgumentException),AllowDerivedTypes = true)] yapılması gerek.  üremiş türlere izin ver demiş oluruz.
    #endregion

    #region Introduction Asserts    
    // Assert, CollectionAsssert,StringAssert
    //Demo Assert - 1
    //Assert.AreEqual(beklenen,gerceklesen,test_result_ekranında yazakcak string veri)
    //Assert.AreEqual(beklenen,gerceklesen,delta = 0.0001) virgülden sonraki 4 basamağın doğru olması yeterlidir.
    // bir tolerans tanıma olayı mesela pi 3,1622 ve 3,16225565 olduğunda patlamasın diye
    // MERHABA, merhaba hata vermesin diye Assert.AreEqual(beklnen, gerceklesen,true) ypaılabilir
    // istediğimiz sonuç dışında bir değer gelmesinde
    // Assert.AreNotEqual(beklenmeyen, gercekese) = 5, 5,1 gibi
    // Demo Assert - 2
    //Assert.AreSame ve ArenotSame referanslarının aynı(referance type) olup olmaması(value type) ile ilgilenir.
    // Demo Assert - 3
    // Assert.AreEqual(1,1) Assert.Inconclisive("Bu test yeterli değildir.")
    // Assert.IsInstanceOfType(sayi, typeof(decimal)); belirtilen tipte olup olmadığını kontrol eder
    // Assert.IsTrue ve Assert.IsFalse bool değeri kontrol eder Assert.IsTrue(10 %2 ==0);
    // Demo Assert - 4
    // Assert.IsNull ve IsnotNull bir değerin null olup olmamasını kontrol eder. ikinci parametre ile mesaj verilmesi tavsiye edilir.
    // Assert.Fail("Test başarısız oldu") test metodunda catch içinde yazılabilir. ve test başarısız olur başarılı geçmez.
    #endregion

    #region Collection Assert
    // - 1
    //CollectionAssert.AreEqueal(liste,liste) -> elemanların sırası ve değerleri aynı mı
    //CollectionAssert.AreEquivalent(liste,liste) -> sıra farklı fakat verilerin aynı olması gerek, olumsuzda elemanlar farklı olmalıdr.
    // - 2
    //CollectionAssert.allItemsAreNotNull(liste) -> gelen listede null değeri olup olmamasını kontrol eder null var ise başarısız olur
    //CollectionAssert.allItemsAreUnique(liste) -> gelen listede elemaların benzersiz olması gerek
    //CollectionAssert.allItemsAreInstanceOfType(liste) -> gelen listede elemaların tiplerinin aynı olması gerek.
    // - 3
    //CollectionAssert.IsSubsetOf(liste, liste) -> bir listenin diğer listenini kümesi olup olmadığına vakar
    //CollectionAssert.IsNotSubsetOf(liste, liste) -> 
    //CollectionAssert.Contains(liste, string) -> içinde geçen veri var mı yok mu diye bakar
    //CollectionAssert.DoesNotContain(liste,string) -> 
    #endregion

    #region String Assert   
    // StringAssert.Contains(string,string) -> 
    // StringAssert.Matches(string, new Regex()) -> regular ex pattern i geçerli mi dğeilmi diye bakar
    // StringAssert.StartsWith(string,string) -> 
    // StringAssert.EndWith(string,string) -> 
    #endregion

    #region Test Context
    // Test COntext nesnesi birim testlerinini çalışma anında bize bilgi veren nesnedir. testin adı durumu gibi verileri almak için kullanılaiblir web servis url ve durumu gibi....
    // Demo TestContext
    // private readonly TestContext TestContext tipinde bir prop oluştur ve bir method içinde TestContext.Writeline("--TestMethod 1") olarak kullanabilirsin veya
    // TestContext.TestName -> çalışan testin adı. TestContext.CurrentTestOutcome testin durumunu
    // TestCOntext.FulltQualifiedTestClassName -> className.MethodName
    // TestContext.CurrentTestOutcome -> [TestCLenaup]  a yazarsak başarısız testleri loglar
    // TestCOntext.Properties["bilgi"] = "bi bur ekstra bilgidir" ekstra bilgi yazdırıyoruz.
    #endregion

    #region Data-Driven Unit Test
    // Veri temelli birim testleri yapılır. aynı birim testini farklı değerler ile veya veritabanına veri import etmek istediğimizde yapabiliyoruz.
    #endregion

    #region Test Attributes
    // Test attributelarına bakıcaz [Owner] gibi....
    #endregion

    #region Ordered Test
    //Bazı durumlarda testleri sıra ile çalıştırmak istersek
    // sağ tık ekle orderedtest diyip sırasıyla testleri seçerek yapabilirsin. check işareti sıradaki test hata aldığında altındakilerin de hata almaması için işaretlenebilir isteğe bağlıdır.
    #endregion


    //aşağıyı tekrar izleyebilirsin
    #region Unit Test Doğru yapılması
    //Birim testleri integration testlerine dönüştürmemek gerek solid prensiblerine uygun yazılım yapılması gerek
    #endregion

    #region Mocking
    //mocking bağımlılık durumlarında solide uygun yazılmış bir projede sahte nesne üretip bu bağımlılıkları yaşatmadan nesne alabildiğimiz ve sahte nesne gibi davranmasını sağlamamıza yarayan bir frameworktür.
    #endregion

    #region Test First Driven, Test Domain Driven
    //Test First Driven da önce test yazılır sonra proje oluşturulur gereksinimler ypaılır. bunu yaparken önce başarısız bir test daha sonra basit düzeyde başarılı test en son ise rafactor edilir.
    //Test Domain Driven da ise önce proje oluşturulmuş olur. daha sonra testleri yazılır.
    #endregion

}
