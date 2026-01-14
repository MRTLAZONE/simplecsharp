// =============================================================
// EXERCICES C# – NIVEAU 2
// Adapté à la structure avec Program.cs comme lanceur
// =============================================================

using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

public static class ExercicesNiveau2
{
    // -------------------------------------------------
    // EXERCICE 1 : Manipulation de chaînes
    // -------------------------------------------------
    public static void Exercice1_ManipulationStrings()
    {
        Console.Write("Entre une phrase : ");
        string phrase = Console.ReadLine() ?? " ";

        Console.WriteLine($"Majuscules : {phrase.ToUpper()}");
        Console.WriteLine($"Nombre de caractères : {phrase.Length}");

        int nbMots = phrase.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length;
        Console.WriteLine($"Nombre de mots : {nbMots}");

        Console.WriteLine($"Avec tirets : {phrase.Replace(" ", "-")}");
    }

    // -------------------------------------------------
    // EXERCICE 2 : Gestion des erreurs
    // -------------------------------------------------
    public static void Exercice2_GestionErreurs()
    {
        try
        {
            Console.Write("Entre un nombre : ");
            int nombre = int.Parse(Console.ReadLine() ?? "0");
            Console.WriteLine($"Nombre saisi : {nombre}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Erreur : ce n'est pas un nombre valide");
        }
        finally
        {
            Console.WriteLine("Fin du programme");
        }
    }

    // -------------------------------------------------
    // EXERCICE 3 : Fichiers
    // -------------------------------------------------
    public static void Exercice3_Fichiers()
    {
        string chemin = "data.txt";

        string[] lignes =
        {
            "Première ligne",
            "Deuxième ligne",
            "Troisième ligne"
        };

        File.WriteAllLines(chemin, lignes);

        Console.WriteLine("Contenu du fichier :");
        foreach (string ligne in File.ReadAllLines(chemin))
        {
            Console.WriteLine(ligne);
        }
    }

    // -------------------------------------------------
    // EXERCICE 4 : Enum + switch
    // -------------------------------------------------
    public static void Exercice4_EnumEtSwitch()
    {
        Console.WriteLine("Choisis un jour (1 = Lundi, 7 = Dimanche) :");
        int valeur = int.Parse(Console.ReadLine() ?? "1");

        JourSemaine jour = (JourSemaine)valeur;

        switch (jour)
        {
            case JourSemaine.Samedi:
            case JourSemaine.Dimanche:
                Console.WriteLine("Week-end");
                break;

            default:
                Console.WriteLine("Jour travaillé");
                break;
        }
    }

    // -------------------------------------------------
    // EXERCICE 5 : Dictionnaire
    // -------------------------------------------------
    public static void Exercice5_Dictionnaire()
    {
        Dictionary<string, int> produits = new Dictionary<string, int>()
        {
            { "Pomme", 2 },
            { "Banane", 1 },
            { "Orange", 3 }
        };

        foreach (var produit in produits)
        {
            Console.WriteLine($"{produit.Key} : {produit.Value}€");
        }

        Console.Write("Produit recherché : ");
        string recherche = Console.ReadLine() ?? "";

        if (produits.ContainsKey(recherche))
        {
            Console.WriteLine($"Prix : {produits[recherche]}€");
        }
        else
        {
            Console.WriteLine("Produit inconnu");
        }
    }

    // -------------------------------------------------
    // EXERCICE 6 : LINQ
    // -------------------------------------------------
    public static void Exercice6_LINQ()
    {
        List<int> nombres = new List<int> { 1, 4, 7, 10, 15, 20 };

        var resultats = nombres
            .Where(n => n % 2 == 0)
            .OrderByDescending(n => n)
            .ToList();

        Console.WriteLine("Nombres pairs triés décroissants :");
        resultats.ForEach(n => Console.WriteLine(n));
    }

    // -------------------------------------------------
    // EXERCICE 7 : POO avancée
    // -------------------------------------------------
    public static void Exercice7_POO_Avancee()
    {
        Employe emp = new Employe("Alice", 30, 2500);
        emp.AfficherInfos();
    }

    // -------------------------------------------------
    // EXERCICE 8 : Mini-projet (gestion de tâches)
    // -------------------------------------------------
    public static void Exercice8_MiniProjet()
    {
        List<Tache> taches = new List<Tache>();
        bool continuer = true;

        while (continuer)
        {
            Console.WriteLine("\n1 - Ajouter une tâche");
            Console.WriteLine("2 - Lister les tâches");
            Console.WriteLine("3 - Marquer une tâche comme terminée");
            Console.WriteLine("0 - Quitter");

            Console.Write("Choix : ");
            string choix = Console.ReadLine() ?? "0";

            switch (choix)
            {
                case "1":
                    Console.Write("Titre : ");
                    taches.Add(new Tache(Console.ReadLine() ?? ""));
                    break;

                case "2":
                    for (int i = 0; i < taches.Count; i++)
                    {
                        Console.WriteLine($"{i} - {taches[i]}");
                    }
                    break;

                case "3":
                    Console.Write("Index : ");
                    int index = int.Parse(Console.ReadLine() ?? "0");
                    taches[index].MarquerCommeTerminee();
                    break;

                case "0":
                    continuer = false;
                    break;
            }
        }
    }
}

// =============================================================
// TYPES ASSOCIÉS AU NIVEAU 2
// =============================================================

public enum JourSemaine
{
    Lundi = 1,
    Mardi,
    Mercredi,
    Jeudi,
    Vendredi,
    Samedi,
    Dimanche
}

public class Personne
{
    public string Nom { get; set; }
    public int Age { get; set; }

    public Personne(string nom, int age)
    {
        Nom = nom;
        Age = age;
    }

    public virtual void AfficherInfos()
    {
        Console.WriteLine($"Nom : {Nom}, Âge : {Age}");
    }
}

public class Employe : Personne
{
    public double Salaire { get; set; }

    public Employe(string nom, int age, double salaire)
        : base(nom, age)
    {
        Salaire = salaire;
    }

    public override void AfficherInfos()
    {
        Console.WriteLine($"Employé : {Nom}, {Age} ans, Salaire : {Salaire}€");
    }
}

public class Tache
{
    public string Titre { get; set; }
    public bool EstTerminee { get; private set; }

    public Tache(string titre)
    {
        Titre = titre;
        EstTerminee = false;
    }

    public void MarquerCommeTerminee()
    {
        EstTerminee = true;
    }

    public override string ToString()
    {
        return $"[{(EstTerminee ? "X" : " ")}] {Titre}";
    }
}
