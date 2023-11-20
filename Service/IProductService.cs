using API_.Net_Azure.Models;

namespace API_.Net_Azure.Service
{
    public interface IProductService
    {
        void CreatedProduct(Product product);
        void DeleteProduct(int id);
        Product GetProductById(int id);
    }
}