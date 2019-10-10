using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlazingPizza.Models
{
    public class Address
    {
        public int Id { get; set; }

        //[Required, MaxLength(100)]
        public string Name { get; set; }

        //[Required, MaxLength(100)]
        public string Line1 { get; set; }

        //[MaxLength(100)]
        public string Line2 { get; set; }

        //[Required, MaxLength(50)]
        public string City { get; set; }

        //[Required, MaxLength(20)]
        public string Region { get; set; }

        //[Required, MaxLength(20)]
        public string PostalCode { get; set; }
    }
}
