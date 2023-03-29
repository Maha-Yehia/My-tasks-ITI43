using bussiness_logic_tear.Entity_Manager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiers_application
{
    public partial class updateForm : Form
    {
        public updateForm()
        {
            InitializeComponent();
        }

        private void updateForm_Load(object sender, EventArgs e)
        {
           itemLabel.Text = "1";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if( textBox.Text.Length> 0  ) 
            { 
            // bool  status=  titelsManager.updateTitelById(textBox.Text, itemLabel.Text);
               // this.Text = $"status :{status}";
            }
        }
    }
}
