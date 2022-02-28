using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
namespace Catalog.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ItemController : ControllerBase
    {
        private readonly IItemRepository _repo;
        public ItemController(IItemRepository repo)
        {
           
            _repo = repo;
        }

        [HttpGet]
        public ActionResult<Item> GetItems()
        {
            return Ok(_repo.GetItems());
        }

        [HttpGet("{id}")]
        public ActionResult<Item> GetItem(Guid id){
            var result=_repo.getItem(id);
            if(result is null)
                return NotFound();
            return Ok(result);
        }
    }
}