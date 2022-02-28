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
            return Ok(repo.GetItems());
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id){
            var result=repo.getItem(id);
            if(result is null)
                return NotFound();
            return Ok(result);
        }
    }
}