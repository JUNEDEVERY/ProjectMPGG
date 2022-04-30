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
    public partial class Postavshiki_add : Form
    {
        DataBase dataBase = new DataBase();
        public Postavshiki_add()
        {
            InitializeComponent();
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
                var addQuery = $"insert into Supplier (name_organization, surname, name, patronymic, id_pol, phone) values ('{textBox2.Text}','{text_price.Text}','{text_data_manufacture.Text}','{textBox1.Text}','{pol}','{textBox3.Text}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена в таблицу");
                dataBase.closeConnection();

            }

        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postavshiki postavshiki = new Postavshiki();
            postavshiki.ShowDialog(); 
        }
        private void Postavshiki_add_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet6.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.progect_MPGG1DataSet6.Pol);


        }
     
           
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        
    }
}
