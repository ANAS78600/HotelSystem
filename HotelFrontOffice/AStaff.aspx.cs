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
        //capture the StaffFirstName
        string StaffFirstName = txtFirstName.Text;
        //capture the StaffLastName
        string StaffLastName = txtLastName.Text;
        //capture the Salary
        string StaffSalary = txtSalary.Text;
        //capture the StaffDateAdded
        string DateAdded = txtDateAdded.Text;
        //capture the STaffGender
        string StaffGender = txtGender.Text;
        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = AStaff.Valid(StaffFirstName, StaffLastName, StaffSalary, StaffGender, DateAdded);
        if(Error =="")
            { 
                //capture the StaffNo
                AStaff.StaffNo = Convert.ToInt32(txtStaffNo.Text);
                //capture the StaffFirstName
                AStaff.StaffFirstName = txtFirstName.Text;
                //capture the StaffLastName
                AStaff.StaffLastName = txtLastName.Text;
                //capture the Salary
                AStaff.StaffSalary = Convert.ToInt32(txtSalary.Text);
                //capture the StaffDateAdded
                AStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
                //capture the STaffGender
                AStaff.StaffGender = txtGender.Text;
                //store the staff in the session object
                Session["AStaff"] = AStaff;
                //redirect to the viewer page
                Response.Write("StaffViewer.aspx");
            }
        else
            {
            //display the error message
            lblError.Text = Error;
            }
    }


    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the staff class
        clsStaff AStaff = new clsStaff();
        //variable to store the primary key 
        Int32 StaffNo;
        //variable to store the result is the find operative
        Boolean Found = false;
        //get the primary key entered by the user
        StaffNo = Convert.ToInt32(txtStaffNo.Text);
        //find record
        Found = AStaff.Find(StaffNo);
        //if found 
        if (Found == true)
        {
            //display the values of the properties in the form
            txtDateAdded.Text = AStaff.DateAdded.ToString();
            txtFirstName.Text = AStaff.StaffFirstName;
            txtLastName.Text = AStaff.StaffLastName;
            txtSalary.Text = AStaff.StaffSalary.ToString();
            txtGender.Text = AStaff.StaffGender;
}
    }
}
