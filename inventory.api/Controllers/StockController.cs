using Microsoft.AspNetCore.Mvc;
using inventory.api.Models;
using inventory.api.Repository;

namespace inventory.api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StockController : GenericController<Stock, IRepository<Stock>>
    {
        public StockController(IRepository<Stock> repository) : base(repository)
        {
        }
    }
}