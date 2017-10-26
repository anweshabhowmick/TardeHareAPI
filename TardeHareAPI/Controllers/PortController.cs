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
    public class PortController : ApiController
    {
        TRADEHAREDBEntities objentites = new TRADEHAREDBEntities();

        [Route("api/Port/PortDetail")]
        [HttpGet]
        public IEnumerable<PortList> PortDetail(int id, string type)
        {
            var result = objentites.GetAllPorts(id, type).AsEnumerable();
            return result;
        }
        [Route("api/Port/AddPort")]
        [HttpPost]
        public IHttpActionResult AddPort(PortViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.AddPort(objcomm.PortName, objcomm.PortType, objcomm.UserId, objParam);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
        [Route("api/Port/UpdatePort")]
        [HttpPost]
        public IHttpActionResult UpdatePort(PortViewModel objcomm)
        {
            try
            {
                ObjectParameter objParam = new ObjectParameter("id", typeof(int));
                var result = objentites.UpdatePort(objcomm.PortId, objcomm.PortName,objcomm.PortType,objcomm.Active,objcomm.UserId);
                return Ok(objParam.Value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);

            }
        }
    }
}
