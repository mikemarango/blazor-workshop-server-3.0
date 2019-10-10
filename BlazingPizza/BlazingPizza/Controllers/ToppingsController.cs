using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazingPizza.Data;
using BlazingPizza.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BlazingPizza.Controllers
{
    [Route("[controller]"), ApiController]
    public class ToppingsController : Controller
    {
        public ToppingsController(PizzaContext context)
        {
            Context = context;
        }

        public PizzaContext Context { get; }

        [HttpGet]
        public async Task<List<Topping>> GetToppings()
        {
            return await Context.Toppings.OrderBy(t => t.Name).ToListAsync();
        }
    }
}
