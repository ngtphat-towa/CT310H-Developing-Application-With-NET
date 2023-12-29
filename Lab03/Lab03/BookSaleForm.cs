using Lab03.Models;

namespace Lab03
{
    public partial class BookSaleForm : Form
    {
        public BookSaleForm()
        {
            InitializeComponent();
        }
        private BookSale? _bookSale;

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void menuBtnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                _bookSale = new BookSale
                (
                    title: txtTitle.Text ?? "",
                    quantity: int.Parse(txtQuantity.Text),
                    price: decimal.Parse(txtPrice.Text),
                    isDiscount: cbIsNormalDiscount.Checked
                );
                txtExtendedPrice.Text = _bookSale.ExtentedPrice.ToString("C");
                txtDiscount.Text = _bookSale.DiscountAmount.ToString("C");
                txtNetDue.Text = _bookSale.NetDue.ToString("C");
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error in quantity or Price " + ex.Message,
                                caption: "Data Entry Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Exclamation);
            }
        }

        private void menuBtnClear_Click(object sender, EventArgs e)
        {
            // Clear text boxes
            txtTitle.Text = "";
            txtQuantity.Text = "";
            txtPrice.Text = "";
            txtExtendedPrice.Text = "";
            cbIsNormalDiscount.Checked = false;
            txtExtendedPrice.Text = "";
            txtDiscount.Text = "";
            txtNetDue.Text = "";
        }

        private void menuBtnSummary_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Total sales: {BookSale.SaleCount}\nTotal amount: {BookSale.TotalSales:C}", "Sales Summary", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void cbIsNormalDiscount_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}