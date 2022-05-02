using Elevén.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Elevén.Data
{
    public class FacturaService : IFacturaService
    {
        public readonly MyDBContext _dbContext;

        public FacturaService(MyDBContext dBContext)
        {
            _dbContext = dBContext;
        }

        public async Task<bool> deleteFactura(int id)
        {
            var factura = await _dbContext.Factura.FindAsync(id);
            _dbContext.Factura.Remove(factura);
            return await _dbContext.SaveChangesAsync() > 0;
        }

        public async Task<IEnumerable<Factura>> getAllFacturas()
        {
            return await _dbContext.Factura.ToListAsync();
        }

        public async Task<Factura> getFacturaDetails(int id)
        {
            return await _dbContext.Factura.FindAsync(id);
        }

        public async Task<bool> insertFactura(Factura factura)
        {
            _dbContext.Factura.Add(factura);
            return await _dbContext.SaveChangesAsync()>0;
        }

        public async Task<bool> saveFactura(Factura factura)
        {
            if (factura.Id == 0)
               return await  insertFactura(factura);
            else
                return await updateFactura(factura);
        }

        public async Task<bool> updateFactura(Factura factura)
        {
            _dbContext.Entry(factura).State = EntityState.Modified;
            return await _dbContext.SaveChangesAsync() > 0;
        }
    }
}
