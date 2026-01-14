// =============================================================
// EXERCICES C# – BASES
// Objectif : apprendre progressivement les fondamentaux du C#
// Instructions :
// - Chaque exercice est indépendant
// - Lis l'énoncé, puis écris le code là où c'est indiqué
// - Tu peux tout mettre dans ce fichier Program.cs
// =============================================================

using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        // Décommente les exercices un par un pour les tester
        
        // Exercice1_Variables();
        Console.WriteLine("Exercice1 fait");
        // Exercice2_Conditions();
        Console.WriteLine("Exercice2 fait");
        // Exercice3_Boucles();
        Console.WriteLine("Exercice3 fait");
        // Exercice4_Tableaux();
        Console.WriteLine("Exercice4 fait");
        // Exercice5_Listes();
        Console.WriteLine("Exercice5 fait");
        // Exercice6_Methodes();
        Console.WriteLine("Exercice6 fait");

        Exercice7_Classes();
    }

    // -------------------------------------------------------------
    // EXERCICE 1 : Variables et types
    // Objectif : comprendre les types de base et l'affichage
    // -------------------------------------------------------------
    static void Exercice1_Variables()
    {
        Console.WriteLine("Bienvenue aux exercices C# – Bases !");
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("Exercice1_Variables");
        // 1. Déclare une variable int age et donne-lui une valeur
        // 2. Déclare une variable string prenom
        // 3. Déclare une variable double taille
        // 4. Affiche une phrase du type :
        //    "Je m'appelle Paul, j'ai 25 ans et je mesure 1.80m"

        // Ton code ici
        int age = 25;
        string prenom = "Paul";
        double taille = 1.80;
        Console.WriteLine($"Je m'appelle {prenom}, j'ai {age} ans et je mesure {taille}m");
    }

    // -------------------------------------------------------------
    // EXERCICE 2 : Conditions (if / else)
    // Objectif : logique conditionnelle
    // -------------------------------------------------------------
    static void Exercice2_Conditions()
    {
        // 1. Demande à l'utilisateur son âge
        // 2. Si l'âge est >= 18 : affiche "Majeur"
        // 3. Sinon : affiche "Mineur"

        // Indice : Console.ReadLine() + int.Parse

        // Ton code ici
        Console.WriteLine("Exercice2_Conditions");
        Console.Write("Quel est votre âge? ");
        string input = Console.ReadLine() ?? "0" ;
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

    // -------------------------------------------------------------
    // EXERCICE 3 : Boucles
    // Objectif : for / while
    // -------------------------------------------------------------
    static void Exercice3_Boucles()
    {
        // 1. Avec une boucle for, affiche les nombres de 1 à 10
        // 2. Avec une boucle while, affiche les nombres pairs de 0 à 20

        // Ton code ici
        Console.WriteLine("Exercice3_Boucles");
        for (int i = 1; i <= 10; i++)
        {
            Console.Write(i + " ");
        }
        int j = 0;
        while (j <= 20)
        {
            Console.Write(j + " ");
            j += 2;
        }
    }

    // -------------------------------------------------------------
    // EXERCICE 4 : Tableaux
    // Objectif : manipuler des tableaux
    // -------------------------------------------------------------
    static void Exercice4_Tableaux()
    {
        // 1. Crée un tableau d'entiers avec les valeurs : 5, 8, 12, 3
        // 2. Affiche chaque valeur avec une boucle
        // 3. Calcule et affiche la somme des valeurs

        // Ton code ici
        Console.WriteLine("Exercice4_Tableaux");
        int[] nombres = [ 5, 8, 12, 3 ];
        int somme = 0;
        foreach (int nombre in nombres)
        {
            Console.WriteLine(nombre);
            somme += nombre;
        }
    }

    // -------------------------------------------------------------
    // EXERCICE 5 : Listes (List<T>)
    // Objectif : collections dynamiques
    // -------------------------------------------------------------
    static void Exercice5_Listes()
    {
        // 1. Crée une List<string> de prénoms
        // 2. Ajoute au moins 3 prénoms
        // 3. Affiche-les avec foreach
        // 4. Vérifie si un prénom donné est présent dans la liste

        // Ton code ici
        Console.WriteLine("Exercice5_Listes");
        List<string> prenoms = new List<string>();
        prenoms.Add("Alice");
        prenoms.Add("Bob");
        prenoms.Add("Charlie");
        foreach (string prenom in prenoms)
        {
            Console.WriteLine(prenom);
        }
        Console.WriteLine("Charlie est dans la liste? " + prenoms.Contains("Charlie"));
    }

    // -------------------------------------------------------------
    // EXERCICE 6 : Méthodes
    // Objectif : découper son code
    // -------------------------------------------------------------

    static int Addition(int a, int b)
    {
        return a + b;
    }

    static void Exercice6_Methodes()
    {
        // 1. Crée une méthode Addition(int a, int b)
        //    qui retourne la somme
        // 2. Appelle-la depuis cet exercice
        // 3. Affiche le résultat

        // Ton code ici
        Console.WriteLine("Exercice6_Methodes");
        Console.WriteLine("La somme de 5 et 7 est : " + Addition(5, 7));
        
        
    }

    // -------------------------------------------------------------
    // EXERCICE 7 : Classes et objets
    // Objectif : programmation orientée objet
    // -------------------------------------------------------------

    static void Exercice7_Classes()
    {
        // 1. Crée une classe Voiture (en dehors de Program)
        //    avec les propriétés : Marque, Modele, Annee
        // 2. Crée un constructeur
        // 3. Crée une méthode AfficherInfos()
        // 4. Instancie une voiture et affiche ses infos

        // Ton code ici
        Console.WriteLine("Exercice7_Classes");
        
        Voiture maVoiture = new("Toyota", "Corolla", 2020);
        maVoiture.AfficherInfos();
    }
}

// -------------------------------------------------------------
// CLASSE À COMPLÉTER POUR L'EXERCICE 7
// -------------------------------------------------------------

class Voiture
{
    // Propriétés
    private string _marque;
    private string _modele;
    private int _annee;

    // Constructeur
    public Voiture(string marque, string modele, int annee)
    {
        _marque = marque;
        _modele = modele;
        _annee = annee;
    }

    // Méthode AfficherInfos

    public void AfficherInfos()
    {
        Console.WriteLine($"Voiture : {_marque} {_modele}, Année : {_annee}");
    }

}

// =============================================================
// BONUS (quand tu es à l'aise) :
// - Gestion des exceptions (try / catch)
// - Enum
// - Dictionnaire (Dictionary<TKey, TValue>)
// - LINQ (Where, Select, etc.)
// =============================================================
