using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibApp_Gr6.Models;

namespace LibApp_Gr6.ViewModels
{
    public class RandomBookViewModel
    {
        public Book Book { get; set; }
        public List<Customer> Customers { get; set; }

    }
}
