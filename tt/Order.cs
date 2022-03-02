using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tt
{
     public class Order
     {
       
        public Meal OrderMeal { get; set; }

        public override string ToString()
        {
            string text = "";
            foreach (Extra item in OrderScreen.sauces)
            {
                text +=" "+ item.Name;
            }

            return OrderMeal.Name + " " + "Meal" + " " + OrderMeal.MSize.SizeName + " x" + OrderMeal.MealCount + " Extras: " + text;
        }

        public double OrderPrice { get; set; }

        public  DateTime OrderDate { get; set; }



    }
}
