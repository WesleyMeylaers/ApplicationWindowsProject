using System;
// importeer de System namespace
using System.Collections.Generic;
// importeer de System.Collections.Generic namespace
using System.Linq;
// importeer de System.Linq namespace
using System.Text;
// importeer de System.Text namespace
using System.Threading.Tasks;
// importeer de System.Threading.Tasks namespace
namespace ProjectWindows2023
// naam van de namespace 
{
    class Program
    // begin van de class Program
    {
        static void Main(string[] args)
        // begin van de Main functie met als parameter args van het type string[]
        {

            double[,] array = new double[10, 3];
            // declareer een 2-dimensionale array van het type double genaamd array met 10 rijen en 3 kolommen

            Random rnd = new Random();
            // maak een instantie van de Random klasse genaamd rnd

            double getal;
            // declareer een variabele van het type double genaamd getal
            double verschillend = 0;
            // declareer een variabele van het type double genaamd verschillend en initialiseer het met de waarde 0
            int score = 0;
            // declareer een variabele van het type int genaamd score en initialiseer het met de waarde 0
            for (int rij = 0; rij < 10; rij++)
            // for loop die 10 keer loopt voor elke rij
            {
                for (int kolom = 0; kolom < 2; kolom++)
                // for loop die 2 keer loopt voor elke kolom
                {
                    array[rij, kolom] = Math.Round(rnd.NextDouble() * 100 + 1, 2);
                    // geef de array[rij,kolom] een random waarde van 1 tot en met 100 met 2 decimalen
                }
            }
            for (int rij = 0; rij < 10; rij++)
            // for loop die 10 keer loopt voor elke rij
            {
                array[rij, 2] = array[rij, 0] + array[rij, 1];
                // tel de waardes van array[rij,0] en array[rij,1] op en stop het in array[rij,2]
            }
            for (int rij = 0; rij < 5; rij++)
            // for loop die 5 keer loopt voor elke rij
            {
                for (int kolom = 0; kolom < 1; kolom++)
                // for loop die 1 keer loopt voor elke kolom
                {
                    {
                        Console.Write("{0} + {1} = ", array[rij, 0], array[rij, 1]);
                        // vraag aan de gebruiker wat de som van array[rij,0] en array[rij,1] is
                        verschillend = array[rij, 0] + array[rij, 1];
                        // bereken de juiste som van array[rij,0] en array[rij,1] en stop het in de variabele verschillend
                        getal = Convert.ToDouble(Console.ReadLine());
                        // lees de input van de gebruiker en converteer het naar een double en sla het op in getal
                        Console.WriteLine("Het juiste antwoord = {0}", verschillend);
                        // geef de juiste som weer
                        if (getal == verschillend)
                        // als de som gegeven door de gebruiker gelijk is aan de juiste som
                        {
                            Console.WriteLine("Goed geantwoord");
                            // geef weer dat de gebruiker het goed heeft
                            score += 1;
                        }
                        else
                        //Als de gegeven som niet gelijk is aan de juiste som
                        {
                            Console.WriteLine("Jammer volgende keer beter");
                            // geef weer dat de gebruiker het fout heeft
                        }
                    }
                }

            }
            Console.WriteLine("Je score = {0}/5", score);
            // Weergeven van de behaalde score op 5.
        }
    }
}

