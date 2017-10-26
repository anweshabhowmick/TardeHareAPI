using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TardeHareAPI.Models;

namespace TardeHareAPI.Controllers
{
    public class CommodityController : ApiController
    {
        TRADEHAREDBEntities objentites = new TRADEHAREDBEntities();

       
        public IEnumerable<CommodityList> GetAllCommodity()
        {
            var result = objentites.GetCommodity(0, "").AsEnumerable();
            return result;
        }

        
        public IHttpActionResult PostAddCommodity(CommodityViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.AddCommodity(objcomm.CommodityName, objcomm.CommoditySpec, objcomm.TradeRules, 1, objParam);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
