using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace proba
{
    public partial class VidNomenklatury_add : Form
    {
        DataBase dataBase = new DataBase();
        public VidNomenklatury_add()
        {
            InitializeComponent();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_back_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenkatury vidNomenkatury = new VidNomenkatury();
            vidNomenkatury.ShowDialog();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            if (text_description.Text.Replace(" ", "") == "") MessageBox.Show("Поле вид инструмента не может быть пустым");
            else
            {
                dataBase.openConnection();
                var view_tools = text_description.Text;
                var addQuery = $"insert into [View_tools] (view_tools) values (N'{view_tools}')";
                var command = new SqlCommand(addQuery, dataBase.GetConnection());
                command.ExecuteNonQuery();
                MessageBox.Show("Запись успешно добавлена в таблицу");
                dataBase.closeConnection();
            }
        }
    }
}
