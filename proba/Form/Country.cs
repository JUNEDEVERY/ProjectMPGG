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
    public partial class Country : Form
    {
        string id_country;
        string country;
        DataBase dataBase = new DataBase();
        public Country()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_country", "Код страны");
            dataGridView1.Columns.Add("country", "страна");
            dataGridView1.Columns.Add("", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1), RowState.ModifiedNew);
        }
        private void RefresDataGird(DataGridView dgw)
        {
            dgw.Rows.Clear();
            dataGridView1.Columns[2].Visible = false;
            string queryString = $"Select * from Country";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryAdd country_Add = new CountryAdd();
            country_Add.ShowDialog();
        }
        private void Country_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefresDataGird(dataGridView1);
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            MainMenu f1 = new MainMenu();
            f1.Show();
            Hide();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            if (id_country == null)
            {
                MessageBox.Show("Не выделена строчка для изменения");
            }
            else
            {
                this.Hide();
                CountryUpd countryupd = new CountryUpd(id_country, country);
                countryupd.ShowDialog();
            }
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();

        }
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[2].Value = RowState.Deleted;
        }
        new private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[2].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from Country where id_country = {id}";
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
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"Select * from Country Where country like '%" + StrokaSearch.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }
        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                id_country = row.Cells[0].Value.ToString();
                country = row.Cells[1].Value.ToString();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }
    }
}

