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
        public IQueryable<Models.Product> Get()
        {
            var productRepository = new Models.ProductRepository();
            return productRepository.Retrieve().AsQueryable();
        }

        // GET: api/Products
        public IEnumerable<Models.Product> Get(string search)
        {
            var productRepository = new Models.ProductRepository();
            var products = productRepository.Retrieve();
            return products.Where(p => p.ProductCode.Contains(search));
        }

        // GET: api/Products/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Products
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Products/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Products/5
        public void Delete(int id)
        {
        }
    }
}
