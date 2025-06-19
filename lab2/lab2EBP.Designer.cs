namespace WindowsFormsApp1
{
    partial class Form1
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
            this.BRed = new System.Windows.Forms.RadioButton();
            this.BGreen = new System.Windows.Forms.RadioButton();
            this.BBlue = new System.Windows.Forms.RadioButton();
            this.GBColor = new System.Windows.Forms.GroupBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.cbAnimal = new System.Windows.Forms.ComboBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.btnVanish = new System.Windows.Forms.Button();
            this.DateStart = new System.Windows.Forms.DateTimePicker();
            this.DateEnd = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblEnd = new System.Windows.Forms.Label();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.btnDays = new System.Windows.Forms.Button();
            this.btnTime = new System.Windows.Forms.Button();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.lblTimeEnd = new System.Windows.Forms.Label();
            this.lblTimeStart = new System.Windows.Forms.Label();
            this.TimeEnd = new System.Windows.Forms.DateTimePicker();
            this.TimeStart = new System.Windows.Forms.DateTimePicker();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GBColor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // BRed
            // 
            this.BRed.AutoSize = true;
            this.BRed.Location = new System.Drawing.Point(17, 36);
            this.BRed.Name = "BRed";
            this.BRed.Size = new System.Drawing.Size(64, 24);
            this.BRed.TabIndex = 0;
            this.BRed.TabStop = true;
            this.BRed.Text = "Red";
            this.BRed.UseVisualStyleBackColor = true;
            this.BRed.CheckedChanged += new System.EventHandler(this.Red_CheckedChanged);
            // 
            // BGreen
            // 
            this.BGreen.AutoSize = true;
            this.BGreen.Location = new System.Drawing.Point(17, 77);
            this.BGreen.Name = "BGreen";
            this.BGreen.Size = new System.Drawing.Size(79, 24);
            this.BGreen.TabIndex = 1;
            this.BGreen.TabStop = true;
            this.BGreen.Text = "Green";
            this.BGreen.UseVisualStyleBackColor = true;
            this.BGreen.CheckedChanged += new System.EventHandler(this.BGreen_CheckedChanged);
            // 
            // BBlue
            // 
            this.BBlue.AutoSize = true;
            this.BBlue.Location = new System.Drawing.Point(17, 119);
            this.BBlue.Name = "BBlue";
            this.BBlue.Size = new System.Drawing.Size(66, 24);
            this.BBlue.TabIndex = 2;
            this.BBlue.TabStop = true;
            this.BBlue.Text = "Blue";
            this.BBlue.UseVisualStyleBackColor = true;
            this.BBlue.CheckedChanged += new System.EventHandler(this.BBlue_CheckedChanged);
            // 
            // GBColor
            // 
            this.GBColor.Controls.Add(this.BBlue);
            this.GBColor.Controls.Add(this.BGreen);
            this.GBColor.Controls.Add(this.BRed);
            this.GBColor.Location = new System.Drawing.Point(53, 46);
            this.GBColor.Name = "GBColor";
            this.GBColor.Size = new System.Drawing.Size(129, 165);
            this.GBColor.TabIndex = 3;
            this.GBColor.TabStop = false;
            this.GBColor.Text = "Color";
            this.GBColor.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(53, 214);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(129, 37);
            this.lblColor.TabIndex = 4;
            // 
            // cbAnimal
            // 
            this.cbAnimal.FormattingEnabled = true;
            this.cbAnimal.Items.AddRange(new object[] {
            "Cat",
            "Dog",
            "Bird"});
            this.cbAnimal.Location = new System.Drawing.Point(243, 55);
            this.cbAnimal.Name = "cbAnimal";
            this.cbAnimal.Size = new System.Drawing.Size(121, 28);
            this.cbAnimal.TabIndex = 5;
            this.cbAnimal.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(243, 103);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(163, 163);
            this.picBox.TabIndex = 6;
            this.picBox.TabStop = false;
            // 
            // btnVanish
            // 
            this.btnVanish.AutoSize = true;
            this.btnVanish.Location = new System.Drawing.Point(476, 55);
            this.btnVanish.Name = "btnVanish";
            this.btnVanish.Size = new System.Drawing.Size(187, 47);
            this.btnVanish.TabIndex = 7;
            this.btnVanish.Text = "Vanishing Cursor";
            this.btnVanish.UseVisualStyleBackColor = true;
            // 
            // DateStart
            // 
            this.DateStart.Location = new System.Drawing.Point(16, 325);
            this.DateStart.Name = "DateStart";
            this.DateStart.Size = new System.Drawing.Size(348, 26);
            this.DateStart.TabIndex = 8;
            // 
            // DateEnd
            // 
            this.DateEnd.Location = new System.Drawing.Point(399, 325);
            this.DateEnd.Name = "DateEnd";
            this.DateEnd.Size = new System.Drawing.Size(340, 26);
            this.DateEnd.TabIndex = 9;
            // 
            // lblStart
            // 
            this.lblStart.Location = new System.Drawing.Point(12, 299);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(100, 23);
            this.lblStart.TabIndex = 10;
            this.lblStart.Text = "Date Start";
            this.lblStart.Click += new System.EventHandler(this.lblStart_Click);
            // 
            // lblEnd
            // 
            this.lblEnd.Location = new System.Drawing.Point(395, 299);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(100, 23);
            this.lblEnd.TabIndex = 11;
            this.lblEnd.Text = "Date End";
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(762, 327);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(134, 26);
            this.txtDays.TabIndex = 12;
            this.txtDays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDays
            // 
            this.btnDays.Location = new System.Drawing.Point(759, 281);
            this.btnDays.Name = "btnDays";
            this.btnDays.Size = new System.Drawing.Size(137, 41);
            this.btnDays.TabIndex = 13;
            this.btnDays.Text = "Total Day";
            this.btnDays.UseVisualStyleBackColor = true;
            this.btnDays.Click += new System.EventHandler(this.btnDays_Click);
            // 
            // btnTime
            // 
            this.btnTime.Location = new System.Drawing.Point(759, 369);
            this.btnTime.Name = "btnTime";
            this.btnTime.Size = new System.Drawing.Size(137, 41);
            this.btnTime.TabIndex = 19;
            this.btnTime.Text = "Total Time";
            this.btnTime.UseVisualStyleBackColor = true;
            this.btnTime.Click += new System.EventHandler(this.btnTime_Click);
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(762, 415);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(134, 26);
            this.txtTime.TabIndex = 18;
            this.txtTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblTimeEnd
            // 
            this.lblTimeEnd.Location = new System.Drawing.Point(395, 387);
            this.lblTimeEnd.Name = "lblTimeEnd";
            this.lblTimeEnd.Size = new System.Drawing.Size(100, 23);
            this.lblTimeEnd.TabIndex = 17;
            this.lblTimeEnd.Text = "Time End";
            // 
            // lblTimeStart
            // 
            this.lblTimeStart.Location = new System.Drawing.Point(12, 387);
            this.lblTimeStart.Name = "lblTimeStart";
            this.lblTimeStart.Size = new System.Drawing.Size(100, 23);
            this.lblTimeStart.TabIndex = 16;
            this.lblTimeStart.Text = "Time Start";
            // 
            // TimeEnd
            // 
            this.TimeEnd.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeEnd.Location = new System.Drawing.Point(399, 413);
            this.TimeEnd.Name = "TimeEnd";
            this.TimeEnd.Size = new System.Drawing.Size(340, 26);
            this.TimeEnd.TabIndex = 15;
            // 
            // TimeStart
            // 
            this.TimeStart.CustomFormat = "";
            this.TimeStart.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimeStart.Location = new System.Drawing.Point(16, 413);
            this.TimeStart.Name = "TimeStart";
            this.TimeStart.Size = new System.Drawing.Size(348, 26);
            this.TimeStart.TabIndex = 14;
            this.TimeStart.Value = new System.DateTime(2025, 3, 27, 15, 17, 0, 0);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(726, 67);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 20;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(755, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1030, 473);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnTime);
            this.Controls.Add(this.txtTime);
            this.Controls.Add(this.lblTimeEnd);
            this.Controls.Add(this.lblTimeStart);
            this.Controls.Add(this.TimeEnd);
            this.Controls.Add(this.TimeStart);
            this.Controls.Add(this.btnDays);
            this.Controls.Add(this.txtDays);
            this.Controls.Add(this.lblEnd);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.DateEnd);
            this.Controls.Add(this.DateStart);
            this.Controls.Add(this.btnVanish);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.cbAnimal);
            this.Controls.Add(this.lblColor);
            this.Controls.Add(this.GBColor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.GBColor.ResumeLayout(false);
            this.GBColor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton BRed;
        private System.Windows.Forms.RadioButton BGreen;
        private System.Windows.Forms.RadioButton BBlue;
        private System.Windows.Forms.GroupBox GBColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.ComboBox cbAnimal;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button btnVanish;
        private System.Windows.Forms.DateTimePicker DateStart;
        private System.Windows.Forms.DateTimePicker DateEnd;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.Button btnDays;
        private System.Windows.Forms.Button btnTime;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Label lblTimeEnd;
        private System.Windows.Forms.Label lblTimeStart;
        private System.Windows.Forms.DateTimePicker TimeEnd;
        private System.Windows.Forms.DateTimePicker TimeStart;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label1;
    }
}

