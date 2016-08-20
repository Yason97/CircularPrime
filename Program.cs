using System;
using System.Collections.Generic;
using System.Text;

namespace CircularPrime
{
    class Program
    {
        static bool IsPrime(int num)
        {
            if (num == 1) return false;
            if (num == 2) return true;
            for(int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0) return false;
            }
            return true;
        }
        static bool IsCircularPrime(int num)
        {
            if (IsPrime(num))
            {
                int length = 0, copy = num;
                while(num > 0)
                {
                    num /= 10;
                    length++;
                }
                for(int i = 0; i < length-1; i++)
                {
                    int dight = copy % 10;
                    copy = dight * (int)Math.Pow(10, length - 1) + copy / 10;
                    if (!IsPrime(copy)) return false;
                }
                return true;
            }
            else return false;
        }
        static void Main(string[] args)
        {
            const int MAX = 1000000;
            int count = 0;
            for(int i = 1; i <= MAX; i += 1)
            {
                if (IsCircularPrime(i)) count++;
            }
            Console.WriteLine(count);
            Console.ReadKey();
        }
    }
}
