using CQRS.DefinitionExampleProject.Context;
using CQRS.DefinitionExampleProject.CQRS.Queries.Request;
using CQRS.DefinitionExampleProject.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.CQRS.Handlers.QueryHandlers
{
    public class GetAllProductQueryHandler
    {
        private readonly ApplicationDbContext _context;

        public GetAllProductQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<GetAllProductQueryResponse> GetAllProduct(GetAllProductQueryRequest getAllProductQueryRequest)
        {
            return _context.ProductList.Select(product => new GetAllProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateDate = product.CreateDate
            }).ToList();
        }
    }
}
