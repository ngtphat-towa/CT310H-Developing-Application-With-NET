using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Models
{
    internal class StudentBookSale : BookSale
    {
        public StudentBookSale(string title,
                  int quantity,
                  decimal price,
                  bool isDiscount,
                  bool isStudent
        ) : base(
           title,
           quantity,
           price,
           isDiscount)
        {
            this.isStudent = isStudent;
        }
        public const decimal STUDENT_DISCOUNT_RATE = (decimal)0.15F;

        private bool isStudent;
        public bool IsStudent { get => isStudent; set => isStudent = value; }

        public override decimal DiscountAmount =>
            isStudent ?  ExtentedPrice * STUDENT_DISCOUNT_RATE
                       : base.DiscountAmount;
    }
}
