using System;
using System.Windows.Forms;

namespace Jiffy
{
    public partial class ConfigurationForm : Form
    {
        string endStore;
        public ConfigurationForm()
        {
            InitializeComponent();
        }

        private void TextValidate(object sender, EventArgs e)
        {
            Check();
            StartTimeLabel.Enabled = true;
            StartTimeTextBox.Enabled = true;
            if (!EndTimeCheckBox.Checked)
                return;
            if (HourTextBox.Text != "0" || MinuteTextBox.Text != "00")
            {                
                StartTimeLabel.Enabled = false;
                StartTimeTextBox.Enabled = false;
            }           
        }

        private void ApplyButton_Click(object sender, EventArgs e)
        {
            TimerForm timerForm = (TimerForm)Application.OpenForms["TimerForm"];
            string subject = SubjectTextBox.Text;
            TimeSpan end;
            TimeSpan start;
            TimeSpan length;
            int duration;

            bool validEnd;

            validEnd = TimeSpan.TryParse(EndTimeTextBox.Text, out end);
            TimeSpan.TryParse(StartTimeTextBox.Text, out start);

            duration = Int32.Parse(HourTextBox.Text) * 60 + Int32.Parse(MinuteTextBox.Text);
            if (duration == 0)
            {
                if (start > end)
                {
                    end.Add(TimeSpan.FromHours(12));
                }
                length = end - start;
                duration = (int)length.TotalMinutes;
            }
            else
            {
                length = TimeSpan.FromMinutes(duration);
                if (validEnd)
                {
                    start = end - length;
                } else
                {
                    end = start + length;
                }
            }

            timerForm.UpdateDisplay(subject, end, start, duration);
            Close();
        }

        private void EndTimeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            EndTimeTextBox.Enabled = checkBox.Checked;
            if (checkBox.Checked)
            {
                EndTimeTextBox.Text = endStore;
            } else
            {
                endStore = EndTimeTextBox.Text;
                EndTimeTextBox.Text = "";
            }
            TextValidate(sender, e);
            StartTimeTextBoxValidate(sender, e);
        }

        private void StartTimeTextBoxValidate(object sender, EventArgs e)
        {
            Check();
            DurationLabel.Enabled = true;
            HourTextBox.Enabled = true;
            MinuteTextBox.Enabled = true;
            if (!EndTimeCheckBox.Checked)
                return;
            if (StartTimeTextBox.Text != "  :")
            {
                DurationLabel.Enabled = false;
                HourTextBox.Enabled = false;
                MinuteTextBox.Enabled = false;
            }         
        }

        private void Check()
        {
            if (StartTimeTextBox.Text != "  :" && (HourTextBox.Text != "0" || MinuteTextBox.Text != "00"))
            {
                EndTimeCheckBox.Enabled = false;
            }
            else
            {
                EndTimeCheckBox.Enabled = true;
            }
        }

        private void TextBoxEnter(object sender, EventArgs e)
        {
            MaskedTextBox maskedTextBox = sender as MaskedTextBox;
            BeginInvoke((MethodInvoker)delegate ()
            {
                maskedTextBox.Select(0, 0);
            });
        }
    }
}
