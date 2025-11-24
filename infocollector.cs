using System;

class Program
{
    static void Main()
    {
        bool rep;

        do
        {
            Console.WriteLine("Ce programme vous souhaite la bienvenue.");

            // Récupération du nom
            Console.WriteLine("Donnez votre nom :");
            string nom = Console.ReadLine();

            // Récupération du prenom
            Console.WriteLine("Donnez votre prénom :");
            string prenom = Console.ReadLine();

            // Récupération de l'email
            Console.WriteLine("Donnez votre email :");
            string email = Console.ReadLine();

            // Affichage le mot de bienvenue
            Console.WriteLine("Bonjour {0} {1}, votre email est {2}.", prenom, nom, email);

            // Recommencer
            Console.WriteLine("Voulez-vous recommencer ? (o/n)");
            rep = (Console.ReadLine().ToLower() == "o");

        } while (rep);
    }
}