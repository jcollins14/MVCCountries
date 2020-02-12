using System;

namespace MVCCountries
{
    class Program
    {
        static void Main(string[] args)
        {
            CountryController app = new CountryController();

            app.WelcomeAction();
        }
    }
}
