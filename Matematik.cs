using System;
namespace Metotlar_Uygulama1
{
	public class Matematik
	{
	    public decimal toplamaIslemi(decimal sayi1, decimal sayi2)
		{
			decimal sonuc = sayi1 + sayi2;
			return sonuc;
		}
		public decimal cıkartmaIslemi(decimal sayi1,decimal sayi2)
		{
			decimal sonuc = sayi1 - sayi2;
			return sonuc;
		}
		public decimal carpmaIslemi(decimal sayi1,decimal sayi2)
		{
			decimal sonuc = sayi1 * sayi2;
			return sonuc;
		}
		public decimal bolmeIslemi(decimal sayi1 ,decimal sayi2)
		{
			decimal sonuc = sayi1 / sayi2;
			return sonuc;
		}
		public void MenuHazırla() // Geriye bir şey dönmeyecek sadece ekrana bir şey yazdıracaksam void kullanılır.
		{
			Console.Clear();
			Console.WriteLine("***** MENÜ *****");
			Console.WriteLine("1-) Toplama işlemi ");
            Console.WriteLine("2-) Çıkarma işlemi");
            Console.WriteLine("3-) Çarpma işlemi");
			Console.WriteLine("4-) Bölme işlemi");
			Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz : ");
        }
		public void sonucEkranaYaz(decimal ksayi1 ,decimal ksayi2 , decimal sonuc ,string operators)
		{
			Console.WriteLine("{0} {1} {2} = {3}",ksayi1,operators,ksayi2,sonuc);
		}
	}
}

