using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace WebAppAssignmnet10
{
    public partial class ProductRegistration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DdlCategory.Items.Add("Clothing");
            DdlCategory.Items.Add("Electronics");
            DdlCategory.Items.Add("Furnitures");
            DdlCategory.Items.Add("Home Appliances");

            if (!Page.IsPostBack)
            {
                lblInfo.Visible = false;
            }
            Page.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

        }
        protected void BtnRegister_Click(object sender, EventArgs e)
        {
            lblInfo.Visible = true;
            lblInfo.Text = "Successfully Registered ";
            lblInfo.Text += "<br> Product Name: " + TxtProName.Text;
            lblInfo.Text += "<br>Product Category: " + DdlCategory.Text;
            lblInfo.Text += "<br> Product Price: " + TxtPrice.Text;
            lblInfo.Text += "<br> Product Description: " + DdlDes.Text;
            lblInfo.Text += "<br> Product Release Date: " + CalReleaseDate.SelectedDate;
        }
    }
}