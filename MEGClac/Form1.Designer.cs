
namespace MEGClac
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
            this.SuspendLayout();
            // 
            // tbPlayer1
            // 
            this.tbPlayer1.Location = new System.Drawing.Point(27, 36);
            this.tbPlayer1.Name = "tbPlayer1";
            this.tbPlayer1.Size = new System.Drawing.Size(202, 20);
            this.tbPlayer1.TabIndex = 0;
            this.tbPlayer1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbPlayer2
            // 
            this.tbPlayer2.Location = new System.Drawing.Point(27, 73);
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
            this.ProcentName.Size = new System.Drawing.Size(72, 13);
            this.ProcentName.TabIndex = 4;
            this.ProcentName.Text = "ProcentName";
            // 
            // Netherrack
            // 
            this.Netherrack.AutoSize = true;
            this.Netherrack.Location = new System.Drawing.Point(24, 132);
            this.Netherrack.Name = "Netherrack";
            this.Netherrack.Size = new System.Drawing.Size(35, 13);
            this.Netherrack.TabIndex = 5;
            this.Netherrack.Text = "label3";
            // 
            // Distance
            // 
            this.Distance.AutoSize = true;
            this.Distance.Location = new System.Drawing.Point(181, 132);
            this.Distance.Name = "Distance";
            this.Distance.Size = new System.Drawing.Size(35, 13);
            this.Distance.TabIndex = 6;
            this.Distance.Text = "label4";
            // 
            // Procent
            // 
            this.Procent.AutoSize = true;
            this.Procent.Location = new System.Drawing.Point(119, 175);
            this.Procent.Name = "Procent";
            this.Procent.Size = new System.Drawing.Size(35, 13);
            this.Procent.TabIndex = 7;
            this.Procent.Text = "label5";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(235, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "N";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 80);
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(275, 385);
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
            this.Name = "Leg calculator";
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
    }
}

