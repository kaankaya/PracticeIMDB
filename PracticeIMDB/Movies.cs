using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeIMDB
{
    public class Movies
    {
        public string Name { get; set; }
        public double Point { get; set; }

        public Movies(string name, double point)
        {
            Name = name;
            Point = point;
        }

        public void DisplayMovie()
        {
            Console.WriteLine("*********************");
            Console.WriteLine($"Flim Adı : {Name} - IMDB Puanı : {Point}");
        }
    }
}
