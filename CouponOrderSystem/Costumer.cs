using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    class Costumer : Person
    {
        public int CostumerId { get; set; }

        public virtual List<Category> Prefrences { get; set; }
        public virtual List<Coupon> CostumerCoupons { get; set; }
    }
}
