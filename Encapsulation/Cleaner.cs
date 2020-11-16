using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Cleaner
    {
        private string name;

        public Cleaner(string name)
        {
            this.name = name;
        }

        public void cleanRooms(Hotel hotel, Cleaner cleaner)
        {
            hotel.cleanRooms(cleaner);
        }

    }
}
