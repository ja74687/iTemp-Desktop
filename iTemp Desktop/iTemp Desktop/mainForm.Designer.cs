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
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tempAlarmSet = new System.Windows.Forms.NumericUpDown();
            this.tempCWUSet = new System.Windows.Forms.NumericUpDown();
            this.licznikLabel = new System.Windows.Forms.Label();
            this.zapiszButton = new System.Windows.Forms.Button();
            this.wykresCWU = new iTemp_Desktop.VerticalProgressBar();
            this.wykresCO = new iTemp_Desktop.VerticalProgressBar();
            this.trybPracyPomp = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pompaCOButton = new System.Windows.Forms.Button();
            this.pompaCWUButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempAlarmSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCWUSet)).BeginInit();
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
            this.groupBox2.Controls.Add(this.pompaCWUButton);
            this.groupBox2.Controls.Add(this.pompaCOButton);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.trybPracyPomp);
            this.groupBox2.Controls.Add(this.zapiszButton);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.tempAlarmSet);
            this.groupBox2.Controls.Add(this.tempCWUSet);
            this.groupBox2.Location = new System.Drawing.Point(295, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 316);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ustawienia";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(6, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "Temp. Alarm";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "Temp. CWU";
            // 
            // tempAlarmSet
            // 
            this.tempAlarmSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempAlarmSet.Location = new System.Drawing.Point(149, 56);
            this.tempAlarmSet.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.tempAlarmSet.Name = "tempAlarmSet";
            this.tempAlarmSet.Size = new System.Drawing.Size(54, 31);
            this.tempAlarmSet.TabIndex = 0;
            this.tempAlarmSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempAlarmSet.ValueChanged += new System.EventHandler(this.numericUpDown2_ValueChanged);
            // 
            // tempCWUSet
            // 
            this.tempCWUSet.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tempCWUSet.Location = new System.Drawing.Point(149, 19);
            this.tempCWUSet.Maximum = new decimal(new int[] {
            90,
            0,
            0,
            0});
            this.tempCWUSet.Name = "tempCWUSet";
            this.tempCWUSet.Size = new System.Drawing.Size(54, 31);
            this.tempCWUSet.TabIndex = 0;
            this.tempCWUSet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tempCWUSet.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
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
            // zapiszButton
            // 
            this.zapiszButton.Location = new System.Drawing.Point(67, 287);
            this.zapiszButton.Name = "zapiszButton";
            this.zapiszButton.Size = new System.Drawing.Size(75, 23);
            this.zapiszButton.TabIndex = 2;
            this.zapiszButton.Text = "Zapisz";
            this.zapiszButton.UseVisualStyleBackColor = true;
            this.zapiszButton.Click += new System.EventHandler(this.zapiszButton_Click);
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
            // trybPracyPomp
            // 
            this.trybPracyPomp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.trybPracyPomp.FormattingEnabled = true;
            this.trybPracyPomp.Location = new System.Drawing.Point(10, 122);
            this.trybPracyPomp.Name = "trybPracyPomp";
            this.trybPracyPomp.Size = new System.Drawing.Size(193, 21);
            this.trybPracyPomp.TabIndex = 3;
            this.trybPracyPomp.SelectedIndexChanged += new System.EventHandler(this.trybPracyPomp_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 106);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 4;
            this.label8.Text = "Tryb pracy pomp:";
            // 
            // pompaCOButton
            // 
            this.pompaCOButton.Location = new System.Drawing.Point(7, 163);
            this.pompaCOButton.Name = "pompaCOButton";
            this.pompaCOButton.Size = new System.Drawing.Size(196, 27);
            this.pompaCOButton.TabIndex = 5;
            this.pompaCOButton.Text = "Pompa CO: ";
            this.pompaCOButton.UseVisualStyleBackColor = true;
            this.pompaCOButton.Click += new System.EventHandler(this.pompaCOButton_Click);
            // 
            // pompaCWUButton
            // 
            this.pompaCWUButton.Location = new System.Drawing.Point(7, 196);
            this.pompaCWUButton.Name = "pompaCWUButton";
            this.pompaCWUButton.Size = new System.Drawing.Size(196, 27);
            this.pompaCWUButton.TabIndex = 5;
            this.pompaCWUButton.Text = "Pompa CWU;";
            this.pompaCWUButton.UseVisualStyleBackColor = true;
            this.pompaCWUButton.Click += new System.EventHandler(this.pompaCWUButton_Click);
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
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tempAlarmSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempCWUSet)).EndInit();
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
        private System.Windows.Forms.NumericUpDown tempCWUSet;
        private System.Windows.Forms.NumericUpDown tempAlarmSet;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button zapiszButton;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox trybPracyPomp;
        private System.Windows.Forms.Button pompaCWUButton;
        private System.Windows.Forms.Button pompaCOButton;
    }
}