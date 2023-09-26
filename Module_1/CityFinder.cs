using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class CityFinder
    {
        public static int FindCityIndex(string[] cities, string cityName)
        {
            for (int i = 0; i < cities.Length; i++)
            {
                if (cities[i].Equals(cityName, StringComparison.OrdinalIgnoreCase))
                    return i;
            }
            return -1; // Город не найден
        }
    }
}
