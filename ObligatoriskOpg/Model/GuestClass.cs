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
        public int Guest_No { get; set; }   
        public string Address { get; set; }

        public GuestClass(string name, int guestNo, string address)
        {
            Name = name;
            Guest_No = guestNo;
            Address = address;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Guest_No: {Guest_No}, Address: {Address}";
        }
    }
}
