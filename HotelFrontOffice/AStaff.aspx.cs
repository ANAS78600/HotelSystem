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

    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        //add the new record
        Add();
        //all done so redirect back to the main page
        Response.Redirect("StaffDefault.aspx");
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


    //function for adding new records
    void Add()
    {
        //create an instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //validate the data on the web form
        string Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtSalary.Text, txtGender.Text, txtDateAdded.Text);
        //if the data id OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            StaffBook.ThisStaff.StaffFirstName = txtFirstName.Text;
            StaffBook.ThisStaff.StaffLastName = txtLastName.Text;
            StaffBook.ThisStaff.StaffSalary = Convert.ToInt32(txtSalary.Text);
            StaffBook.ThisStaff.StaffGender = txtGender.Text;
            StaffBook.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            StaffBook.ThisStaff.Active = chkActive.Checked;
            //add the record
            StaffBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("StaffDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There wasproblems with the data entered" + Error;
        }
    }

    protected void btnOK_Click1(object sender, EventArgs e)
    {

    }
}
