using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevén.Models
{
    public class Factura
    {
        public int Id { get; set; } 
        public string nameOwner { get; set; }
        public string email { get; set; }
        public string description { get; set; }
        public DateTime dateFacture   { get; set; }  
        public double price { get; set; }

        
    }
}
