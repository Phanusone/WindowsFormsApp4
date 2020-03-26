namespace WindowsFormsApp4
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
            this.panelSlider = new System.Windows.Forms.Panel();
            this.button11 = new System.Windows.Forms.Button();
            this.btMNproduct = new System.Windows.Forms.Button();
            this.btMNemployee = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelBackground = new System.Windows.Forms.Panel();
            this.btMNvendor = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelSlider.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelSlider
            // 
            this.panelSlider.AutoScroll = true;
            this.panelSlider.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panelSlider.Controls.Add(this.btMNvendor);
            this.panelSlider.Controls.Add(this.button11);
            this.panelSlider.Controls.Add(this.btMNproduct);
            this.panelSlider.Controls.Add(this.btMNemployee);
            this.panelSlider.Controls.Add(this.button6);
            this.panelSlider.Controls.Add(this.button5);
            this.panelSlider.Controls.Add(this.button4);
            this.panelSlider.Controls.Add(this.button3);
            this.panelSlider.Controls.Add(this.button2);
            this.panelSlider.Controls.Add(this.button1);
            this.panelSlider.Controls.Add(this.panel1);
            this.panelSlider.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlider.Location = new System.Drawing.Point(0, 0);
            this.panelSlider.Name = "panelSlider";
            this.panelSlider.Size = new System.Drawing.Size(200, 490);
            this.panelSlider.TabIndex = 0;
            this.panelSlider.Paint += new System.Windows.Forms.PaintEventHandler(this.panelSlider_Paint);
            // 
            // button11
            // 
            this.button11.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button11.Location = new System.Drawing.Point(0, 467);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(200, 23);
            this.button11.TabIndex = 11;
            this.button11.Text = "ອອກຈາກລະບົບ";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // btMNproduct
            // 
            this.btMNproduct.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMNproduct.Location = new System.Drawing.Point(0, 320);
            this.btMNproduct.Name = "btMNproduct";
            this.btMNproduct.Size = new System.Drawing.Size(200, 29);
            this.btMNproduct.TabIndex = 10;
            this.btMNproduct.Text = "ຂໍ້ມູນສິນຄ້າ";
            this.btMNproduct.UseVisualStyleBackColor = true;
            this.btMNproduct.Visible = false;
            this.btMNproduct.Click += new System.EventHandler(this.button10_Click);
            // 
            // btMNemployee
            // 
            this.btMNemployee.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMNemployee.Location = new System.Drawing.Point(0, 291);
            this.btMNemployee.Name = "btMNemployee";
            this.btMNemployee.Size = new System.Drawing.Size(200, 29);
            this.btMNemployee.TabIndex = 9;
            this.btMNemployee.Text = "ຂໍ້ມູນພະນັກງານ";
            this.btMNemployee.UseVisualStyleBackColor = true;
            this.btMNemployee.Visible = false;
            this.btMNemployee.Click += new System.EventHandler(this.btMNemployee_Click);
            // 
            // button6
            // 
            this.button6.Dock = System.Windows.Forms.DockStyle.Top;
            this.button6.Location = new System.Drawing.Point(0, 262);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(200, 29);
            this.button6.TabIndex = 6;
            this.button6.Text = "ຈັດການຂໍ້ມູນ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button5
            // 
            this.button5.Dock = System.Windows.Forms.DockStyle.Top;
            this.button5.Location = new System.Drawing.Point(0, 233);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(200, 29);
            this.button5.TabIndex = 5;
            this.button5.Text = "Barcode Generate";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Location = new System.Drawing.Point(0, 204);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(200, 29);
            this.button4.TabIndex = 4;
            this.button4.Text = "ສິນຄ້າ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Dock = System.Windows.Forms.DockStyle.Top;
            this.button3.Location = new System.Drawing.Point(0, 175);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 29);
            this.button3.TabIndex = 3;
            this.button3.Text = "ໃບບິນສັ່ງເຄື່ອງ";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Location = new System.Drawing.Point(0, 146);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(200, 29);
            this.button2.TabIndex = 2;
            this.button2.Text = "ສາງ";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Top;
            this.button1.Location = new System.Drawing.Point(0, 117);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 29);
            this.button1.TabIndex = 1;
            this.button1.Text = "ໜ້າທຳອິດ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 117);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Silver;
            this.label2.Location = new System.Drawing.Point(79, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Admin";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(79, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MR.TA ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // PanelBackground
            // 
            this.PanelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(36)))), ((int)(((byte)(84)))));
            this.PanelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBackground.Location = new System.Drawing.Point(200, 0);
            this.PanelBackground.Name = "PanelBackground";
            this.PanelBackground.Size = new System.Drawing.Size(876, 490);
            this.PanelBackground.TabIndex = 1;
            this.PanelBackground.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelBackground_Paint);
            // 
            // btMNvendor
            // 
            this.btMNvendor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btMNvendor.Location = new System.Drawing.Point(0, 349);
            this.btMNvendor.Name = "btMNvendor";
            this.btMNvendor.Size = new System.Drawing.Size(200, 29);
            this.btMNvendor.TabIndex = 13;
            this.btMNvendor.Text = "ຜູ້ສະໜອງ";
            this.btMNvendor.UseVisualStyleBackColor = true;
            this.btMNvendor.Visible = false;
            this.btMNvendor.Click += new System.EventHandler(this.btMNvendor_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::WindowsFormsApp4.Properties.Resources.robot;
            this.pictureBox1.Location = new System.Drawing.Point(46, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1076, 490);
            this.Controls.Add(this.PanelBackground);
            this.Controls.Add(this.panelSlider);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panelSlider.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlider;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button btMNemployee;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel PanelBackground;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btMNproduct;
        private System.Windows.Forms.Button btMNvendor;
    }
}

