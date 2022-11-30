using System;
using System.Collections.Generic;// dont forget

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


                var letter = new List<char>();
                letter.Add(charc[i]);
                Console.Write(charc[i]+" ");//write
                b++; // looks cool without this
            }

            
        }
        
    }
}
