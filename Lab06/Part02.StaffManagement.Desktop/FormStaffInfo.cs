using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Part02.StaffManagement.Desktop
{


    public partial class FormStaffInfo : Form
    {
        public FormStaffInfo()
        {
            InitializeComponent();
            PopulatePositionCombobox();
            ResetMenuContext();
        }

        private static string connectionString = ConfigurationManager.ConnectionStrings["QLCBConnectionString"].ConnectionString;

        private int staffCode;
        private string staffName;
        private int positionCode;
        private int lectureHours;
        private decimal unitPrice;

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ResetMenuContext(true);
            staffCode = GetLatestStaffCode() + 1;
            txtNo.Text = staffCode.ToString();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            staffName = txtStaffName.Text;
            positionCode = Convert.ToInt32(cboStaffPosition.SelectedValue);
            lectureHours = Convert.ToInt32(updLectureHours.Value);
            unitPrice = upCostPerHour.Value;

            SaveStaffInforamtion();
            ResetMenuContext();
        }
        

        private void ResetMenuContext(bool isAddNew = false)
        {
            // Clear the context menu
            txtNo.Clear();
            txtStaffName.Clear();
            cboStaffPosition.SelectedIndex = -1;
            updLectureHours.Value = updLectureHours.Minimum;
            upCostPerHour.Value = upCostPerHour.Minimum;

            // Resset the default state
            btnSave.Enabled = isAddNew;
            btnAdd.Enabled = !isAddNew;
            txtStaffName.Focus();
        }
        
        private void SaveStaffInforamtion()
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    string query = "INSERT INTO dbo.Staff (StaffCode, StaffName, PositionCode, LectureHours, UnitPrice) VALUES (@StaffCode, @StaffName, @PositionCode, @LectureHours, @UnitPrice)";
                    SqlCommand command = new SqlCommand(query, connection);

                    command.Parameters.AddWithValue("@StaffCode", staffCode);
                    command.Parameters.AddWithValue("@StaffName", staffName);
                    command.Parameters.AddWithValue("@PositionCode", positionCode);
                    command.Parameters.AddWithValue("@LectureHours", lectureHours);
                    command.Parameters.AddWithValue("@UnitPrice", unitPrice);

                    connection.Open();
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        private int GetLatestStaffCode()
        {

            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    SqlCommand command = new SqlCommand("dbo.GetLatestStaffCode", connection);
                    command.CommandType = CommandType.StoredProcedure;

                    connection.Open();

                    int latestStaffCode = (int)command.ExecuteScalar();

                    connection.Close();
                    return latestStaffCode;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
         }
        private void PopulatePositionCombobox()
        {
         
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter("SELECT PositionCode, PositionName FROM Position", connection);

                    // Create a DataTable to hold the results
                    DataTable positionsTable = new DataTable();
                    adapter.Fill(positionsTable);

                    // Bind the combo box to the DataTable
                    cboStaffPosition.DataSource = positionsTable;
                    cboStaffPosition.DisplayMember = "PositionName";
                    cboStaffPosition.ValueMember = "PositionCode";
                    connection.Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetMenuContext();
            this.Close();
        }

    
    }
}
