using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    class BusinessOwner : Person
    {
        public int BusinessOwnerId { get; set; }

        public virtual List<Business> BuisnessList { get; set; }
    }
}
