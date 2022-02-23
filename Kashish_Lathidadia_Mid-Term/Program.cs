using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kashish_Lathidadia_Mid_Term
{
    class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {
                try
                {
                    double result = 0;

                    Console.WriteLine("Enter a value to convert:");
                    int input = int.Parse(Console.ReadLine());

                    if (input < 0)
                        throw new Exception("Please only enter numbers greater than 0.");

                    Console.WriteLine("Choose your conversion:\n1. Megabytes to Bytes\n2. Gigabytes to Megabytes\n3. Terabytes to Gigabytes\n4. Exit");

                    int option = int.Parse(Console.ReadLine());

                    switch (option)
                    {
                        case 1:
                            result = ByteConversion.MegabytesToBytes(input);
                            break;
                        case 2:
                            result = ByteConversion.GigabytesToMegabytes(input);
                            break;
                        case 3:
                            result = ByteConversion.TerabytesToGigabytes(input);
                            break;
                        case 4:
                            exit = true;
                            break;
                        default:
                            throw new Exception("Incorrect option. Please try again.");
                    }

                    if (!exit)
                        Console.WriteLine("Result: " + result.ToString());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e + "\nERROR\nPress ENTER to try again.\n");
                    Console.ReadLine();
                }
            }
            Environment.Exit(1);
        }
    }
}
