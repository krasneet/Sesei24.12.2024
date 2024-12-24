using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Apartment myApartment = new Apartment("49А", "Салов Даниил");

            
            myApartment.AddRoom(new Room("Зал", 25.5));
            myApartment.AddRoom(new Room("Спальня", 18.0));
            myApartment.AddRoom(new Room("Кухня", 12.5));

            
            myApartment.ShowAll();//Салов Даниил

            Console.ReadLine();
        }
    }
}
