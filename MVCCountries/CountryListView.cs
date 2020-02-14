using System;
using System.Collections.Generic;
using System.Text;

namespace MVCCountries
{
    class CountryListView
    {
        public List<Country> Countries { get; set; }

        public CountryListView(List<Country> country)
        {
            this.Countries = country;
        }
        public void Display()
        {
            //loops through the Country List and displays each country along with a selection integer
            for (int i = 0; i < Countries.Count; i++)
            {
                Country a = Countries[i];
                Console.WriteLine((i+1) + ": " + a.Name);
            }
        }
    }
}
