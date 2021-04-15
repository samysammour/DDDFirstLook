using AutoMapper;
using Bogus;
using DDDFirstLook.Domain.Products;
using DDDFirstLook.Infrastructure.Db;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DDDFirstLook.Infrastructure.Products
{
    public class ProductRepository : IProductRepository
    {
        private readonly IMapper mapper;

        public ProductRepository(IMapper mapper)
        {
            this.mapper = mapper;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll()
        {
            var generator = new Faker<ProductDbEntity>();
            var entities = generator.Generate(100);
            return this.mapper.Map<List<Product>>(entities);
        }

        public Product GetById(int id)
        {
            return this.GetAll().FirstOrDefault(x => x.Id == id);
        }

        public Product Insert(Product product)
        {
            // insert product
            // insert all addresses
            // insert all availability
            throw new NotImplementedException();
        }

        public Product Update(Product product)
        {
            throw new NotImplementedException();
        }
    }
}
