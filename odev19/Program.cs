using System;

namespace or223
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("İsim girin: ");
            string isim = Console.ReadLine();

            char[] isimKarakterleri = isim.ToCharArray();
            bool[] D = new bool[isimKarakterleri.Length];

            Random rastgele = new Random();

            for (int a = 0; a < isimKarakterleri.Length; a++)
            {
                int sayi;
                do
                {
                    sayi = rastgele.Next(isimKarakterleri.Length);
                } while (D[sayi]);

                D[sayi] = true;
                Console.Write(isimKarakterleri[sayi]);
            }

            Console.Write("\n\n\nDevam etmek için bir tuşa basın...");
            Console.ReadKey(true);
        }
    }
}
