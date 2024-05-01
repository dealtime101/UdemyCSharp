using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nom = "";

            Console.OutputEncoding = System.Text.Encoding.UTF8;
            while (nom == "" || (int.TryParse(nom, out int _)))
            {
                Console.Write("Quel est ton nom ? ");
                nom = Console.ReadLine();
                nom.Trim();

                try
                {

                    if (nom == "")
                    {
                        Console.WriteLine("Erreur: Le nom ne doit pas être vide");
                    }
                    else if (int.TryParse(nom, out int _))
                    {
                        Console.WriteLine("Erreur: Le nom ne doit pas être un nombre");
                    }
                }
                catch
                {

                }
            }




            int age_num = 0;

            while (age_num <= 0)
            {
                Console.Write("Quel est ton age ? ");
                string age_str = Console.ReadLine();

                try
                {
                    int? age_null = age_num;
                    age_num = int.Parse(age_str);


                    if (age_null == null)
                    {
                        Console.WriteLine("Erreur: l'âge ne doit pas être vide");
                    }

                    if (age_num < 0)
                    {
                        Console.WriteLine("Erreur: L'âge ne doit pas être négatif");
                    }
                    if (age_num == 0)
                    {
                        Console.WriteLine("Erreur: L'âge ne doit pas être zéro");
                    }
                }
                catch
                {
                    Console.WriteLine("Erreur: vous devez rentrer un age valide.");
                }


            }

            Console.WriteLine("Bonjour, vous vous appelez " + nom + ", vous avez " + age_num + " ans");

            int age_prochain = age_num + 1;
            Console.WriteLine("bientôt vous aurez " + age_prochain + " ans");
        }
    }
}