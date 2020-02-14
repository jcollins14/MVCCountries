using System;

namespace MVCCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiates the CountryController class and starts its actions
            CountryController app = new CountryController();

            app.WelcomeAction();
        }
    }
}
