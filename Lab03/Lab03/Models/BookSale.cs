using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Lab03.Models
{
    internal class BookSale
    {
        private string? title;
        private int quantity;
        private decimal price;

        public decimal ExtentedPrice
        {
            get
            {
                var extendedPrice = this.Quantity * this.Price;
                return extendedPrice;
            }
        }

        public string? Title { get => title; set => title = value; }

        public int Quantity
        {
            get => quantity;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Quantity), "Quantity must be positive.");
                }
                quantity = value;
            }
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException(nameof(Price), "Price must be positive.");
                }
                price = value;
            }
        }
    }
}
