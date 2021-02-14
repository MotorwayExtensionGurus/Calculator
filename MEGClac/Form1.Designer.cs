
namespace MEGCalc
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
            this.tbPlayer1 = new System.Windows.Forms.TextBox();
            this.tbPlayer2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProcentName = new System.Windows.Forms.Label();
            this.Netherrack = new System.Windows.Forms.Label();
            this.Distance = new System.Windows.Forms.Label();
            this.Procent = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tbPasta = new System.Windows.Forms.TextBox();
            this.tbOldN = new System.Windows.Forms.TextBox();
            this.tbOldNE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbDays = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.daysLeft = new System.Windows.Forms.Label();
            this.distancePerDay = new System.Windows.Forms.Label();
            this.NetherrackPerDay = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(27, 70);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(202, 20);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(27, 96);
            this.tbPlayer2.Name = "tbPlayer2";
            this.tbPlayer2.Size = new System.Drawing.Size(202, 20);
            this.tbPlayer2.TabIndex = 1;
            this.tbPlayer2.TextChanged += new System.EventHandler(this.tbPlayer2_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Netherrack mined";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(167, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Distance";
            // 
            // ProcentName
            // 
            this.ProcentName.AutoSize = true;
            this.ProcentName.Location = new System.Drawing.Point(100, 162);
            this.ProcentName.Name = "ProcentName";
            this.ProcentName.Size = new System.Drawing.Size(44, 13);
            this.ProcentName.TabIndex = 4;
            this.ProcentName.Text = "Procent";
            // 
            // Netherrack
            // 
            this.Netherrack.AutoSize = true;
            this.Netherrack.Location = new System.Drawing.Point(24, 132);
            this.Netherrack.Name = "Netherrack";
            this.Netherrack.Size = new System.Drawing.Size(0, 13);
            this.Netherrack.TabIndex = 5;
            this.Netherrack.Click += new System.EventHandler(this.Netherrack_Click);
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(181, 132);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(0, 13);
            this.Distance.TabIndex = 6;
            // 
            // Procent
            // 
            this.Procent.AutoSize = true;
            this.Procent.Location = new System.Drawing.Point(119, 175);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(0, 13);
            this.Procent.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "NE";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 174);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Load";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tbPasta
            // 
            this.tbPasta.Location = new System.Drawing.Point(12, 203);
            this.tbPasta.Multiline = true;
            this.tbPasta.Name = "tbPasta";
            this.tbPasta.Size = new System.Drawing.Size(245, 170);
            this.tbPasta.TabIndex = 12;
            // 
            // tbOldN
            // 
            this.tbOldN.Location = new System.Drawing.Point(339, 70);
            this.tbOldN.Name = "tbOldN";
            this.tbOldN.Size = new System.Drawing.Size(205, 20);
            this.tbOldN.TabIndex = 13;
            this.tbOldN.TextChanged += new System.EventHandler(this.tbOldN_TextChanged);
            // 
            // tbOldNE
            // 
            this.tbOldNE.Location = new System.Drawing.Point(339, 96);
            this.tbOldNE.Name = "tbOldNE";
            this.tbOldNE.Size = new System.Drawing.Size(205, 20);
            this.tbOldNE.TabIndex = 14;
            this.tbOldNE.TextChanged += new System.EventHandler(this.tbOldNE_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(154, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "ETA Calculator. This is optional";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(298, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 13);
            this.label6.TabIndex = 16;
            this.label6.Text = "N";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(291, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "NE";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(376, 54);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "Old coordinates";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(346, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(123, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Days since these coords";
            // 
            // tbDays
            // 
            this.tbDays.Location = new System.Drawing.Point(505, 129);
            this.tbDays.Name = "tbDays";
            this.tbDays.Size = new System.Drawing.Size(39, 20);
            this.tbDays.TabIndex = 20;
            this.tbDays.TextChanged += new System.EventHandler(this.tbDays_TextChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(336, 175);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(48, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Days left";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(460, 175);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(87, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Distance per day";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(392, 234);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(119, 13);
            this.label12.TabIndex = 23;
            this.label12.Text = "Netherrack dug per day";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(343, 203);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(0, 13);
            this.label13.TabIndex = 24;
            // 
            // daysLeft
            // 
            this.daysLeft.AutoSize = true;
            this.daysLeft.Location = new System.Drawing.Point(336, 203);
            this.daysLeft.Name = "daysLeft";
            this.daysLeft.Size = new System.Drawing.Size(41, 13);
            this.daysLeft.TabIndex = 25;
            this.daysLeft.Text = "label14";
            // 
            // distancePerDay
            // 
            this.distancePerDay.AutoSize = true;
            this.distancePerDay.Location = new System.Drawing.Point(463, 204);
            this.distancePerDay.Name = "distancePerDay";
            this.distancePerDay.Size = new System.Drawing.Size(41, 13);
            this.distancePerDay.TabIndex = 26;
            this.distancePerDay.Text = "label15";
            // 
            // NetherrackPerDay
            // 
            this.NetherrackPerDay.AutoSize = true;
            this.NetherrackPerDay.Location = new System.Drawing.Point(416, 259);
            this.NetherrackPerDay.Name = "NetherrackPerDay";
            this.NetherrackPerDay.Size = new System.Drawing.Size(0, 13);
            this.NetherrackPerDay.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(493, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 28;
            this.button2.Text = "Deactivate";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(85, 54);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(87, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "New coordinates";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 379);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NetherrackPerDay);
            this.Controls.Add(this.distancePerDay);
            this.Controls.Add(this.daysLeft);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.tbDays);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbOldNE);
            this.Controls.Add(this.tbOldN);
            this.Controls.Add(this.tbPasta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Procent);
            this.Controls.Add(this.Distance);
            this.Controls.Add(this.Netherrack);
            this.Controls.Add(this.ProcentName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPlayer2);
            this.Controls.Add(this.tbPlayer1);
            this.Name = "Form1";
            this.Text = "Leg calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPlayer1;
        private System.Windows.Forms.TextBox tbPlayer2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProcentName;
        private System.Windows.Forms.Label Netherrack;
        private System.Windows.Forms.Label Distance;
        private System.Windows.Forms.Label Procent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tbPasta;
        private System.Windows.Forms.TextBox tbOldN;
        private System.Windows.Forms.TextBox tbOldNE;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDays;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label daysLeft;
        private System.Windows.Forms.Label distancePerDay;
        private System.Windows.Forms.Label NetherrackPerDay;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label14;
    }
}

