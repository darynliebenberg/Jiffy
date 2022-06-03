using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using System.Threading;

namespace Jiffy
{
    public partial class TimerForm : Form
    {
        public TimerForm()
        {
            InitializeComponent();
        }

        private void TimerForm_Activated(object sender, EventArgs e)
        {
            string startInput = Interaction.InputBox("Please enter the start time:", "Start");
            TimeSpan start;
            TimeSpan.TryParse(startInput, out start);

            string EndInput = Interaction.InputBox("Please enter the start time:", "Start");
            TimeSpan end;
            TimeSpan.TryParse(EndInput, out end);

            TimeSpan time = end - start;
            TimerLabel.Text = time.ToString();
        }
    }
}
