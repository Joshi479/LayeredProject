using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace LayeredProject
{
    public partial class LoginPage : System.Web.UI.Page
    {
        BLL logicLayer = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogin_Click(object sender, EventArgs e)
        {
            MyUser user = new MyUser();
            user.UserId = Convert.ToInt32(txtUserId.Text);
            user.Password = txtPassword.Text;
            if (logicLayer.AuthorizeUser(user))
            {
                Session["userID"] = user.UserId;
                Response.Redirect("UserPage.aspx");
            }
            else
                lblErrorMessage.Text = "Invalid credentials. Try again.";
        }
    }
}