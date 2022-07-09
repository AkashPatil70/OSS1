using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using WebAPIProject.Models;
using WebAPIProject.DAL;

namespace WebAPIProject.Controllers
{
    public class FlowersController : ApiController
    {
        DbORMContext entities = new DbORMContext();
        // GET: api/Flowers
        public IEnumerable<Product> Get()
        {
            List<Product> products = entities.Products.ToList();
            return products;
        }

        // GET: api/Flowers/5
        public Product Get(int id)
        {
            var product = entities.Products.SingleOrDefault(p => p.Id == id);
            return product;
        }

        // POST: api/Flowers
        public void Post([FromBody]Product product)
        {
            entities.Products.Add(product);

            entities.SaveChanges();
        }
    

        // PUT: api/Flowers/5
        public void Put(int id, [FromBody] Product  product)
        {
            entities.Entry(product).State = System.Data.Entity.EntityState.Modified;
            entities.SaveChanges();
        }

        // DELETE: api/Flowers/5
        public void Delete(int id)
        {
            var product = entities.Products.SingleOrDefault(p => p.Id == id);
            entities.Products.Remove(product ?? throw new InvalidOperationException());
            entities.SaveChanges();   // to reflect changes back to database by Entity framework

        }
    }
}
