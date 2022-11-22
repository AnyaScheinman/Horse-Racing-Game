namespace Assingment2_HorseRacing_AnyaScheinman
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.GpResults = new System.Windows.Forms.GroupBox();
            this.txtSpeed = new System.Windows.Forms.TextBox();
            this.txtTiming = new System.Windows.Forms.TextBox();
            this.txtWinner = new System.Windows.Forms.TextBox();
            this.GpTally = new System.Windows.Forms.GroupBox();
            this.lblSpeed3 = new System.Windows.Forms.Label();
            this.lblTiming3 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lblSpeed2 = new System.Windows.Forms.Label();
            this.lblTiming2 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lblSpeed1 = new System.Windows.Forms.Label();
            this.lblTiming1 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblSpeed = new System.Windows.Forms.Label();
            this.lblTiming = new System.Windows.Forms.Label();
            this.lblHorsenum = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pStart = new System.Windows.Forms.Panel();
            this.lblStart = new System.Windows.Forms.Label();
            this.pEnd = new System.Windows.Forms.Panel();
            this.lblEnd = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.horse1 = new System.Windows.Forms.Button();
            this.horse2 = new System.Windows.Forms.Button();
            this.horse3 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GpResults.SuspendLayout();
            this.GpTally.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.pStart.SuspendLayout();
            this.pEnd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // GpResults
            // 
            this.GpResults.BackColor = System.Drawing.Color.White;
            this.GpResults.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.GpResults.Controls.Add(this.txtSpeed);
            this.GpResults.Controls.Add(this.txtTiming);
            this.GpResults.Controls.Add(this.txtWinner);
            this.GpResults.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpResults.Location = new System.Drawing.Point(631, 63);
            this.GpResults.Name = "GpResults";
            this.GpResults.Size = new System.Drawing.Size(416, 166);
            this.GpResults.TabIndex = 27;
            this.GpResults.TabStop = false;
            this.GpResults.Text = "Results";
            // 
            // txtSpeed
            // 
            this.txtSpeed.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSpeed.Location = new System.Drawing.Point(64, 123);
            this.txtSpeed.Name = "txtSpeed";
            this.txtSpeed.Size = new System.Drawing.Size(264, 34);
            this.txtSpeed.TabIndex = 12;
            this.txtSpeed.Text = "Speed:";
            // 
            // txtTiming
            // 
            this.txtTiming.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiming.Location = new System.Drawing.Point(64, 67);
            this.txtTiming.Name = "txtTiming";
            this.txtTiming.Size = new System.Drawing.Size(264, 34);
            this.txtTiming.TabIndex = 11;
            this.txtTiming.Text = "Timing:";
            // 
            // txtWinner
            // 
            this.txtWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWinner.Location = new System.Drawing.Point(64, 17);
            this.txtWinner.Name = "txtWinner";
            this.txtWinner.Size = new System.Drawing.Size(264, 34);
            this.txtWinner.TabIndex = 10;
            this.txtWinner.Text = "Winner:";
            // 
            // GpTally
            // 
            this.GpTally.BackColor = System.Drawing.Color.White;
            this.GpTally.Controls.Add(this.lblSpeed3);
            this.GpTally.Controls.Add(this.lblTiming3);
            this.GpTally.Controls.Add(this.lbl3);
            this.GpTally.Controls.Add(this.lblSpeed2);
            this.GpTally.Controls.Add(this.lblTiming2);
            this.GpTally.Controls.Add(this.lbl2);
            this.GpTally.Controls.Add(this.lblSpeed1);
            this.GpTally.Controls.Add(this.lblTiming1);
            this.GpTally.Controls.Add(this.lbl1);
            this.GpTally.Controls.Add(this.lblSpeed);
            this.GpTally.Controls.Add(this.lblTiming);
            this.GpTally.Controls.Add(this.lblHorsenum);
            this.GpTally.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpTally.Location = new System.Drawing.Point(631, 250);
            this.GpTally.Name = "GpTally";
            this.GpTally.Size = new System.Drawing.Size(416, 193);
            this.GpTally.TabIndex = 26;
            this.GpTally.TabStop = false;
            this.GpTally.Text = "Tally";
            // 
            // lblSpeed3
            // 
            this.lblSpeed3.AutoSize = true;
            this.lblSpeed3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSpeed3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed3.Location = new System.Drawing.Point(270, 144);
            this.lblSpeed3.Name = "lblSpeed3";
            this.lblSpeed3.Size = new System.Drawing.Size(103, 29);
            this.lblSpeed3.TabIndex = 21;
            this.lblSpeed3.Text = "               ";
            // 
            // lblTiming3
            // 
            this.lblTiming3.AutoSize = true;
            this.lblTiming3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTiming3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming3.Location = new System.Drawing.Point(185, 144);
            this.lblTiming3.Name = "lblTiming3";
            this.lblTiming3.Size = new System.Drawing.Size(97, 29);
            this.lblTiming3.TabIndex = 20;
            this.lblTiming3.Text = "              ";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(89, 144);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(104, 29);
            this.lbl3.TabIndex = 19;
            this.lbl3.Text = "3             ";
            // 
            // lblSpeed2
            // 
            this.lblSpeed2.AutoSize = true;
            this.lblSpeed2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed2.Location = new System.Drawing.Point(280, 105);
            this.lblSpeed2.Name = "lblSpeed2";
            this.lblSpeed2.Size = new System.Drawing.Size(0, 29);
            this.lblSpeed2.TabIndex = 18;
            // 
            // lblTiming2
            // 
            this.lblTiming2.AutoSize = true;
            this.lblTiming2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming2.Location = new System.Drawing.Point(231, 105);
            this.lblTiming2.Name = "lblTiming2";
            this.lblTiming2.Size = new System.Drawing.Size(97, 29);
            this.lblTiming2.TabIndex = 17;
            this.lblTiming2.Text = "              ";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(89, 105);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(26, 29);
            this.lbl2.TabIndex = 16;
            this.lbl2.Text = "2";
            // 
            // lblSpeed1
            // 
            this.lblSpeed1.AutoSize = true;
            this.lblSpeed1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblSpeed1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpeed1.Location = new System.Drawing.Point(270, 71);
            this.lblSpeed1.Name = "lblSpeed1";
            this.lblSpeed1.Size = new System.Drawing.Size(103, 29);
            this.lblSpeed1.TabIndex = 15;
            this.lblSpeed1.Text = "               ";
            // 
            // lblTiming1
            // 
            this.lblTiming1.AutoSize = true;
            this.lblTiming1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lblTiming1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTiming1.Location = new System.Drawing.Point(185, 71);
            this.lblTiming1.Name = "lblTiming1";
            this.lblTiming1.Size = new System.Drawing.Size(85, 29);
            this.lblTiming1.TabIndex = 14;
            this.lblTiming1.Text = "            ";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(89, 71);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(110, 29);
            this.lbl1.TabIndex = 13;
            this.lbl1.Text = "1              ";
            // 
            // lblSpeed
            // 
            this.lblSpeed.AutoSize = true;
            this.lblSpeed.Location = new System.Drawing.Point(301, 39);
            this.lblSpeed.Name = "lblSpeed";
            this.lblSpeed.Size = new System.Drawing.Size(48, 16);
            this.lblSpeed.TabIndex = 8;
            this.lblSpeed.Text = "Speed";
            // 
            // lblTiming
            // 
            this.lblTiming.AutoSize = true;
            this.lblTiming.Location = new System.Drawing.Point(187, 39);
            this.lblTiming.Name = "lblTiming";
            this.lblTiming.Size = new System.Drawing.Size(48, 16);
            this.lblTiming.TabIndex = 7;
            this.lblTiming.Text = "Timing";
            // 
            // lblHorsenum
            // 
            this.lblHorsenum.AutoSize = true;
            this.lblHorsenum.Location = new System.Drawing.Point(75, 39);
            this.lblHorsenum.Name = "lblHorsenum";
            this.lblHorsenum.Size = new System.Drawing.Size(54, 16);
            this.lblHorsenum.TabIndex = 6;
            this.lblHorsenum.Text = "Horse #";
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStart.Location = new System.Drawing.Point(695, 450);
            this.btnStart.Margin = new System.Windows.Forms.Padding(4);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(100, 42);
            this.btnStart.TabIndex = 25;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRestart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRestart.Location = new System.Drawing.Point(880, 450);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(100, 42);
            this.btnRestart.TabIndex = 24;
            this.btnRestart.Text = "Restart";
            this.btnRestart.UseVisualStyleBackColor = false;
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(-740, -138);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 28;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(226, 237);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 30;
            this.label1.Text = "Horse Race";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pStart
            // 
            this.pStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pStart.Controls.Add(this.lblStart);
            this.pStart.Location = new System.Drawing.Point(25, 227);
            this.pStart.Name = "pStart";
            this.pStart.Size = new System.Drawing.Size(152, 26);
            this.pStart.TabIndex = 37;
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(60, 4);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(53, 16);
            this.lblStart.TabIndex = 0;
            this.lblStart.Text = "START";
            // 
            // pEnd
            // 
            this.pEnd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.pEnd.Controls.Add(this.lblEnd);
            this.pEnd.Location = new System.Drawing.Point(246, 321);
            this.pEnd.Name = "pEnd";
            this.pEnd.Size = new System.Drawing.Size(43, 148);
            this.pEnd.TabIndex = 38;
            // 
            // lblEnd
            // 
            this.lblEnd.AutoSize = true;
            this.lblEnd.Location = new System.Drawing.Point(13, 54);
            this.lblEnd.Name = "lblEnd";
            this.lblEnd.Size = new System.Drawing.Size(17, 48);
            this.lblEnd.TabIndex = 0;
            this.lblEnd.Text = "E\r\nN\r\nD\r\n";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(0, 0);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(536, 492);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 39;
            this.pictureBox4.TabStop = false;
            // 
            // horse1
            // 
            this.horse1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("horse1.BackgroundImage")));
            this.horse1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horse1.Location = new System.Drawing.Point(49, 259);
            this.horse1.Name = "horse1";
            this.horse1.Size = new System.Drawing.Size(28, 28);
            this.horse1.TabIndex = 40;
            this.horse1.UseVisualStyleBackColor = true;
            // 
            // horse2
            // 
            this.horse2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("horse2.BackgroundImage")));
            this.horse2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horse2.Location = new System.Drawing.Point(98, 259);
            this.horse2.Name = "horse2";
            this.horse2.Size = new System.Drawing.Size(28, 28);
            this.horse2.TabIndex = 41;
            this.horse2.UseVisualStyleBackColor = true;
            // 
            // horse3
            // 
            this.horse3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("horse3.BackgroundImage")));
            this.horse3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.horse3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.horse3.Location = new System.Drawing.Point(143, 259);
            this.horse3.Name = "horse3";
            this.horse3.Size = new System.Drawing.Size(28, 28);
            this.horse3.TabIndex = 42;
            this.horse3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(378, 512);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 16);
            this.label2.TabIndex = 43;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(479, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 16);
            this.label3.TabIndex = 44;
            this.label3.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(549, 512);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 16);
            this.label4.TabIndex = 45;
            this.label4.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1119, 609);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.horse3);
            this.Controls.Add(this.horse2);
            this.Controls.Add(this.horse1);
            this.Controls.Add(this.pEnd);
            this.Controls.Add(this.pStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.GpResults);
            this.Controls.Add(this.GpTally);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.pictureBox4);
            this.Name = "Form1";
            this.Text = "HorseRacingGame";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GpResults.ResumeLayout(false);
            this.GpResults.PerformLayout();
            this.GpTally.ResumeLayout(false);
            this.GpTally.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.pStart.ResumeLayout(false);
            this.pStart.PerformLayout();
            this.pEnd.ResumeLayout(false);
            this.pEnd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GpResults;
        private System.Windows.Forms.TextBox txtSpeed;
        private System.Windows.Forms.TextBox txtTiming;
        private System.Windows.Forms.TextBox txtWinner;
        private System.Windows.Forms.GroupBox GpTally;
        private System.Windows.Forms.Label lblSpeed3;
        private System.Windows.Forms.Label lblTiming3;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lblSpeed2;
        private System.Windows.Forms.Label lblTiming2;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lblSpeed1;
        private System.Windows.Forms.Label lblTiming1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblSpeed;
        private System.Windows.Forms.Label lblTiming;
        private System.Windows.Forms.Label lblHorsenum;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnRestart;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel pStart;
        private System.Windows.Forms.Panel pEnd;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblEnd;
        private System.Windows.Forms.Button horse1;
        private System.Windows.Forms.Button horse2;
        private System.Windows.Forms.Button horse3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

