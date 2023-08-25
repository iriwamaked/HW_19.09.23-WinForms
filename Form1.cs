namespace HW_19._08._23
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(HW_19._08._23.Properties.Resources.emblem);
                Graphics fromImg = Graphics.FromImage(img);
                fromImg.DrawEllipse(new Pen(Color.BlueViolet, 10), 40, 600, 50, 80);
                fromImg.DrawEllipse(new Pen(Color.Green, 10), 50, 600, 80, 50);
                fromImg.DrawRectangle(new Pen(Color.AliceBlue, 7), 30, 580, 120, 120);
                fromImg.DrawRectangle(new Pen(Color.DarkBlue, 10), 20, 570, 140, 140);
                img.Save(@"emblem.bmp");
                Rectangle rect = new Rectangle(new Point(0, 0), img.Size);
                img.Dispose();
                fromImg.Dispose();
                Invalidate(rect);
            }
            catch { }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            try
            {
                Bitmap img = new Bitmap(@"emblem.bmp");
                Graphics g = e.Graphics;
                g.DrawImage(img, 0, 0, 600, 400);
                img.Dispose();
                g.Dispose();
            }
            catch { }
        }
    }
}