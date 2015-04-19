using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CouponOrderSystem
{
    class Business
    {
        public Business()
        {
            businessCounter++;
            BusinessId = businessCounter;
        }

        public static int businessCounter = 0;
        public int BusinessId { get; set; }

        [RegularExpression(@"^\d+$")]
        public string PhoneNum { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        [MaxLength(20)]
        public string Address { get; set; }

        [Required]
        [MaxLength(20)]
        public string City { get; set; }
        
        [Required]
        [MaxLength(200)]
        public string Description { get; set; }

        [Required]
        public  Category BuisnessCategory { get; set; }

        [Required]
        public  BusinessOwner Owner { get; set; }

        [Required]
        public double x { get; set; }

        [Required]
        public double y { get; set; }

    }
}
