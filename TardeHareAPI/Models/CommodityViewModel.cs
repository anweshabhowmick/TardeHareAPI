using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TardeHareAPI.Models
{
    public class CommodityViewModel
    {
        public int ComId { get; set; }
        public string CommodityName { get; set; }
        public string CommoditySpec { get; set; }
        public string TradeRules { get; set; }
        public byte Active { get; set; }
        public System.DateTime Updt_Time { get; set; }
    }
}