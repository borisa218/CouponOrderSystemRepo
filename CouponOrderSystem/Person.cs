using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CouponOrderSystem
{
    abstract class Person
    {
        public Person()
        {
            PersonCounter++;
            PersonId = PersonCounter;
        }


        public static int PersonCounter = 0;
        public int PersonId { get; set; }

        [RegularExpression(@"^\d+$")]
        public string PhoneNum { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        [MaxLength(20)]
        public string Name { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        [MaxLength(10)]
        public string Password { get; set; }

        [Required]
        [Range(18, 120)]
        public int Age { get; set; }

        [Required]
        public Sex Sex { get; set; }
    }


    public enum Sex
    {
        Female,
        Male
    }

    public enum Category
    {
        Sports,
        Food,
        Shoping,
        HelpAndBeauty
    }
}
