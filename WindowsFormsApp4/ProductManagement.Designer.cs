namespace WindowsFormsApp4
{
    partial class ProductManagement
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNameUnit = new System.Windows.Forms.TextBox();
            this.btDelUn = new System.Windows.Forms.Button();
            this.btUpdateUn = new System.Windows.Forms.Button();
            this.btsaveUn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btDelCategory = new System.Windows.Forms.Button();
            this.btUpdateCategory = new System.Windows.Forms.Button();
            this.txtNameCategory = new System.Windows.Forms.TextBox();
            this.btsaveCategory = new System.Windows.Forms.Button();
            this.dgvCategory = new System.Windows.Forms.DataGridView();
            this.dgvUnit = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "ຊື່ຫົວໜ່ວຍ";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNameUnit);
            this.groupBox2.Controls.Add(this.btDelUn);
            this.groupBox2.Controls.Add(this.btUpdateUn);
            this.groupBox2.Controls.Add(this.btsaveUn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(3, 320);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(336, 169);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ຫົວໜ່ວຍສິນຄ້າ";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // txtNameUnit
            // 
            this.txtNameUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameUnit.Location = new System.Drawing.Point(23, 73);
            this.txtNameUnit.Name = "txtNameUnit";
            this.txtNameUnit.Size = new System.Drawing.Size(194, 26);
            this.txtNameUnit.TabIndex = 5;
            // 
            // btDelUn
            // 
            this.btDelUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelUn.Location = new System.Drawing.Point(212, 120);
            this.btDelUn.Name = "btDelUn";
            this.btDelUn.Size = new System.Drawing.Size(89, 29);
            this.btDelUn.TabIndex = 10;
            this.btDelUn.Text = "del";
            this.btDelUn.UseVisualStyleBackColor = true;
            this.btDelUn.Click += new System.EventHandler(this.btDelUn_Click);
            // 
            // btUpdateUn
            // 
            this.btUpdateUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateUn.Location = new System.Drawing.Point(117, 120);
            this.btUpdateUn.Name = "btUpdateUn";
            this.btUpdateUn.Size = new System.Drawing.Size(89, 29);
            this.btUpdateUn.TabIndex = 9;
            this.btUpdateUn.Text = "update";
            this.btUpdateUn.UseVisualStyleBackColor = true;
            this.btUpdateUn.Click += new System.EventHandler(this.btUpdateUn_Click);
            // 
            // btsaveUn
            // 
            this.btsaveUn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaveUn.Location = new System.Drawing.Point(23, 120);
            this.btsaveUn.Name = "btsaveUn";
            this.btsaveUn.Size = new System.Drawing.Size(88, 29);
            this.btsaveUn.TabIndex = 8;
            this.btsaveUn.Text = "save";
            this.btsaveUn.UseVisualStyleBackColor = true;
            this.btsaveUn.Click += new System.EventHandler(this.btsaveUn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "ຊື່ປະເພດສິນຄ້າ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btDelCategory);
            this.groupBox1.Controls.Add(this.btUpdateCategory);
            this.groupBox1.Controls.Add(this.txtNameCategory);
            this.groupBox1.Controls.Add(this.btsaveCategory);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(336, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ປະເພດສິນຄ້າ";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btDelCategory
            // 
            this.btDelCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDelCategory.Location = new System.Drawing.Point(212, 113);
            this.btDelCategory.Name = "btDelCategory";
            this.btDelCategory.Size = new System.Drawing.Size(89, 29);
            this.btDelCategory.TabIndex = 6;
            this.btDelCategory.Text = "del";
            this.btDelCategory.UseVisualStyleBackColor = true;
            this.btDelCategory.Click += new System.EventHandler(this.btDelCategory_Click);
            // 
            // btUpdateCategory
            // 
            this.btUpdateCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdateCategory.Location = new System.Drawing.Point(117, 113);
            this.btUpdateCategory.Name = "btUpdateCategory";
            this.btUpdateCategory.Size = new System.Drawing.Size(89, 29);
            this.btUpdateCategory.TabIndex = 5;
            this.btUpdateCategory.Text = "Update";
            this.btUpdateCategory.UseVisualStyleBackColor = true;
            this.btUpdateCategory.Click += new System.EventHandler(this.btUpdateCategory_Click);
            // 
            // txtNameCategory
            // 
            this.txtNameCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNameCategory.Location = new System.Drawing.Point(23, 72);
            this.txtNameCategory.Name = "txtNameCategory";
            this.txtNameCategory.Size = new System.Drawing.Size(194, 26);
            this.txtNameCategory.TabIndex = 4;
            // 
            // btsaveCategory
            // 
            this.btsaveCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btsaveCategory.Location = new System.Drawing.Point(23, 113);
            this.btsaveCategory.Name = "btsaveCategory";
            this.btsaveCategory.Size = new System.Drawing.Size(88, 29);
            this.btsaveCategory.TabIndex = 3;
            this.btsaveCategory.Text = "Save";
            this.btsaveCategory.UseVisualStyleBackColor = true;
            this.btsaveCategory.Click += new System.EventHandler(this.btsaveCategory_Click);
            // 
            // dgvCategory
            // 
            this.dgvCategory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategory.Location = new System.Drawing.Point(24, 22);
            this.dgvCategory.Name = "dgvCategory";
            this.dgvCategory.Size = new System.Drawing.Size(496, 224);
            this.dgvCategory.TabIndex = 1;
            this.dgvCategory.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategory_CellContentClick);
            // 
            // dgvUnit
            // 
            this.dgvUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUnit.Location = new System.Drawing.Point(24, 306);
            this.dgvUnit.Name = "dgvUnit";
            this.dgvUnit.Size = new System.Drawing.Size(505, 216);
            this.dgvUnit.TabIndex = 2;
            this.dgvUnit.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUnit_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(777, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(53, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Refresh";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(342, 637);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgvCategory);
            this.panel2.Controls.Add(this.dgvUnit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(342, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(642, 637);
            this.panel2.TabIndex = 10;
            // 
            // ProductManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 637);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProductManagement";
            this.Text = "ProductManagement";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.ProductManagement_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategory)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUnit)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btsaveCategory;
        private System.Windows.Forms.TextBox txtNameUnit;
        private System.Windows.Forms.Button btDelUn;
        private System.Windows.Forms.Button btUpdateUn;
        private System.Windows.Forms.Button btsaveUn;
        private System.Windows.Forms.Button btDelCategory;
        private System.Windows.Forms.Button btUpdateCategory;
        private System.Windows.Forms.TextBox txtNameCategory;
        private System.Windows.Forms.DataGridView dgvCategory;
        private System.Windows.Forms.DataGridView dgvUnit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}