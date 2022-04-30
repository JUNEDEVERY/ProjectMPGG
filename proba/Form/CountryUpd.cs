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
    public partial class CountryUpd : Form
    {
        string id_country;
        DataBase dataBase = new DataBase();
        public CountryUpd(string id_country, string country)
        {
            InitializeComponent();
            textBox1.Text = country;
            this.id_country = id_country;
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Replace(" ", "") == "") MessageBox.Show("Поле страна не может быть пустым");
            else
            {
                dataBase.openConnection();
                var addQuery = $"update Country set country = '{textBox1.Text}' where id_country = '{id_country}'";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена");
                dataBase.closeConnection();
                this.Hide();
                Country vidNomenkatury = new Country();
                vidNomenkatury.ShowDialog();
            }
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Country country = new Country();
            country.ShowDialog();
        }
    }
}
