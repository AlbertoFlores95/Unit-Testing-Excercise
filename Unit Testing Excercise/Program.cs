using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Unit_Testing_Excercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hash("leepadg"));
            Console.Read();
        }

        public static Int64 Hash (string s)
        {
            Int64 h;
            String letters;
            int i;
            int index;
            Int64 inc;

            h = 7;
            letters = "acdegilmnoprstuw";

            for(i =0; i< s.Length; i++) 
            {
                inc = h * 37;
                index = letters.IndexOf(s[i]);
                h = inc + index;
            }

            return h;
        }


    }
}
