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
    public partial class Nomenklatura_update : Form
    {
        string id_tools;
        DataBase dataBase = new DataBase();
        public Nomenklatura_update(string id_tool, string id_view_tools, string name, string description, string price, string id_suplier, string data_manufacture, string id_country)
        {
            InitializeComponent();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet5.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.progect_MPGG1DataSet5.Country);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet4.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter.Fill(this.progect_MPGG1DataSet4.Supplier);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet3.View_tools". При необходимости она может быть перемещена или удалена.
            this.view_toolsTableAdapter.Fill(this.progect_MPGG1DataSet3.View_tools);
            dataBase.openConnection();
            SqlCommand sqlCommand2 = new SqlCommand($"SELECT view_tools From View_tools WHERE id_view_tools = '{id_view_tools}'", dataBase.GetConnection());
            text_id_view_tools.Text = sqlCommand2.ExecuteScalar().ToString();
            text_name.Text = name;
            text_description.Text = description;
            text_price.Text = price;
            SqlCommand sqlCommand1 = new SqlCommand($"SELECT name_organization From Supplier WHERE id_supplier = '{id_suplier}'", dataBase.GetConnection());
            text_id_suplier.Text = sqlCommand1.ExecuteScalar().ToString();
            text_data_manufacture.Text = data_manufacture;
            SqlCommand sqlCommand = new SqlCommand($"SELECT country From Country WHERE id_country = '{id_country}'", dataBase.GetConnection());
            text_id_country.Text = sqlCommand.ExecuteScalar().ToString();
            this.id_tools = id_tool;
            dataBase.closeConnection();
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura nomenklatura = new Nomenklatura();
            nomenklatura.ShowDialog();
        }
        public void button_update_Click(object sender, EventArgs e)
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
                var addQuery = $"update Tools set id_view_tools = '{id_view_tools}', name = '{name}', description = '{description}', price = '{price}', id_supplier = '{id_suplier}', data_manufacture = '{data_manufacture}', id_country = '{id_country}' where id_tool = '{id_tools}'";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно изменена");
                dataBase.closeConnection();
                this.Hide();
                Nomenklatura nomenklatura = new Nomenklatura();
                nomenklatura.ShowDialog();
            }
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Nomenklatura_update_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet.Supplier". При необходимости она может быть перемещена или удалена.
            this.supplierTableAdapter1.Fill(this.progect_MPGG1DataSet.Supplier);

        }
    }
}
