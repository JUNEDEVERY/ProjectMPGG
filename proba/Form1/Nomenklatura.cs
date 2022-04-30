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
    enum RowState
    {
        Existed,
        New,
        ModifiedNew,
        Deleted
    }
    public partial class Nomenklatura : Form
    {
        DataBase dataBase = new DataBase();
        public Nomenklatura()
        {
            InitializeComponent();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_tool", "Номер инструмента");
            dataGridView1.Columns.Add("id_view_tools", "Номер вида инструмента");
            dataGridView1.Columns.Add("name", "Наиенование");
            dataGridView1.Columns.Add("description", "Описание");
            dataGridView1.Columns.Add("price", "Цена");
            dataGridView1.Columns.Add("id_supplier", "Номер поставщика");
            dataGridView1.Columns.Add("data_manufacture", "Дата поставки");
            dataGridView1.Columns.Add("id_country", "Код страны");
            dataGridView1.Columns.Add("IsNew", String.Empty);
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetInt32(1), record.GetString(2), record.GetString(3), record.GetDouble(4), record.GetInt32(5), record.GetDateTime(6), record.GetInt32(7), RowState.ModifiedNew);
        }
        private void RefresDataGird(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"Select * from Tools";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void Nomenklatura_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefresDataGird(dataGridView1);

        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mainMenu = new MainMenu();
            mainMenu.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            RefresDataGird(dataGridView1);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura_add nomenklatura_Add = new Nomenklatura_add();
            nomenklatura_Add.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            
            printPreviewDialog1.ShowDialog();
        }
        Bitmap bmp;
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
