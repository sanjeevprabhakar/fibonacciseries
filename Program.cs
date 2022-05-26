using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int n1 = 0;
            int n2 = 1;
            int number;
            int n3;

            Console.WriteLine("here are your series");
            

            number = int.Parse(Console.ReadLine());
            Console.Write(n1 + " " + n2);

            for (int i = 3; i < number; i++)
            {
                n3 = n1 + n2;
                Console.Write(n3+ " ");
                n1 = n2;
                n2 = n3;

            }








        }
    }
}
