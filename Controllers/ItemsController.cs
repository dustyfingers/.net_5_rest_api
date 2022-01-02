using Microsoft.AspNetCore.Mvc;
using Catalog.Repositories;
using Catalog.Entities;

namespace Catalog.Controllers
{

    // route is /items 
    [ApiController]
    // sets route to name of controller
    // [Route("[controller]")]
    [Route("items")]

    public class ItemsController : ControllerBase
    {
        private readonly InMemItemsRepository repository;

        public ItemsController()
        {

            repository = new InMemItemsRepository();

        }

        // GET /items
        [HttpGet]
        public IEnumerable<Item> GetItems()
        {

            var items = repository.GetItems();

            return items;

        }

    }

}