using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Models
{
    public class PizzaTopping
    {
        public Topping Topping { get; set; }

        public int ToppingId { get; set; }

        public int PizzaId { get; set; }
    }
}
