using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using ReCustomerRegister.WebForm.DataAccess;

namespace ReCustomerRegister.WebForm
{
    public partial class CustomerList : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getCustomer();
            }
        }

        protected void GridView_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                if (e.Row.RowIndex % 2 == 0)
                {
                    e.Row.BackColor = System.Drawing.Color.FromArgb(224, 244, 255);
                }
                CheckBox checkbox = e.Row.FindControl("CheckBoxPhai") as CheckBox;
                if (checkbox != null)
                {
                    string GenderValue = DataBinder.Eval(e.Row.DataItem, "Gender").ToString();
                    if (GenderValue == "Nam")
                    {
                        checkbox.Checked = true;
                    }
                    else
                    {
                        checkbox.Checked = false;
                    }
                }
            }
        }

        protected void GridView_RowCreated(object sender, GridViewRowEventArgs e)
        {

        }

        protected void GridView_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                Label txtUsername = row.FindControl("LabelUsername") as Label;
                SqlDataAccess.OpenConnection();
                SqlCommand cmd = new SqlCommand("delete from Customer where username = @username", SqlDataAccess.ConnectionInstance);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);
            }
            finally
            {
                SqlDataAccess.CloseConnection();
            }
            getCustomer();
        }

        private void getCustomer()
        {
            SqlDataAccess.OpenConnection();
            SqlCommand cmd = new SqlCommand("select username as Username, Username as Name, DateOfBirth, Gender, Email from Customer;", SqlDataAccess.ConnectionInstance);
            DataTable t = new DataTable();
            t.Load(cmd.ExecuteReader());
            GridView.DataSource = t;
            GridView.DataBind();
            SqlDataAccess.CloseConnection();
        }

        protected void grdSV_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            getCustomer();
        }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView.EditIndex = e.NewEditIndex;
            getCustomer();
        }

        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                TextBox txtName = row.FindControl("TextBoxName") as TextBox;
                HtmlInputControl txtDateOfBirth = row.FindControl("TextBoxDOB") as HtmlInputControl;
                string DateOfBirth = txtDateOfBirth.Value;
                CheckBox checkbox = (CheckBox)row.FindControl("CheckBoxPhai");
                TextBox txtEmail = row.FindControl("TextBoxEmail") as TextBox;
                Label txtUsername = row.FindControl("LabelUsername") as Label;

                SqlDataAccess.OpenConnection();
                SqlCommand cmd = new SqlCommand("update Customer set Username = @name, DateOfBirth = @dob, Gender = @Gender, Email = @Email where username = @username", SqlDataAccess.ConnectionInstance);
                cmd.Parameters.AddWithValue("@name", txtName.Text);
                cmd.Parameters.AddWithValue("@dob", DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", checkbox.Checked ? "Nam" : "Nu");
                cmd.Parameters.AddWithValue("@Email", txtEmail.Text);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                Response.Write(ex.Message);

            }
            finally
            {
                SqlDataAccess.CloseConnection();
            }
            GridView.EditIndex = -1;
            getCustomer();
        }

        protected void GridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView.EditIndex = -1;
            getCustomer();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView.SelectedIndex;
            if (selectedIndex != -1)
            {
                GridViewRow row = GridView.Rows[selectedIndex];
                CheckBox checkbox = GridView.Rows[selectedIndex].FindControl("CheckBoxPhai") as CheckBox;
                Label Username = row.FindControl("LabelUsername") as Label;
                Label Name = row.FindControl("LabelName") as Label;
                Label DateOfBirth = row.FindControl("LabelDateOfBirth") as Label;
                Label Email = row.FindControl("LabelEmail") as Label;
                string username = Username.Text;
                string name = Name.Text;
                string email = Email.Text;
                int phai = checkbox.Checked ? 0 : 1;
                //Student student = new Student(maSV, tenSV, phai, lop);
                // Save student to session
                //Session["student"] = student;
                // Handle Student Detail page, but there none
                Response.Redirect($"CustomerList.aspx?userid={username}");
            }
        }

    }
}