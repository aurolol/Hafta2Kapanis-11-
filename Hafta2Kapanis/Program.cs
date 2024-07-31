// 1 - Aşağıdaki çıktıyı yazan bir program.
Console.WriteLine("Merhaba\nNasılsın?\nİyiyim\nSen nasılsın?");
// 2 - Bir adet metinsel , bir adet tam sayı verisi tutmak için 2 adet değişken tanımlayınız. Bunların değerlerini atayıp , ekrana yazdırınız.
string ad = "Atakan";
int yas = 26;
Console.WriteLine($"Merhabalar adım {ad} ve yaşım {yas}dır.");
// 3 - Rastgele bir sayı üretip , ekrana yazdırınız.
Random rnd = new Random();
int rastgeleSayi = rnd.Next();
Console.WriteLine($"Rasgele sayı -> {rastgeleSayi}");
// 4 - Rastgele bir sayı üretip , bunun 3'e bölümünden kalanı ekrana yazdırınız.
Random rnd2 = new Random();
int rasgeleSayi2 = rnd2.Next();
Console.WriteLine("Sayının 3'e bölümünden kalanı ->" + (rasgeleSayi2 % 3));
// 5 - Kullanıcıya yaşını sorup , 18'den büyükse "+" küçükse "-" yazdıran bir uygulama.
int yasiSor = 0;
Console.Write("Lütfen yaşınızı giriniz:");
int yasiSor2 = Convert.ToInt32(Console.ReadLine());
if (yasiSor2 >= 18)
{
    Console.WriteLine("+");
}
else
{
    Console.WriteLine("-");
}
// 6 - Ekrana 10 defa " Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem." yazan bir uygulama.
int i = 0;
while (i < 10)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
    i++;
}
// 7 - Kullanıcıdan 2 adet metinsel değer alıp "Gülse Birsel" , "Demet Evgar" , bunların yerlerini değiştiriniz.
Console.WriteLine("1. metni giriniz:");
string metin1 = Console.ReadLine();
Console.WriteLine("2. metni giriniz:");
string metin2 = Console.ReadLine();
string metin3 = metin1;
metin1 = metin2;
metin2 = metin3;
Console.WriteLine($"{metin1} {metin2}"); // 1. ve 2. metinsel değerlerin yerleri değiştirildi.
// 8 - Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımlayınız. Ekrana "Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma" yazsın.
void BenDegerDondurmem()
{
    Console.WriteLine("Ben değer döndürmem, benim bir karşılığım yok, beni değişkene atamaya çalışma");
}
BenDegerDondurmem();
// 9 - İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yazınız.
int İkiSayıToplamı()
{
    Console.Write("Birinci sayı:");
    int num1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("İkinci sayı:");
    int num2 = Convert.ToInt32(Console.ReadLine());
    return num1 + num2;
}
Console.WriteLine(İkiSayıToplamı());
// 10 - Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımlayınız.
string SoruOn(bool deger)
{
    return deger.ToString();
}
// 11 - 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yazınız.
int EnYasliOlan()
{
    Console.Write("1. yaşı giriniz:");
    int age1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("2. yaşı giriniz:");
    int age2 = Convert.ToInt32(Console.ReadLine());
    Console.Write("3. yaşı giriniz:");
    int age3 = Convert.ToInt32(Console.ReadLine());
    return Math.Max(age1, Math.Max(age2, age3));
}
Console.WriteLine(EnYasliOlan());
// 12 - Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yazınız.
int EnBüyükSayı()
{

    int enBüyük;
    Console.WriteLine("Oyunu bitirmek istiyorsanız 0 değerini giriniz.");
    Console.Write("Sayı giriniz:");
    int giris = Convert.ToInt32(Console.ReadLine());
    enBüyük = giris;
    while (giris != 0)
    {
        Console.WriteLine("Sayı giriniz:");
        giris = Convert.ToInt32(Console.ReadLine());
        if (giris > enBüyük)
        {
            enBüyük = giris;
        }
    }
    return enBüyük;
}
Console.WriteLine(EnBüyükSayı());
// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yazınız.
void YerDegistir()
{
    Console.Write("İsim 1 :");
    string name1 = Console.ReadLine();
    Console.Write("İsim 2 :");
    string name2 = Console.ReadLine();
    string name3 = name1;
    name1 = name2;
    name2 = name3;
    Console.WriteLine("name 1 :" + name1);
    Console.WriteLine("name 2 :" + name2);
}
YerDegistir();
// 14 - Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot.
static bool TekCift(int number)
{
    if (number % 2 == 0)
        return true;
    else
        return false;
}
Console.WriteLine("Bir sayı giriniz");
int number = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(TekCift(number));
// 15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yazınız.
Console.WriteLine("Kaç km/h?");
int hız = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ne kadar süre ile?");
int sure = Convert.ToInt32(Console.ReadLine());
KmHesapla(hız, sure);
void KmHesapla(int hız, int sure)
{
    int km = hız * sure;
    Console.WriteLine($"Gidilen hız->{hız}\nGidilen süre->{sure}\nToplam km->{km}kmdir.");

}
// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yazınız.
Console.Write("Dairenin yarıçapını giriniz.");
double yariCap = Convert.ToDouble(Console.ReadLine());
void DaireAlanHesapla(double yariCap)
{
    double pi = 3.14;
    double alan = pi * (yariCap * yariCap);
    Console.WriteLine($"Dairenin yarı çapı->{yariCap}\nDairenin alanı->{alan}dır.");
}
DaireAlanHesapla(yariCap);
// 17 - "Zaman bir GeRi SayIm" cümlesini alıp , hepsi büyük harf ve hepsi küçük harfle yazdırınız.
string cumle = "Zaman bir GeRi SayIm";
string upperCumle = cumle.ToUpper();
string lowerCumle = cumle.ToLower();
Console.WriteLine(upperCumle);
Console.WriteLine(lowerCumle);
// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları siliniz. Kalıcı olarak.
string selam = "    Selamlar   ";
selam = selam.Trim();
Console.WriteLine(selam);