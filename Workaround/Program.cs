// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



static void SelamVer()
{
    Console.WriteLine("Merhaba");
}

string[] sehirler1 = new[] { "Ankara", "İstanbul", "İzmir" };
string[] sehirler2 = new[] { "Bursa", "Antalya", "Diyarbakır" };

sehirler2 = sehirler1;
sehirler1[0] = "Adana";

Console.WriteLine(sehirler2[0]);



int sayi1 = 10;
int sayi2 = 20;
sayi2 = sayi1;
sayi1 = 30;
Console.WriteLine(sayi2);
//cevap 10

foreach (string sehir in sehirler1)
{
    Console.WriteLine(sehir);
}

//List - Array yerine bu kullanılıyor daha çok artık.
List<string> yeniSehirler1 = new List<string> { "Ankara 1", "İstanbul 1", "İzmir 1" };
yeniSehirler1.Add(item: "Adana 1");
foreach (var sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}

public class Vatandas
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int DogumYili { get; set; }
    public long TcNo { get; set; }

}