using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = 10;
            int l = 10;
            string alphabet = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";

            string[] sifreler = GenerateRandomPasswords(n, l, alphabet);

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(sifreler[i]);
            }

            Console.ReadLine();
        }

        static string[] GenerateRandomPasswords(int n, int l, string alphabet)
        {
            Random r = new Random();
            string[] passwords = new string[n];
            Parallel.For(0, n, (i) =>
            {
                string password = "";
                for (int j = 0; j < l; j++)
                {
                    password += alphabet[r.Next(0, alphabet.Length)];
                }
                passwords[i] = password;
            });
            return passwords;
        }
    }
}
