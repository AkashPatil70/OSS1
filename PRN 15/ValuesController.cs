using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPIProject.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "PGDAC", "PGDBDA", "DIOT", "DITTS","FullStack" };
        }

        // GET api/values/5
        public string Get(int id)
        {
            string result=string.Empty;
            switch (id)
            {
                case 1:
                    result = "PGDAC";
                    break;
                case 2:
                    result = "PGDBDA";
                    break;
                case 3:
                    result = "DIOT";
                    break;
                case 4:
                    result = "DITS";
                    break;
                case 5:
                    result = "FullStack";
                    break;

            }
            return result;
        }

        // POST api/values
        public void Post([FromBody] string value)
        {
            string dataReceived = value;

        }

        // PUT api/values/5
        public void Put(int id, [FromBody] string value)
        {
            int idWhoseDataTobeUpdated = id;
            string datatobeUpdated = value;

        }

        // DELETE api/values/5
        public void Delete(int id)
        {
            int idWhoseDataTobeDeleted = id;
        }
    }
}
