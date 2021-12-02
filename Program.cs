using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace p17_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Country> c = new List<Country>();
                int n = 0;
                while (true)
                {
                    Console.Write("численность населения страны должна быть больше: ");
                    n = int.Parse(Console.ReadLine());
                    if (n >= 0) { break; }
                }
                foreach (var item in File.ReadAllLines("file.txt"))
                {
                    string[] str = item.Split(' ');
                    string num = "";
                    for (int i = 1; i < str.Length; i++)
                    {
                        num += str[i];
                    }
                    int chisl = int.Parse(num);
                    c.Add(new Country { name = str[0], population = chisl });
                }
                foreach (var item in c.OrderBy(x => x.name.Length).Where(x => x.population > n).ToList())
                {
                    Console.WriteLine($"{item.name} {item.population}");
                }
            }
            catch { Console.WriteLine("неверные данные"); }
        }
    }
    class Country
    {
        public string name;
        public int population;
    }
}
