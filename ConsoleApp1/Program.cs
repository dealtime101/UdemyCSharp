using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("Hello World!");

            Console.WriteLine("Veuillez entrez votre nom.");
            string name = Console.ReadLine();

            Console.WriteLine("Veuillez maintenant entrez votre âge.");
            string age = Console.ReadLine();

            Console.WriteLine("Bonjour, vous vous appelez " + name + " et votre âge est : " + age);
        }
    }
}