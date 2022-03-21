using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using HotelClasses;


public partial class AnSupplier : System.Web.UI.Page
{
    Int32 SupplierNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supplier to be processed
        SupplierNo = Convert.ToInt32(Session["SupplierNo"]);
        if (IsPostBack == false)
        {
            //populate the list of supplierfirstname
            DisplaySupplier();
            //if this is not a new record
            if (SupplierNo !=-1)
            {
                //display the current data for the record
                DisplaySupplier();
            }

        }
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        if (SupplierNo == -1)
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
        //create a instancw of the class we want to make
        clsSupplier AnSupplier = new clsSupplier();
        //bollean variable to store the restults of the valdation
        //varaible to store the primark key
        Int32 SupplierNo;
        //variavvle to store the results for the final operation
        Boolean Found = false;
        //get the key entred from the user
        SupplierNo = Convert.ToInt32(txtSupplierNo.Text);
        //find the record
        Found = AnSupplier.Find(SupplierNo);
        //if found
        if (Found == true)
        {
            //display the values of the property in the form
            txtSupplierFirstName.Text = AnSupplier.SupplierFirstName;
            txtSupplierLastName.Text = AnSupplier.SupplierLastName;
            txtSupplierAddress.Text = AnSupplier.SupplierAddress;
            txtSupplierTel.Text = AnSupplier.SupplierTel;
            txtDateAdded.Text = AnSupplier.DateAdded.ToString();
        }
    }

    //function for adding new record
    void Add()
    {
        //create an instance of the supplier class
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //validate the data on the web form
        string Error = SupplierBook.ThisSupplier.Valid(txtSupplierFirstName.Text, txtSupplierLastName.Text, txtSupplierAddress.Text, txtSupplierTel.Text, txtDateAdded.Text);
        //if the data id OK then add it to the object
        if (Error == "")
        {
            //get the data entered by the user
            SupplierBook.ThisSupplier.SupplierFirstName = txtSupplierFirstName.Text;
            SupplierBook.ThisSupplier.SupplierLastName = txtSupplierLastName.Text;
            SupplierBook.ThisSupplier.SupplierTel = txtSupplierTel.Text;
            SupplierBook.ThisSupplier.SupplierAddress = txtSupplierAddress.Text;
            SupplierBook.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            SupplierBook.ThisSupplier.Active = chkActive.Checked;
            //add the record
            SupplierBook.Add();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");

        }
        else
        {
            //report an error
            IblError.Text = "There were problems with the data entered " + Error;
        }
    }


    void DeleteSupplier()
    {
        //create a new instance of the supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to delete
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //delete the record
        SupplierBook.Delete();
    }


    void Update()
    {
        //create an instance of the supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //validate the data on the web form
        string Error = SupplierBook.ThisSupplier.Valid(txtSupplierFirstName.Text, txtSupplierLastName.Text, txtSupplierAddress.Text, txtSupplierTel.Text, txtDateAdded.Text);
        //if the data id OK then add it to the object
        if (Error == "")
        {
            //find the record to update
            SupplierBook.ThisSupplier.Find(SupplierNo);
            //get the data entered by the user
            SupplierBook.ThisSupplier.SupplierFirstName = txtSupplierFirstName.Text;
            SupplierBook.ThisSupplier.SupplierLastName = txtSupplierLastName.Text;
            SupplierBook.ThisSupplier.SupplierTel = txtSupplierTel.Text;
            SupplierBook.ThisSupplier.SupplierAddress = txtSupplierAddress.Text;
            SupplierBook.ThisSupplier.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
            SupplierBook.ThisSupplier.Active = chkActive.Checked;
            //add the record
            SupplierBook.Update();
            //all done so redirect back to the main page
            Response.Redirect("Default.aspx");

        }
        else
        {
            //report an error
            IblError.Text = "There were problems with the data entered " + Error;
        }
    }


    void DisplaySupplier()
    {
        //create an instance of the supplier book
        clsSupplierCollection SupplierBook = new clsSupplierCollection();
        //find the record to update 
        SupplierBook.ThisSupplier.Find(SupplierNo);
        //display this data for this record
        txtSupplierFirstName.Text = SupplierBook.ThisSupplier.SupplierFirstName;
        txtSupplierLastName.Text = SupplierBook.ThisSupplier.SupplierLastName;
        txtSupplierTel.Text = SupplierBook.ThisSupplier.SupplierTel;
        txtSupplierAddress.Text = SupplierBook.ThisSupplier.SupplierAddress;
        txtDateAdded.Text = SupplierBook.ThisSupplier.DateAdded.ToString();
        chkActive.Checked = SupplierBook.ThisSupplier.Active;
        
    }
}

    
