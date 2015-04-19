using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CouponOrderSystem
{
    class Coupon
    {
        public Coupon()
        {
            CouponCounter++;
            CouponId = CouponCounter;
        }

        public int CouponId { get; set; }
        public static int CouponCounter = 0;

        [Required]
        [MaxLength(20)]
        public string CouponName { get; set; }

        [Required]
        public Category CouponCategory { get; set; }

        [Required]
        [Range(0,int.MaxValue)]
        public int OriginalPrice { get; set; }

        [Required]
        [Range(0, int.MaxValue)]
        public int DiscountPrice { get; set; }

        [Required]
        [MaxLength(200)]
        public string Description { get; set; }
        
        //public DateTime ExperationDate { get; set; }

        public  List<Costumer> BuyingCostumers { get; set; }
        public  Business Buisness { get; set; }

    }
}
