using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TardeHareAPI.Models
{
    public class PortViewModel
    {
        public int PortId { get; set; }
        public string PortName { get; set; }
        public string PortType { get; set; }
        public byte Active { get; set; }
        public System.DateTime Updt_Time { get; set; }
        public byte UserId { get; set; }
    }
}