using DDDFirstLook.Domain.Products;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDFirstLook.Infrastructure.Products
{
    public class ProductRepository : IProductRepository
    {
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            var product1 = new Product(1, "Product 1");
            product1.AddAvailability("black", 10);

            var product2 = new Product(2, "Product 2");
            product2.AddAvailability("red", 23);
            return new List<Product>()
            {
                product1, product2
            };
        }

        public Product GetById(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public Product Insert(Product product)
        {
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
