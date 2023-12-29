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
                _bookSale = new();
                _bookSale.Title = txtTitle.Text ?? "";
                _bookSale.Price = decimal.Parse(txtPrice.Text);
                _bookSale.Quantity = int.Parse(txtQuantity.Text);

                txtTotal.Text = _bookSale.ExtentedPrice.ToString("C");
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
            txtTotal.Text = "";
            //chkStudentDiscount.Checked = false;

        }
    }
}