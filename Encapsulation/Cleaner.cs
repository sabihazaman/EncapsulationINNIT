using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Cleaner
    {
        private string Name;

        public Cleaner(string name)
        {
            Name = name;
        }

        public void cleanRooms(Hotel hotel, Cleaner cleaner)
        {
            hotel.cleanRooms(cleaner);
        }

        public string GetName()
        {
            return Name;
        }
    }
}
