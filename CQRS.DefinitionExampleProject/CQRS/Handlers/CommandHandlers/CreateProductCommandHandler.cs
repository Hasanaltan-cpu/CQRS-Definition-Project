using CQRS.DefinitionExampleProject.Context;
using CQRS.DefinitionExampleProject.CQRS.Commands.Request;
using CQRS.DefinitionExampleProject.CQRS.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.CQRS.Handlers.CommandHandlers
{
    public class CreateProductCommandHandler
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CreateProductCommandHandler(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public CreateProductCommandResponse CreateProduct(CreateProductCommandRequest createProductCommandRequest)
        {
            var id = Guid.NewGuid();
            _applicationDbContext.ProductList.Add(new()
            {
                Id = id,
                Name = createProductCommandRequest.Name,
                Price = createProductCommandRequest.Price,
                Quantity = createProductCommandRequest.Quantity,
                CreateDate = DateTime.Now
            });
            return new CreateProductCommandResponse
            {
                IsSuccess = true,
                ProductId = id,
            };
        }

    }
}
