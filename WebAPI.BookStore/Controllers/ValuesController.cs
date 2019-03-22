using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using WebAPI.BookStore.Data;
using WebAPI.BookStore.Models;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData;
using System.Linq;

namespace WebAPI.BookStore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        [EnableQuery()]
        public ActionResult<IEnumerable<Value>> Get()
        {
            return DataSeed.GetValues();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<Value> Get(int id)
        {
            return DataSeed.GetValues().Where(x => x.Id == id).FirstOrDefault();
        }

        // POST api/values
        [HttpPost]
        public void Post(Value value)
        {
            DataSeed.UpdateValue(value);
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
