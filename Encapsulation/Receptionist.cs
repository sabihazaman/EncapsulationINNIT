using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Receptionist
    {
        private string name;

        public Receptionist(string name)
        {
            this.name = name;
        }

        public void checkIn(Hotel hotel, Customer customer)
        {
            // Longer way to do the one-liner below:
            //List<Room> rooms = hotel.checkRooms();
            //hotel.addOccupant(customer, rooms[customer.roomBooking - 1]);

            hotel.addOccupant(customer, hotel.checkRooms()[customer.roomBooking - 1]);
            Console.WriteLine(name + " checked in " + customer.name);
        }

        public void checkOut(Hotel hotel, Customer customer, Manager manager)
        {
            hotel.removeOccupant(customer);
            Console.WriteLine(name + " checked out " + customer.name);
            manager.takeFeedback(customer);
        }
    }
}
