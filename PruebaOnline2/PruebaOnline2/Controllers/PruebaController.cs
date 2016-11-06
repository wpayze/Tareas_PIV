using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PruebaOnline2.Controllers
{
    public class PruebaController : ApiController
    {
        [Route("api/Prueba/{id}/triple")]
        [HttpGet]
        public int GetTriple(int id)
        {
            return id * 3;
        }

        // GET: api/Prueba
        public IEnumerable<int> Get()
        {
            return new int[] { 1, 2, 3, 4, 5 };
        }

        // GET: api/Prueba/5
        public int Get(int id)
        {
            return id * 2;
        }
        
        // POST: api/Prueba
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Prueba/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Prueba/5
        public string Delete(int id)
        {
            return "Eliminado";
        }
    }
}
