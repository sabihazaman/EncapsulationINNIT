using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class MC
    { 

        public MC()
        {
            List<Room> rooms = new List<Room>();
            rooms.Add(new Room(1, 1, false));
            rooms.Add(new Room(2, 2, false));
            rooms.Add(new Room(3, 1, false));

            Hotel hotel = new Hotel(rooms);

            Customer customer1 = new Customer(1, "Mrs. White");
            Customer customer2 = new Customer(2, "Mr. Green");
            Customer customer3 = new Customer(2, "Miss. Scarlett");
            Customer customer4 = new Customer(3, "Mrs. Peacock");
            Customer customer5 = new Customer(2, "Prof. Plum");
            Customer customer6 = new Customer(3, "Col. Mustard");

            Receptionist receptionist = new Receptionist("Jane");
            Cleaner cleaner = new Cleaner("Michael");
            Manager manager = new Manager("Janhavi");

            receptionist.checkIn(hotel, customer1);
            receptionist.checkIn(hotel, customer2);
            receptionist.checkIn(hotel, customer3);
            receptionist.checkOut(hotel, customer1, manager);

            cleaner.cleanRooms(hotel, cleaner);

            receptionist.checkIn(hotel, customer4);
            receptionist.checkOut(hotel, customer4, manager);
            receptionist.checkIn(hotel, customer5);
            receptionist.checkOut(hotel, customer5, manager);
            receptionist.checkOut(hotel, customer2, manager);
            receptionist.checkOut(hotel, customer3, manager);

            cleaner.cleanRooms(hotel, cleaner);

            receptionist.checkIn(hotel, customer6);
            receptionist.checkOut(hotel, customer6, manager);
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            new MC();
        }
    }
}

/*
       static void addOccupant(Room room, Customer occupantIn)
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

       static void removeOccupant(Room room, Customer occupantOut)
       {
           int index = -1;
           for (int i = 0; i < room.occupants.Count; i++)
           {
               if (string.Equals(room.occupants[i], occupantOut))
                   index = i;
           }
           if (index != -1)
               room.occupants.RemoveAt(index);
       }

       static void takeFeedback(Manager manager, Customer customer)
       {
           if (customer.feedback > 0)
               Console.WriteLine(manager.name + " says: " + customer.name + " was happy with their stay!");
           else if (customer.feedback < 0)
               Console.WriteLine(manager.name + " says: " + customer.name + " was unhappy with their stay!");
           else
               Console.WriteLine(manager.name + " says: " + customer.name + " found their stay ok.");
       }

       static void cleanRooms(Cleaner cleaner, List<Room> hotel)
       {
           for (int i = 0; i < hotel.Count; i++)
           {
               if (hotel[i].occupants.Count == 0)
               {
                   hotel[i].clean = true;
                   Console.WriteLine(cleaner.name + " cleaned Room " + hotel[i].number);
               }
           }
       }

       static void checkIn(Receptionist receptionist, List<Room> hotel, Customer customer)
       {
           addOccupant(hotel[customer.roomBooking - 1], customer);
           Console.WriteLine(receptionist.name + " checked in " + customer.name);
       }

       static void checkOut(Receptionist receptionist, List<Room> hotel, Customer customer, Manager manager)
       {
           removeOccupant(hotel[customer.roomBooking - 1], customer);
           Console.WriteLine(receptionist.name + " checked out " + customer.name);
           takeFeedback(manager, customer);
       }
       */
