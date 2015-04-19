using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var ctx = new CouponDBContext())
            {
                Coupon c = new Coupon() { CouponName = "New Coupon" };

                ctx.Coupons.Add(c);
                ctx.SaveChanges();
            }

        }
    }
}
