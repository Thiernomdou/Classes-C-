using System;

    namespace App 
    {
        //Pour distinguer une structure d'une classe
        /*Une structure est utilisée pour réprésenter un type qui 
        sera modifier constement*/
        
        /*Une classe */

        public class Stock
        {
            //attributs
            private int Capacite;

            //constructeur par défaut
            public Stock()
            {
                Capacite = 100;
            }

            //Constructeur avec paramètres
            public Stock(int capacite)
            {
                Capacite = capacite;
            }

            /*rédefinition de la méthode pour afficher les informations*
            elle est automatiquement lancée quand on affiche un objet*/
            public override string ToString() => $"Capacité du stock : {Capacite}";
        }
        

        class Program
        {
            static void Main(string[] args)
            {
                /*déclaration de la classe en créant une nouvelle instance
                avec le constructeur pour affecter des valeurs*/
                Stock stock_disks = new Stock();
                Stock stock_mouses = new Stock(25);
                // Disk d2 = new Disk("Western Digital", 5000);

                Console.WriteLine(stock_disks);
                Console.WriteLine(stock_mouses);
                // Console.WriteLine(d.Capacite);

                // Console.WriteLine(d2.Marque);
                // Console.WriteLine(d2.Capacite);
            }
        }

    }
