using CQRS.DefinitionExampleProject.Context;
using CQRS.DefinitionExampleProject.Models;
using CQRS.DefinitionExampleProject.VMs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.Services
{
    public class ProductService
    {
        private readonly ApplicationDbContext _context;

        public ProductService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<ProductReadVM> GetProducts()
        {
            var productList =_context.ProductList;
            return productList.Select(product => new ProductReadVM
            {
                Id = product.Id,
                Name = product.Name,
                CreateDate = product.CreateDate
            }).ToList();
        }

        public void CreateProduct(ProductCreateVM product)
        {
            var productModel = new Product
            {
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity
            };
            _context.ProductList.Add(productModel);
        }



    }
}
