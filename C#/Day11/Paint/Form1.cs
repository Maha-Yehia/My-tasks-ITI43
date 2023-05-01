namespace Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }

        Color pen = Color.Black;
        Graphics g ; 

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {

                g.FillEllipse(new SolidBrush(pen), e.X-5, e.Y-5, 10, 10);
                g.DrawEllipse(new Pen(pen), e.X-5, e.Y - 5, 10, 10);
            }
            else if (e.Button == MouseButtons.Right)
            {
                g.FillEllipse(new SolidBrush(Form1.DefaultBackColor), e.X , e.Y , 10, 10);
                g.DrawEllipse(new Pen(Form1.DefaultBackColor), e.X, e.Y, 10, 10);
            }
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
                pen = colorDialog1.Color;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}