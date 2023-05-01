using System.Drawing.Drawing2D;

namespace Mickey
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;
            btnClose.Click += (sender, e) => this.Close();
            btnMinimize.Click += (sender, e) => this.WindowState = FormWindowState.Minimized;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            path.AddEllipse(0, 0, 150, 150);
            path.AddEllipse(ClientSize.Width - 150, 0, 150, 150);
            path.FillMode = FillMode.Winding;
            this.Region = new Region(path);
            base.OnPaint(e);
        }

        Point oldLocation = Point.Empty;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point newLocation = e.Location;

                var offsetX = newLocation.X - oldLocation.X;
                var offsetY = newLocation.Y - oldLocation.Y;

                this.Location = new Point(this.Location.X + offsetX, this.Location.Y + offsetY);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            oldLocation = e.Location;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void btnClose_Click(object sender, EventArgs e)
        {

        }
        private void btnMinimize_Click(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
