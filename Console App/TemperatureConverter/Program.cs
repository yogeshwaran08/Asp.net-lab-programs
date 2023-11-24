using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemperatureConverter
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("1. Farenheit to celsius\n2. Celsius to farenheit");
                Console.Write("Enter your choice : ");
                int choice = Convert.ToInt32(Console.ReadLine());
                if (choice == 1)
                {
                    Console.Write("Enter temperature in Farenheit : ");
                    int faren = Convert.ToInt32(Console.ReadLine());
                    int cel = (faren - 32) * 5 / 9;
                    Console.WriteLine("Celsius : " + cel);
                }
                else if (choice == 2)
                {
                    Console.Write("Enter the temperature in Celsius : ");
                    int cel = Convert.ToInt32(Console.ReadLine());
                    int faren = cel * 9 / 5 + 32;
                    Console.WriteLine(" Farenheit : " + faren);
                }
            }
        }
    }
}
