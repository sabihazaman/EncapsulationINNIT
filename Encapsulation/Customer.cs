using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Customer {
    public int roomBooking;
    public string name;
    public int feedback;

    public Customer(int roomBooking, string name) {
        this.roomBooking = roomBooking;
        this.name = name;
        this.feedback = 0;
    } 		
}
}
