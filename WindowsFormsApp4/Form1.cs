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
            Stock frmStock = new Stock();
            frmStock.TopLevel = false;
            PanelBackground.Controls.Add(frmStock);
            frmStock.BringToFront();
            frmStock.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Order frmOrder = new Order();
            frmOrder.TopLevel = false;
            PanelBackground.Controls.Add(frmOrder);
            frmOrder.BringToFront();
            frmOrder.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Product frmProduct = new Product();
            frmProduct.TopLevel = false;
            PanelBackground.Controls.Add(frmProduct);
            frmProduct.BringToFront();
            frmProduct.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            GenerateBarcode frmBarcode = new GenerateBarcode();
            frmBarcode.TopLevel = false;
            PanelBackground.Controls.Add(frmBarcode);
            frmBarcode.BringToFront();
            frmBarcode.Show();
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
            btMNemployee.Visible = true;
            btMNproduct.Visible = true;
            btMNvendor.Visible = true;
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

        private void PanelBackground_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
