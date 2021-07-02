using CQRS.DefinitionExampleProject.Context;
using CQRS.DefinitionExampleProject.CQRS.Queries.Request;
using CQRS.DefinitionExampleProject.CQRS.Queries.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.CQRS.Handlers.QueryHandlers
{
    public class GetByIdProductQueryHandler
    {

        private readonly ApplicationDbContext _context;

        public GetByIdProductQueryHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public GetByIdProductQueryResponse GetByIdProduct(GetByIdProductQueryRequest getByIdProductQueryRequest)
        {
            var product = _context.ProductList.FirstOrDefault(p => p.Id == getByIdProductQueryRequest.Id);
            return new GetByIdProductQueryResponse
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Quantity = product.Quantity,
                CreateDate = product.CreateDate
            };
        }


    }
}
