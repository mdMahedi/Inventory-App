using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using InventoryApp.Connection;

namespace InventoryApp.Product
{
    public partial class InsertProduct : System.Web.UI.Page
    {
        DataAccessClass dataAccess = new DataAccessClass();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            string name = productName.Text;
            decimal price = Convert.ToDecimal(unitPrice.Text);
            int qty = Convert.ToInt32(quantity.Text);

            
            //if (IsTextboxEmpty())
            //{
            //    lblMsg.Text = "Dont try to input empty value";
            //}
            //else 

            if (dataAccess.IsProductExist(name))
            {
                dataAccess.EditProduct(name, price, qty);
                lblMsg.Text = name + " updated.";
            }
            else if (dataAccess.InsertIntoProduct(name, price, qty))
            {
                lblMsg.Text = name+" inserted succesfully";
            }
            else
            {
                lblMsg.Text = "Product not inserted";
            }
            ClearTextBoxes();
        }

        public void ClearTextBoxes()
        {
            productName.Text = "";
            unitPrice.Text = "";
            quantity.Text = "";
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            string name = NameTextbox.Text;
            if (dataAccess.DeleteFromProduct(name))
            {
                msgDelete.Text = name + " has been deleted";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            DataAccessClass dac = new DataAccessClass();
            GridView1.DataSource = dac.GetAllProduct();
            GridView1.DataBind();
            
        }

        //public bool IsTextboxEmpty()
        //{
        //    if (productName.Text == "" || unitPrice.Text == null || quantity.Text == "")
        //    {
        //        return true;
        //    }
        //    else
        //    {
        //        return false;
        //    }
        //}
        
    }
}