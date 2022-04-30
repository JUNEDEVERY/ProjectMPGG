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
    public partial class Sales : Form
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
        public Sales()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_tool", "Номер инструмента");
            dataGridView1.Columns.Add("id_view_tools", "Номер вида инструмента");
            dataGridView1.Columns.Add("name", "Наиенование");
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
            string queryString = $"Select * from Tools T LEFT JOIN Sales S ON T.id_tool = S.id_tool WHERE S.id_tool IS NULL";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Sales_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.progect_MPGG1DataSet1.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet3.View_tools". При необходимости она может быть перемещена или удалена.
            this.view_toolsTableAdapter.Fill(this.progect_MPGG1DataSet3.View_tools);
            text_id_view_tools.Text = "";
            text_id_country.Text = "";
            CreateColumns();
            RefresDataGird(dataGridView1);
        }
        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_buy_Click(object sender, EventArgs e)
        {
            if (id_tools == null)
            {
                MessageBox.Show("Не выделена номенклатура для покупки");
            }
            else
            {
                this.Hide();
                BuyTools buyTools = new BuyTools(id_tools, id_view_tools, name, description, price, id_suplier, data_manufacture, id_country);
                buyTools.ShowDialog();
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }
        private void text_id_view_tools_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = "";
            if (text_id_view_tools.Text != "")
            {
                string str1;
                SqlCommand sqlCommand2 = new SqlCommand($"SELECT id_view_tools From View_tools WHERE view_tools = '{text_id_view_tools.Text}'", dataBase.GetConnection());
                str1 = sqlCommand2.ExecuteScalar().ToString();
                if (text_name.Text != "")
                {
                    if (text_id_country.Text != "")
                    {
                        string str2;
                        SqlCommand sqlCommand = new SqlCommand($"SELECT id_country From Country WHERE country = '{text_id_country.Text}'", dataBase.GetConnection());
                        str2 = sqlCommand.ExecuteScalar().ToString();
                        if (text_description.Text != "")
                        {
                            if (text_price1.Text != "")
                            {
                                if (text_price2.Text != "")
                                {
                                    searchString = $"Select * from Tools Where id_view_tools = '{str1}' and name like '%" + text_name.Text + "%' and description like '%" + text_description.Text + "%' and id_country = '" + str2 + "' and price > '" + text_price1.Text + "' and price < '" + text_price2.Text + "'";
                                }
                                else
                                {
                                    searchString = $"Select * from Tools Where id_view_tools = '{str1}' and name like '%" + text_name.Text + "%' and description like '%" + text_description.Text + "%' and id_country = '" + str2 + "' and price > '" + text_price1.Text + "'";
                                }
                            }
                            else
                            {
                                searchString = $"Select * from Tools Where id_view_tools = '{str1}' and name like '%" + text_name.Text + "%' and description like '%" + text_description.Text + "%' and id_country = '" + str2 + "'";
                            }
                        }    
                        else
                        {
                            searchString = $"Select * from Tools Where id_view_tools = '{str1}' and name like '%" + text_name.Text + "%' and id_country = '" + str2 + "'";
                        }
                    }
                    else
                    {
                        searchString = $"Select * from Tools Where id_view_tools = '{str1}' and name like '%" + text_name.Text + "%'";
                    }
                }
                else
                {
                    searchString = $"Select * from Tools Where id_view_tools = '{str1}'";
                }
            }
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void text_name_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void text_id_country_SelectedIndexChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void text_description_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void text_price1_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void text_price2_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
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
