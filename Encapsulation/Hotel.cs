using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Hotel
    {
        private List<Room> rooms;

        public Hotel(List<Room> rooms)
        {
            this.rooms = rooms;
        }

        public List<Room> checkRooms()
        {
            return this.rooms;
        }

        public void addOccupant(Customer customer, Room room)
        {
            room.AddOccupant(customer);
        }

        public void removeOccupant(Customer customer)
        {
            foreach (var r in rooms)
            {
                if (r.HasOccupant(customer))
                {
                    r.RemoveOccupant(customer);
                }
            }
        }

        public void cleanRooms(Cleaner cleaner)
        {
            foreach (var r in rooms)
            {
                r.Clean();
                Console.WriteLine($"{cleaner.GetName()} cleaned room {r.GetNumber()}");
            }
        }
    }
}