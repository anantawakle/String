using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String
{
    internal class Counts8
    {
        static void Main(string[] args)
        {
            string str = "Hello$Word";
            int count = 0;
            for(int i=0; i<str.Length; i++)
            {
                count++;
            }
            Console.WriteLine($" Total word in string "+count);
        }
    }
}
