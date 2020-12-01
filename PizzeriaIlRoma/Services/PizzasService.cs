using Microsoft.EntityFrameworkCore;
using PizzeriaIlRoma.Contracts.Repositories;
using PizzeriaIlRoma.Contracts.Services;
using PizzeriaIlRoma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Services
{
    public class PizzasService : IPizzasService
    {
        private readonly IPizzaRepository _repository;

        public PizzasService(IPizzaRepository repository)
        {
            _repository = repository;
        }

        public async Task CreatePizza(Pizza pizza)
        {
            await _repository.CreatePizza(pizza).ConfigureAwait(false);
        }

        public async Task<IEnumerable<Pizza>> GetPizzas()
        {
            return await _repository.GetPizzas().ConfigureAwait(false);
        }
    }
}
