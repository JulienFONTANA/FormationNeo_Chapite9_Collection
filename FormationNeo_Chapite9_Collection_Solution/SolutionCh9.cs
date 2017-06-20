using Ressources_Partagés;
using System;
using System.Collections.Generic;

namespace FormationNeo_Chapite9_Collection_Solution
{
    class SolutionCh9
    {
        static void Main(string[] args)
        {
            // Quelques Variables offertent par la maison:
            Personne Jean = new Personne(23, "Jean", "4 chemin du marché");
            Personne Fred = new Personne(26, "Fred", "9 avenue du General Malloc");

            Hero GigaPoney = new Hero(35, "Hippolyte Fairachval", "2 QG des gentils", "GigaPoney", "Super Poney");
            Hero FreeMuffin = new Hero(17, "Frank Plop", "7 QG des gentils", "FreeMuffin", "Muffins gratuits");

            Villain TréMocheu = new Villain(42, "Hugues Heunot", "3 rue du Volcan", "TréMocheu");
            Villain Radoteur = new Villain(82, "Pierre-Jean Toxi", "chez maman", "Radoteur");

            SuperHero UltraBeau = new SuperHero(17, "Aimé Partoutes", "7 QG des gentils", "UltraBeau", "Super Sourire", "tube de dentifrice", TréMocheu);
            SuperHero CouréConcis = new SuperHero(24, "Lily Pluvite", "182 QG des gentils", "CouréConcis", "Super Efficacité", "montre", Radoteur);

            // Faites un tableau contenant tout les chiffres impaires entre 0 et 20, puis afficher le résultat
            // en utilisant une boucle foreach!
            // Méthode 1 - Calcul
            int[] tabImpaires = new int[10];
            int index = 0;
            for (int i = 0; i < 20; i++)
            {
                if ((i % 2) != 0)
                {
                    tabImpaires[index] = i;
                    index++;
                }
            }
            // Méthode 2 - Affectation directe de valeur
            //int[] tabImpaires = new int[] { 1, 3, 5, 7, 9, 11, 13, 15, 17, 19 };

            Console.WriteLine("Les impaires entre 0 et 20 sont :");
            foreach (var item in tabImpaires)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();


            // Faites un tableau à deux dimensions de neuf lignes contenant un couple de valeurs dont la première est un chiffre entre 0 et 9
            // et la seconde ça valeur au carrée, puis afficher le résultat

            int[,] tabCarre = new int[9, 2]; // Tableau de 9 lignes et de 2 colonnes
            for (int i = 1; i < 9; i++)
            {
                tabCarre[i, 0] = i;     // Valeur
                tabCarre[i, 1] = i * i; // Carré
            }

            Console.WriteLine('\n' + "Les carré entre 0 et 10 sont :");
            for (int i = 1; i < 9; i++)
            {
                Console.WriteLine(tabCarre[i, 0] + "² = " + tabCarre[i, 1]);
            }
            Console.WriteLine();

            // Faites une liste contenant tout les héro et superhéro (oui, une seule liste)
            // puis afficher le résultat!
            // Une liste de héro peut contenir des super héros! C'est l'héritage!
            List<Hero> listeHero = new List<Hero>();
            listeHero.Add(GigaPoney);
            listeHero.Add(FreeMuffin);
            listeHero.Add(UltraBeau);
            listeHero.Add(CouréConcis);

            Console.Write("Ma liste contient les noms : ");
            foreach (var item in listeHero)
            {
                Console.Write(item.Nom + " ");
            }
            Console.WriteLine("\n\n");

            // Faites un dictionnaire qui prend en entrée un nom de héro ou de villain et qui retrouve l'adresse de celui-ci.
            // Utiliserdes string en clé et des objets en Valeur
            // Ce dictionnaire contient les Héro, les Villains et les Super Héros!
            // Montrez en un ou deux exemples!

            Dictionary<string, Personne> annuaireDesSuper = new Dictionary<string, Personne>();

            annuaireDesSuper.Add(GigaPoney.NomDeHero, GigaPoney);
            annuaireDesSuper.Add(FreeMuffin.NomDeHero, FreeMuffin);
            annuaireDesSuper.Add(TréMocheu.NomDeVillain, TréMocheu);
            annuaireDesSuper.Add(Radoteur.NomDeVillain, Radoteur);
            annuaireDesSuper.Add(UltraBeau.NomDeHero, UltraBeau);
            annuaireDesSuper.Add(CouréConcis.NomDeHero, CouréConcis);

            Console.WriteLine("La base secrète de GigaPoney est situé '" + annuaireDesSuper[GigaPoney.NomDeHero].Adresse + "'.");
            Console.WriteLine("La base secrète de TréMocheu est situé '" + annuaireDesSuper[TréMocheu.NomDeVillain].Adresse + "'.");
            Console.WriteLine("La base secrète de UltraBeau est situé '" + annuaireDesSuper[UltraBeau.NomDeHero].Adresse + "'.");
        }
    }
}

