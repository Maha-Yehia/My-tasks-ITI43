using Timer = System.Windows.Forms.Timer;

namespace Ball
{
    public partial class Form1 : Form
    {
        Graphics g;
        Timer Timer1 = new Timer();
        int posX = 0;
        int dx = 40;
        public Form1()
        {
            InitializeComponent();
            g = CreateGraphics();
            Timer1.Interval = 100;
            Timer1.Enabled = true;
            Timer1.Tick += Timer1_Tick;


        }


        private void Timer1_Tick(object? sender, EventArgs e)
        {
            posX += dx;

            if (posX + 100 >= 650)
            {
                posX = 650 - 100;
                dx = -dx;
            }
            else if (posX < 60)
            {
                posX = 60;
                dx = -dx;
            }

            this.Invalidate();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            ///Boy
            e.Graphics.DrawEllipse(Pens.Blue, new(10, 0, 100, 100));
            e.Graphics.DrawLine(Pens.Blue, new(60, 100), new(60, 350));
            e.Graphics.DrawLine(Pens.Blue, new(60, 150), new(30, 180));
            e.Graphics.DrawLine(Pens.Blue, new(60, 150), new(90, 180));
            e.Graphics.DrawLine(Pens.Blue, new(60, 350), new(30, 380));
            e.Graphics.DrawLine(Pens.Blue, new(60, 350), new(90, 380));
            ///Girl
            e.Graphics.DrawEllipse(Pens.DeepPink, new(600, 0, 100, 100));
            e.Graphics.DrawLine(Pens.DeepPink, new(610, 20), new(550, 80));
            e.Graphics.DrawLine(Pens.DeepPink, new(690, 20), new(750, 80));
            e.Graphics.DrawLine(Pens.DeepPink, new(650, 100), new(650, 350));
            e.Graphics.DrawLine(Pens.DeepPink, new(650, 150), new(620, 180));
            e.Graphics.DrawLine(Pens.DeepPink, new(650, 150), new(680, 180));
            e.Graphics.DrawLine(Pens.DeepPink, new(650, 350), new(620, 380));
            e.Graphics.DrawLine(Pens.DeepPink, new(650, 350), new(680, 380));

            //ball
            g.DrawEllipse(new Pen(Color.Black), posX, 280, 100, 100);
            g.FillEllipse(new SolidBrush(Color.Gray), posX ,280,100,100);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}