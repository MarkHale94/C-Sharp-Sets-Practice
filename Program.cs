using System;
using System.Collections.Generic;

namespace sets {
    class Program {
        static void Main (string[] args) {
            HashSet<string> Showroom = new HashSet<string> ();

                Showroom.Add ("Ferrari Enzo");

                Showroom.Add ("Mercedes SLR-McClarin");
                
                Showroom.Add ("Nissan GTR");
                
                Showroom.Add ("Mitsubishi Lancer-Evo");
                
                Console.WriteLine ("In the Showroom:");

                foreach (string model in Showroom) {

                    Console.WriteLine (model);
                
                }

            HashSet<string> UsedLot = new HashSet<string> ();
            
                UsedLot.Add ("Nissan Maxima");
                
                UsedLot.Add ("Porsche Cayman S");

                Console.WriteLine ("In the UsedLot:");
                
                foreach (string model in UsedLot) {

                     Console.WriteLine (model);
                     
                }
            
            Showroom.UnionWith(UsedLot);

            Console.WriteLine ("In the Showroom:");

            foreach (string model in Showroom) {

                Console.WriteLine (model);
                
            }

            Console.WriteLine ("In the UsedLot:");
            
            foreach (string model in UsedLot) {

                Console.WriteLine (model);
                     
            }
        }
    }
}