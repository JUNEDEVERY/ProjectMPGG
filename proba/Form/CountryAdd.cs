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
    public partial class CountryAdd : Form
    {
        DataBase dataBase = new DataBase();
        public CountryAdd()
        {
            InitializeComponent();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Replace(" ", "") == "") MessageBox.Show("Поле страна не может быть пустым");
            else
            {
                dataBase.openConnection();
                var country = textBox1.Text;
                var addQuery = $"insert into [Country] (country) values (N'{country}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена в таблицу");
                dataBase.closeConnection();
            }
        }



        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Country nomenklatura = new Country();
            nomenklatura.ShowDialog();
        }
    }
}
