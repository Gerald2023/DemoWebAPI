using DemoApi.Data;
using DemoApi.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        //retrieve the injected demoDB context dependency from the constructor
     
        private readonly DemoDbContext _demoDbContext;
        public ProductController(DemoDbContext demoDbContext) => _demoDbContext = demoDbContext;

        [HttpGet]
        public ActionResult<IEnumerable<Product>> Get()
        {
            return _demoDbContext.Products;
        }
    }
}
