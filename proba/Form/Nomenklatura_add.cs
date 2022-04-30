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
    public partial class Nomenklatura_add : Form
    {
        public static int razmer = 0;
        public static string[] add = new string[1];
        DataBase dataBase = new DataBase();
        public Nomenklatura_add()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (text_id_view_tools.Text.Replace(" ", "") == "") MessageBox.Show("Поле вид инструмента не может быть пустым");
            else if (text_name.Text.Replace(" ", "") == "") MessageBox.Show("Поле название не может быть пустым");
            else if (text_description.Text.Replace(" ", "") == "") MessageBox.Show("Поле описание не может быть пустым");
            else if (text_id_suplier.Text.Replace(" ", "") == "") MessageBox.Show("Поле поставщика не может быть пустым");
            else if (text_data_manufacture.Text.Replace(" ", "") == "") MessageBox.Show("Поле дата поставки не может быть пустым");
            else if (text_id_country.Text.Replace(" ", "") == "") MessageBox.Show("Поле страна не может быть пустым");
            else if (text_price.Text.Replace(" ", "") == "") MessageBox.Show("Поле цена не может быть пустым");
            else
            {
                dataBase.openConnection();
                string id_view_tools;
                SqlCommand sqlCommand2 = new SqlCommand($"SELECT id_view_tools From View_tools WHERE view_tools = '{text_id_view_tools.Text}'", dataBase.GetConnection());
                id_view_tools = sqlCommand2.ExecuteScalar().ToString();
                var name = text_name.Text;
                var description = text_description.Text;
                var price = text_price.Text;
                string id_suplier;
                SqlCommand sqlCommand1 = new SqlCommand($"SELECT id_supplier From Supplier WHERE name_organization = '{text_id_suplier.Text}'", dataBase.GetConnection());
                id_suplier = sqlCommand1.ExecuteScalar().ToString();
                var data_manufacture = text_data_manufacture.Text;
                string id_country;
                SqlCommand sqlCommand = new SqlCommand($"SELECT id_country From Country WHERE country = '{text_id_country.Text}'", dataBase.GetConnection());
                id_country = sqlCommand.ExecuteScalar().ToString();
                var addQuery = $"insert into Tools (id_view_tools, name, description, price, id_supplier, data_manufacture, id_country) values ('{id_view_tools}','{name}','{description}','{price}','{id_suplier}','{data_manufacture}','{id_country}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена в таблицу");
                add[razmer] = text_name.Text;
                Array.Resize(ref add, add.Length + 1);
                razmer++;
                dataBase.closeConnection();
            }
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura nomenklatura = new Nomenklatura();
            nomenklatura.ShowDialog();
        }
        private void Nomenklatura_add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet4.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter1.Fill(this.progect_MPGG1DataSet4.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet3.View_tools". При необходимости она может быть перемещена или удалена.
            this.view_toolsTableAdapter1.Fill(this.progect_MPGG1DataSet3.View_tools);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet6.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.progect_MPGG1DataSet6.Pol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet6.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.progect_MPGG1DataSet6.Pol);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet2.View_tools". При необходимости она может быть перемещена или удалена.
            this.view_toolsTableAdapter.Fill(this.progect_MPGG1DataSet2.View_tools);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.progect_MPGG1DataSet.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.progect_MPGG1DataSet1.Country);
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void text_price_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void text_data_manufacture_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, точка и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
