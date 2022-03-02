using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tt
{
   
           
     public class Meal
    {
        
        public Meal()
        {

        }
        public Meal(string _name,double _price)
        {
            Name = _name;
            Price = _price;
        }
        public double Price { get; set; }
        public string Name { get; set; }
        
        public Sizee MSize { get; set; }
        public short MealCount { get; set; }

        public override string ToString()
        {
            return Name + " " + "Meal";

        }
        public Extra Extra { get; set; }

        public double TotalPrice 
        {
            get
            {
                double totalPrice;
                totalPrice = Price + MSize.AdditionalCost;
                return totalPrice;
            }
        }


    }
}
