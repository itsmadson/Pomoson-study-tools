using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Reflection;
using System.IO;
using System.Media;


namespace Pomoson
{
    public partial class Pomoson : Form
    {


        //move frame
        private const int WM_NCHITTEST = 0x84;
        private const int HTCLIENT = 0x1;
        private const int HTCAPTION = 0x2;


        int timerValue = 25; // Initial timer value in minutes
        Timer timer = new Timer();
        int remainingTime;

        //Setup player hint: add one lofi and white noise audio in to ur project and call it here, i delete that from my project cuz i cant upload my file in github

        SoundPlayer lofiPlayer = new SoundPlayer(Properties.Resources.Lofi);
        SoundPlayer whiteNoisePlayer = new SoundPlayer(Properties.Resources.White_noise);
        bool lofiPlaying = false;
        bool whiteNoisePlaying = false;


        //night light 
        public class NightLightController
        {
            private string registryKeyPath =
                "Software\\Microsoft\\Windows\\CurrentVersion\\CloudStore\\Store\\DefaultAccount\\Current\\default$windows.data.bluelightreduction.bluelightreductionstate\\windows.data.bluelightreduction.bluelightreductionstate";

            private RegistryKey registryKey;

            public bool IsNightLightEnabled
            {
                get
                {
                    if (!IsNightLightSupported) return false;
                    var data = registryKey?.GetValue("Data") as byte[];
                    if (data == null) return false;
                    return data[18] == 0x15;
                }
            }

            public bool IsNightLightSupported
            {
                get => registryKey != null;
            }

            public NightLightController()
            {
                registryKey = Registry.CurrentUser.OpenSubKey(registryKeyPath, true);
            }

            public void ToggleNightLight()
            {
                if (IsNightLightSupported)
                {
                    var data = registryKey.GetValue("Data") as byte[];
                    var newData = new byte[43];

                    if (IsNightLightEnabled)
                    {
                        newData = new byte[41];
                        Array.Copy(data, 0, newData, 0, 22);
                        Array.Copy(data, 25, newData, 23, 43 - 25);
                        newData[18] = 0x13;
                    }
                    else
                    {
                        Array.Copy(data, 0, newData, 0, 22);
                        Array.Copy(data, 23, newData, 25, 41 - 23);
                        newData[18] = 0x15;
                        newData[23] = 0x10;
                        newData[24] = 0x00;
                    }

                    for (int i = 10; i < 15; i++)
                    {
                        if (newData[i] != 0xff)
                        {
                            newData[i]++;
                            break;
                        }
                    }

                    registryKey.SetValue("Data", newData, RegistryValueKind.Binary);
                    registryKey.Flush();
                }
            }

            public void Dispose()
            {
                registryKey.Close();
            }
        }


        public Pomoson()
        {
            //fix form style
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            this.TransparencyKey = System.Drawing.Color.Black;
            this.BackColor = System.Drawing.Color.Black;
            this.Opacity = 0.96;
            this.Size = new System.Drawing.Size(370, 600);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackgroundImageLayout = ImageLayout.Stretch;
            this.UpdateStyles();


        }


        // + & - btn to control time
        private void btnIncrease_Click(object sender, EventArgs e)
        {
            timerValue += 1;
            lblTimer.Text = FormatTime(timerValue);
        }

        private void btnDecrease_Click(object sender, EventArgs e)
        {
            if (timerValue > 1)
            {
                timerValue -= 1;
                lblTimer.Text = FormatTime(timerValue);
            }
        }

        //start & reset btn
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!timer.Enabled)
            {
                remainingTime = timerValue * 60;
                timer.Interval = 1000; // 1 second
                timer.Tick += Timer_Tick;
                timer.Start();
                status.Text = "Stay focused and achieve your goals.";
            }

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            timer.Stop();
            timerValue = 25;
            lblTimer.Text = FormatTime(timerValue);
            status.Text = "U can manipulate the fourth dimension now";
        }

        // pomodoro stuff
        private void Timer_Tick(object sender, EventArgs e)
        {
            remainingTime--;

            int minutes = remainingTime / 60;
            int seconds = remainingTime % 60;

            lblTimer.Text = FormatTime(minutes, seconds);

            if (remainingTime <= 0)
            {
                timer.Stop();
                MessageBox.Show("Pomodoro session is complete!");
            }
        }


        private string FormatTime(int minutes, int seconds = 0)
        {
            return string.Format("{0:D2}:{1:D2}", minutes, seconds);
        }
// to do list
        private void taskTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string newTask = taskTextBox.Text;
                if (!string.IsNullOrEmpty(newTask))
                {
                    checkedListBox1.Items.Add(newTask, false);
                    taskTextBox.Text = string.Empty;
                }
            }

        }

        private void AddTaskButton_Click(object sender, EventArgs e)
        {
            string newTask = taskTextBox.Text;
            if (!string.IsNullOrEmpty(newTask))
            {
                checkedListBox1.Items.Add(newTask, false);
                taskTextBox.Text = string.Empty;
            }
        }


        private void RemoveTaskButton_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.SelectedIndex != -1)
            {
                checkedListBox1.Items.RemoveAt(checkedListBox1.SelectedIndex);
            }
        }



        // audio player
        private void btnLofi_Click(object sender, EventArgs e)
        {
            if (!lofiPlaying)
            {


                lofiPlayer.PlayLooping();
                btnLofi.Text = "Pause Lofi";
                lofiPlaying = true;
                status.Text = "Relax to soothing Lofi beats.";
            }
            else
            {
                lofiPlayer.Stop();
                btnLofi.Text = "Play Lofi";
                lofiPlaying = false;
                status.Text = "I know, sometimes lofi is sick";
            }
        }

        private void btnWhiteNoise_Click(object sender, EventArgs e)
        {
            if (!whiteNoisePlaying)
            {

                whiteNoisePlayer.PlayLooping();
                btnWhiteNoise.Text = "Pause White Noise";
                whiteNoisePlaying = true;
                status.Text = "Its cloudy here,آسمان تو چه رنگ است؟ ";
            }
            else
            {
                lofiPlayer.Stop();
                btnWhiteNoise.Text = "Play White Noise";
                whiteNoisePlaying = false;
                status.Text = "The clouds go away and the rain stops.";
            }
        }

        //night light 

        NightLightController nightLightController = new NightLightController();

        private void btnToggleNightLight_Click(object sender, EventArgs e)
        {
            nightLightController.ToggleNightLight();
            status.Text = "Be kind with ur ocean eyes with NM.";
        }

        //btn exit and min
        private void btnexit_click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnmin_click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        // move frame
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            if (m.Msg == WM_NCHITTEST && m.Result.ToInt32() == HTCLIENT)
            {
                m.Result = (IntPtr)HTCAPTION;
            }
        }
    }



}
