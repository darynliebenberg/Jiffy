using System;
using System.Drawing;
using System.Windows.Forms;
using System.Threading;

namespace Jiffy
{
    public partial class TimerForm : Form
    {
        Thread TimeUpdateThread;
        Label[] formComponents;
        int[] formComponentsTop;
        TimeSpan startTime;
        TimeSpan endTime;
        bool timer = false;
        int update = 1000;

        public TimerForm()
        {
            InitializeComponent();
            formComponents = new Label[]
            {
                SubjectLabel,
                WritingLabel,
                TimerLabel,
                DateLabel,
                TimeLabel
            };
            formComponentsTop = new int[]
            {
                SubjectLabel.Top,
                WritingLabel.Top,
                TimerLabel.Top,
                DateLabel.Top,
                TimeLabel.Top
            };
        }

        public void UpdateDisplay(string subject, TimeSpan endTime, TimeSpan startTime, int duration)
        {
            int hour = duration / 60;
            int minute = duration % 60;
            this.startTime = startTime;
            this.endTime = endTime;
            SubjectLabel.Text = subject + "     " + hour.ToString() + "h";
            if (minute != 0)
            {
                SubjectLabel.Text += minute.ToString("D2");
            }
            WritingLabel.Text += startTime.ToString(@"hh\:mm") + " - " + endTime.ToString(@"hh\:mm");
        }

        private void UpdateTime()
        {
            while (true)
            {
                Invoke((MethodInvoker)delegate
                {
                    DateTime now = DateTime.Now;
                    TimeLabel.Text = now.ToString("HH:mm");
                    if (TimeLabel.Text == startTime.ToString(@"hh\:mm") && !timer)
                    {
                        timer = true;
                        InfoPanel.Hide();
                        update = 100;
                    }
                    if (timer)
                    {
                        TimeSpan time = endTime - new TimeSpan(now.Hour, now.Minute, now.Second);
                        TimerLabel.Text = time.ToString();
                        if (time.TotalMinutes == 1)
                        {
                            TimerLabel.ForeColor = Color.Yellow;
                        }
                        else if (time.TotalSeconds == 0)
                        {
                            TimerLabel.ForeColor = Color.Red;
                            Refresh();
                            Thread.Sleep(5000);
                            timer = false;
                            InfoPanel.Show();
                            update = 1000;
                        }
                    }
                    Refresh();
                });                
                Thread.Sleep(update);
            }
        }

        private void TimerForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                TimeUpdateThread.Abort();
                Application.Exit();
            }
        }

        private void TimerForm_Shown(object sender, EventArgs e)
        {
            // Create a thread  
            TimeUpdateThread = new Thread(new ThreadStart(UpdateTime));
            // Start thread  
            TimeUpdateThread.Start();
            WindowState = FormWindowState.Maximized;

            // Calculate the scale of the form size change. 780 and 398 is it's default size.
            double hScale = Math.Floor((double)Height / 398);
            double scale = Math.Ceiling((double)Width / 780) + hScale;
            // Scale of the resizing
            for (int i = 0; i < formComponents.Length; i++)
            {
                float font = (float)(formComponents[i].Font.Size * scale / 2);
                formComponents[i].Font = new Font(formComponents[i].Font.FontFamily, font);
            }
            WritingLabel.Top = (int)(Math.Floor(formComponentsTop[1] * hScale));

            #region Time
            TimePanel.Top = Height - TimeLabel.Height * 2;
            TimePanel.Size = new Size(Width, Height - TimePanel.Top);

            TimeLabel.Location = new Point(0, 0);
            TimeLabel.Size = new Size(TimePanel.Width, TimePanel.Height);

            DateLabel.Text = DateTime.Today.ToString("d MMMM yyyy");
            DateLabel.Left = Width - DateLabel.Width - 10;
            DateLabel.Top = TimePanel.Height - DateLabel.Height - 10;
            #endregion

            #region TimerInfo
            InfoPanel.Location = new Point(0, 0);
            InfoPanel.Size = new Size(Width, TimePanel.Top);

            TimerPanel.Location = InfoPanel.Location;
            TimerPanel.Size = InfoPanel.Size;

            TimerLabel.Location = new Point((TimerLabel.Width - Width) / 2 * -1, TimerPanel.Height / 4);
            //TimerLabel.Size = new Size(TimerPanel.Width, TimerPanel.Height);
            #endregion
            ConfigurationForm configuration = new ConfigurationForm();
            configuration.Show(this);
            NativeMethods.PreventSleep();
        }

        private void TimerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            NativeMethods.AllowSleep();
        }
    }
}
