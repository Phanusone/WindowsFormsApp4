using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace WindowsFormsApp4
{
    
    public partial class Employee : Form
    {
        MySqlConnection connOpen = DB.getConnect();
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        public Employee()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //(EMID, EMName, EMSurname, Age, Gender, Address, Tel, Email, User, Password, Status)
            try
            {

                string Gender = "";
                if (rdMale.Checked)
                {
                    Gender = rdMale.Text;
                    
                }
                else if (rdFemale.Checked)
                {
                    Gender = rdFemale.Text;
                }
                cmd = new MySqlCommand("Insert into tbemployee values (@id, @name, @sur, @age, @sex, @address, @tel, @email, @user, @pw, @stat, @pic)", connOpen);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("sur", txtSur.Text);
                cmd.Parameters.AddWithValue("age", txtAge.Text);
                cmd.Parameters.AddWithValue("sex", Gender);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("tel", txtTel.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("user", txtUser.Text);
                cmd.Parameters.AddWithValue("pw", txtPw.Text);
                cmd.Parameters.AddWithValue("stat", cbStatus.SelectedItem.ToString());
                cmd.Parameters.AddWithValue("pic", pic.Image);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                    showData();
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

        private void Employee_Load(object sender, EventArgs e)
        {
            showData();
        }
        public void showData()
        {
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter("select * from tbemployee", connOpen);
            adapter.Fill(dt);
            dataGridView1.DataSource = dt;
            dataGridView1.RowTemplate.Height = 40;
            DataGridViewImageColumn image = new DataGridViewImageColumn();
            image = (DataGridViewImageColumn)dataGridView1.Columns[11];
            image.ImageLayout = DataGridViewImageCellLayout.Stretch;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            String sex, stat;
           txtID.Text =  dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtName.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtSur.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtAge.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            sex = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (sex == "ຊາຍ")
            {
                rdMale.Checked = true;

            }
            else if (sex == "ຍິງ")
            {
                rdFemale.Checked = true;
            }
            txtAddress.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            txtTel.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            txtEmail.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            txtUser.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            txtPw.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();

            stat= dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();
            if (stat == "admin")
            {
                cbStatus.SelectedIndex = 0;
            }else if (stat == "user")
            {
                cbStatus.SelectedIndex = 1;
            }

            //MemoryStream ms = new MemoryStream();
            //Bitmap img = (Bitmap)dataGridView1.Rows[e.RowIndex].Cells[11].Value;
            //img.Save(ms, ImageFormat.Jpeg);
            //pic.Image = Image.FromStream(ms);

            //Byte[] data = new Byte[0];
            //data = (Byte[])(dataGridView1.Rows[e.RowIndex].Cells[11].Value);
            //MemoryStream mem = new MemoryStream(data);
            //pic.Image = Image.FromStream(mem);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btAddpic_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                pic.Image = new Bitmap(open.FileName);
                
                
            }
        }

        private void btEdit_Click(object sender, EventArgs e)
        {
            try
            {

                string Gender = "";
                if (rdMale.Checked)
                {
                    Gender = rdMale.Text;

                }
                else if (rdFemale.Checked)
                {
                    Gender = rdFemale.Text;
                }
                cmd = new MySqlCommand("Update tbemployee set EMName = @name, 	EMSurname = @sur, 	Age = @age, Gender = @sex, Address = @address, Tel = @tel, Email = @email, User = @user, Password = @pw, Status = @stat where EMID = @id ", connOpen);
                cmd.Parameters.AddWithValue("id", txtID.Text);
                cmd.Parameters.AddWithValue("name", txtName.Text);
                cmd.Parameters.AddWithValue("sur", txtSur.Text);
                cmd.Parameters.AddWithValue("age", txtAge.Text);
                cmd.Parameters.AddWithValue("sex", Gender);
                cmd.Parameters.AddWithValue("address", txtAddress.Text);
                cmd.Parameters.AddWithValue("tel", txtTel.Text);
                cmd.Parameters.AddWithValue("email", txtEmail.Text);
                cmd.Parameters.AddWithValue("user", txtUser.Text);
                cmd.Parameters.AddWithValue("pw", txtPw.Text);
                cmd.Parameters.AddWithValue("stat", cbStatus.SelectedItem.ToString());
                
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                    showData();
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

        private void btDel_Click(object sender, EventArgs e)
        {
            try
            {
                cmd = new MySqlCommand("Delete From tbemployee  Where EMID = '" + txtID.Text + "' ", connOpen);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
                    showData();
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

