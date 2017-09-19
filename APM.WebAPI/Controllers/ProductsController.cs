using APM.WebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.OData;

namespace APM.WebAPI.Controllers
{
    [EnableCorsAttribute("http://localhost:57101", "*","*")]
    public class ProductsController : ApiController
    {
        // GET: api/Products
        [EnableQuery()]
        public IQueryable<Product> Get()
        {
            ProductRepository productRepository = new ProductRepository();
            return productRepository.Retrieve().AsQueryable();
        }
        /*
        // GET: api/Products
        public IEnumerable<Models.Product> Get(string search)
        {
            var productRepository = new Models.ProductRepository();
            var products = productRepository.Retrieve();
            return products.Where(p => p.ProductCode.Contains(search));
        }*/

        // GET: api/Products/5
        public Product Get(int id)
        {
            Product product;
            ProductRepository productRepository = new ProductRepository();
            if (id > 0)
            {
                var products = productRepository.Retrieve();
                product = products.FirstOrDefault(p => p.ProductId == id);
            }
            else {
                product = productRepository.Create();
            }
            return product;
        }

        // POST: api/Products
        public void Post([FromBody]Product product)
        {
            ProductRepository productRepository = new ProductRepository();
            Product newProduct = productRepository.Save(product);
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]Product product)
        {
            ProductRepository productRepository = new ProductRepository();
            Product updatedProduct = productRepository.Save(id, product);
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
