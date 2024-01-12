using System;

namespace ucgen_cizme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Üçgen yüksekliğini giriniz : ");
            int yukseklik = int.Parse(Console.ReadLine());
            UcgenCiz(yukseklik);
        }

        static void UcgenCiz(int yukseklik)
        {
            for (int i = 0; i < yukseklik; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
