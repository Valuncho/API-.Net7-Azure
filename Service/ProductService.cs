using API_.Net_Azure.DataAcces;
using API_.Net_Azure.DTOs;
using API_.Net_Azure.Models;
using Microsoft.Identity.Client;

namespace API_.Net_Azure.Service
{
    public class ProductService : IProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void CreatedProduct(Product product)
        {
            // Este metodo esta trabajando sobre el Modelo y no sobre el Dto *falta arreglar*
            Product productEntity = new()
            {
                Name = product.Name,
                Description = product.Description,
                Stock = product.Stock,
                CreateDate = DateTime.Now,
            };
            _context.Products.Add(productEntity);
            _context.SaveChanges();
        }

        public void DeleteProduct(int id)
        {

        }

        public Product GetProductById(int id)
        {
            return _context.Products.SingleOrDefault(p => p.Id == id);
        }
    }
}
