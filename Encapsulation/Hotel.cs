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

            if (room.occupants.Count < room.size)
            {
                room.occupants.Add(occupantIn);
                occupantIn.feedback++;
            }
            else
            {
                occupantIn.feedback--;
                return;
            }
            if (room.clean == true)
                occupantIn.feedback++;
            else
                occupantIn.feedback--;
            room.clean = false;
        }
        public void removeOccupant(Customer customer)
        {

        }
        public void cleanRooms(Cleaner cleaner)
        {

        }
    }
}