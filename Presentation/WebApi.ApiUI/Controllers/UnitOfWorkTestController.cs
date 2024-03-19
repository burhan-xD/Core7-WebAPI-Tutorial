using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApi.Application.Interfaces.UnitOfWorks;
using WebApi.Domain.Entities;

namespace WebApi.ApiUI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class UnitOfWorkTestController : ControllerBase
    {
        private readonly IUnitOfWork unitOfWork;

        public UnitOfWorkTestController(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var value = await unitOfWork.GetReadRepository<Product>().GetAllAsync();
            return Ok(value);
        }
    }
}
