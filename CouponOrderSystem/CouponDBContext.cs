using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace CouponOrderSystem
{
    class CouponDBContext : DbContext
    {
        public CouponDBContext(): base()
        {

        }

        public DbSet<Person> Persons { get; set; }
        public DbSet<Coupon> Coupons { get; set; }
        public DbSet<Business> Businesses { get; set; }


    }
}
