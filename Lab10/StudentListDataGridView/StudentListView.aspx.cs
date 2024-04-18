using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using CustomerRegister.WebForm.DataAccess;
using StudentListDataGridView.Models;

namespace StudentListDataGridView
{
    public partial class StudentListView : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                LoadData();
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
                CheckBox checkbox = e.Row.FindControl("CheckBoxGender") as CheckBox;
                if (checkbox != null)
                {
                    int dataValue = Convert.ToInt32(DataBinder.Eval(e.Row.DataItem, "Gender"));
                    checkbox.Checked = (dataValue == 0);
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
                Label labelStudentId = (Label)row.FindControl("LabelStudentId");
                SqlDataAccess.OpenConnection();
                SqlCommand cmd = new SqlCommand("DELETE FROM Students WHERE StudentId = @StudentId", SqlDataAccess.ConnectionInstance);
                cmd.Parameters.AddWithValue("@StudentId", labelStudentId.Text);
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
            LoadData();
        }

        private void LoadData()
        {
            SqlDataAccess.OpenConnection();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Students", SqlDataAccess.ConnectionInstance);
            DataTable t = new DataTable();
            t.Load(cmd.ExecuteReader());
            GridView.DataSource = t;
            GridView.DataBind();
            SqlDataAccess.CloseConnection();
        }

        protected void grdSV_OnPageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView.PageIndex = e.NewPageIndex;
            LoadData();
        }

        protected void GridView_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView.EditIndex = e.NewEditIndex;
            LoadData();
        }

        protected void GridView_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            try
            {
                GridViewRow row = GridView.Rows[e.RowIndex];
                TextBox textBoxStudentId = (TextBox)row.FindControl("TextBoxStudentId");
                TextBox textBoxStudentName = (TextBox)row.FindControl("TextBoxStudentName");
                CheckBox checkbox = (CheckBox)row.FindControl("CheckBoxGender");
                TextBox textBoxClassName = (TextBox)row.FindControl("TextBoxClassName");
                Label labelStudentId = (Label)row.FindControl("LabelStudentId");

                SqlDataAccess.OpenConnection();
                SqlCommand cmd = new SqlCommand("UPDATE Students SET StudentName = @StudentName, Gender = @Gender, ClassName = @ClassName WHERE StudentId = @StudentId", SqlDataAccess.ConnectionInstance);
                cmd.Parameters.AddWithValue("@StudentId", labelStudentId.Text);
                cmd.Parameters.AddWithValue("@StudentName", textBoxStudentName.Text);
                cmd.Parameters.AddWithValue("@Gender", checkbox.Checked ? 0 : 1);
                cmd.Parameters.AddWithValue("@ClassName", textBoxClassName.Text);
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
            LoadData();
        }

        protected void GridView_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView.EditIndex = -1;
            LoadData();
        }

        protected void GridView_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedIndex = GridView.SelectedIndex;
            if (selectedIndex != -1)
            {
                GridViewRow row = GridView.Rows[selectedIndex];
                CheckBox checkbox = GridView.Rows[selectedIndex].FindControl("CheckBoxGender") as CheckBox;
                Label StudentId = row.FindControl("LabelStudentId") as Label;
                Label StudentName = row.FindControl("LabelStudentName") as Label;
                Label ClassName = row.FindControl("LabelClassName") as Label;
                string studentId = StudentId.Text;
                string studentName = StudentName.Text;
                string className = ClassName.Text;
                int Gender = checkbox.Checked ? 0 : 1;
                Student student = new Student(studentId, studentName, Gender, className);
                // Save student to session
                Session["student"] = student;
                // Handle Student Detail page, but there none
                Response.Redirect($"wfrStudent.aspx?userid={StudentId}");
            }
        }

        protected void GridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {

        }

        protected void GridView_RowDeleted(object sender, GridViewDeletedEventArgs e)
        {

        }
    }
}