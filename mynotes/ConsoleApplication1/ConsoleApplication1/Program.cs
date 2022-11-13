using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleApplication1
{


    class Program
    {
        static void Main(string[] args)
        {

           // Console.WriteLine("Adınız: ");
           // string amk = Console.ReadLine();
           //  Console.WriteLine("Hello "+amk+"!");


            /*
            string str = "20";
            int integer = 20;

            int convertTuru = integer + Convert.ToInt16(str);
            Console.WriteLine(convertTuru);

            int parseTuru = integer + int.Parse(str);
            Console.WriteLine(convertTuru);

            string st = str + integer.ToString();
            Console.WriteLine(st);

            string input = Console.ReadLine();

            if(input == "tamam") {
                Console.WriteLine("Sen Türksün");
            }
            else if (input == "ok")
            {
                Console.WriteLine("you are englishen");
            }
            else {
                Console.WriteLine("not");
            } */


            //BÖLÜM NEXT

        /*    try{
                Console.WriteLine("GİRİNİZ: ");
                int sayi = Convert.ToInt16(Console.ReadLine());
                Console.WriteLine("XD: " + sayi);
            }*/

           /* catch(Exception ex){
                Console.WriteLine("Hata: " + ex.Message.ToString());
            }*/
               // OverflowException = küçük değer
                //ArgumentException = boş değer
            /*catch (FormatException ex) {
                Console.WriteLine("uygun dfedğil");
               // Console.WriteLine(ex);
            }*/

           /* finally {
                Console.WriteLine("İşlem tamam");
            }*/




            /*
            Console.WriteLine("sayi: ");
            int sayi = Convert.ToInt16(Console.ReadLine());

            switch (sayi)
            {
                case 1:
                   Console.WriteLine("bir");
                    break;
                case 2:
                    Console.WriteLine("iki");
                    break;
                case 3:
                    Console.WriteLine("üç");
                    break;
                default:
                    Console.WriteLine();
                    break;
            }*/
            /*
            int sayac = 1;
            while (sayac <= 5)
            {
                Console.WriteLine(sayac);
                sayac++;
            }

            int[] sayiDizisi = { 2, 4, 5, 1, 2, 4 };
            int toplam = 0;

            foreach (int i in SayiDizisi)
            {
                toplam += i;
            }*/




            /*string[] renkler = { "x", "xx", "xxx", "xxxx" };
            string renk = renkler[1];
            Console.WriteLine(renk);
             */

            /* int[] sayilar = { 1, 2, 3, 4, 5 };
            int sayi = sayilar[1];
            Console.WriteLine(sayi);
             */



            /*
            int[] SayDizisi = { 10, 20, 30, 40, 50 };
            Array.Reverse(SayDizisi);

            foreach (var sayi in SayDizisi)
                Console.WriteLine(SayDizisi);
            
            */

           // int sonuc = Topla(5, 4);
            //Console.WriteLine(sonuc);

            
            Metotlar ornek = new Metotlar();
            //ornek.EkranaYazdir("x");
            
 
            Console.ReadKey();

        }

      static int Topla(int deger1, int deger2)
        {
            return deger1 + deger2;
        } 



    }


    class Metotlar
    {
        public void EkranaYazdir(string veri) {
        
            Console.Write(veri);
        
        }

        /*
        public int ToplaAttir(ref int deger1, ref int deger2) {

            deger1 = +1;
            deger2 = +1;
            return deger1 + deger2;
        
            
         */

    }

}
