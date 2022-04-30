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
    public partial class BuyTools : Form
    {
        public static int razmer = 0;
        public static string[] buy = new string[1];
        string id_tools;
        DataBase dataBase = new DataBase();
        public BuyTools(string id_tool, string id_view_tools, string name, string description, string price, string id_suplier, string data_manufacture, string id_country)
        {
            InitializeComponent();
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
            Sales sales = new Sales();
            sales.ShowDialog();
        }
        private void text_input_TextChanged(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(text_price.Text) - Convert.ToInt32(text_input.Text);
            text_output.Text = Convert.ToString(a);
        }
        private void button_buy_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string str = Convert.ToString(DateTime.Now);
            string str1;
            SqlCommand sqlCommand1 = new SqlCommand($"SELECT id_employee From Employee WHERE login = '{PosleVHODA.login}'", dataBase.GetConnection());
            str1 = sqlCommand1.ExecuteScalar().ToString();
            var addQuery = $"insert into Sales (id_tool, date_sale, sum, id_employee) values ('{id_tools}','{str}','{text_price.Text}','{str1}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Покупка совершена");
            buy[razmer] = text_name.Text;
            Array.Resize(ref buy, buy.Length + 1);
            razmer++;
            dataBase.closeConnection();
            this.Hide();
            Sales sales = new Sales();
            sales.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
