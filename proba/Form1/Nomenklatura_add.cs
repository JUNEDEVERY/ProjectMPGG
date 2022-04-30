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
        DataBase dataBase = new DataBase();
        public Nomenklatura_add()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var id_view_tools = text_id_view_tools.Text;
            var name = tex_name.Text;
            var description = text_description.Text;
            var price = text_price.Text;
            var id_suplier = text_id_supplier.Text;
            var data_manufacture = text_data_manufacture.Text;
            string id_country;
            SqlCommand sqlCommand = new SqlCommand($"SELECT id_country From Country WHERE country = '{text_id_country.Text}'", dataBase.GetConnection());
            id_country = sqlCommand.ExecuteScalar().ToString();
            var addQuery = $"insert into Tools (id_view_tools, name, description, price, id_supplier, data_manufacture, id_country) values ('{id_view_tools}','{name}','{description}','{price}','{id_suplier}','{data_manufacture}','{id_country}')";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно добавлена в таблицу");
            dataBase.closeConnection();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura nomenklatura = new Nomenklatura();
            nomenklatura.ShowDialog();
        }

        private void Nomenklatura_add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet1.Country". При необходимости она может быть перемещена или удалена.
            this.countryTableAdapter.Fill(this.progect_MPGG1DataSet1.Country);

        }

        private void text_id_country_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
