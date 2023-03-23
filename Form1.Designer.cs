namespace Lab04
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Name = new System.Windows.Forms.TextBox();
            this.by = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GPA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.g = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NMin = new System.Windows.Forms.TextBox();
            this.NMax = new System.Windows.Forms.TextBox();
            this.AVG = new System.Windows.Forms.TextBox();
            this.Min = new System.Windows.Forms.TextBox();
            this.Max = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.namelist = new System.Windows.Forms.TextBox();
            this.total = new System.Windows.Forms.TextBox();
            this.g.SuspendLayout();
            this.SuspendLayout();
            // 
            // Name
            // 
            this.Name.Location = new System.Drawing.Point(11, 15);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(125, 27);
            this.Name.TabIndex = 0;
            
            // 
            // by
            // 
            this.by.Location = new System.Drawing.Point(11, 48);
            this.by.Name = "by";
            this.by.Size = new System.Drawing.Size(125, 27);
            this.by.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Click";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "ชื่อ";
            
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "ปีเกิด";
            // 
            // GPA
            // 
            this.GPA.Location = new System.Drawing.Point(11, 81);
            this.GPA.Name = "GPA";
            this.GPA.Size = new System.Drawing.Size(125, 27);
            this.GPA.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(154, 88);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(36, 20);
            this.label10.TabIndex = 20;
            this.label10.Text = "GPA";
            // 
            // g
            // 
            this.g.Controls.Add(this.label9);
            this.g.Controls.Add(this.label8);
            this.g.Controls.Add(this.label7);
            this.g.Controls.Add(this.label6);
            this.g.Controls.Add(this.label5);
            this.g.Controls.Add(this.NMin);
            this.g.Controls.Add(this.NMax);
            this.g.Controls.Add(this.AVG);
            this.g.Controls.Add(this.Min);
            this.g.Controls.Add(this.Max);
            this.g.Controls.Add(this.label4);
            this.g.Controls.Add(this.label3);
            this.g.Controls.Add(this.namelist);
            this.g.Controls.Add(this.total);
            this.g.Location = new System.Drawing.Point(239, 8);
            this.g.Name = "g";
            this.g.Size = new System.Drawing.Size(549, 429);
            this.g.TabIndex = 21;
            this.g.TabStop = false;
            this.g.Text = "ข้อมูลรายวิชา";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(491, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(26, 20);
            this.label9.TabIndex = 32;
            this.label9.Text = "ชื่อ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(491, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 31;
            this.label8.Text = "ชื่อ";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 20);
            this.label7.TabIndex = 30;
            this.label7.Text = "GPA Max";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(274, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 29;
            this.label6.Text = "GPA Min";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "GPA AVG";
            // 
            // NMin
            // 
            this.NMin.Location = new System.Drawing.Point(392, 81);
            this.NMin.Multiline = true;
            this.NMin.Name = "NMin";
            this.NMin.Size = new System.Drawing.Size(93, 33);
            this.NMin.TabIndex = 27;
            // 
            // NMax
            // 
            this.NMax.Location = new System.Drawing.Point(392, 27);
            this.NMax.Multiline = true;
            this.NMax.Name = "NMax";
            this.NMax.Size = new System.Drawing.Size(93, 33);
            this.NMax.TabIndex = 26;
            
            // 
            // AVG
            // 
            this.AVG.Location = new System.Drawing.Point(41, 140);
            this.AVG.Multiline = true;
            this.AVG.Name = "AVG";
            this.AVG.Size = new System.Drawing.Size(234, 33);
            this.AVG.TabIndex = 25;
            // 
            // Min
            // 
            this.Min.Location = new System.Drawing.Point(41, 81);
            this.Min.Multiline = true;
            this.Min.Name = "Min";
            this.Min.Size = new System.Drawing.Size(234, 33);
            this.Min.TabIndex = 24;
            // 
            // Max
            // 
            this.Max.Location = new System.Drawing.Point(41, 27);
            this.Max.Multiline = true;
            this.Max.Name = "Max";
            this.Max.Size = new System.Drawing.Size(234, 33);
            this.Max.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(281, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 22;
            this.label4.Text = "รายชื่อ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(281, 208);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "อายุรวม";
            // 
            // namelist
            // 
            this.namelist.Location = new System.Drawing.Point(41, 245);
            this.namelist.Multiline = true;
            this.namelist.Name = "namelist";
            this.namelist.Size = new System.Drawing.Size(234, 172);
            this.namelist.TabIndex = 20;
                
            // 
            // total
            // 
            this.total.Location = new System.Drawing.Point(41, 205);
            this.total.Multiline = true;
            this.total.Name = "total";
            this.total.Size = new System.Drawing.Size(234, 33);
            this.total.TabIndex = 19;
            this.total.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.g);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.GPA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.by);
            this.Controls.Add(this.Name);
            
            this.Text = "Form1";
            this.g.ResumeLayout(false);
            this.g.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox Name;
        private TextBox by;
        private Button button1;
        private Label label1;
        private Label label2;
        private TextBox GPA;
        private Label label10;
        private GroupBox g;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private TextBox NMin;
        private TextBox NMax;
        private TextBox AVG;
        private TextBox Min;
        private TextBox Max;
        private Label label4;
        private Label label3;
        private TextBox namelist;
        private TextBox total;
    }
}