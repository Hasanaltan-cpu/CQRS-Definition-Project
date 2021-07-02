using CQRS.DefinitionExampleProject.Context;
using CQRS.DefinitionExampleProject.CQRS.Commands.Request;
using CQRS.DefinitionExampleProject.CQRS.Commands.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CQRS.DefinitionExampleProject.CQRS.Handlers.CommandHandlers
{
    public class DeleteProductCommandHandler
    {
        private readonly ApplicationDbContext _context;

        public DeleteProductCommandHandler(ApplicationDbContext context)
        {
            _context = context;
        }

        public DeleteProductCommandResponse DeleteProduct(DeleteProductCommandRequest deleteProductCommandRequest)
            {
                var deleteProduct = _context.ProductList.FirstOrDefault(p => p.Id == deleteProductCommandRequest.Id);
                _context.ProductList.Remove(deleteProduct);

                return new DeleteProductCommandResponse
                {
                    IsSuccess = true
                };
            }
       
    }
}
