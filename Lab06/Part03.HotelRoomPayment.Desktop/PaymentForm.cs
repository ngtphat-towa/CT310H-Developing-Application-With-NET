using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Part03.HotelRoomPayment.Desktop
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
            PopulateRoomCombobox();
            ResetMenuContext();
        }
        private static readonly string connectionString = ConfigurationManager.ConnectionStrings["QLCBConnectionString"].ConnectionString;


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetMenuContext(true);
            txtContractNo.Text = (GetCurrentMaxInvoiceId()+1).ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var invoiceId = Convert.ToInt32(txtContractNo.Text);
            var guestName = txtCustomerName.Text;
            var idNumber = txtCustomerID.Text;
            var paymentAmount =Convert.ToDecimal(txtPayment.Text);
            var roomId = Convert.ToInt32(cbRoomNo.SelectedValue);

            SaveGuestInvoice(invoiceId, guestName, idNumber, paymentAmount, roomId);
            ResetMenuContext();
        }
        public bool SaveGuestInvoice(int invoiceId, string guestName, string idNumber, decimal paymentAmount, int roomId)
        {
            // Get current date and generate invoice ID
            DateTime currentDate = DateTime.Now;

            // Build SQL insert statement
            string sql = "INSERT INTO Guests (InvoiceID, GuestName, IDNumber, PaymentAmount, PaymentDate, RoomID) VALUES (@invoiceId, @guestName, @idNumber, @paymentAmount, @paymentDate, @roomId)";

            // Use try-catch block for safe database interaction
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@invoiceId", invoiceId);
                        command.Parameters.AddWithValue("@guestName", guestName);
                        command.Parameters.AddWithValue("@idNumber", idNumber);
                        command.Parameters.AddWithValue("@paymentAmount", paymentAmount);
                        command.Parameters.AddWithValue("@paymentDate", currentDate);
                        command.Parameters.AddWithValue("@roomId", roomId);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected == 1)
                        {
                            return true;
                        }
                        else
                        {
                            MessageBox.Show("Error saving guest invoice. No rows affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error saving guest invoice: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void PopulateRoomCombobox()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT RoomID, RoomName FROM dbo.Rooms", connection);

                    // Create a DataTable to hold the results
                    DataTable positionsTable = new DataTable();
                    adapter.Fill(positionsTable);

                    // Bind the combo box to the DataTable
                    cbRoomNo.DataSource = positionsTable;
                    cbRoomNo.DisplayMember = "RoomName";
                    cbRoomNo.ValueMember = "RoomID";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private int GetCurrentMaxInvoiceId()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "select MAX(InvoiceID) from dbo.Guests;";
                    SqlCommand command = new SqlCommand(query, connection);

                    connection.Open();
                    var result =   command.ExecuteScalar();
                    connection.Close();
                    return Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
        private void ResetMenuContext(bool isAddNew = false)
        {
            // Clear the context menu
            txtContractNo.Clear();
            txtCustomerName.Clear();
            cbRoomNo.SelectedIndex = -1;
            txtPayment.Clear();

            // Resset the default state
            btnSave.Enabled = isAddNew;
            btnAdd.Enabled = !isAddNew;
            txtContractNo.Focus();
        }
    }
}
