# C-_Metot_Uygulama1
# C# Konsol Hesap Makinesi Uygulaması

Bu proje, C# dilinde metot (fonksiyon) kullanımını göstermek amacıyla geliştirilmiş basit bir konsol hesap makinesi uygulamasıdır. Uygulama, kullanıcıdan iki sayı alır ve seçilen temel aritmetik işlemi gerçekleştirir.

## Projenin Amacı

Bu kodun temel amacı, C#'ta sınıf yapısını ve metotları kullanarak kodun nasıl organize edileceğini göstermektir:

* **Sorumlulukların Ayrılması (Separation of Concerns):** `Program.cs` dosyası kullanıcı etkileşimi ve program akışını yönetirken, `Matematik.cs` dosyası tüm hesaplama ve yardımcı (menü, sonuç yazdırma) işlemlerini içerir.
* **Metot Kullanımı:** Her bir matematiksel işlem (Toplama, Çıkarma, Çarpma, Bölme) kendi özel metoduna ayrılmıştır.
* **Geriye Değer Döndüren (`decimal`) ve Döndürmeyen (`void`) Metotlar:** Proje, hem bir sonuç üreten (örn: `toplamaIslemi`) hem de sadece bir eylem gerçekleştiren (örn: `MenuHazırla`) metot türlerini örnekler.

## Özellikler

* Toplama İşlemi (+)
* Çıkarma İşlemi (-)
* Çarpma İşlemi (*)
* Bölme İşlemi (/)
* Kullanıcı dostu konsol menüsü
* Her işlemden sonra yeni bir işlem yapma veya programdan çıkma seçeneği

## Kullanılan Teknolojiler

* C#
* .NET (Konsol Uygulaması)

## Kod Yapısı

Proje iki ana sınıftan oluşmaktadır:

### 1. `Program.cs`

* Uygulamanın giriş noktası olan `Main` metodunu içerir.
* `Matematik` sınıfından bir nesne (`M`) türetir.
* `goto` etiketleri (`YenidenIslemYap`) kullanarak ana işlem döngüsünü yönetir.
* Kullanıcıdan menü seçimi ve işlem yapılacak sayıları (`ksayi1`, `ksayi2`) alır.
* `switch-case` yapısı ile kullanıcının seçimine göre ilgili `Matematik` metodunu çağırır.
* İşlem sonunda kullanıcıya devam etmek isteyip istemediğini sorar.

### 2. `Matematik.cs`

`Metotlar_Uygulama1` namespace'i içinde yer alan `Matematik` sınıfını tanımlar. Bu sınıf aşağıdaki metotları içerir:

* `public decimal toplamaIslemi(decimal sayi1, decimal sayi2)`: İki sayıyı toplar ve sonucu `decimal` olarak döndürür.
* `public decimal cıkartmaIslemi(decimal sayi1, decimal sayi2)`: İki sayıyı çıkarır ve sonucu `decimal` olarak döndürür.
* `public decimal carpmaIslemi(decimal sayi1, decimal sayi2)`: İki sayıyı çarpar ve sonucu `decimal` olarak döndürür.
* `public decimal bolmeIslemi(decimal sayi1, decimal sayi2)`: İki sayıyı böler ve sonucu `decimal` olarak döndürür.
* `public void MenuHazırla()`: Ekrana işlem menüsünü yazdıran, geriye değer döndürmeyen metottur.
* `public void sonucEkranaYaz(decimal ksayi1, decimal ksayi2, decimal sonuc, string operators)`: İşlemin sonucunu formatlı bir şekilde ekrana yazdıran metottur.

## Nasıl Çalıştırılır?

1.  Projeyi bir C# IDE'si (Örn: Visual Studio, VS Code) ile açın.
2.  Projeyi derleyin ve çalıştırın (veya terminal üzerinden `dotnet run` komutunu kullanın).
3.  Konsol ekranındaki menüden yapmak istediğiniz işlemi seçin (1-4).
4.  İstendiğinde 1. ve 2. sayıları girin.
5.  Sonuç ekranda gösterilecektir.
6.  Yeni bir işlem yapmak için "E" veya "e" tuşuna basın.
