using API_.Net_Azure.DataAcces;
using Microsoft.Identity.Client;

namespace API_.Net_Azure.Service
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            this._context = context;
        }

        public void CreatedProdutct()
        {

        }



    }
}
