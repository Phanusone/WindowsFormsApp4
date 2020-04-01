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
    public partial class ProductManagement : Form
    {
        //MySqlConnection connOpen = new ConnectDatabase().getConnect();
        //MySqlConnection connClose = new  ConnectDatabase().getCloseConnect();
        MySqlConnection connOpen = DB.getConnect();
        MySqlDataAdapter adapter;
        MySqlCommand cmd;
        String idCat, idUnit;
        public ProductManagement()
        {
            InitializeComponent();
            
        }
       
        private void ProductManagement_Load(object sender, EventArgs e)
        {
            showDataCategory();
            showDataUnit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void showDataCategory()
        {
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter("select * from tbcategory", connOpen);
            adapter.Fill(dt);
            dgvCategory.DataSource = dt;
           
        }
        public void showDataUnit()
        {
            DataTable dt = new DataTable();
            adapter = new MySqlDataAdapter("select * from tbunit", connOpen);
            adapter.Fill(dt);
            dgvUnit.DataSource = dt;
            
        }
        private void btsaveCategory_Click(object sender, EventArgs e)
        {
            insert("tbcategory", "CategoryName", txtNameCategory.Text);
            showDataCategory();
        }

        private void btsaveUn_Click(object sender, EventArgs e)
        {
            insert("tbunit", "UnitName", txtNameUnit.Text);
            showDataUnit();
        }

        private void btUpdateCategory_Click(object sender, EventArgs e)
        {
            Update("tbcategory", "CategoryName", txtNameCategory.Text, idCat, "CategoryID");
            showDataCategory();
        }
        public void insert(String tb,String col, String name)
        {
            try
            {
                cmd = new MySqlCommand("insert into " + tb + " (" + col + ") values ('" + name + "')", connOpen);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
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

        public void Update(String tb, String colName, String name , String id , String colID )
        {
            try
            {
                string sql = "update  " + tb + " set " + colName + " = '" + name + "' where " + colID + " = '" + id + "'";
                MessageBox.Show(sql);
                cmd = new MySqlCommand(sql , connOpen);

                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
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

        public void Delete(String tb, String colID, String ID)
        {
            try
            {
                cmd = new MySqlCommand("Delete From "+ tb +"  Where "+ colID +" = '"+ ID +"' ", connOpen);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Done!");
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

        private void btUpdateUn_Click(object sender, EventArgs e)
        {
            Update("tbunit", "UnitName", txtNameUnit.Text, idUnit, "UnitID");
            showDataUnit();
        }

        private void dgvUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameUnit.Text = dgvUnit.Rows[e.RowIndex].Cells[1].Value.ToString();
            idUnit = dgvUnit.Rows[e.RowIndex].Cells[0].Value.ToString();
        }

        private void btDelCategory_Click(object sender, EventArgs e)
        {
            Delete("tbcategory", "CategoryID", idCat);
            showDataCategory();
        }

        private void btDelUn_Click(object sender, EventArgs e)
        {
            Delete("tbunit", "UnitID", idUnit);
            showDataUnit();
        }

        private void dgvCategory_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameCategory.Text = dgvCategory.Rows[e.RowIndex].Cells[1].Value.ToString();
            idCat = dgvCategory.Rows[e.RowIndex].Cells[0].Value.ToString();   
        }
    }
}
