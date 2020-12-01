using Microsoft.EntityFrameworkCore;
using PizzeriaIlRoma.Contracts.Repositories;
using PizzeriaIlRoma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Repositories
{
    public class PizzaRepository : IPizzaRepository
    {
        private readonly ApplicationDbContext _context;

        public PizzaRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CreatePizza(Pizza pizza)
        {
            _context.Add(pizza);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public async Task<IEnumerable<Pizza>> GetPizzas()
        {
            var pizzas = await _context.Pizzas.ToListAsync().ConfigureAwait(false);
            return pizzas;
        }
    }
}
