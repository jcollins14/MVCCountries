using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryController
    {
        List<Country> CountryDB { get; set; }

        public CountryController()
        {
            CountryDB = new List<Country>();
            CountryDB.Add(new Country()
            {
                Name = "USA",
                Continent = "North America",
                Colors = new List<string> { "Red", "White", "Blue" }
            }
              ) ;
            CountryDB.Add(new Country()
            {
                Name = "Columbia",
                Continent = "South America",
                Colors = new List<string> { "Yellow", "Blue", "Red" }
            }
              );
            CountryDB.Add(new Country()
            {
                Name = "England",
                Continent = "Europe",
                Colors = new List<string> { "Red", "White", "Blue" }
            }
              );
            CountryDB.Add(new Country()
            {
                Name = "Japan",
                Continent = "Asia",
                Colors = new List<string> { "White", "Red",}
            }
              );
            CountryDB.Add(new Country()
            {
                Name = "Australia",
                Continent = "Australia",
                Colors = new List<string> { "Red", "White", "Blue" }
            }
              );

        }

        public void CountryAction (Country c)
        {
            CountryView view = new CountryView(c);
            view.Display();
        }

        public void WelcomeAction()
        { 
            CountryListView listview = new CountryListView(CountryDB);
            bool loop = true;
            

            Console.WriteLine("Hello, Welcome to the Country App. Please select a Country from the following list:");

            while (loop)
            {
                int answer = 0;
                listview.Display();
                Console.WriteLine("Please enter the integer of the country you would like to select.");

                while (answer == 0 && answer < CountryDB.Count)
                {
                    try
                    {
                        answer = int.Parse(Console.ReadLine().Trim());
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter only valid integers.");
                    }
                }

                answer--;
                Country a = CountryDB[answer];
                Console.WriteLine();
                CountryAction(a);
               
                Console.WriteLine("Would you like to learn about another country? Type No to Exit");
                string response = "";
                response = Console.ReadLine().ToLower().Trim();
                if (response == "no")
                {
                    loop = false;
                }
                Console.WriteLine();
            }
        }
    }
}
