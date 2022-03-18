using Domainlayer;
using RepositoryLayer;
using System;

namespace BussinessLayer
{
    public class ProductCatalog : IProductCatalog
    {
        ProductDbContext _context;
        IRepositoryOperations<Product> _repo; 
        public ProductCatalog(ProductDbContext context)
        {
            _context = context;
        }
        public void AddProduct(Product product)
        {
            _repo.Add(product);
        }
    }
}
