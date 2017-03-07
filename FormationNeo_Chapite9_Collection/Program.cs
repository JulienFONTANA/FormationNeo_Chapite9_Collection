
/* Bienvenue dans ce tutoriel sur les Collections
 * Les variables n'ont plus aucun secret pour vous?
 * Les structures de controles sont devenu une seconde nature?
 * Les fonctions sont une seconde nature?
 * Les classes, et l'héritage ne vous font plus peur? Parfait!
 * 
 * Que faire quand on possède un grand nombre d'objet à manipuler?
 * 
 * Il est temps de voir les collections! 
 * (Et d'enfin recréer le QG des héros, non ?)
 * 
*/

using Ressources_Partagés;
using System;
using System.Collections.Generic;
using System.Linq;

namespace FormationNeo_Chapite9_Collection
{
    class Program
    {
        /* Ce cours est très complet et très long. Il contient donc de nombreuses "région".
         * Si vous n'avez toujours pas utilisé cette fonctionnalitée de Visual Studio, sachez
         * qu'une région défini une zone dans le code qui peut être agrandi ou réduite à volonté.
         * Il suffi pour cela de cliquer sur [+] ou [-] pour agrandir ou réduire une
         * portion de code! Une région peut aussi en contenir d'autres...
         * 
         * Il y a dans ce code de nombreuses région imbriqués, et je vous conseil fortement de
         * n'agrandir que la partie de code sur laquel vous êtes en train de travailler!
        */

        static void Main(string[] args)
        {
            // Quelques variables...
            #region Variables
            Personne P0 = new Personne(10, "Alan");
            Personne P1 = new Personne(11, "Liam");
            Personne P2 = new Personne(12, "Théo");
            Personne P3 = new Personne(13, "José");
            Personne P4 = new Personne(14, "Hugo");
            Personne P5 = new Personne(15, "Alex");
            Personne P6 = new Personne(16, "John");
            Personne P7 = new Personne(17, "Elie");
            Personne P8 = new Personne(18, "Eden");
            Personne P9 = new Personne(19, "Loïs");
            #endregion

            // Tableaux
            // Une collection simple et commune qui permet de ranger facilement des informations!
            // En C#, on utilisera plutôt des objets pour en contenir d'autres.
            // Ces exemples sont surtout données à titre d'information!
            #region Tableaux
            // TABLEAUX A UNE DIMENSION
            #region Tableaux à une dimension
            Console.WriteLine("- - - Tableaux à une dimension - - -");
            // Un tableau à une dimension est un rangement d'élément consécutifs

            // Un tableau se déclare comme un variable, notez juste la présence de crochet
            double[] monTableauDouble;
            // Ce tableau ne peut contenir que 3 doubles !
            monTableauDouble = new double[3];

            // On affecte les valeurs voulues au index du tableau
            // Notez que l'on commence par l'index 0!
            monTableauDouble[0] = 3.14159;
            monTableauDouble[1] = 1.41421;
            monTableauDouble[2] = 1.73205;

            AfficheTableau(monTableauDouble);

            // Il est possible de modifier la taille d'un tableau
            monTableauDouble = new double[5];
            // Il faut réafecter les valeurs dans ce cas.
            // Observer la disparition de la valeur monTableauDouble[2]
            monTableauDouble[0] = 3.14159;
            monTableauDouble[1] = 1.41421;
            // Pas d'affectation pour monTableauDouble[2]
            monTableauDouble[3] = 3.56667;
            monTableauDouble[4] = 0.12345;
            monTableauDouble[4] = 2.00000;  // On peut réafecter une valeur à un tableau...
            monTableauDouble[4] = monTableauDouble[4] + 7.87654; // ... et effectuer les même traitement que sur une variable

            AfficheTableau(monTableauDouble);

            // Et comme un objet est une variable, on peut créer un tableau avec comme
            // type un objet!
            Personne[] monTableauPersonne = new Personne[2];
            monTableauPersonne[0] = P0;
            monTableauPersonne[1] = P1;
            #endregion

            // TABLEAUX MULTIDIMENSIONELS
            #region Tableaux multidimmensionels
            Console.WriteLine("- - - Tableaux multidimmensionels - - -");
            // Un tableau multidimmensionel est un rangement d'élément en rangés et colonnes (pour les tableaux à 2 dimensuions)
            // Un tableau à 2 dimensions est comme un tableur Excel
            // Un tableau à 3 dimensions est un "cube"

            // Déclaration d'un tableau en une seule ligne!
            // Notez la virgule qui sépare le nombre de dimensions du tableau
            // L'affichage en plusieurs lignes est juste pour la claretée, et n'est absolument pas nécessaire
            int[,] monTableauInt = new int[4, 3] { { 1, 2, 3 },
                                                   { 4, 5, 6 },
                                                   { 7, 8, 9 },
                                                   { 6, 0, 7 }};

            AfficheTableau(monTableauInt, 4, 3);

            // Tout peut être un tableau!
            string[,] monTableauString = new string[3, 2] { { "Bonjour    ", "comment" },
                                                            { "allez      ", "vous" },
                                                            { "aujourd'hui", "?" } };

            AfficheTableau(monTableauString, 3, 2);

            // Pas de limites aux dimensions d'un tableau!
            char[,,,] monTableauChar4D = new char[4, 3, 2, 2];
            // Mais il est fortement déconseillé d'utiliser un tableau avec plus de deux dimensions!
            #endregion

            /* Reflexion sur les Tableaux!
             * 
             * Comme vous l'avez vu, les tableaux sont très pratiques pour stocker des informations,
             * mais leur déclaration n'est pas évidente et les traitements qu'ils proposent sont limités
             * 
             * Heureusement, les Collections suivantes sont beaucoup plus simples à utiliser et 
             * facillitent toute sorte de traitements! 
            */
            #endregion

            // Listes
            // Une Liste est exactement ce que le terme suppose, une liste de variable.
            // L'énorme avantage par rapport à un tableau est le nombre de traitement que
            // cette collection propose!
            #region Listes
            Console.WriteLine("- - - Les Listes - - -");

            // Liste "simple"
            // Déclaration sans taille fixe. Une Liste est un conteneur dynamique!
            List<int> maListeInt = new List<int>();
            maListeInt.Add(3); // Ajout d'élément sans s'occuper le moins du monde de l'index de celui-ci!
            maListeInt.Add(8); // C'est la liste qui s'occupe de tout!
            maListeInt.Add(18);
            maListeInt.Add(9);
            AfficheListe(maListeInt);

            // Fonctions intégrés! Voici quelques exemples...
            maListeInt.Remove(3); // Enlèvement d'un element
            maListeInt.Sort();    // La liste est triée...
            maListeInt.Reverse(); // ... puis inversée, tout simplement!
            AfficheListe(maListeInt);

            Console.WriteLine("Ma liste comporte " + maListeInt.Count + " élements dont la somme fait " + maListeInt.Sum() + "...");


            // Liste "complexe"
            // La force des Collection en C# est leur facilité à contenir d'autre objets.
            List<Personne> maListePersonne = new List<Personne>();
            maListePersonne.Add(P3);
            maListePersonne.Add(P0);
            maListePersonne.Add(P5);
            maListePersonne.Add(P6);
            maListePersonne.Add(P8);
            maListePersonne.Add(P9);

            Console.WriteLine("Ma liste comporte " + maListePersonne.Count + " entrées.");
            AfficheListePersonne(maListePersonne);

            // La lecture est très simple avec les listes... Exemple:
            if (maListePersonne.Contains(P2)) // Si ma liste de "Personne" contient "P2"
                Console.WriteLine("La liste contient P2."); // Faux, donc ligne non visible
            if (maListePersonne.Contains(P3)) // Si ma liste de "Personne" contient "P3"
                Console.WriteLine("La liste contient P3."); // Vrai
            #endregion

            // Dictionnaires
            // Les dictionnaires sont encore un conteneur dont le terme est explicite.
            // Un dictionnaire est une liste dont ont accède aux éléments via leur index,
            // comme lorsque l'on recherche un mot... dans le dictionnaire!
            // Avouez que le monde est parfois bien fait!
            #region Dictionnaires
            Console.WriteLine('\n' + "- - - Les Dictionnaires - - -");
            // Ce dictionnaire prend le nom d'une personne comme "clé"
            // Quand on a le nom de quelqu'uin qui se trouve dans ce dictionnaire, on a accès à
            // l'objet Personne associé. Attention au doublons!
            Dictionary<string, Personne> monDico = new Dictionary<string, Personne>();
            monDico.Add(P3.Nom, P3);
            monDico.Add(P2.Nom, P2);
            monDico.Add(P5.Nom, P5);
            monDico.Add(P0.Nom, P0);
            monDico.Add(P4.Nom, P4);

            // Pour parcourir facilement une collection, on utilise un "itérateur"
            // Et plus précicément la boucle "foreach", qui s'occupe de tout pour nous!
            string message = "";
            foreach (var entree in monDico) // Pour chaque entrée de mon dictionnaire...
            {
                message = message + entree.Key; // ...je récupère le nom de la personne...
                message = message + " ";
            }
            Console.WriteLine("Mon dictionnaire contient les noms : " + message); // ...puis je les affiches!
            // On peut dès à présent ajouter et retirer des personnes dans ce dictionnaire à loisir,
            // et il n'y à plus besoin de modifier cette boucle! Magique ;)

            // Enfin, je peut simplement tester la présence d'un couple clé/valeur dans un dictionnaire:
            if (monDico.ContainsKey("Alex")) // Si mon dictionnaire contient la clé "Alex"...
            {
                var tmpPersonne = monDico["Alex"];
                Console.WriteLine("Mon dictionnaire contient la personne : '" + tmpPersonne.Nom 
                                + "' dont l'age est : '" + tmpPersonne.Age + "'."); // ...alors j'affiche ce message!
            }
            #endregion
        }

        #region Fonctions d'affichage
        // Ces fonctions utilisent des constructions très complexes et "poussés"...
        // Il est déconseillé d'allez plus loin dans l'ouverture de ces régions.
        // Si toutefois vous êtes curieux de ce qu'on peut faire quand on
        // pousse le C# plus loin que dans cette formation, alors vous
        // pouvez lire ces fonctions. Le nom des concepts seront juste écrit
        // en commentaire...
        #region Affichage des Tableaux
        // Cette fonction est un "générique"
        // Elle accepte tout type de tableau à une dimension...
        static void AfficheTableau<T>(T[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine("Tableau[" + i + "] -> " + tableau[i]);
            }
            Console.WriteLine();
        }

        // Cette fonction est un "générique" elle aussi
        // C'est aussi une surcharge de la fonction précédante!
        static void AfficheTableau<T>(T[,] tableau, int dim1, int dim2)
        {
            for (int i = 0; i < dim1; i++)
            {
                for (int j = 0; j < dim2; j++)
                {
                    Console.Write(" " + tableau[i, j]);
                    if (j != (dim2 - 1)) // Evite de mettre une barre verticale en trop
                    {
                        Console.Write(" |");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        #endregion

        #region Affichage des Listes
        // Encore un générique!
        static void AfficheListe<T>(List<T> liste)
        {
            // La boucle foreach est vue à la fin de ce tutoriel
            foreach (var elem in liste)
            {
                Console.Write(elem + " ");
            }
            Console.WriteLine();
        }

        static void AfficheListePersonne(List<Personne> liste)
        {
            Console.Write("Ma liste contient les noms : ");
            // Itérateur
            foreach (var item in liste)
            {
                Console.Write(item.Nom + " ");
            }
            Console.WriteLine();
        }
        #endregion

        #endregion
    }
}
