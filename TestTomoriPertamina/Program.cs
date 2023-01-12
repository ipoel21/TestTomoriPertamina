// See https://aka.ms/new-console-template for more information
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {

        Test1();

        Test2();

        Test3();
    }

    private static void Test1()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("|             Test 1                      |");
        Console.WriteLine("==========================================");
        //Console.WriteLine("===================Cara 1=================");
        //for (int i = 1; i <= 3; i++)
        //{
        //    for (int j = 1; j <= 5; j++)
        //    {
        //        Console.Write(j);
        //        if (j == 5)
        //        {
        //            Console.WriteLine();
        //            for (int l = 5; l >= 1; l--)
        //            {
        //                Console.Write(l);
        //                if (l == 1)
        //                {
        //                    Console.WriteLine();
        //                }

        //            }
        //        }

        //    }

        //}
        //Console.WriteLine("===================Cara 2=================");
        for (int i = 1; i <= 3; i++)
        {
            int x = 1;
            int y = 1;
            while (x >= 1)
            {
                Console.Write(x);
                if (x == 5)
                {
                    y = -1;
                    Console.WriteLine();
                    Console.Write(x);
                }
                x += y;
            };
            Console.WriteLine();
        }

    }

    private static void Test2()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("|             Test 2                      |");
        Console.WriteLine("==========================================");

        int jumlah = InputInt("Masukan jumlah Baris Segitiga = ");
        Console.WriteLine("=================Bentuk 1=================");
        for (int i = 1; i <= jumlah; i++)
        {
            for (int j = jumlah; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("=================Bentuk 2=================");
        for (int i = 1; i <= jumlah; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("=================Bentuk 3=================");
        int x = 1;
        for (int i = 1; i <= jumlah; i++)
        {
            for (int j = jumlah; j >= i; j--)
            {
                Console.Write(" ");
            }
            for (int j = 1; j <= x; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            x += 2;
        }
    }

    private static void Test3()
    {
        Console.WriteLine("==========================================");
        Console.WriteLine("|             Test 3                      |");
        Console.WriteLine("==========================================");


        //int x = 1, y = 1, z = 1;
        //int jumlah = InputInt("Masukan jumlah bilangan fibonacci = ");
        //for (int i = 0; i < jumlah; i++)
        //{
        //    Console.Write(z + " ");
        //    z = x + y;
        //    x = y;
        //    y = z;
        //}
        //Console.Read();

        int x = 1, y = 1; 
        int jumlah = InputInt("Masukan jumlah bilangan fibonacci = ");
        for (int i = 0; i < jumlah; i++)
        {
            Console.Write(y + " ");
            (x, y) = (y, x + y);
        }
        Console.Read();

    }

    private static int InputInt(string outputString)
    {
        try
        {
            Console.Write(outputString);
            int result = Convert.ToInt32(Console.ReadLine());
            return result;
        }
        catch
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Coba Masukan Angka yang benar");
            Console.ResetColor();
            return InputInt(outputString);
        }
    }
}
