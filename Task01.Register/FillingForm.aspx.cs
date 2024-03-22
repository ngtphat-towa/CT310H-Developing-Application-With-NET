using System;
using System.Web.UI.WebControls;

namespace Task01.Register
{
    public partial class FillingForm : System.Web.UI.Page
    {
        private string gender ="";
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void radMale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nam";
        }

        protected void radFemale_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Nu";
        }
        protected void cv_gender_ServerValidate(object source, ServerValidateEventArgs args)
        {
            args.IsValid = false;
            if (gender != "")
            {
                args.IsValid = true;
            }
        }

        protected void btnRegister_Click(object sender, EventArgs e)
        {
            lblNotification.Text = "Sign Up Success!";
        }
    }
}