using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            string nom = "";
            while (string.IsNullOrEmpty(nom) || int.TryParse(nom, out int _))
            {
                Console.Write("Quel est ton nom ? ");
                nom = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(nom))
                {
                    Console.WriteLine("Erreur: Le nom ne doit pas être vide.");
                }
                else if (int.TryParse(nom, out int _))
                {
                    Console.WriteLine("Erreur: Le nom ne doit pas être un nombre.");
                }
            }

            int age_num = 0;
            while (age_num <= 0)
            {
                Console.Write("Quel est ton âge ? ");
                string age_str = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(age_str) || !int.TryParse(age_str, out age_num) || age_num <= 0)
                {
                    if (string.IsNullOrEmpty(age_str))
                    {
                        Console.WriteLine("Erreur: L'âge ne doit pas être vide.");
                    }
                    else if (!int.TryParse(age_str, out age_num))
                    {
                        Console.WriteLine("Erreur: Veuillez entrer un nombre valide pour l'âge.");
                    }
                    else if (age_num <= 0)
                    {
                        if (age_num < 0)
                        {
                            Console.WriteLine("Erreur: L'âge ne doit pas être négatif.");
                        }
                        if (age_num == 0)
                        {
                            Console.WriteLine("Erreur: L'âge ne doit pas être zéro.");
                        }
                    }
                }
            }

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans.");
            int age_prochain = age_num + 1;
            Console.WriteLine("Bientôt vous aurez " + age_prochain + " ans.");
        }
    }
}