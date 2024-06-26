﻿using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.Features.Brands.Commands;
using WebApi.Application.Features.Brands.Queries;
using WebApi.Application.Features.Products.Commands.CreateProduct;
using WebApi.Application.Features.Products.Commands.DeleteProduct;
using WebApi.Application.Features.Products.Commands.UpdateProduct;
using WebApi.Application.Features.Products.Queries.GetAllProducts;

namespace WebApi.ApiUI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator mediator;

        public ProductController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllProducts()
        {
            var response = await mediator.Send(new GetAllProductQueryRequest());
            return Ok(response);
        }
        [HttpPost]
        public async Task<IActionResult> CreateProduct(CreateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpPut]
        public async Task<IActionResult> UpdateProduct(UpdateProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        [HttpDelete]
        public async Task<IActionResult> RemoveProduct(DeleteProductCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }

        //BRAND TEST
        [HttpPost]
        public async Task<IActionResult> CreateBrand(CreateBrandCommandRequest request)
        {
            await mediator.Send(request);
            return Ok();
        }
        public async Task<IActionResult> GetAllBrands()
        {
            var response = await mediator.Send(new GetAllBrandsQueryRequest());
            return Ok(response);
        }
    }
}
