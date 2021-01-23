 using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            //sayi1 ??  30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ????  999
            // int, decimal, fload, double, bool  == değer tip
            // array ,class, interface == referans tip
            // bellekte stack ve heap diye 2 alan var.Değer tip olanlar stack'te gerçekleşir.
            //...Sadece değeri atar başka irtibatı yok.
            //Referans tipler : int[] sayilar1 yazınca stack'te sayilar1 adında bir alan oluşturur. 
            //...new dediğinde heap'ta [10,20,30] için bir adres oluşur.bu adrese örneğin 101 diyelim.bu adres referans
            //...olarak kullanılır.
            //new demek heap2ta yeni bir adres oluştur demek.
            //sayilar1 = sayilar2 dediğinde sayira1'in referans no.sı sayilar2'nin referans no.sına eşittir diye okunur.
            //sayilar1in referans no.sı eşittir sayilar2nin ref.no.sına.
            //...sayilar2 dediğinde heap'ta [100,200,300] içeren bir adres oluşur.
            //...17. satır sayilar1'in referans no.sı sayilar2'nin referans no sına eşittir demek.
            //101 nolı referans alanını tutan hiçbirşey olmadığı için bellekten atılır.
            //
        }
    }
}
