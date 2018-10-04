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
                
                // Console.WriteLine ("In the Showroom:");

                // foreach (string model in Showroom) {

                //     Console.WriteLine (model);
                
                // }

            HashSet<string> UsedLot = new HashSet<string> ();
            
                UsedLot.Add ("Nissan Maxima");
                
                UsedLot.Add ("Porsche Cayman S");

                // Console.WriteLine ("In the UsedLot:");
                
                // foreach (string model in UsedLot) {

                //      Console.WriteLine (model);
                     
                // }
            
            Showroom.UnionWith(UsedLot);

            // Console.WriteLine ("In the Showroom:");

            // foreach (string model in Showroom) {

            //     Console.WriteLine (model);
                
            // }

            // Console.WriteLine ("In the UsedLot:");

            // foreach (string model in UsedLot) {

            //     Console.WriteLine (model);
                     
            // }

            Showroom.Remove("Nissan Maxima");

            // Console.WriteLine ("In the Showroom:");

            // foreach (string model in Showroom) {

            //     Console.WriteLine (model);
                
            // }

            HashSet<string> Junkyard = new HashSet<string> ();
            
            Junkyard.Add ("Nissan GTR");
                
            Junkyard.Add ("Mitsubishi Lancer-Evo");

            Junkyard.Add ("Toyota Camry");
                
            Junkyard.Add ("Ford Mustang");

            Junkyard.Add ("Mazda RX8");
                
            Junkyard.Add ("Dodge Charger");

            HashSet<string> clone = new HashSet<string>(Showroom);

            clone.IntersectWith(Junkyard);

            Showroom.UnionWith(Junkyard);

            // Console.WriteLine ("In the Junkyard:");

            // foreach (string model in Junkyard) {

            //     Console.WriteLine (model);
                
            // }

            // Console.WriteLine ("In the Cloned Showroom:");

            // foreach (string model in clone) {

            //     Console.WriteLine (model);
                
            // }

            Console.WriteLine ("In the Original Showroom:");

            foreach (string model in Showroom) {

                Console.WriteLine (model);
                
            }
        }
    }
}