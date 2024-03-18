using Part01.DVDLibraryMnt.Desktop.Database;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Part01.DVDLibraryMnt.Desktop
{
    public partial class DVDLibraryForm : Form
    {

        private int dvdCodeNo;
        private decimal price;
        private string language;
        private int subTitle;


        public DVDLibraryForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                DVDDatabase.OpenConnection();

                SqlCommand sqlCommand = new SqlCommand("Select Max(DVDCodeNo) from dbo.DVDLibrary", DVDDatabase.ConnectionInstance);
                dvdCodeNo = Convert.ToInt32(sqlCommand.ExecuteScalar());
                DVDDatabase.CloseConnection();


            }
            catch (Exception exception)
            {
                dvdCodeNo = 0;
                MessageBox.Show(exception.Message, caption: "DB Error", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                DVDDatabase.CloseConnection();
            }
            dvdCodeNo++;
            ResetFeilds(true);
            txtNo.Text = dvdCodeNo.ToString();

        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string strInsert ="Insert Into DVDLibrary Values (@DVDNO, @DVDTitle, @DVDLang, @SubTitle, @Price);";
                DVDDatabase.OpenConnection();
                SqlCommand com= new SqlCommand(strInsert, DVDDatabase.ConnectionInstance);
                SqlParameter p1 = new SqlParameter("@DVDNo", SqlDbType.Int);
                p1.Value = dvdCodeNo;
                SqlParameter p2 = new SqlParameter("@DVDTitle", SqlDbType.NVarChar); 
                p2.Value = txtTitle.Text;
                SqlParameter p3 = new SqlParameter("@DVDLang", SqlDbType.VarChar); 
                p3.Value = language;
                SqlParameter p4 = new SqlParameter("@SubTitle", SqlDbType.Bit); 
                p4.Value = subTitle;
                SqlParameter p5 = new SqlParameter("@Price", SqlDbType.Money);
                p5.Value = price;
                com.Parameters.Add(p1);
                com.Parameters.Add(p2);
                com.Parameters.Add(p3);
                com.Parameters.Add(p4);
                com.Parameters.Add(p5);
                com.ExecuteNonQuery();

                MessageBox.Show("Insert successfully!!!");
                DVDDatabase.CloseConnection();
                ResetFeilds(false);
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                DVDDatabase.CloseConnection();
            }
        }
    

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ResetFeilds(false);
        }
        private void ResetFeilds(bool status)
        {
            txtNo.Clear();
            txtTitle.Clear();
            cboLang.SelectedIndex = -1;
            updPrice.Value = updPrice.Minimum;
            rbtnYes.Checked = true;
            rbtnNo.Checked = false;
            btnSave.Enabled = status;
            btnCancel.Enabled = status;
            btnAdd.Enabled = !status;
            txtTitle.Focus();
        }

        private void updPrice_ValueChanged(object sender, EventArgs e)
        {
            price = updPrice.Value;
        }

        private void rbtnYes_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 1;
        }

        private void rbtnNo_CheckedChanged(object sender, EventArgs e)
        {
            subTitle = 0;
        }

        private void cboLang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLang.SelectedIndex==-1)
            {
                return;
            }
            language = cboLang.Text;
        }
    }
}
