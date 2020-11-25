using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homeWorkWeek2Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
                                                                            // Evan Caraway, Sirnivas Reddy Doma, Kipack Jeong

            Console.Write("Enter temperature in degrees Fahrenheit: ");     // ask user for temp.

            string temp = Console.ReadLine();                               // read user input and save in temp.

            double tempInFahrenheit = Convert.ToDouble(temp);               // convert temp to double.
            double tempInCelsius = (5.0 / 9.0) * (tempInFahrenheit - 32);   // formula for converting from Fahrenheit to Celsius.
            tempInCelsius = Math.Round(tempInCelsius, 2);                   // round to 2 decimal places.
            Console.WriteLine($"The temperature is {tempInCelsius} degrees Celsius." );
        }
    }
}
