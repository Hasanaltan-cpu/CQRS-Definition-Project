using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CQRS.DefinitionExampleProject.CQRS.Commands.Request;
using CQRS.DefinitionExampleProject.CQRS.Commands.Response;
using CQRS.DefinitionExampleProject.CQRS.Queries.Request;
using CQRS.DefinitionExampleProject.CQRS.Queries.Response;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CQRS.DefinitionExampleProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        IMediator _mediator;

        public ProductController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GetAllProductQueryRequest requestModel)
        {
            List<GetAllProductQueryResponse> allProducts = (List<GetAllProductQueryResponse>)await _mediator.Send(requestModel);
            return Ok(allProducts);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get([FromQuery] GetByIdProductQueryRequest requestModel)
        {
            GetByIdProductQueryResponse product = (GetByIdProductQueryResponse)await _mediator.Send(requestModel);
            return Ok(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] CreateProductCommandRequest requestModel)
        {
            CreateProductCommandResponse response = (CreateProductCommandResponse)await _mediator.Send(requestModel);
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete([FromQuery] DeleteProductCommandRequest requestModel)
        {
            DeleteProductCommandResponse response = (DeleteProductCommandResponse)await _mediator.Send(requestModel);
            return Ok(response);
        }
    }
}
