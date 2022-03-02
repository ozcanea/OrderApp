using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tt
{
    public class Extra
    {
        public Extra()
        { }
        public Extra(string _name, double _price)
        {
            Name = _name;
            Price = _price;
        }

        public string Name { get; set; }
        public double Price { get; set; }

    }
}
