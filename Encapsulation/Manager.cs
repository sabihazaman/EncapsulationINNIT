using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
    public class Manager
    {
        public string name;
        private string feedback;

        public Manager(string name)
        {
            this.name = name;
        }

        public string takeFeedback(Manager manager, Customer customer)
        {
            if (customer.feedback > 0)
                Console.WriteLine(manager.name + " says: " + customer.name + " was happy with their stay!");
            else if (customer.feedback < 0)
                Console.WriteLine(manager.name + " says: " + customer.name + " was unhappy with their stay!");
            else
                Console.WriteLine(manager.name + " says: " + customer.name + " found their stay ok.");

            return feedback;
            
        }
        public void setFeedback(string review)
        {
            feedback = review;
        }
    }
}
