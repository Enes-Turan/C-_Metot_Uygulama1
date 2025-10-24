namespace Metotlar_Uygulama1;

class Program
{

    static void Main(string[] args)
    {
        Matematik M = new Matematik();
        YenidenIslemYap:
        M.MenuHazırla();
        int kullanicidanGelenDeger = int.Parse(Console.ReadLine());

        Console.WriteLine("Lütfen 1.sayı değerini giriniz = ");
        decimal ksayi1 = decimal.Parse(Console.ReadLine());
        Console.WriteLine("Lütfen 2.sayı değerini giriniz = ");
        decimal ksayi2 = decimal.Parse(Console.ReadLine());

        decimal sonuc = 0;


        switch (kullanicidanGelenDeger) { 
            case 1:
               sonuc = M.toplamaIslemi(ksayi1,ksayi2);
                M.sonucEkranaYaz(ksayi1,ksayi2,sonuc,"+");
                break;
            case 2:
                sonuc = M.cıkartmaIslemi(ksayi1,ksayi2);
                M.sonucEkranaYaz(ksayi1,ksayi2,sonuc,"-");
                break;
            case 3:
                sonuc = M.carpmaIslemi(ksayi1,ksayi2);
                M.sonucEkranaYaz(ksayi1,ksayi2,sonuc,"*");
                break;
            case 4:
                sonuc = M.bolmeIslemi(ksayi1,ksayi2);
                M.sonucEkranaYaz(ksayi1,ksayi2,sonuc,"/");
                break;
            default:
                Console.WriteLine("Geçersiz karakter girdiniz.");
                Console.WriteLine("Lütfen işlem seçiniz = ");
                System.Threading.Thread.Sleep(2000);
                goto YenidenIslemYap;
                break;
        }
        Console.WriteLine("İşlem yapmak istiyor musunuz ? ");
        string EH = Console.ReadLine();
        if (EH == "E" || EH == "e")
        {
            goto YenidenIslemYap;
        }
    }
}

