using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trader.Domain.Models
{
    public class AssetTransaction : DomainObject
    {
        public int Id { get; set; }
        
        public Account Account { get; set; }
        public bool IsPurchase { get; set; }
        public Asset Asset { get; set; }
        public int Shares { get; set; }
        public DateTime DateProcessed { get; set; }

    }
}
