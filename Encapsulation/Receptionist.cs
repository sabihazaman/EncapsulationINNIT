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
            //addOccupant(hotel[customer.roomBooking - 1], customer);
            hotel.addOccupant(customer);
            Console.WriteLine(name + " checked in " + customer.name);
        }

        public void checkOut(Hotel hotel, Customer customer, Manager manager)
        {
            hotel.removeOccupant(customer);
            Console.WriteLine(name + " checked out " + customer.name);

            //removeOccupant(hotel[customer.roomBooking - 1], customer);

            //manager.review(customer, manager, hotel);

            manager.setFeedback();
        }
    }
}
