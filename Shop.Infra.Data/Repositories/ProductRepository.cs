using Shop.Domain.Entities;
using Shop.Domain.Interfaces;
using Shop.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Infra.Data.Repositories
{
    public class ProductRepository: IProductRepository
    {

        public AppDbContext _context;

        public ProductRepository(AppDbContext context)
        {
            _context = context;
        }


        public IEnumerable<Product> GetProducts()
        {
           return _context.Products;
        }
    }
}
