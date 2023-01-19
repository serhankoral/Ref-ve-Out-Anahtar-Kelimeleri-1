using System;

namespace Ref_ve_Out_Anahtar_Kelimeleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ref ile out aynı gorevi yaparken aralarında ki fark sadece ref ilk değer isterken out istmez
            int sayi1 = 5;
            Console.WriteLine(sayi1);
            degistir1(ref sayi1);
            Console.WriteLine(sayi1);
            int sayi2;
            //Console.WriteLine(sayi2); Sayi2 de herhangi bir değer olmadığından ekrana yazmaz hata verir
            degistir2(out sayi2);
            Console.WriteLine(sayi2);
        }
        static void degistir1(ref int sayi1)//static olrak tanımlanmaz ise erişim olmuyor
        {
            sayi1 = 15;
        }

        static void degistir2(out int sayi2)//static olrak tanımlanmaz ise erişim olmuyor
        {
            sayi2 = 25;
        }

    }
}
