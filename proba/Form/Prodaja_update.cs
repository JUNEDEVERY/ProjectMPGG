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
    public partial class Prodaja_update : Form
    {
        string id_sale;
        DataBase dataBase = new DataBase();
        public Prodaja_update(string id_sale, string id_tool, string date_sale, string sum, string id_employee)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet7.Tools". При необходимости она может быть перемещена или удалена.
            this.toolsTableAdapter.Fill(this.progect_MPGG1DataSet7.Tools);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet8.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.progect_MPGG1DataSet8.Employee);
            this.id_sale = id_sale;
            dataBase.openConnection();
            SqlCommand sqlCommand2 = new SqlCommand($"SELECT name From Tools WHERE id_tool = '{id_tool}'", dataBase.GetConnection());
            text_name.Text = sqlCommand2.ExecuteScalar().ToString();
            text_data.Text = date_sale;
            text_price.Text = sum;
            SqlCommand sqlCommand1 = new SqlCommand($"SELECT surname From Employee WHERE id_employee = '{id_employee}'", dataBase.GetConnection());
            text_surname.Text = sqlCommand1.ExecuteScalar().ToString();
            dataBase.closeConnection();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 prodaja = new Form2();
            prodaja.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if(text_name.Text.Replace(" ", "") == "") MessageBox.Show("Поле название инструмента не может быть пустым");
            else if (text_data.Text.Replace(" ", "") == "") MessageBox.Show("Поле дата не может быть пустым");
            else if (text_price.Text.Replace(" ", "") == "") MessageBox.Show("Поле цена не может быть пустым");
            else if (text_surname.Text.Replace(" ", "") == "") MessageBox.Show("Поле цена не может быть пустым");
            else
            {
                dataBase.openConnection();
                string id_tool;
                SqlCommand sqlCommand2 = new SqlCommand($"SELECT id_tool From Tools WHERE name = '{text_name.Text}'", dataBase.GetConnection());
                id_tool = sqlCommand2.ExecuteScalar().ToString();
                string id_employee;
                SqlCommand sqlCommand1 = new SqlCommand($"SELECT id_employee From Employee WHERE surname = '{text_surname.Text}'", dataBase.GetConnection());
                id_employee = sqlCommand1.ExecuteScalar().ToString();
                var addQuery = $"update Sales set id_tool = '{id_tool}', date_sale = '{text_data.Text}', sum = '{text_price.Text}', id_employee = '{id_employee}' where id_sale = '{id_sale}'";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена");
                dataBase.closeConnection();
                this.Hide();
                Form2 form2 = new Form2();
                form2.ShowDialog();
            }
        }
    }
}
