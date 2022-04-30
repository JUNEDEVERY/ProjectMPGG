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
    public partial class VidNomenklaturyUpdate : Form
    {
        string id_view_tools;
        string view_tools;
        DataBase dataBase = new DataBase();
        public VidNomenklaturyUpdate(string id_view_tools, string view_tools)
        {
            InitializeComponent();
            text_description.Text = view_tools;
            this.id_view_tools = id_view_tools;
        }


        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenklatury_add vidNomenkatury_Add = new VidNomenklatury_add();
            vidNomenkatury_Add.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button_save_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
         
            var addQuery = $"update View_tools set view_tools = '{text_description.Text}' where id_view_tools = '{id_view_tools}'";
            var command = new SqlCommand(addQuery, dataBase.GetConnection());
            command.ExecuteNonQuery();
            MessageBox.Show("Запись успешно изменена");
            dataBase.closeConnection();
            this.Hide();
            VidNomenkatury vidNomenkatury = new VidNomenkatury();
            vidNomenkatury.ShowDialog();
        }

        //private void VidNomenklatury_add_FormClosing(object sender, FormClosingEventArgs e)
        //{
        //    Application.Exit();
        //}

        private void VidNomenklaturyUpdate_Load(object sender, EventArgs e)
        {

        }
    }
}
