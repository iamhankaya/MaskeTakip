// See https://aka.ms/new-console-template for more information


using Entities.Conctrete;

using Business.Concrete;

string mesaj = "Selam";
double tutar = 1000.25; //database'den gelir.
int sayi1 = 100;
int sayi2 = 200;
int sonuc;
bool girisYapmisMi = false;

string ad = "Metehan";
string soyad = "Kaya";
int dogumYili = 2003;
long tcNo = 12345678901;

Person vatandas1 = new Person();
vatandas1.Ad = "Metehan";
vatandas1.Soyad = "Kaya";
vatandas1.DogumYili = 2003;
vatandas1.TcNo = 12345678901;


Console.WriteLine(mesaj);
Console.WriteLine(tutar*1.18);

PersonManager personManager = new PersonManager();

static void SelamVer(Person vatandas)
{
    Console.WriteLine("Selam" +" "+ vatandas.Ad);
}

static int Topla(int sayi1,int sayi2)
{
    return sayi1 + sayi2;
}
    

SelamVer(vatandas1);
sonuc= Topla(sayi1,sayi2);
Console.WriteLine(sonuc);


string ogrenci1 = "Metehan";
string ogrenci2 = "Engin";
string ogrenci3 = "Ayşe";

Console.WriteLine(ogrenci1);
Console.WriteLine(ogrenci2);
Console.WriteLine(ogrenci3);

string[] ogrenciler = new string[3];
ogrenciler[0] = "Metehan";
ogrenciler[1] = "Engin";
ogrenciler[2] = "Ayşe";

ogrenciler = new string[4];
ogrenciler[3] = "İlker";

for(int i = 0; i < ogrenciler.Length; i++)
{
    Console.WriteLine(ogrenciler[i]);
}

string[] sehirler1 = ["Ankara", "İstanbul", "İzmir"];
string[] sehirler2 = ["Çanakkale","Diyarbakır","Çorum"];

sehirler2 = sehirler1;

Console.WriteLine(sehirler2[0]);

Person person1 = new Person();
person1.Ad = "Metehan";
person1.Soyad = "Kaya";
person1.TcNo = 1234434;
person1.DogumYili = 2003;
Person person2 = new Person();
person2.Ad = "Engin";

foreach(string s in sehirler2)
{
    Console.WriteLine(s);
}

List<string> yeniSehirler1 = new List<string> {"Afyon","Burdur", "Yozgat"};
yeniSehirler1.Add(sehirler1[0]);

foreach(string sehir in yeniSehirler1)
{
    Console.WriteLine(sehir);
}


PttManager pttManager = new PttManager(new PersonManager());
pttManager.GiveMask(person1);