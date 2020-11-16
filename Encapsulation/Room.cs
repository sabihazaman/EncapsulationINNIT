using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Room
    {
        private int number;
        private int size;
        private List<Customer> occupants;
        private bool clean;

        public Room(int number, int size, bool clean)
        {
            this.number = number;
            this.size = size;
            this.occupants = new List<Customer>();
            this.clean = clean;

            //return;

        }
        
    }
}
