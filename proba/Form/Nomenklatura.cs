using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proba
{
    public partial class Nomenklatura : Form
    {
        string id_tools;
        string id_view_tools;
        string name;
        string description;
        string price;
        string id_suplier;
        string data_manufacture;
        string id_country;

        DataBase dataBase = new DataBase();
        public Nomenklatura()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_tool", "Номер инструмента");
            dataGridView1.Columns.Add("id_view_tools", "Номер вида инструмента");
            dataGridView1.Columns.Add("name", "Наименование");
            dataGridView1.Columns.Add("description", "Описание");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("id_supplier", "Номер поставщика");
            dataGridView1.Columns.Add("data_manufacture", "Дата поставки");
            dataGridView1.Columns.Add("id_country", "Код страны");
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetDouble(4), record.GetInt32(5), record.GetDateTime(6), record.GetInt32(7));
        }
        private void RefresDataGird(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"Select * from Tools";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Nomenklatura_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefresDataGird(dataGridView1);

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
        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura_add nomenklatura_Add = new Nomenklatura_add();
            nomenklatura_Add.ShowDialog();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"Select * from Tools Where name like '%" + StrokaSearch.Text +"%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if(dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }
        new private void Update()
        {
            dataBase.openConnection();
            for(int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;
                if (rowState == RowState.Existed)
                    continue;
                if(rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Tools where id_tool = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void StrokaSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            if(id_tools == null)
            {
                MessageBox.Show("Не выделена строчка для изменения");
            }
            else
            {
                this.Hide();
                Nomenklatura_update nomenklatura_Update = new Nomenklatura_update(id_tools, id_view_tools, name, description, price, id_suplier, data_manufacture, id_country);
                nomenklatura_Update.ShowDialog();
            }
        }
        public void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                id_tools = row.Cells[0].Value.ToString();
                id_view_tools = row.Cells[1].Value.ToString();
                name = row.Cells[2].Value.ToString();
                description = row.Cells[3].Value.ToString();
                price = row.Cells[4].Value.ToString();
                id_suplier = row.Cells[5].Value.ToString();
                data_manufacture = row.Cells[6].Value.ToString();
                id_country = row.Cells[7].Value.ToString();
            }
        }

       
    }
}
