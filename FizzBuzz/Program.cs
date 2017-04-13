using System;
using FizzBuzz.Services;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var service = new FizzBuzzService();
            int[] original = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            Console.WriteLine(service.CreateFizzBuzz(original));
        }
    }
}
