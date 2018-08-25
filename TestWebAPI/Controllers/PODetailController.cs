using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TestWebAPI.Models;

namespace TestWebAPI.Controllers
{
    public class PODetailController : ApiController
    {
        PODetail[] PODetails = new PODetail[]
        {
            new PODetail{PONO="P001", PODATE="08/10/2018", SUPLNAME="DELL", QTY=3, ITDESC="Laptop", ITAMOUNT = 20000},
            new PODetail{PONO="P002", PODATE="08/02/2018", SUPLNAME="Microsoft", QTY=5, ITDESC="Computer", ITAMOUNT = 15000},
            new PODetail{PONO="P003", PODATE="08/01/2018", SUPLNAME="IBM", QTY=4, ITDESC="Mouse", ITAMOUNT = 2000},
           new PODetail{PONO="P004", PODATE="08/09/2018", SUPLNAME="DELL", QTY=8, ITDESC="Processor", ITAMOUNT = 4000}
        };
        public IEnumerable<PODetail> GetAllPODetail()
        {
            return PODetails;
        }

        // GET api/podetail/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/podetail
        public void Post([FromBody]string value)
        {
        }

        // PUT api/podetail/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/podetail/5
        public void Delete(int id)
        {
        }
    }
}
