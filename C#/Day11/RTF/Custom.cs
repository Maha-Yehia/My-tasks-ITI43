using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTF
{
    public partial class Custom : Form
    {
        public string UserText
        {
            get => textBox1.Text; set => textBox1.Text = value;
        }
        public Custom()
        {
            InitializeComponent();
        }

        private void Custom_Load(object sender, EventArgs e)
        {

        }
    }
}