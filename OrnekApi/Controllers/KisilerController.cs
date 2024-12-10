using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrnekApi.Data;

namespace OrnekApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class KisilerController : ControllerBase
    {
        // GET: api/Kisiler
        [HttpGet]
        public List<Kisi> Get()
        {
            return Veri.Kisiler();
        }

        // GET: api/Kisiler/3
        [HttpGet("{id}")]
        public ActionResult<Kisi> Get(int id)
        {
            Kisi? kisi = Veri.Kisiler().FirstOrDefault(x => x.Id == id);

            if (kisi == null)
                return NotFound();

            return kisi;
        }
    }
}
