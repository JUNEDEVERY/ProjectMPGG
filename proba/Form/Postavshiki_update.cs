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
    public partial class Postavshiki_update : Form
    {
        string id_supplier;
        DataBase dataBase = new DataBase();
        public Postavshiki_update(string id_supplier, string name_organization,string surname, string name, string patronymic, string pol, string phone)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet6.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.progect_MPGG1DataSet6.Pol);
            dataBase.openConnection();
            SqlCommand sqlCommand2 = new SqlCommand($"SELECT pol From Pol WHERE id_pol = '{pol}'", dataBase.GetConnection());
            text_id_view_tools.Text = sqlCommand2.ExecuteScalar().ToString();
            textBox2.Text = name_organization;
            text_price.Text = surname;
            text_data_manufacture.Text = name;
            textBox1.Text = patronymic;
            textBox3.Text = phone;
            this.id_supplier = id_supplier;
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postavshiki postavshiki = new Postavshiki();
            postavshiki.ShowDialog();

        }
        private void button_save_Click(object sender, EventArgs e)
        {
            if (textBox2.Text.Replace(" ", "") == "") MessageBox.Show("Поле название не может быть пустым");
            else if (text_price.Text.Replace(" ", "") == "") MessageBox.Show("Поле фамилия не может быть пустым");
            else if (text_data_manufacture.Text.Replace(" ", "") == "") MessageBox.Show("Поле имя поставки не может быть пустым");
            else if (textBox1.Text.Replace(" ", "") == "") MessageBox.Show("Поле отчество поставки не может быть пустым");
            else
            {

                dataBase.openConnection();
                string pol;
                SqlCommand sqlCommand2 = new SqlCommand($"SELECT id_pol From Pol WHERE pol = '{text_id_view_tools.Text}'", dataBase.GetConnection());
                pol = sqlCommand2.ExecuteScalar().ToString();
                var addQuery = $"update Supplier set name_organization = '{textBox2.Text}', surname = '{text_price.Text}', name = '{text_data_manufacture.Text}', patronymic = '{textBox1.Text}', id_pol = '{pol}', phone = '{textBox3.Text}' where id_supplier = '{id_supplier}'";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена");
                dataBase.closeConnection();

                this.Hide();
                Postavshiki postavshiki = new Postavshiki();
                postavshiki.ShowDialog();
            }
        }
        
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
