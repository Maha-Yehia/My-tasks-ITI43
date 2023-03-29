using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grid_ado
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter adapter;
        DataTable dt;
        BindingSource src;
        BindingSource srcSup;
        private void Form2_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["Northwind"].ConnectionString;
            cmd = new SqlCommand(Text,conn);
            
            adapter= new SqlDataAdapter(new SqlCommand("select * from Products",conn));
            dt= new DataTable();
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
            adapter.Fill(dt);

            //simple binding
            src = new BindingSource(dt,""); //works only with select on 1 table
            numericUpDown.DataBindings.Add("Value", src, "ProductID");
            prdName.DataBindings.Add("Text", src, "ProductName");
            unitsinstock.DataBindings.Add("Text", src, "UnitsInStock");
            supplier.DataBindings.Add("Text", src, "SupplierID");
            categoryID.DataBindings.Add("Value",src, "CategoryID");
            QuantityPerUnit.DataBindings.Add("Text", src, "QuantityPerUnit");
            UnitsOnOrder.DataBindings.Add("Value",src, "UnitsOnOrder");
            unitsinstock.DataBindings.Add("Value", src, "unitsinstock");
            ReorderLevel.DataBindings.Add("Value", src, "ReorderLevel");
            Discontinued.DataBindings.Add("Text", src, "Discontinued");
            UnitPrice.DataBindings.Add("Text", src, "UnitPrice");


            BindingNavigator navigator = new BindingNavigator(src);
            this.Controls.Add(navigator);


        }


    

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            
            //update
            //cmd.CommandText = "update Products set ProductName=@name  where ProductID=@ID";
            //cmd.Parameters.Add("@name", SqlDbType.NVarChar);
            //cmd.Parameters.Add("@ID", SqlDbType.Int);
            //cmd.Parameters["@name"].Value = prdName.Text;
            //cmd.Parameters["@ID"].Value = Convert.ToDecimal(numericUpDown.Value.ToString());
            src.EndEdit();
            adapter.Update(dt);
            dt.AcceptChanges();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //delete
          // cmd.Parameters.Clear();
            
            //cmd.CommandText = "delete from Products where ProductID=@ID";           
            //cmd.Parameters.Add("@ID", SqlDbType.Int); 
            //cmd.Parameters["@ID"].Value = Convert.ToDecimal(numericUpDown.Value.ToString());
            src.EndEdit();
            adapter.Update(dt);
            dt.AcceptChanges();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //insert
            cmd.Parameters.Clear();

            src.EndEdit();
            adapter.Update(dt);
            dt.AcceptChanges();

        }



    }
}
