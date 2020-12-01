using PizzeriaIlRoma.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PizzeriaIlRoma.Contracts.Services
{
    public interface IPizzasService
    {
        Task CreatePizza(Pizza pizza);
        Task<IEnumerable<Pizza>> GetPizzas();

    }
}
