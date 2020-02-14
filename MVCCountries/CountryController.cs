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
            CountryDB.Add(new Country()
            {
                Name = "Germany",
                Continent = "Europe",
                Colors = new List<string> { "Red", "Black", "Yellow" }
            }
            );
            CountryDB.Add(new Country()
            {
                Name = "Greece",
                Continent = "Europe",
                Colors = new List<string> { "White", "Blue" }
            }
            );
            CountryDB.Add(new Country()
            {
                Name = "Mongolia",
                Continent = "Asia",
                Colors = new List<string> { "Red", "Blue", "Red" }
            }
            );
            CountryDB.Add(new Country()
            {
                Name = "Canada",
                Continent = "North America",
                Colors = new List<string> { "Red", "White" }
            }
            );
            CountryDB.Add(new Country()
            {
                Name = "Congo",
                Continent = "Africa",
                Colors = new List<string> { "Red", "Yellow" , "Green" }
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
            Console.WriteLine("===================================================================================");
            Console.WriteLine();

            while (loop)
            {
                int answer = 0;
                listview.Display();
                Console.WriteLine();
                Console.WriteLine("Please enter the integer of the country you would like to select.");

                string input = "error";
                while (input == "error")
                {
                    input = Console.ReadLine().Trim();
                    try
                    {
                        answer = int.Parse(input);
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Please enter only valid integers.");
                        input = "error";
                    }

                    
                    if (answer == 0 || answer > CountryDB.Count)
                    {
                        try
                        {
                            Country b = CountryDB[answer];
                        }
                        catch (ArgumentOutOfRangeException)
                        {
                            Console.WriteLine("Please select a valid option.");
                            input = "error";
                        }

                    }

                }

                answer--;
                Country a = CountryDB[answer];
                Console.WriteLine();
                CountryAction(a);
               
                Console.WriteLine("Would you like to learn about another country? (Yes/No)");
                string response = "";
           
                while (response == "")
                {
                    response = Console.ReadLine().ToLower().Trim();
                    if (response == "no")
                    {
                        loop = false;
                        Console.WriteLine("Thank you for using the Country App. Goodbye.");
                        Environment.Exit(1);
                    }
                    else if (response != "yes")
                    {
                        Console.WriteLine("Please select yes or no.");
                        Console.WriteLine();
                        response = "";
                    }

                }

                Console.Clear();
                Console.WriteLine("Hello, Welcome to the Country App. Please select a Country from the following list:");
                Console.WriteLine("===================================================================================");
                Console.WriteLine();
            }
        }
    }
}
