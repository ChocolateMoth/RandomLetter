using System;
using System.Collections.Generic;// dont forget . . .                                                                                                                                                 i'm with you in the dark

namespace random_letter
{
    class Program
    {

        static void Main(string[] args)
        {
            int b = 0;
            while (b < 30)
            {
                string charc = "$%#@!*abcdefghijklmnopqrstuvwxyz1234567890?;:ABCDEFGHIJKLMNOPQRSTUVWXYZ^&";//alphabet that i took from the internet so I dont have to write it all out.
                Random rnd = new Random();//random num
                int i = rnd.Next(0, charc.Length);//0 to lenght of alph
                
                // just remember that charc is the alphabet string. I already see myself forgetting this


                var letter = new List<char>();
                letter.Add(charc[i]);
                Console.Write(charc[i]+" ");//write


                if(b >= 29)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("-- Original array -- ");
                    foreach(var e in letter)
                    {
                        Console.Write($" {e}");
                    }
                }

                b++; // looks cool without this

                
            }
             // how to get final list from while loop ?

            
        }
        
    }
}
