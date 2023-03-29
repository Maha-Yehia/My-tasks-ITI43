using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;

namespace Grid_ado
{
    public partial class Form1 : Form
    {
        SqlConnection conn;
        SqlCommand cmd;
        SqlDataAdapter DaAd;
        DataTable table;
        SqlCommandBuilder builder;

        SqlCommand supCmd;
        SqlDataAdapter supAdapter;
        DataTable supTable;
        SqlCommandBuilder supplierBuilder;
        DataGridViewComboBoxColumn column;

        public Form1()
        {
            InitializeComponent();

        }

        
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection();
            conn.ConnectionString=@"Data Source=.;initial Catalog=Northwind;Integrated Security=true;Encrypt=false";
            cmd =new SqlCommand(Text, conn);
            cmd.CommandText = "select * from Products";
            DaAd= new SqlDataAdapter(cmd);
            table = new DataTable();
            builder = new SqlCommandBuilder(DaAd);
            this.Text = "Branch number :"+ConfigurationManager.AppSettings["BranchID"]?.ToString();



            //supplier inner join
            supCmd = new SqlCommand("select CompanyName ,SupplierID from Suppliers ", conn);
            supAdapter = new SqlDataAdapter(supCmd);
            supplierBuilder = new SqlCommandBuilder(supAdapter);
            supTable = new DataTable();
            
            column= new DataGridViewComboBoxColumn();
            column.DataSource = supTable;
            column.DisplayMember = "CompanyName";
            column.ValueMember = "SupplierID";
            column.DataPropertyName= "SupplierID";
            column.HeaderText = "supplier name";

        }

        private void READ_Click(object sender, EventArgs e)
        {
            
                DaAd.Fill(table);
                supAdapter.Fill(supTable);
                dataGridView.DataSource = table;
                dataGridView.Columns.Add(column);
                dataGridView.Columns[0].ReadOnly = true;
            
        }

        private void sAVEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in table.Rows)
            {
                Debug.WriteLine(row.RowState);
            }

            dataGridView.EndEdit();
            supAdapter.Update(supTable);
            //    try {
            //        dataGridView.EndEdit();
            //        DaAd.Update(table);
            //        supAdapter.Update(supTable);
            //    }
            //    catch { }
            //}
        }
    }
}