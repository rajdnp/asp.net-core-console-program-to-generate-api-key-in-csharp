using System;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var key = new byte[32];

            using (var generator = RandomNumberGenerator.Create())
            {
                generator.GetBytes(key);
            }
            string apiKey = Convert.ToBase64String(key);
            Console.WriteLine("Your API KEY IS :    " + apiKey);
        }
    }
}
