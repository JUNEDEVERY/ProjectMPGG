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
    public partial class Postavshiki : Form
    {
        
        string id_supplier;
        string name_organization;
        string surname;
        string name;
        string patronymic;
        string floor;
        string phone;
        DataBase dataBase = new DataBase();
        public Postavshiki()
        {
            InitializeComponent();
           
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_supplier", "Номер поставщика");
            dataGridView1.Columns.Add("name_organization", "Название организации");
            dataGridView1.Columns.Add("surname", "Фамилия");
            dataGridView1.Columns.Add("name", "Имя");
            dataGridView1.Columns.Add("patronymic", "Отчество");
            dataGridView1.Columns.Add("id_pol", "Пол");
            dataGridView1.Columns.Add("phone", "Мобильный номер");
            dataGridView1.Columns.Add("", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), record.GetString(2), record.GetString(3), record.GetString(4), record.GetInt32(5), record.GetString(6), RowState.ModifiedNew);
        }
        private void RefresDataGird(DataGridView dgw)
        {
            dgw.Rows.Clear();
            dataGridView1.Columns[7].Visible = false;
            string queryString = $"Select * from Supplier";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                id_supplier = row.Cells[0].Value.ToString();
                name_organization = row.Cells[1].Value.ToString();
                surname = row.Cells[2].Value.ToString();
                name = row.Cells[3].Value.ToString();
                patronymic = row.Cells[4].Value.ToString();
                floor = row.Cells[5].Value.ToString();
                phone = row.Cells[6].Value.ToString();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postavshiki_add postavshiki_Add = new Postavshiki_add();
            postavshiki_Add.ShowDialog();

        }
        private void button_insert_Click(object sender, EventArgs e)
        {
            if (id_supplier == null)
            {
                MessageBox.Show("Не выделена строчка для изменения");
            }
            else
            {
                this.Hide();
                Postavshiki_update postavshiki_Update = new Postavshiki_update(id_supplier, name_organization, surname, name, patronymic, floor, phone);
                postavshiki_Update.ShowDialog();
            }
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"Select * from Supplier Where name_organization like '%" + StrokaSearch.Text + "%'";
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
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[7].Value = RowState.Deleted;
        }
        new private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[7].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Supplier where id_supplier = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu main = new MainMenu();
            main.ShowDialog();

        }
        private void button_delete_Click_1(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void Postavshiki_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefresDataGird(dataGridView1);
        }
        private void StrokaSearch_TextChanged_1(object sender, EventArgs e)
        {
            Search(dataGridView1);
            ToolTip t = new ToolTip();
            t.SetToolTip(StrokaSearch, "Поиск осуществляется по названию организации");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
    }
}
