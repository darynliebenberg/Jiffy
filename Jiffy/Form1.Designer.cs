namespace Jiffy
{
    partial class TimerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TimerLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TimerLabel
            // 
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 133F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.Lime;
            this.TimerLabel.Location = new System.Drawing.Point(0, 73);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(780, 187);
            this.TimerLabel.TabIndex = 0;
            this.TimerLabel.Text = "00:00:00";
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 349);
            this.Controls.Add(this.TimerLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "TimerForm";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.TimerForm_Activated);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label TimerLabel;
    }
}

