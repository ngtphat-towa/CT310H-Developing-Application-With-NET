namespace Lab03.Models
{
    internal class BookSale
    {
        public BookSale(string title,
                        int quantity,
                        decimal price,
                        bool isDiscount
        ){
            this.title = title;
            this.quantity = quantity;
            this.price = price;
            this.isDiscount = isDiscount;
        }
        private string title;
        private int quantity;
        private decimal price;
        private bool isDiscount;

        public static int SaleCount = 0;
        public static decimal TotalSales = 0;
        public const decimal DISCOUNT_RATE = (decimal)0.1F;



        public virtual decimal DiscountAmount => IsDiscount 
                ? Quantity * Price * DISCOUNT_RATE 
                : 0M;
        public decimal ExtentedPrice => Quantity * Price;
        public decimal NetDue
        {
            get
            {
                var netDue = ExtentedPrice - DiscountAmount;
                TotalSales += netDue;
                SaleCount+=1;
                return netDue;
            }
        }
        public string Title { get => title; set => title = value; }

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

        public bool IsDiscount { get => isDiscount; set => isDiscount = value; }
    }
}
