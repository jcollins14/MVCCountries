using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryView
    {
        public Country DisplayCountry { get; set; }

        public CountryView (Country country)
        {
            this.DisplayCountry = country;
        }

        public void Display()
        {
            Console.WriteLine("Country Name: " + DisplayCountry.Name);
            Console.WriteLine("Continent: " + DisplayCountry.Continent);

            Console.WriteLine("Colors: ");
            foreach (string color in DisplayCountry.Colors)
            {
                //foreach (ConsoleColor console in Enum.GetValues(typeof(ConsoleColor)))
                //{
                //        Console.ForegroundColor = Enum.TryParse(ConsoleColor, color);
                //}
                Console.WriteLine(color);
            }
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
        }
    }
}
