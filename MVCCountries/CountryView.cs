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

            //loop to check the color of the country against the items stored in ConsoleColor
            foreach (string color in DisplayCountry.Colors)
            {
                foreach (ConsoleColor console in Enum.GetValues(typeof(ConsoleColor)))
                {
                    string compare = console.ToString();
                    //sets the text color to the countries color if it matches
                    //also sets the background to white if the color is black for readability
                    if (compare.Equals(color))
                    {
                        Console.ForegroundColor = console;
                    }
                    if (color == "Black")
                    {
                        Console.BackgroundColor = ConsoleColor.White;
                    }
                }
                Console.WriteLine(color);
                //resets the color back to default black/grey
                Console.BackgroundColor = ConsoleColor.Black;

            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine();
        }
    }
}
