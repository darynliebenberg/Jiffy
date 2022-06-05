namespace Jiffy
{
    partial class ConfigurationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigurationForm));
            this.SubjectLabel = new System.Windows.Forms.Label();
            this.SubjectTextBox = new System.Windows.Forms.TextBox();
            this.StartTimeLabel = new System.Windows.Forms.Label();
            this.DurationLabel = new System.Windows.Forms.Label();
            this.ApplyButton = new System.Windows.Forms.Button();
            this.EndHint = new System.Windows.Forms.Label();
            this.StartHint = new System.Windows.Forms.Label();
            this.HourHint = new System.Windows.Forms.Label();
            this.MinuteHint = new System.Windows.Forms.Label();
            this.EndTimeCheckBox = new System.Windows.Forms.CheckBox();
            this.EndTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.StartTimeTextBox = new System.Windows.Forms.MaskedTextBox();
            this.HourTextBox = new System.Windows.Forms.MaskedTextBox();
            this.MinuteTextBox = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // SubjectLabel
            // 
            this.SubjectLabel.AutoSize = true;
            this.SubjectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SubjectLabel.Location = new System.Drawing.Point(12, 13);
            this.SubjectLabel.Name = "SubjectLabel";
            this.SubjectLabel.Size = new System.Drawing.Size(59, 17);
            this.SubjectLabel.TabIndex = 0;
            this.SubjectLabel.Text = "Subject:";
            // 
            // SubjectTextBox
            // 
            this.SubjectTextBox.Location = new System.Drawing.Point(97, 12);
            this.SubjectTextBox.Name = "SubjectTextBox";
            this.SubjectTextBox.Size = new System.Drawing.Size(144, 20);
            this.SubjectTextBox.TabIndex = 1;
            // 
            // StartTimeLabel
            // 
            this.StartTimeLabel.AutoSize = true;
            this.StartTimeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartTimeLabel.Location = new System.Drawing.Point(12, 66);
            this.StartTimeLabel.Name = "StartTimeLabel";
            this.StartTimeLabel.Size = new System.Drawing.Size(77, 17);
            this.StartTimeLabel.TabIndex = 7;
            this.StartTimeLabel.Text = "Start Time:";
            // 
            // DurationLabel
            // 
            this.DurationLabel.AutoSize = true;
            this.DurationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DurationLabel.Location = new System.Drawing.Point(12, 93);
            this.DurationLabel.Name = "DurationLabel";
            this.DurationLabel.Size = new System.Drawing.Size(66, 17);
            this.DurationLabel.TabIndex = 8;
            this.DurationLabel.Text = "Duration:";
            // 
            // ApplyButton
            // 
            this.ApplyButton.Location = new System.Drawing.Point(431, 212);
            this.ApplyButton.Name = "ApplyButton";
            this.ApplyButton.Size = new System.Drawing.Size(75, 23);
            this.ApplyButton.TabIndex = 9;
            this.ApplyButton.Text = "Apply";
            this.ApplyButton.UseVisualStyleBackColor = true;
            this.ApplyButton.Click += new System.EventHandler(this.ApplyButton_Click);
            // 
            // EndHint
            // 
            this.EndHint.AutoSize = true;
            this.EndHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndHint.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.EndHint.Location = new System.Drawing.Point(161, 39);
            this.EndHint.Name = "EndHint";
            this.EndHint.Size = new System.Drawing.Size(50, 17);
            this.EndHint.TabIndex = 10;
            this.EndHint.Text = "hh:mm";
            // 
            // StartHint
            // 
            this.StartHint.AutoSize = true;
            this.StartHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StartHint.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.StartHint.Location = new System.Drawing.Point(161, 66);
            this.StartHint.Name = "StartHint";
            this.StartHint.Size = new System.Drawing.Size(50, 17);
            this.StartHint.TabIndex = 11;
            this.StartHint.Text = "hh:mm";
            // 
            // HourHint
            // 
            this.HourHint.AutoSize = true;
            this.HourHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HourHint.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.HourHint.Location = new System.Drawing.Point(126, 93);
            this.HourHint.Name = "HourHint";
            this.HourHint.Size = new System.Drawing.Size(16, 17);
            this.HourHint.TabIndex = 12;
            this.HourHint.Text = "h";
            // 
            // MinuteHint
            // 
            this.MinuteHint.AutoSize = true;
            this.MinuteHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinuteHint.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.MinuteHint.Location = new System.Drawing.Point(171, 93);
            this.MinuteHint.Name = "MinuteHint";
            this.MinuteHint.Size = new System.Drawing.Size(19, 17);
            this.MinuteHint.TabIndex = 14;
            this.MinuteHint.Text = "m";
            // 
            // EndTimeCheckBox
            // 
            this.EndTimeCheckBox.AutoSize = true;
            this.EndTimeCheckBox.Checked = true;
            this.EndTimeCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.EndTimeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EndTimeCheckBox.Location = new System.Drawing.Point(2, 38);
            this.EndTimeCheckBox.Name = "EndTimeCheckBox";
            this.EndTimeCheckBox.Size = new System.Drawing.Size(91, 21);
            this.EndTimeCheckBox.TabIndex = 15;
            this.EndTimeCheckBox.Text = "End Time:";
            this.EndTimeCheckBox.UseVisualStyleBackColor = true;
            this.EndTimeCheckBox.CheckedChanged += new System.EventHandler(this.EndTimeCheckBox_CheckedChanged);
            // 
            // EndTimeTextBox
            // 
            this.EndTimeTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.EndTimeTextBox.Location = new System.Drawing.Point(97, 38);
            this.EndTimeTextBox.Mask = "00:00";
            this.EndTimeTextBox.Name = "EndTimeTextBox";
            this.EndTimeTextBox.Size = new System.Drawing.Size(58, 20);
            this.EndTimeTextBox.TabIndex = 16;
            this.EndTimeTextBox.Text = "1250";
            this.EndTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EndTimeTextBox.ValidatingType = typeof(System.DateTime);
            this.EndTimeTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // StartTimeTextBox
            // 
            this.StartTimeTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.StartTimeTextBox.Location = new System.Drawing.Point(97, 65);
            this.StartTimeTextBox.Mask = "00:00";
            this.StartTimeTextBox.Name = "StartTimeTextBox";
            this.StartTimeTextBox.Size = new System.Drawing.Size(58, 20);
            this.StartTimeTextBox.TabIndex = 17;
            this.StartTimeTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StartTimeTextBox.ValidatingType = typeof(System.DateTime);
            this.StartTimeTextBox.TextChanged += new System.EventHandler(this.StartTimeTextBoxValidate);
            this.StartTimeTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // HourTextBox
            // 
            this.HourTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.HourTextBox.Location = new System.Drawing.Point(97, 92);
            this.HourTextBox.Mask = "0";
            this.HourTextBox.Name = "HourTextBox";
            this.HourTextBox.PromptChar = '0';
            this.HourTextBox.Size = new System.Drawing.Size(29, 20);
            this.HourTextBox.TabIndex = 18;
            this.HourTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.HourTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.HourTextBox.TextChanged += new System.EventHandler(this.TextValidate);
            this.HourTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // MinuteTextBox
            // 
            this.MinuteTextBox.InsertKeyMode = System.Windows.Forms.InsertKeyMode.Overwrite;
            this.MinuteTextBox.Location = new System.Drawing.Point(142, 92);
            this.MinuteTextBox.Mask = "00";
            this.MinuteTextBox.Name = "MinuteTextBox";
            this.MinuteTextBox.PromptChar = '0';
            this.MinuteTextBox.Size = new System.Drawing.Size(29, 20);
            this.MinuteTextBox.TabIndex = 19;
            this.MinuteTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MinuteTextBox.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt;
            this.MinuteTextBox.TextChanged += new System.EventHandler(this.TextValidate);
            this.MinuteTextBox.Enter += new System.EventHandler(this.TextBoxEnter);
            // 
            // ConfigurationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 242);
            this.Controls.Add(this.MinuteTextBox);
            this.Controls.Add(this.HourTextBox);
            this.Controls.Add(this.StartTimeTextBox);
            this.Controls.Add(this.EndTimeTextBox);
            this.Controls.Add(this.EndTimeCheckBox);
            this.Controls.Add(this.MinuteHint);
            this.Controls.Add(this.HourHint);
            this.Controls.Add(this.StartHint);
            this.Controls.Add(this.EndHint);
            this.Controls.Add(this.ApplyButton);
            this.Controls.Add(this.DurationLabel);
            this.Controls.Add(this.StartTimeLabel);
            this.Controls.Add(this.SubjectTextBox);
            this.Controls.Add(this.SubjectLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ConfigurationForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Configuration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SubjectLabel;
        private System.Windows.Forms.TextBox SubjectTextBox;
        private System.Windows.Forms.Label StartTimeLabel;
        private System.Windows.Forms.Label DurationLabel;
        private System.Windows.Forms.Button ApplyButton;
        private System.Windows.Forms.Label EndHint;
        private System.Windows.Forms.Label StartHint;
        private System.Windows.Forms.Label HourHint;
        private System.Windows.Forms.Label MinuteHint;
        private System.Windows.Forms.CheckBox EndTimeCheckBox;
        private System.Windows.Forms.MaskedTextBox EndTimeTextBox;
        private System.Windows.Forms.MaskedTextBox StartTimeTextBox;
        private System.Windows.Forms.MaskedTextBox HourTextBox;
        private System.Windows.Forms.MaskedTextBox MinuteTextBox;
    }
}