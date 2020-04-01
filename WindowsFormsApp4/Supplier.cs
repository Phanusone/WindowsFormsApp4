using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp4
{
    public partial class Supplier : Form
    {
        MySqlConnection connOpen = DB.getConnect();
        MySqlDataAdapter adapter;
        String ID;
        MySqlCommand cmd;
        public Supplier()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                cmd = new MySqlCommand("Insert into tbsupplier (SupName, SupSuername, CompanyName, Tel, Address, Email) values ( @name, @sur, @company,  @tel, @address, @email)", connOpen);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("sur", txtSur.Text);
                cmd.Parameters.AddWithValue("company", txtCompany.Text);
                cmd.Parameters.AddWithValue("tel", txtTel.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                    Display();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        public void Display()
        {
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter("select * from tbsupplier", connOpen);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
            ID =  dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSur.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCompany.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
             txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
        }

        private void Supplier_Load(object sender, EventArgs e)
        {
            Display();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                MessageBox.Show(ID);
                cmd = new MySqlCommand("Update tbsupplier set SupName = @name , SupSuername =  @sur, CompanyName = @company, Tel = @tel , Address =  @address, Email = @email  where SupID = "+ ID +"", connOpen);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("sur", txtSur.Text);
                cmd.Parameters.AddWithValue("company", txtCompany.Text);
                cmd.Parameters.AddWithValue("tel", txtTel.Text);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                    Display();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("Delete From tbsupplier  Where SupID = '" + ID + "' ", connOpen);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                    Display();
                }
                else
                {
                    MessageBox.Show("Error!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
    }
}
