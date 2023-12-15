using System;
using System.Collections.Generic;
using System.Text;
using Velasquez14.Models;

namespace Velasquez14.Services
{
    public class CompraService
    {
        private readonly DataContext.AppDbContext _context;

        public CompraService() => _context = App.GetContext();


        public bool Create(Compra item)
        {
            try
            {
                //EntityFrameworkCore
                _context.Compras.Add(item);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }



        public bool CreateRange(List<Compra> items)
        {
            try
            {
                //EntityFrameworkCore
                _context.Compras.AddRange(items);
                _context.SaveChanges();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public List<Compra> Get()
        {
            return _context.Compras.ToList();
        }


        public List<Compra> GetByText(string text)
        {
            return _context.Compras.Where(x => x.Name.Contains(text)).ToList();
        }
    }
}
