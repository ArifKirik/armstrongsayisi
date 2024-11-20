namespace _221120241014_Arif_Kirik_Armstrong_sayi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.WriteLine("bir sayı giriniz:");
            sayi=Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= sayi; i++)
            {
                int a = i / 100;
                int b = (i - a * 100) / 10;
                int c = (i - a * 100 - b * 10);

                int d = (a * a * a + b * b * b + c * c * c);

                if (i == d)
                    Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
