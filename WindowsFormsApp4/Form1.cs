using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button10_Click(object sender, EventArgs e)
        {
           
        }

        private void panelSlider_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //MN = Manager
           
        }

        private void btMNvendor_Click(object sender, EventArgs e)
        {

        }

        private void btMNemployee_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

      

        private void button7_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Stock frmStock = new Stock();
            frmStock.TopLevel = false;
            panelMid.Controls.Add(frmStock);
            frmStock.BringToFront();
            frmStock.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Order frmOrder = new Order();
            frmOrder.TopLevel = false;
            panelMid.Controls.Add(frmOrder);
            frmOrder.BringToFront();
            frmOrder.Show();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Product frmProduct = new Product();
            frmProduct.TopLevel = false;
            panelMid.Controls.Add(frmProduct);
            frmProduct.BringToFront();
            frmProduct.Show();
        }

        private void btBarcodeGenerate_Click(object sender, EventArgs e)
        {
            GenerateBarcode frmBarcode = new GenerateBarcode();
            frmBarcode.TopLevel = false;
            panelMid.Controls.Add(frmBarcode);
            frmBarcode.BringToFront();
            frmBarcode.Show();
        }

        private void btManagement_Click(object sender, EventArgs e)
        {
            btMNemployee.Visible = true;
            btMNproduct.Visible = true;
            btMNvendor.Visible = true;
        }

        private void btMNemployee_Click_1(object sender, EventArgs e)
        {
            Employee frmEmployee = new Employee();
            frmEmployee.TopLevel = false;
            panelMid.Controls.Add(frmEmployee);
            frmEmployee.BringToFront();
            frmEmployee.Show();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btMNproduct_Click(object sender, EventArgs e)
        {
            ProductManagement frmMnProduct = new ProductManagement();
            frmMnProduct.TopLevel = false;
            panelMid.Controls.Add(frmMnProduct);
            frmMnProduct.BringToFront();
            frmMnProduct.Show();
        }

        private void btMNvendor_Click_1(object sender, EventArgs e)
        {
            Supplier frmsup = new Supplier();
            frmsup.TopLevel = false;
            panelMid.Controls.Add(frmsup);
            frmsup.BringToFront();
            frmsup.Show();
        }
    }
}
