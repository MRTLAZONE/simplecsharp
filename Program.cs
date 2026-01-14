using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("=== LANCEUR D'EXERCICES C# ===");
        Console.WriteLine("1 - Variables");
        Console.WriteLine("2 - Conditions");
        Console.WriteLine("3 - Boucles");
        Console.WriteLine("4 - Tableaux");
        Console.WriteLine("5 - Strings (niveau 2)");
        Console.WriteLine("6 - LINQ");
        Console.WriteLine("7 - POO avancée");
        Console.WriteLine("8 - Mini-projet");
        Console.WriteLine("0 - Quitter");

        Console.Write("Ton choix : ");
        string choix = Console.ReadLine() ?? "0";

        Console.WriteLine();

        switch (choix)
        {
            case "1":
                ExercicesBase.Exercice1_Variables();
                break;

            case "2":
                ExercicesBase.Exercice2_Conditions();
                break;

            case "3":
                ExercicesBase.Exercice3_Boucles();
                break;

            case "4":
                ExercicesBase.Exercice4_Tableaux();
                break;
            case "5":
                ExercicesNiveau2.Exercice1_ManipulationStrings();
                break;

            case "6":
                ExercicesNiveau2.Exercice6_LINQ();
                break;

            case "7":
                ExercicesNiveau2.Exercice7_POO_Avancee();
                break;

            case "8":
                ExercicesNiveau2.Exercice8_MiniProjet();
                break;


            case "0":
                Console.WriteLine("Au revoir 👋");
                break;

            default:
                Console.WriteLine("Choix invalide");
                break;
        }

        Console.WriteLine("\nFin du programme");
    }
}
