using Elevén.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevén.Data
{
    interface IFacturaService
    {
        Task<IEnumerable<Factura>> getAllFacturas();
        Task<Factura> getFacturaDetails(int id);
        Task<bool> insertFactura(Factura factura);
        Task<bool> updateFactura(Factura factura);
        Task<bool> deleteFactura(int id);
        Task<bool> saveFactura(Factura factura);



    }
}
