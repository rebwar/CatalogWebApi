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
        public ActionResult<ItemDto> GetItems()
        {
            return Ok(_repo.GetItems().Select(c=>c.AsDto()));
        }

        [HttpGet("{id}")]
        public ActionResult<ItemDto> GetItem(Guid id){
            var result=_repo.getItem(id);
            if(result is null)
                return NotFound();
            return Ok(result.AsDto());
        }
    }
}