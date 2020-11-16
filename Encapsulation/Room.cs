using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Room
    {
        private int Number;
        private int size;
        private List<Customer> occupants;
        private bool clean;

        public int GetNumber()
        {
            return Number;
        }

        public Room(int number, int size, bool clean)
        {
            Number = number;
            this.size = size;
            this.occupants = new List<Customer>();
            this.clean = clean;
        }
        
        public void AddOccupant(Customer cust)
        {
            if (occupants.Count < size)
            {
                occupants.Add(cust);
                cust.feedback++;
            }
            else
            {
                cust.feedback--;
                return;
            }

            if (this.clean)
                cust.feedback++;
            else
                cust.feedback--;

            this.clean = false;
        }

        public void RemoveOccupant(Customer cust)
        {
            occupants.RemoveAll(c => c.name == cust.name);
        }

        public bool HasOccupant(Customer cust)
        {
            foreach (var o in occupants)
            {
                if (o.name == cust.name)
                {
                    return true;
                }
            }

            return false;
        }

        public void Clean()
        {
            this.clean = true;
        }
    }
}
