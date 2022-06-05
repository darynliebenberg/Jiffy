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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimerForm));
            this.TimerPanel = new System.Windows.Forms.Panel();
            this.TimerLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.WritingLabel = new System.Windows.Forms.Label();
            this.TimePanel = new System.Windows.Forms.Panel();
            this.DateLabel = new System.Windows.Forms.Label();
            this.TimeLabel = new System.Windows.Forms.Label();
            this.TimerPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.TimePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // TimerPanel
            // 
            this.TimerPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TimerPanel.Controls.Add(this.TimerLabel);
            this.TimerPanel.Location = new System.Drawing.Point(0, 0);
            this.TimerPanel.Name = "TimerPanel";
            this.TimerPanel.Size = new System.Drawing.Size(780, 398);
            this.TimerPanel.TabIndex = 2;
            // 
            // TimerLabel
            // 
            this.TimerLabel.AutoSize = true;
            this.TimerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 133F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimerLabel.ForeColor = System.Drawing.Color.Lime;
            this.TimerLabel.Location = new System.Drawing.Point(0, 30);
            this.TimerLabel.Margin = new System.Windows.Forms.Padding(0);
            this.TimerLabel.Name = "TimerLabel";
            this.TimerLabel.Size = new System.Drawing.Size(776, 200);
            this.TimerLabel.TabIndex = 1;
            this.TimerLabel.Text = "00:00:00";
            this.TimerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoPanel
            // 
            this.InfoPanel.Controls.Add(this.SubjectLabel);
            this.InfoPanel.Controls.Add(this.WritingLabel);
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.Size = new System.Drawing.Size(780, 398);
            this.InfoPanel.TabIndex = 3;
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.ForeColor = System.Drawing.Color.White;
            this.SubjectLabel.Location = new System.Drawing.Point(20, 30);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(193, 31);
            this.SubjectLabel.TabIndex = 0;
            this.SubjectLabel.Text = "[Subject]      0h";
            // 
            // WritingLabel
            // 
            this.WritingLabel.AutoSize = true;
            this.WritingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WritingLabel.ForeColor = System.Drawing.Color.White;
            this.WritingLabel.Location = new System.Drawing.Point(20, 97);
            this.WritingLabel.Name = "WritingLabel";
            this.WritingLabel.Size = new System.Drawing.Size(127, 31);
            this.WritingLabel.TabIndex = 1;
            this.WritingLabel.Text = "Writing:   ";
            // 
            // TimePanel
            // 
            this.TimePanel.Controls.Add(this.DateLabel);
            this.TimePanel.Controls.Add(this.TimeLabel);
            this.TimePanel.Location = new System.Drawing.Point(0, 248);
            this.TimePanel.Name = "TimePanel";
            this.TimePanel.Size = new System.Drawing.Size(780, 150);
            this.TimePanel.TabIndex = 4;
            // 
            // DateLabel
            // 
            this.DateLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.DateLabel.AutoSize = true;
            this.DateLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateLabel.ForeColor = System.Drawing.Color.White;
            this.DateLabel.Location = new System.Drawing.Point(630, 110);
            this.DateLabel.Name = "DateLabel";
            this.DateLabel.Size = new System.Drawing.Size(138, 31);
            this.DateLabel.TabIndex = 3;
            this.DateLabel.Text = "%Today%";
            // 
            // TimeLabel
            // 
            this.TimeLabel.BackColor = System.Drawing.Color.Black;
            this.TimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TimeLabel.ForeColor = System.Drawing.Color.White;
            this.TimeLabel.Location = new System.Drawing.Point(0, 0);
            this.TimeLabel.Name = "TimeLabel";
            this.TimeLabel.Size = new System.Drawing.Size(780, 150);
            this.TimeLabel.TabIndex = 2;
            this.TimeLabel.Text = "00:00";
            this.TimeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TimerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(780, 398);
            this.Controls.Add(this.TimePanel);
            this.Controls.Add(this.InfoPanel);
            this.Controls.Add(this.TimerPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "TimerForm";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.TimerForm_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TimerForm_KeyDown);
            this.TimerPanel.ResumeLayout(false);
            this.TimerPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.TimePanel.ResumeLayout(false);
            this.TimePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel TimerPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.Label TimerLabel;
        private System.Windows.Forms.Panel TimePanel;
        private System.Windows.Forms.Label DateLabel;
        private System.Windows.Forms.Label TimeLabel;
        private System.Windows.Forms.Label WritingLabel;
    }
}

