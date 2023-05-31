using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/**
 * The Interface IContextualisationRsc.
 *
 * @author HNabli
 * @since 1 oct. 2018
 */

namespace Trader.Domain.Models
{
    public class Asset
    {
        public string Symbol { get; set; }
        public double PricePerShare { get; set; }
    }
}
