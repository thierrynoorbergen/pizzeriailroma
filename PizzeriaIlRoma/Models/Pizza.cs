using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Models
{
    public class Pizza
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ICollection<PizzaIngredient> PizzaIngredients { get; set; }
        public string ImageUrl { get; set; }
    }
}
