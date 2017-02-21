using Ressources_Partagés;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormationNeo_Chapite9_Collection_Exos
{
    class ExerciesCh9
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

            // Faites un tableau à deux dimensions contenant un couple de valeurs dont la première est un chiffre entre 0 et 9
            // et la seconde ça valeur au carrée, puis afficher le résultat

            // Faites une liste contenant tout les héro et superhéro (oui, une seule liste)
            // puis afficher le résultat!
            // Une liste de héro peut contenir des super héros! C'est l'héritage!

            // Faites un dictionnaire qui prend en entrée un nom de héro ou de villain et qui retrouve l'adresse de celui-ci.
            // Utiliserdes string en clé et des objets en Valeur
            // Ce dictionnaire contient les Héro, les Villains et les Super Héros!
            // Montrez en un ou deux exemples!
        }
    }
}
