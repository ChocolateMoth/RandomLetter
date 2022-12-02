using System;
using System.Linq;
using System.Collections.Generic;// dont forget . . .                                                                                                                                                 i'm with you in the dark

namespace random_letter
{
    class Program
    {

        static void Main(string[] args)
        {
            int b = 0;
            var letter = new List<char>(30);
            Random rnd = new Random();//random num gen
            //var noDupe = letter.Distinct().ToList();

            for (; b < 30; b++)
            {

                string charc = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";//alphabet that i took from the internet so I dont have to write it all out.
                int i = rnd.Next(0, charc.Length);//0 to lenght of alphabet


                // just remember that charc is the alphabet string. I already see myself forgetting this



                letter.Add(charc[i]);
                //Console.WriteLine(charc[i]+" ");//write


                if(b >= 29)
                {
                    Console.WriteLine(" ");
                    Console.WriteLine("-- Original array -- ");
                    foreach(var e in letter)
                    {
                        Console.WriteLine($"{e}");
                    }
                }
            }
            var hOI =
                from e in letter
                orderby e ascending
                select e;

            Console.WriteLine("the list ascending");
            foreach (var element in hOI)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(" ");

            var tEMMIE =
            from e in letter
            orderby e descending
            select e;
            Console.WriteLine("the list descending");
            foreach (var element in tEMMIE)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine(" ");

            var Tem =
                from e in letter
                orderby e ascending
                select e;
            Console.WriteLine("the list without dupes");
            foreach (var element in Tem.Distinct())
            {
                Console.WriteLine(element);
            }




        }

    }
}


//abcdefghijklmnopqrstuvwxyz