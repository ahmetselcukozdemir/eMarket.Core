using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eMarket.Core.Web.UI.Models.Home
{
    public class SellersModel
    {
        public List<Entity.Member> LastAddSellers { get; set; }
        public List<Entity.Member> StarSellers { get; set; }
        public List<Entity.Member> GetAllSellers { get; set; }
    }
}
