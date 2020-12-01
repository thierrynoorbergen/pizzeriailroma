using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Models
{
    public class PizzaIngredient
    {
        public int PizzaIngredientId { get; set; }
        public int PizzaId { get; set; }
        public Pizza Pizza { get; set; }
        public int IngredientId { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
