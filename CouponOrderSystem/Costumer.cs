using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    class Costumer : Person
    {        
        public List<Category> Prefrences { get; set; }
        public List<Coupon> CostumerCoupons { get; set; }
        public List<Coupon> CoustomerFavorites { get; set; }
    }
}
