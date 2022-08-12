using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
       
        clsStock AStock = new clsStock();
        AStock.StockName = txtStockName.Text;
        AStock.StockID = Convert.ToInt32(txtStockID.Text);
        AStock.StockQuantity = Convert.ToInt32(txtStockQuantity.Text);
        AStock.StockTotalSold = Convert.ToInt32(txtTotalSold.Text);
        AStock.DateAdded = Convert.ToDateTime(txtDateAdded.Text);
        AStock.Price = Convert.ToDecimal(txtPrice.Text);
        AStock.StockAvailable = Convert.ToBoolean(chkAvailable.Checked);
        Session["AStock"] = AStock;
        Response.Redirect("StockViewer.aspx");
    }

    protected void chkAvailable_CheckedChanged(object sender, EventArgs e)
    {

    }
}