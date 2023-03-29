

using bussiness_logic_tear.Entities_List;
using bussiness_logic_tear.Entity;
using bussiness_logic_tear.Entity_Manager;
using System.Diagnostics;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace tiers_application
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        titleList prdList;
        
        private void Form1_Load(object sender, EventArgs e)
        {
            prdList = titelsManager.selectAllTitels();
            dataGridView.DataSource = prdList;
            this.Text = "selectAllTitels";
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            foreach (var i in prdList) 
            {
                Trace.WriteLine(i.EntityState);

                if(i.EntityState==State.Changed)
                 titelsManager.updateTitelById(i.Title_id,i.Title,i.Type,i.Pub_id,i.Price,i.Advance,i.Royalty,i.Ytd_sales,i.Notes,i.Pubdate);
            }
        }
    }


}