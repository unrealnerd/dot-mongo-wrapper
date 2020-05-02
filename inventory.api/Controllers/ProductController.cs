using Microsoft.AspNetCore.Mvc;
using inventory.api.Models;
using inventory.api.Repository;

namespace inventory.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : GenericController<Product, IRepository<Product>>
    {
        public ProductController(IRepository<Product> repository) : base(repository)
        {
        }
    }
}