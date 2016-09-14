using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TuesSlide37HW
{
    class Program
    {
        static void Main(string[] args)


        {


            while (true)
            {
                Console.WriteLine("Enter and integer.");
                int n = int.Parse(Console.ReadLine());

                if (n % 3 != 0)


                {

                    Console.WriteLine("You Lost.  Enter another integer.");



                }

                else if (n % 3 == 0)
                {
                    Console.WriteLine("You win!");

                }

            }

            

        }
    }
}
