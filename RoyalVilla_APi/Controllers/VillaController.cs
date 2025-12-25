using Microsoft.AspNetCore.Mvc;

namespace RoyalVilla_APi.Controllers
{
    [Route("api/villa")]
    [ApiController]
    public class VillaController : ControllerBase
    {
        [HttpGet]
        public string GetVillas()
        {
            return "get all villas";
        }

        [HttpGet("{id:int}")]
        public string GetVillaById(int id)
        {
            return $"get villa with id: {id}";
        }
    }
}
