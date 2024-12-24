using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Apartment
    {
        public string Number { get; set; } 
        public string Owner { get; set; }   
        public List<Room> Rooms { get; set; } 

        public Apartment(string number, string owner)
        {
            Number = number;
            Owner = owner;
            Rooms = new List<Room>();
        }

        
        public void AddRoom(Room room)
        {
            Rooms.Add(room);
        }

        
        public void ShowAll()
        {
            Console.WriteLine($"Номер кв: {Number}, Владелец: {Owner}");
            foreach (var room in Rooms)
            {
                room.Show();//Салов Даниил
            }
        }
    }
}
