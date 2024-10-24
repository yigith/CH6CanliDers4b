
using SekillerDunyasi;


// her dikdörtgen aslında bir şekildir de..
Sekil s1 = new Dikdortgen() { Genislik = 100, Yukseklik = 50 };
Console.WriteLine(s1);

// Console.WriteLine("Köşe Adedi: " + s1.KoseAdedi);

// s1 içinde barınan dikdörtgenin tam bir dikdörtgen gibi davranabilmesi 
// için onu tekrar kendi türüne cast etmemiz gerekiyor
//Dikdortgen d1 = (Dikdortgen)s1;
//Console.WriteLine("Köşe Adedi: " + d1.KoseAdedi);
Console.WriteLine("Alanı: " + s1.Alan());
Console.WriteLine("Çevre: " + s1.Cevre());
Console.WriteLine("Köşe Adedi: " + ((Dikdortgen)s1).KoseAdedi);
Console.WriteLine("--------------------------------------------");

Sekil s2 = new Elips() { Genislik = 10, Yukseklik = 10 };
Console.WriteLine(s2);
Console.WriteLine("Alanı: " + s2.Alan());
Console.WriteLine("Çevre: " + s2.Cevre());
Console.WriteLine("--------------------------------------------");

Console.ReadKey();