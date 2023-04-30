using System;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            //28Aprel
                Console.WriteLine("Birinci ededi girin");
                int var1;
            while (true)
            {
                try
                {
                    var1 = int.Parse(Console.ReadLine());
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Yalniz reqem girin");


                }
            }



                Console.WriteLine("ikinci ededi girin");
                int var2 = int.Parse(Console.ReadLine());
                int sum = Sum(var1, var2);
                Console.WriteLine("Cavab: " + sum);
            
        }
            public static int Sum(int var1, int var2)
            {
                return (var1 + var2);
            }

        
    }
}
