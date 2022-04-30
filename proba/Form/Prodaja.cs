using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proba
{
    public partial class Form2 : Form
    {
        string id_sale;
        string id_tool;
        string date_sale;
        string sum;
        string id_employee;

        DataBase dataBase = new DataBase();
        public Form2()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_sale", "Номер продажи");
            dataGridView1.Columns.Add("id_tool", "Номер инструмента");
            dataGridView1.Columns.Add("date_sale", "Дата");
            dataGridView1.Columns.Add("sum", "Сумма");
            dataGridView1.Columns.Add("id_employee", "Код сотрудника");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetDateTime(2), record.GetDouble(3), record.GetInt32(4));
        }
        private void RefresDataGird(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"Select * from Sales";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"Select * from Sales Where id_tool like '%" + StrokaSearch.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void StrokaSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefresDataGird(dataGridView1);
        }

        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[4].Value = RowState.Deleted;
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        new private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[4].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Sales where id_sale = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (id_sale == null)
            {
                MessageBox.Show("Не выделена строчка для изменения");
            }
            else
            {
                this.Hide();
                Prodaja_update prodaja_Update = new Prodaja_update(id_sale, id_tool, date_sale, sum, id_employee);
                prodaja_Update.ShowDialog();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                id_sale = row.Cells[0].Value.ToString();
                id_tool = row.Cells[1].Value.ToString();
                date_sale = row.Cells[2].Value.ToString();
                sum = row.Cells[3].Value.ToString();
                id_employee = row.Cells[4].Value.ToString();
            }
        }
        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.ShowDialog();
        }
    }
}
