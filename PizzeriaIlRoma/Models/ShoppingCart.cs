using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Models
{
    public class ShoppingCart
    {
        public int ID { get; set; }
        public List<Pizza> Pizzas { get; set; }
        
        public decimal Total
        {
            get
            {
                if(Pizzas.Count > 1)
                {
                    return Pizzas.Sum(p => p.Price);
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
