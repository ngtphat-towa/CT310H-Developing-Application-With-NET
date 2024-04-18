using CustomerRegister.WebForm.DataAccess;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CustomerRegister.WebForm
{
    public partial class FillingForm : System.Web.UI.Page
    {
        private string genderOption = "";
        protected void radMale_CheckedChanged(object sender, EventArgs e)
        {
            if (radMale.Checked)
            {
                genderOption = "Male";
            }
        }

        protected void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            if (radFemale.Checked)
            {
                genderOption = "Female";
            }
        }

        protected void cv_gender_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            if (genderOption != "")
            {
                args.IsValid = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string hashPassword = txtPassword.Text;
            string fullname = txtCustomerName.Text;
            string dateOfBirth = txtBirthDate.Text;
            string gender = genderOption;
            string email = txtEmail.Text;
            decimal.TryParse(txtIncome.Text, out decimal income);
            var result = InsertCustomer(username, hashPassword, fullname, dateOfBirth, gender, email, income);
            if (result)
            {
                lblNotification.Text = "Sign Up Success!";

            }
            else
            {
                lblNotification.Text = "Something wrong happened! Please try again";
            }
        }
        private bool InsertCustomer(string username, string hashPassword, string fullName, string dateOfBirth, string gender, string email, decimal income = 0)
        {
            try
            {
                SqlDataAccess.OpenConnection();

                using (SqlCommand cmd = new SqlCommand("dbo.InsertCustomer", SqlDataAccess.ConnectionInstance))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Username", username);
                    cmd.Parameters.AddWithValue("@HashPassword", hashPassword);
                    cmd.Parameters.AddWithValue("@FullName", fullName);
                    cmd.Parameters.AddWithValue("@DataOfBirth", dateOfBirth);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Email", email);
                    cmd.Parameters.AddWithValue("@Income", income);

                    cmd.ExecuteNonQuery();
                }

                return true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error" + ex.Message);
                return false;
            }
            finally
            {
                SqlDataAccess.CloseConnection();
            }
        }
    }
}