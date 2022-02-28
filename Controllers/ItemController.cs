using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
namespace Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly InMemItemRepository repo;
        public ItemController()
        {
           
            repo = new InMemItemRepository();
        }

        [HttpGet]
        public ActionResult<Item> GetItems()
        {
            return Ok(repo.)
        }
    }
}