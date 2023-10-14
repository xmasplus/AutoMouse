using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace AutoMouse
{
    public partial class AutoMouseMain : Form
    {
        RecordWindow? recordWindow;
        List<Point> pointList = new List<Point>();
        [DllImport("user32.dll")]
        static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, int dwExtraInf);
        [DllImport("user32.dll")]
        private static extern int RegisterHotKey(int hwnd, int id, int fsModifiers, int vk);
        [DllImport("user32.dll")]
        private static extern int UnregisterHotKey(int hwnd, int id);

        private const uint MOUSEMOVE = 0x0001;
        private const uint LBUTTONDOWN = 0x0002;
        private const uint LBUTTONUP = 0x0004;
        private const uint RBUTTONDOWN = 0x0008;
        private const uint RBUTTONUP = 0x00010;
        private const uint ABSOLUTEMOVE = 0x8000;

        private const uint ALT_KEY = 0x1;
        private const uint CTRL_KEY = 0x2;

        private const int HOTKEY_START = 0;

        int repeatCount = 0;
        bool _isRunning = false;
        string msgRecord = "Press the Record button to set the point first.";
        string msgReady = "Your mouse click is ready.";

        public AutoMouseMain()
        {
            InitializeComponent();
            toolStripStatusLabel.Text = msgRecord;
            this.Activated += new EventHandler(AutoMouseMain_Activated);
            initScreen();
            registerHotKeys();
        }

        private void initScreen()
        {
            cbMouseType.SelectedIndex = AutoMouse.Settings.Default.mouse_button;
            cbMouseClick.SelectedIndex = AutoMouse.Settings.Default.click_type;
            cbStartKey1.SelectedIndex = AutoMouse.Settings.Default.stop_hotkey1;
            cbStartKey2.SelectedIndex = AutoMouse.Settings.Default.stop_hotkey2;

            btnStart.Enabled = false;
            btnRecordReset.Enabled = false;
            if (AutoMouse.Settings.Default.repeat_type == 0)
            {
                radioTimes.Checked = true;
            }
            else
            {
                radioInfinite.Checked = true;
            }
            tbClicks.Text = AutoMouse.Settings.Default.repeat_count.ToString();

            chkBoxUseRandom.Checked = AutoMouse.Settings.Default.use_random;
            if (chkBoxUseRandom.Checked == false)
            {
                groupBoxRandomMin.Enabled = false;
                groupBoxRandomMax.Enabled = false;
            }

            clickIntervalMinute.Value = AutoMouse.Settings.Default.click_interval_minute;
            clickIntervalSecond.Value = AutoMouse.Settings.Default.click_interval_second;
            clickIntervalTenthOfSecond.Value = AutoMouse.Settings.Default.click_interval_tenthofsecond;
            repeatIntervalMinute.Value = AutoMouse.Settings.Default.repeat_interval_minute;
            repeatIntervalSecond.Value = AutoMouse.Settings.Default.repeat_interval_second;
            repeatIntervalTenthOfSecond.Value = AutoMouse.Settings.Default.repeat_interval_tenthofsecond;
            randomMinimumSecond.Value = AutoMouse.Settings.Default.rand_min_second;
            randomMinimumTenthOfSecond.Value = AutoMouse.Settings.Default.rand_min_tenthofsecond;
            randomMaximumSecond.Value = AutoMouse.Settings.Default.rand_max_second;
            randomMaximumTenthOfSecond.Value = AutoMouse.Settings.Default.rand_max_tenthofsecond;

            toolStripStatusStatus.Text = "(Stop)";
        }

        private void saveSettings()
        {
            AutoMouse.Settings.Default.mouse_button = cbMouseType.SelectedIndex;
            AutoMouse.Settings.Default.click_type = cbMouseClick.SelectedIndex;
            AutoMouse.Settings.Default.stop_hotkey1 = cbStartKey1.SelectedIndex;
            AutoMouse.Settings.Default.stop_hotkey2 = cbStartKey2.SelectedIndex;

            AutoMouse.Settings.Default.use_random = chkBoxUseRandom.Checked;
            AutoMouse.Settings.Default.repeat_count = Convert.ToInt32(tbClicks.Text);

            AutoMouse.Settings.Default.click_interval_minute = (int)clickIntervalMinute.Value;
            AutoMouse.Settings.Default.click_interval_second = (int)clickIntervalSecond.Value;
            AutoMouse.Settings.Default.click_interval_tenthofsecond = (int)clickIntervalTenthOfSecond.Value;
            AutoMouse.Settings.Default.repeat_interval_minute = (int)repeatIntervalMinute.Value;
            AutoMouse.Settings.Default.repeat_interval_second = (int)repeatIntervalSecond.Value;
            AutoMouse.Settings.Default.repeat_interval_tenthofsecond = (int)repeatIntervalTenthOfSecond.Value;

            AutoMouse.Settings.Default.rand_min_second = (int)randomMinimumSecond.Value;
            AutoMouse.Settings.Default.rand_min_tenthofsecond = (int)randomMinimumTenthOfSecond.Value;
            AutoMouse.Settings.Default.rand_max_second = (int)randomMaximumSecond.Value;
            AutoMouse.Settings.Default.rand_max_tenthofsecond = (int)randomMaximumTenthOfSecond.Value;

            AutoMouse.Settings.Default.Save();
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == (int)0x312)  // Hotkey = 0x312
            {
                if (m.WParam.ToInt32() == HOTKEY_START)   // Start key
                {
                    Console.WriteLine("Stop HotKey");
                    _isRunning = false;
                    btnStart.Enabled = true;
                    btnStart.Click += btnStart_Click;
                    toolStripStatusStatus.Text = "(Stop)";
                    toolStripStatusLabel.Text = msgReady;

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                }
            }
        }

        private void AutoMouseMain_Activated(object? sender, EventArgs e)
        {
            if (pointList.Count > 0)
            {
                btnStart.Enabled = true;
                btnRecordReset.Enabled = true;
                toolStripStatusLabel.Text = msgReady;
                saveSettings();
            }
            else
            {
                btnStart.Enabled = false;
                btnRecordReset.Enabled = false;
            }
        }

        private void record()
        {
            pointList.Clear();
            if (recordWindow == null)
            {
                recordWindow = new RecordWindow(this);
                recordWindow.Closed += (o, args) => recordWindow = null;
            }
            this.Hide();
            recordWindow.Show();
        }

        private void btnRecord_Click(object sender, EventArgs e)
        {
            record();
        }

        public void addPoint(Point point)
        {
            pointList.Add(point);

            foreach (Point p in pointList)
            {
                Console.WriteLine("point list : " + p.ToString());
            }
            tbClickPointCount.Text = pointList.Count.ToString();
        }

        public void clearPoint()
        {
            pointList.Clear();
            tbClickPointCount.Text = pointList.Count.ToString();
        }

        private void btnRecordReset_Click(object sender, EventArgs e)
        {
            pointList.Clear();
            btnStart.Enabled = false;
            btnRecordReset.Enabled = false;
            tbClickPointCount.Text = pointList.Count.ToString();
            AutoMouse.Settings.Default.Save();

            initScreen();
        }

        private new void MouseClick(bool isClick, Point point, uint width, uint height)
        {
            Rectangle rtScreen = Screen.PrimaryScreen.Bounds;

            uint nX = (uint)(65535 * (point.X + width) / rtScreen.Width);
            uint nY = (uint)(65535 * (point.Y + height) / rtScreen.Height);

            if (isClick)
            {
                this.Invoke(new Action(delegate ()
                {
                    if (this.cbMouseType.SelectedIndex == 0)
                    {
                        if (this.cbMouseClick.SelectedIndex == 1)
                        {
                            mouse_event(ABSOLUTEMOVE | MOUSEMOVE | LBUTTONDOWN, nX, nY, 0, 0);
                            mouse_event(ABSOLUTEMOVE | MOUSEMOVE | LBUTTONUP, nX, nY, 0, 0);
                            Thread.Sleep(30);
                        }
                        mouse_event(ABSOLUTEMOVE | MOUSEMOVE | LBUTTONDOWN, nX, nY, 0, 0);
                        mouse_event(ABSOLUTEMOVE | MOUSEMOVE | LBUTTONUP, nX, nY, 0, 0);
                    }
                    else
                    {
                        if (this.cbMouseClick.SelectedIndex == 1)
                        {
                            mouse_event(ABSOLUTEMOVE | MOUSEMOVE | RBUTTONDOWN, nX, nY, 0, 0);
                            mouse_event(ABSOLUTEMOVE | MOUSEMOVE | RBUTTONUP, nX, nY, 0, 0);
                            Thread.Sleep(30);
                        }
                        mouse_event(ABSOLUTEMOVE | MOUSEMOVE | RBUTTONDOWN, nX, nY, 0, 0);
                        mouse_event(ABSOLUTEMOVE | MOUSEMOVE | RBUTTONUP, nX, nY, 0, 0);
                    }
                }));
            }
        }

        private static Int32 getRandomMS(int min, int max)
        {
            Int32 random_number = 0;

            Console.WriteLine("getRand min:" + min + ", max:" + max);

            if (max - min > 0)
            {
                Random rand = new Random();
                random_number = rand.Next(min, max);

            }
            // Console.WriteLine("rand = " + random_number.ToString());
            return random_number;
        }

        public void Start(object? obj)
        {
            // Console.WriteLine("START!!");
            ThreadParam? param = obj as ThreadParam;
            if (param == null)
            {
                Console.WriteLine("param is null");
                return;
            }
            
            Int32 loop = param.loopcount;
            int rand;
            int repeat_sleep = param.repeatMilli;
            int click_sleep = param.clickMilli;

            Console.WriteLine("repeat sleep:" + repeat_sleep + ", click_sleep = " + click_sleep);

            for (Int32 i = 0; i < loop && _isRunning == true; i++)
            {
                if (param.useRandom)
                {
                    rand = getRandomMS(param.randomMinMilli, param.randomMaxMilli);
                    Console.WriteLine("repeat rand = " + rand);
                    Thread.Sleep(rand);
                }
                else
                {
                    Thread.Sleep(repeat_sleep);
                }
                foreach (Point p in param.pointList)
                {
                    if (_isRunning == false) break;
                    if (param.useRandom)
                    {
                        rand = getRandomMS(param.randomMinMilli, param.randomMaxMilli);
                        Console.WriteLine("click rand = " + rand);
                        Thread.Sleep(rand);
                    }
                    else
                    {
                        Thread.Sleep(click_sleep);
                    }
                    if (_isRunning == false) break;

                    Console.WriteLine("Click : " + p.ToString());
                    MouseClick(true, p, 0, 0);
                    Console.WriteLine("Click sleep:" + click_sleep);
                }
                if (_isRunning == false) break;
            }
            this.Invoke(new Action(delegate ()
            {
                if (this.pointList.Count > 0)
                {
                    this.btnStart.Enabled = true;
                    this.btnRecordReset.Enabled = true;
                    this.toolStripStatusLabel.Text = msgReady;

                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                }
                else
                {
                    this.btnStart.Enabled = false;
                    this.btnRecordReset.Enabled = false;
                }

                this.btnStart.Click += btnStart_Click;
                this.toolStripStatusStatus.Text = "(Stop)";
            }));
        }

        private void startThread()
        {
            saveSettings();
            toolStripStatusStatus.Text = "(Running)";
            // Console.WriteLine("startThread");
            ThreadParam param = new ThreadParam();

            if (radioInfinite.Checked)
            {
                param.loopcount = Int32.MaxValue;
            }
            else
            {
                param.loopcount = Convert.ToInt32(tbClicks.Text);
            }

            param.useRandom = chkBoxUseRandom.Checked;
            param.randomMinMilli = (int)((randomMinimumSecond.Value * 1000) +
                                         (randomMinimumTenthOfSecond.Value * 100));
            param.randomMaxMilli = (int)((randomMaximumSecond.Value * 1000) +
                                         (randomMaximumTenthOfSecond.Value * 100));
            param.repeatMilli = (int)((repeatIntervalMinute.Value * 60 * 1000) +
                                      (repeatIntervalSecond.Value * 1000) +
                                      (repeatIntervalTenthOfSecond.Value * 100));
            param.clickMilli = (int)((clickIntervalMinute.Value * 60 * 1000) +
                                     (clickIntervalSecond.Value * 1000) +
                                     (clickIntervalTenthOfSecond.Value * 100));
            param.pointList = pointList;
            param.AutoMouseMain = this;

            _isRunning = true;
            Thread t1 = new Thread(Start);
            t1.Start(param);
        }

        private void btnStart_Click(object? sender, EventArgs e)
        {
            int temp = (int)((clickIntervalMinute.Value * 60 * 1000) +
                             (clickIntervalSecond.Value * 1000) +
                             (clickIntervalTenthOfSecond.Value * 100));
            if (temp < 500)
            {
                System.Windows.Forms.MessageBox.Show("Click time must be at least 500 ms.");
            }
            else
            {
                btnStart.Enabled = false;
                startThread();
                Thread.Sleep(100);
                btnStart.Click -= btnStart_Click;

                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void radioTimes_CheckedChanged(object sender, EventArgs e)
        {
            repeatCount = 1;
            tbClicks.Clear();
            tbClicks.Text = repeatCount.ToString();
            tbClicks.Enabled = true;
        }

        private void radioInfinite_CheckedChanged(object sender, EventArgs e)
        {
            tbClicks.Clear();
            tbClicks.Enabled = false;
        }

        private void chkBoxUseRandom_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxRandomMin.Enabled = chkBoxUseRandom.Checked;
            groupBoxRandomMax.Enabled = chkBoxUseRandom.Checked;

            groupBoxRepeatInterval.Enabled = !chkBoxUseRandom.Checked;
            groupBoxClickInterval.Enabled = !chkBoxUseRandom.Checked;
        }

        private void AutoMouseMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            unregisterHotKyes();
        }

        private void registerHotKeys()
        {
            RegisterHotKey((int)this.Handle,
                           HOTKEY_START,
                           cbStartKey1.SelectedIndex,
                           getFkeyFromIndex(cbStartKey2.SelectedIndex));
        }

        private void unregisterHotKyes()
        {
            UnregisterHotKey((int)this.Handle, HOTKEY_START);
        }

        private int getFkeyFromIndex(int index)
        {
            if (index == 0) return (int)Keys.F2;
            else if (index == 1) return (int)Keys.F3;
            else if (index == 2) return (int)Keys.F4;
            else if (index == 3) return (int)Keys.F5;
            else if (index == 4) return (int)Keys.F6;
            else if (index == 5) return (int)Keys.F7;
            else if (index == 6) return (int)Keys.F8;
            else if (index == 7) return (int)Keys.F9;
            else if (index == 8) return (int)Keys.F10;
            else if (index == 9) return (int)Keys.F11;
            else return (int)Keys.F12;
        }

        private void cbStartKey1_SelectedIndexChanged(object sender, EventArgs e)
        {
            unregisterHotKyes();
            registerHotKeys();
        }

        private void cbStartKey2_SelectedIndexChanged(object sender, EventArgs e)
        {
            unregisterHotKyes();
            registerHotKeys();
        }

        private void randomMinimumSecond_ValueChanged(object sender, EventArgs e)
        {

        }

        private void randomMinimumTenthOfSecond_ValueChanged(object sender, EventArgs e)
        {

        }
    }

    class ThreadParam
    {
        public int loopcount;
        public bool useRandom;
        public int randomMinMilli;
        public int randomMaxMilli;
        public int repeatMilli;
        public int clickMilli;
        public List<Point> pointList = new List<Point>();
        public AutoMouseMain? AutoMouseMain;
    }
}
