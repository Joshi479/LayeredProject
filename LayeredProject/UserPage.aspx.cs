using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BusinessLayer;

namespace LayeredProject
{
    public partial class UserPage : System.Web.UI.Page
    {
        BLL logicLayer = new BLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            lblName.Text = logicLayer.GetUSerName(Convert.ToInt32(Session["UserId"]));
            lblDatetime.Text = DateTime.Now.ToString();
        }
       
    }
}