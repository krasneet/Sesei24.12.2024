using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Room
    {
        public string Name { get; set; }
        public double Area { get; set; } 

        public Room(string name, double area)
        {
            Name = name;
            Area = area;
        }

        
        public void Show()
        {
            Console.WriteLine($"Команата: {Name}, площадь: {Area} квМ");
        }
    }
}