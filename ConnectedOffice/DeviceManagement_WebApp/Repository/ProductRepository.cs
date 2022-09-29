using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using System.Collections.Generic;
using System.Linq;

namespace DeviceManagement_WebApp.Repository
{
    public class ProductRepository              //ProductsRepository links with ProductsController and connects with the Database(CMPG323_P3)
    {
        protected readonly CMPG323_P3Context _context = new CMPG323_P3Context();

        // GET ALL: Products
        public IEnumerable<Product> GetAll()
        {
            return _context.Product.ToList();
        }

        // TO DO: Add ‘Get By Id’
        // TO DO: Add ‘Create’
        // TO DO: Add ‘Edit’
        // TO DO: Add ‘Delete’
        // TO DO: Add ‘Exists’
    }

}
