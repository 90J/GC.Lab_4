using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare
            string userNumber;
            int testNumber;
            string check;
            int squared;
            int cubed;


            while (true)
            {
                // Get input
                Console.WriteLine("Enter a whole number: ");
                userNumber = Console.ReadLine();
                testNumber = int.Parse(userNumber);
                squared = int.Parse(userNumber);
                cubed = int.Parse(userNumber);


                {
                    // Do maths
                    Console.WriteLine("Number     Squared     Cubed");
                    Console.WriteLine("============================");
                    for (int i = 1; i <= testNumber; i++)
                    {
                        squared = (i * i);
                        cubed = (i * i * i);

                        //Print things
                        Console.WriteLine(string.Format("{0, -10} {1, -10} {2, -10}", i, squared, cubed));

                    }
                    //Check
                    Console.Write("Continue y/n: ");
                    check = Console.ReadLine();
                    if (check != "y")
                    {
                        break;
                    }
                    else
                    {
                        Console.Clear();
                    }

                }
            }
        }
    }
}
