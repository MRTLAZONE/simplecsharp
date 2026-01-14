using System;

public static class ExercicesBase
{
    // -------------------------------------------------
    // EXERCICE 1 : Variables
    // -------------------------------------------------
    public static void Exercice1_Variables()
    {
        int age = 25;
        string prenom = "Paul";
        double taille = 1.80;

        Console.WriteLine(
            $"Je m'appelle {prenom}, j'ai {age} ans et je mesure {taille}m"
        );
    }

    // -------------------------------------------------
    // EXERCICE 2 : Conditions
    // -------------------------------------------------
    public static void Exercice2_Conditions()
    {
        Console.Write("Entre ton âge : ");
        string input = Console.ReadLine() ?? "0";
        int age = int.Parse(input);

        if (age >= 18)
        {
            Console.WriteLine("Majeur");
        }
        else
        {
            Console.WriteLine("Mineur");
        }
    }

    // -------------------------------------------------
    // EXERCICE 3 : Boucles
    // -------------------------------------------------
    public static void Exercice3_Boucles()
    {
        Console.WriteLine("Nombres de 1 à 10 :");

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("\nNombres pairs de 0 à 20 :");

        int n = 0;
        while (n <= 20)
        {
            Console.WriteLine(n);
            n += 2;
        }
    }

    // -------------------------------------------------
    // EXERCICE 4 : Tableaux
    // -------------------------------------------------
    public static void Exercice4_Tableaux()
    {
        int[] nombres = { 5, 8, 12, 3 };
        int somme = 0;

        foreach (int n in nombres)
        {
            somme += n;
        }

        Console.WriteLine($"Somme des valeurs : {somme}");
    }
}
