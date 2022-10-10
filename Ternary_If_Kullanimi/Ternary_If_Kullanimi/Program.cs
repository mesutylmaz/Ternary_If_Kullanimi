using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ternary_If_Kullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ternary If:
            // Tek satırda ufak bir karar mekanizması ile yolumuza devam etmek istiyorsak, soru işareti operatörü bize bu pratikliği sağlar.
            // Kullanımı:
            // kontrolEdilecekDeger(KarsilastirmaOperatoru) ? Durumun Doğru Olması Durumu(Yani True): Durumun Yanlış Olması Durumu(Yani False)
            // Eğer karşılaştırma sonucu doğru ise True olcak ve Durumun Doğru Olması işlemini gerçekleştirecek.
            // Eğer karşılaştırma sonucu yanlış ise False olcak ve Durumun Yanlış Olması işlemini gerçekleştirecek.

            Console.WriteLine("---------------------------------------------------------------------------------------------------");


            // Dışarıdan girilen isim bilgisi ile sizin belirlediğiniz string değerin aynı olup olmadığını kontrol edip kullanıcıya sonucu döndüren program:

            Console.WriteLine("Lütfen İsminizi Giriniz: ");
            string ad = Console.ReadLine();

            Console.WriteLine(ad == "Bilge Adam" ? "Girilen isim ile benim tuttuğum isim eşleşmektedir." : "Girilen isim ile benim tuttuğum isim eşleşmemektedir.");
            //bool karsilastirma = sayi1>sayi2 ? sayi

            Console.Read();


            Console.WriteLine("---------------------------------------------------------------------------------------------------");


            // Ternary If Kullanarak, girilen 2 sayının küçüklük, büyüklük veya eşitliklerini bulma:

            sayiYeniden:
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(sayi1 > sayi2 ? "Birinci sayı, ikinci sayıdan büyüktür." : "İkinci sayı, birinci sayıdan büyüktür.");

            Console.WriteLine(sayi1 == sayi2 ? "Birinci sayı, ikinci sayıya eşittir." : "Hatalı giriş yaptınız! Lütfen sayıları tekrar giriniz.");

            goto sayiYeniden;

            Console.Read();


            Console.WriteLine("---------------------------------------------------------------------------------------------------");


            // Ternary If Ve If-Else kullanarak, girilen 2 sayının küçüklük, büyüklük veya eşitliklerini bulma:

            sayiYeniden2:
            Console.WriteLine("Lütfen birinci sayıyı giriniz: ");
            int sayi3;
            bool durum3 = int.TryParse(Console.ReadLine(), out sayi3);

            Console.WriteLine("Lütfen ikinci sayıyı giriniz: ");
            int sayi4;
            bool durum4 = int.TryParse(Console.ReadLine(), out sayi4);

            if (durum3 == true && durum4 == true)
            {
                bool karsilastirma = sayi3 > sayi4 ? true : false;
                if (karsilastirma == true)
                {
                    Console.WriteLine("Birinci sayı, ikinci sayıdan büyüktür.");
                }
                else if (karsilastirma == false)
                {
                    Console.WriteLine("İkinci sayı, birinci sayıdan büyüktür.");
                }
                else
                {
                    Console.WriteLine("Sayılar birbirine eşittir.");            //Burda da Eşitlik yazısını yazdırmadı. Ternary If ile bunu nasıl yapabiliriz?
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz değer hatalı! Lütfen yeniden sayı girişi yapınız.");
                goto sayiYeniden2;
            }
            Console.Read();

            Console.WriteLine("---------------------------------------------------------------------------------------------------");
        }
    }
}
