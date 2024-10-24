
using BizimSirket;
using System.Globalization;

// console üzerinde unicode karakterlerini göster
Console.OutputEncoding = System.Text.Encoding.UTF8;

// programın kültürünü değiştirme
Thread.CurrentThread.CurrentCulture = new CultureInfo("tr-TR");

// vergi oranını değiştirelim (herkes için)
Calisan.VergiOraniniGuncelle(0.20m);

Calisan c1 = new Calisan("Serhat", "Backend Developer", 17002m);
Calisan c2 = new Calisan("İlayda", "CEO", 100000m);
Calisan c3 = new Calisan("Enes", "Yönetici Asistanı", 75000m);
Calisan c4 = new Calisan("İrem", "Product Manager", 200000m);

Calisan[] calisanlar = { c1, c2, c3, c4 };

foreach (var calisan in calisanlar)
{
    Console.WriteLine(calisan);
}

// Bir sınıfın örnekleri (instance) üzerinden o sınıfa ait
// static üyelere erişemezsiniz. Çünkü statik üyeler
// örnekten örneğe değişmeyen sınıf seviyesinde
// herkes için ortak olan değerlerdir.

Console.ReadKey();