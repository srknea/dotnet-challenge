using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SiparisYonetimAPI.Application.Repositories;
using SiparisYonetimAPI.Domain.Entities;
using SiparisYonetimAPI.Persistence.Repositories;
//using SiparisYonetimAPI.Application.Abstractions;

namespace SiparisYonetimAPI.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly private IProductWriteRepository _productWriteRepository;
        readonly private IProductReadRepository _productReadRepository;

        public ProductsController(IProductWriteRepository productWriteRepository, IProductReadRepository productReadRepository)
        {
            _productWriteRepository = productWriteRepository;
            _productReadRepository = productReadRepository;
        }

        [HttpGet]
        public async Task Get()
        {
            await _productWriteRepository.AddRangeAsync(new()
            {
                new () {Id = 1, FirmId = 132, Name = "Product1", Stock = 100, Price = 100 },
                new () {Id = 2, FirmId = 132, Name = "Product1", Stock = 100, Price = 100 },
                new () {Id = 3, FirmId = 132, Name = "Product1", Stock = 100, Price = 100 },
            });
            var count = await _productWriteRepository.SaveAsync();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(string id)
        {
            Product product = await _productReadRepository.GetByIdAsync(id);
            return Ok(product);
        }


    }

}

/*
namespace SiparisYonetimAPI.API.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet]
        public IActionResult GetProducts()
        {
            var products = _productService.GetProducts();
            return Ok(products);
        }
    }

}
*/