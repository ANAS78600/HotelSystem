﻿using System;
using HotelClasses;

public partial class SupplierViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of clsSupplier
        clsSupplier AnSupplier = new clsSupplier();
        //get the data from the session object
        AnSupplier = (clsSupplier)Session["AnSupplier"];
        //display the supplier number from this entry
        Response.Write(AnSupplier.SupplierFirstName);
    }
}