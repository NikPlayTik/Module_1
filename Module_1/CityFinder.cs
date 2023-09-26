using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    class CityFinder
    {
        public static void FindCityIndex()
        {
            // массив 5 городов
            string[] cities =
            {
                "Минск",
                "Орша",
                "Витебск",
                "Могилев",
                "Брест"
            };

            // ввод названия города
            Console.Write("Введите название города: ");
            string cityName = Console.ReadLine();

            // приведение названия введенного города к нижнему регистру для последуйщего сравнения
            string cityName_temp = cityName.ToLower();

            // флаг для результата поиска
            bool flag_search = false;

            // цикл поиска города в массиве
            for (int i = 0; i < cities.Length; i++)
            {
                // условие, приведение всех городов к нижнему регистру и сравнение
                // по индексу каждый город из временной переменной
                if (cities[i].ToLower() == cityName_temp)
                {
                    Console.WriteLine($"Город {cityName}, найден, его индекс: {i}");
                    flag_search = true;
                    break;
                }
            }

            // условие если не будет найден город 
            if (!flag_search)
            {
                Console.WriteLine($"Данный город {cityName}, не найден");
            }

            Console.ReadLine();
        }
    }
}
