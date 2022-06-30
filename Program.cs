using System;

    namespace App 
    {
        //Pour distinguer une structure d'une classe
        /*Une structure est utilisée pour réprésenter un type qui 
        sera modifier constement*/
        
        /*une structure qui représente un disque dur, là par exple on
        aura pas besoin de changer la marque ou la capacité du disque dur*/
        public struct Disk
        {
            //attributs
            public string Marque;
            public int Capacite; //en Go

            //constructeur qui permet de créer une instance de l'objet
            public Disk(string marque, int capacite)
            {
                //doit obligatoirement initialiser tous les champs de l'objet
                Marque = marque;
                Capacite = capacite;
            }

            /*La surcharge d'une méthode déjà existante dans C#
            qui est appelé implicitement dès que j'essaye d'appeler un objet*/
            public override string ToString() => $"Disque de marque {Marque} d'une capacité de {Capacite}Go";
            
        }

        class Program
        {
            static void Main(string[] args)
            {
                /*déclaration du disque dur en créant une nouvelle instance
                avec le constructeur pour affecter des valeurs*/
                Disk d = new Disk("Toshiba", 1);
                // Disk d2 = new Disk("Western Digital", 5000);

                Console.WriteLine(d);
                // Console.WriteLine(d.Capacite);

                // Console.WriteLine(d2.Marque);
                // Console.WriteLine(d2.Capacite);
            }
        }

    }
