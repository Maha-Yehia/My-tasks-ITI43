
using System.Drawing;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        Graphics g;
        int posX = 100;
        int posY = 100;

        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
        }


        protected override void OnPaint(PaintEventArgs e)
        {

            e.Graphics.FillRectangle(new SolidBrush(Color.LightBlue), posX - 100, posY - 100, 200, 200);
            e.Graphics.DrawRectangle(new Pen(Color.Blue), posX - 100, posY - 100, 200, 200);

            base.OnPaint(e);
        }

        private void winMouseUp(object sender, MouseEventArgs e)
        {
            posX = e.X;
            posY = e.Y;
            Invalidate();
        }
       

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}