using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObligatoriskOpg.Model
{
    public class GuestClass
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public GuestClass(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Address: {Address}";
        }
    }
}
