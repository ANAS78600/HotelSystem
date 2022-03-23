using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;

public partial class AStaff : System.Web.UI.Page
{
    Int32 StaffNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        // get the number of the staff to be processed
        StaffNo = Convert.ToInt32(Session["StaffNo"]);
        if (IsPostBack == false)
        {
            //populate the list of staff
            DisplayStaff();
            //if this is not a new record
            if (StaffNo != -1)
            {
                //display the current data for the record
                DisplayStaff();
            }

        }
    }

    //event handler for the ok button
    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (StaffNo == -1)
        {
            //Add new record
            Add();
        }
        else
        {
            //update the record
            Update();
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
            lblError.Text = "There was problems with the data entered" + Error;
        }
    }

    //function for updating records
    void Update()
    {
        // create an instance of the staff book
        HotelClasses.clsStaffCollection StaffBook = new HotelClasses.clsStaffCollection();
        //validate the data on the web form
        string Error = StaffBook.ThisStaff.Valid(txtFirstName.Text, txtLastName.Text, txtSalary.Text, txtGender.Text, txtDateAdded.Text);
        //if the data id OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            StaffBook.ThisStaff.Find(StaffNo);
            //get the data entered by the user
            StaffBook.ThisStaff.StaffFirstName = txtFirstName.Text;
            StaffBook.ThisStaff.StaffLastName = txtLastName.Text;
            StaffBook.ThisStaff.StaffSalary = Convert.ToInt32(txtSalary.Text);
            StaffBook.ThisStaff.StaffGender = txtGender.Text;
            StaffBook.ThisStaff.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            StaffBook.ThisStaff.Active = chkActive.Checked;
            //update the record
            StaffBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("StaffDefault.aspx");
        }
        else
        {
            //report an error
            lblError.Text = "There wasproblems with the data entered" + Error;
        }
    }

    void DisplayStaff()
    {
        //create an instance of the staff book
        clsStaffCollection StaffBook = new clsStaffCollection();
        //find the record to update 
        StaffBook.ThisStaff.Find(StaffNo);
        //display this data for this record
        txtFirstName.Text = StaffBook.ThisStaff.StaffFirstName;
        txtLastName.Text = StaffBook.ThisStaff.StaffLastName;
        txtSalary.Text = StaffBook.ThisStaff.StaffSalary. ToString();
        txtGender.Text = StaffBook.ThisStaff.StaffGender;
        txtDateAdded.Text = StaffBook.ThisStaff.DateAdded.ToString();
        chkActive.Checked = StaffBook.ThisStaff.Active;

    }


}
