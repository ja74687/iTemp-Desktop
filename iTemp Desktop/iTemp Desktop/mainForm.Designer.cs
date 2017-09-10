namespace iTemp_Desktop
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pompaCWUONOFF = new System.Windows.Forms.TextBox();
            this.trybPracyLabel = new System.Windows.Forms.TextBox();
            this.pompaCOONOFF = new System.Windows.Forms.TextBox();
            this.tempCWULabel = new System.Windows.Forms.Label();
            this.tempCOLabel = new System.Windows.Forms.Label();
            this.tempAlarmLabel = new System.Windows.Forms.Label();
            this.zadanaTempLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.licznikLabel = new System.Windows.Forms.Label();
            this.wykresCWU = new iTemp_Desktop.VerticalProgressBar();
            this.wykresCO = new iTemp_Desktop.VerticalProgressBar();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pompaCWUONOFF);
            this.groupBox1.Controls.Add(this.trybPracyLabel);
            this.groupBox1.Controls.Add(this.pompaCOONOFF);
            this.groupBox1.Controls.Add(this.tempCWULabel);
            this.groupBox1.Controls.Add(this.tempCOLabel);
            this.groupBox1.Controls.Add(this.tempAlarmLabel);
            this.groupBox1.Controls.Add(this.zadanaTempLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.wykresCWU);
            this.groupBox1.Controls.Add(this.wykresCO);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(275, 316);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Aktualne Dane";
            // 
            // pompaCWUONOFF
            // 
            this.pompaCWUONOFF.Enabled = false;
            this.pompaCWUONOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pompaCWUONOFF.Location = new System.Drawing.Point(153, 220);
            this.pompaCWUONOFF.Name = "pompaCWUONOFF";
            this.pompaCWUONOFF.ReadOnly = true;
            this.pompaCWUONOFF.ShortcutsEnabled = false;
            this.pompaCWUONOFF.Size = new System.Drawing.Size(116, 20);
            this.pompaCWUONOFF.TabIndex = 8;
            this.pompaCWUONOFF.Text = "Pompa CWU: OFF";
            this.pompaCWUONOFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // trybPracyLabel
            // 
            this.trybPracyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.trybPracyLabel.Location = new System.Drawing.Point(6, 269);
            this.trybPracyLabel.Name = "trybPracyLabel";
            this.trybPracyLabel.ReadOnly = true;
            this.trybPracyLabel.Size = new System.Drawing.Size(263, 20);
            this.trybPracyLabel.TabIndex = 8;
            this.trybPracyLabel.Text = "Pompa CWU";
            // 
            // pompaCOONOFF
            // 
            this.pompaCOONOFF.Enabled = false;
            this.pompaCOONOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.pompaCOONOFF.Location = new System.Drawing.Point(7, 220);
            this.pompaCOONOFF.Name = "pompaCOONOFF";
            this.pompaCOONOFF.ReadOnly = true;
            this.pompaCOONOFF.ShortcutsEnabled = false;
            this.pompaCOONOFF.Size = new System.Drawing.Size(116, 20);
            this.pompaCOONOFF.TabIndex = 8;
            this.pompaCOONOFF.Text = "Pompa CO: OFF";
            this.pompaCOONOFF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tempCWULabel
            // 
            this.tempCWULabel.BackColor = System.Drawing.Color.Transparent;
            this.tempCWULabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempCWULabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tempCWULabel.Location = new System.Drawing.Point(182, 193);
            this.tempCWULabel.Name = "tempCWULabel";
            this.tempCWULabel.Size = new System.Drawing.Size(55, 22);
            this.tempCWULabel.TabIndex = 7;
            this.tempCWULabel.Text = "00°C";
            this.tempCWULabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempCOLabel
            // 
            this.tempCOLabel.BackColor = System.Drawing.Color.Transparent;
            this.tempCOLabel.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempCOLabel.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.tempCOLabel.Location = new System.Drawing.Point(29, 193);
            this.tempCOLabel.Name = "tempCOLabel";
            this.tempCOLabel.Size = new System.Drawing.Size(55, 22);
            this.tempCOLabel.TabIndex = 7;
            this.tempCOLabel.Text = "00°C";
            this.tempCOLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempAlarmLabel
            // 
            this.tempAlarmLabel.AutoSize = true;
            this.tempAlarmLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempAlarmLabel.ForeColor = System.Drawing.Color.Red;
            this.tempAlarmLabel.Location = new System.Drawing.Point(105, 138);
            this.tempAlarmLabel.Name = "tempAlarmLabel";
            this.tempAlarmLabel.Size = new System.Drawing.Size(64, 28);
            this.tempAlarmLabel.TabIndex = 7;
            this.tempAlarmLabel.Text = "00°C";
            // 
            // zadanaTempLabel
            // 
            this.zadanaTempLabel.AutoSize = true;
            this.zadanaTempLabel.Font = new System.Drawing.Font("Consolas", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.zadanaTempLabel.Location = new System.Drawing.Point(105, 67);
            this.zadanaTempLabel.Name = "zadanaTempLabel";
            this.zadanaTempLabel.Size = new System.Drawing.Size(64, 28);
            this.zadanaTempLabel.TabIndex = 7;
            this.zadanaTempLabel.Text = "00°C";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Temperatura CWU";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 125);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Temp. Alarmu";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 41);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(73, 26);
            this.label3.TabIndex = 6;
            this.label3.Text = "Zadana temp.\r\nCWU\r\n";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(127, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Wybrany tryb pracy pomp";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Temperatura CO";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown2);
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Location = new System.Drawing.Point(295, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 316);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // licznikLabel
            // 
            this.licznikLabel.AutoSize = true;
            this.licznikLabel.Location = new System.Drawing.Point(13, 336);
            this.licznikLabel.Name = "licznikLabel";
            this.licznikLabel.Size = new System.Drawing.Size(35, 13);
            this.licznikLabel.TabIndex = 8;
            this.licznikLabel.Text = "label6";
            // 
            // wykresCWU
            // 
            this.wykresCWU.Location = new System.Drawing.Point(182, 41);
            this.wykresCWU.Name = "wykresCWU";
            this.wykresCWU.Size = new System.Drawing.Size(55, 149);
            this.wykresCWU.TabIndex = 5;
            // 
            // wykresCO
            // 
            this.wykresCO.Location = new System.Drawing.Point(29, 41);
            this.wykresCO.Name = "wykresCO";
            this.wykresCO.Size = new System.Drawing.Size(55, 149);
            this.wykresCO.TabIndex = 5;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown1.Location = new System.Drawing.Point(149, 19);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(54, 31);
            this.numericUpDown1.TabIndex = 0;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numericUpDown2.Location = new System.Drawing.Point(149, 67);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(54, 31);
            this.numericUpDown2.TabIndex = 0;
            this.numericUpDown2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 352);
            this.Controls.Add(this.licznikLabel);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "iTemp Desktop";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private VerticalProgressBar wykresCO;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private VerticalProgressBar wykresCWU;
        private System.Windows.Forms.Label zadanaTempLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label tempCOLabel;
        private System.Windows.Forms.Label tempAlarmLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label tempCWULabel;
        private System.Windows.Forms.TextBox pompaCOONOFF;
        private System.Windows.Forms.TextBox pompaCWUONOFF;
        private System.Windows.Forms.TextBox trybPracyLabel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label licznikLabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}