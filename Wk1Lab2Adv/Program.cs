using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wk1Lab2Adv
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1. Input

            // Calculate Area

            while (true)
            {
                Console.WriteLine("Welcome to Grand Cirus' Room Detail Generator");

                double length, width, area;
                Console.WriteLine("Enter Length of Room: ");
                length = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter Width of Room : ");
                width = Convert.ToDouble(Console.ReadLine());
                area = length * width;
                Console.WriteLine("\nArea of room: " + area);


                // Calculate Perimiter

                double perimeter;
                perimeter = 2 * (length + width);
                Console.WriteLine("\nPerimeter of room: " + perimeter);

                //Output



                Console.WriteLine("Would you like to continute Y/N");
                string input = Console.ReadLine();

                if (input.ToLower() == "n")
                {
                    break;
                }


            }
        }


    }
}
