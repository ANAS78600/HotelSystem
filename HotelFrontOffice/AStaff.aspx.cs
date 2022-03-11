using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AStaff : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsStaff
        clsStaff AStaff = new clsStaff();
        //capture the StaffNo
        AStaff.StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //store the staff in the session object
        Session["AStaff"] = AStaff;
        //redirect to the viewer page
        Response.Redirect("StaffViewer.aspx");
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {

    }
}
