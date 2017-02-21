﻿using Ressources_Partagés;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ressources_Partagés
{
    public class Villain : Personne
    {
        public string NomDeVillain { get; set; }

        public Villain(int age, string nom, string addr, string nomVillain)
        {
            Age = age;
            Nom = nom;
            Adresse = addr;
            NomDeVillain = nomVillain;
        }

        public override void Presentation()
        {
            Console.WriteLine("HAHAHAHAHA! Je suis " + NomDeVillain + " et je suis un villain!!!");
        }

        public void RireDiabolique()
        {
            Console.WriteLine("HAHAHAHAHAHAHAHAHAHAH !!!!!!!!");
        }
    }
}
