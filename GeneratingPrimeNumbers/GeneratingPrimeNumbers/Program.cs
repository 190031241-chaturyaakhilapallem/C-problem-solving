using System;

namespace GeneratingPrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter number you want to check:");
            int num;
            num = int.Parse(Console.ReadLine());

            int divisor = 0;

            for (int i = 1; i <= num; i++)
            {
                if (num % i == 0)
                {
                    divisor++;
                }
            }
            if (divisor == 2)
            {
                //If divisor is equal to 2, it has two factors one and itself, so it is a prime number.
                Console.WriteLine("Entered Number is a Prime Number");
            }
            else
            {
                //If divisor does not equal to 2, it is more than two factors, so it is not a prime number.
                Console.WriteLine("Entered Number is not a Prime Number");
            }
            Console.ReadKey();
        }
    }
}


