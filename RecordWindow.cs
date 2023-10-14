using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AutoMouse
{
    public partial class RecordWindow : Form
    {
        AutoMouseMain mainWindow;
        System.Windows.Forms.Timer mouseTimer = new System.Windows.Forms.Timer();
        int mouseX;
        int mouseY;
        int recordCount;
        Point tempPoint;

        public RecordWindow(AutoMouseMain win)
        {
            InitializeComponent();
            
            mouseTimer.Interval = 50;
            mouseTimer.Tick += new EventHandler(mousePointTimer_Tick);
            mouseTimer.Start();

            mainWindow = win;
            recordCount = 0;

            Console.WriteLine("width=" + System.Windows.Forms.SystemInformation.VirtualScreen.Width);
            Console.WriteLine("height=" + System.Windows.Forms.SystemInformation.VirtualScreen.Height);
        }
        private void mousePointTimer_Tick(object? sender, EventArgs e)
        {

            tbX.Text = System.Windows.Forms.Cursor.Position.X.ToString();
            tbY.Text = System.Windows.Forms.Cursor.Position.Y.ToString();

            mouseX = System.Windows.Forms.Cursor.Position.X;
            mouseY = System.Windows.Forms.Cursor.Position.Y;
            tempPoint = System.Windows.Forms.Cursor.Position;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mainWindow.clearPoint();
            mainWindow.Show();
            this.Close();
        }

        private void labelRecord_MouseDown(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse DN X:" + mouseX + ", Y:" + mouseY);
            this.Cursor = Cursors.NoMove2D;

        }
        private void labelRecord_MouseUp(object sender, MouseEventArgs e)
        {
            Console.WriteLine("mouse UP X:" + mouseX + ", Y:" + mouseY);
            mainWindow.addPoint(tempPoint);
            recordCount++;
            tbRecordCount.Text = Convert.ToString(recordCount);
            this.Cursor = Cursors.Default;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            mainWindow.Show();
            this.Close();
        }

        private void RecordWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWindow.Show();
        }
    }
}
