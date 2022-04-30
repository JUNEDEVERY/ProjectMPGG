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
    public partial class VidNomenkatury : Form
    {
        string id_view_tools, view_tools;
        DataBase dataBase = new DataBase();
        public VidNomenkatury()
        {
            InitializeComponent();
        }
        private void ReadSingleRow(DataGridView dgw, IDataRecord record)
        {
            dgw.Rows.Add(record.GetInt32(0), record.GetString(1),RowState.ModifiedNew);
        }
        private void RefresDataGird(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string queryString = $"Select * from View_tools";
            SqlCommand command = new SqlCommand(queryString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                ReadSingleRow(dgw, reader);
            }
            reader.Close();
        }
        private void CreateColumns()
        {
            dataGridView1.Columns.Add("id_view_tools", "Номер виде инструмента");
            dataGridView1.Columns.Add("view_tools", "Вид инструмента");
          
        }

        private void VidNomenkatury_Load(object sender, EventArgs e)
        {
            CreateColumns();
            RefresDataGird(dataGridView1);
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura nomenklatura = new Nomenklatura();
            nomenklatura.ShowDialog();
        }
      

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            RefresDataGird(dataGridView1);
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenklatury_add vidNomenkatury_add = new VidNomenklatury_add();
            vidNomenkatury_add.ShowDialog();
        }
        private void Search(DataGridView dgw)
        {
            dgw.Rows.Clear();
            string searchString = $"Select * from View_tools Where view_tools like '%" + StrokaSearch.Text + "%'";
            SqlCommand com = new SqlCommand(searchString, dataBase.GetConnection());
            dataBase.openConnection();
            SqlDataReader read = com.ExecuteReader();
            while (read.Read())
            {
                ReadSingleRow(dgw, read);
            }
            read.Close();
        }
        private void StrokaSearch_TextChanged(object sender, EventArgs e)
        {
            Search(dataGridView1);
        }

        //private void button_insert_Click(object sender, EventArgs e)
        //{
        //    if (id_view_tools == null)
        //    {
        //        MessageBox.Show("Не выделена строчка для изменения");
        //    }
        //    else
        //    {
        //        this.Hide();
        //        Vid nomenklatura_Update = new Nomenklatura_update(id_tools, id_view_tools, name, description, price, id_suplier, data_manufacture, id_country);
        //        nomenklatura_Update.ShowDialog();
        //    }
        //}
        private void deleteRow()
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            dataGridView1.Rows[index].Visible = false;
            if (dataGridView1.Rows[index].Cells[0].Value.ToString() == String.Empty)
            {
                dataGridView1.Rows[index].Cells[1].Value = RowState.Deleted;
                return;
            }
            dataGridView1.Rows[index].Cells[1].Value = RowState.Deleted;
        }
        private void Update()
        {
            dataBase.openConnection();
            for (int index = 0; index < dataGridView1.Rows.Count; index++)
            {
                var rowState = (RowState)dataGridView1.Rows[index].Cells[1].Value;
                if (rowState == RowState.Existed)
                    continue;
                if (rowState == RowState.Deleted)
                {
                    var id = Convert.ToInt32(dataGridView1.Rows[index].Cells[0].Value);
                    var deleteQuery = $"delete from View_tools where id_view_tools = {id}";
                    var command = new SqlCommand(deleteQuery, dataBase.GetConnection());
                    command.ExecuteNonQuery();
                }
            }
            dataBase.closeConnection();
        }
        private void button_delete_Click(object sender, EventArgs e)
        {
            deleteRow();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Update();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedRow = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[selectedRow];
                id_view_tools = row.Cells[0].Value.ToString();
                view_tools = row.Cells[1].Value.ToString();
            }

        }

        private void button_insert_Click(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenklaturyUpdate vidNomenklaturyUpdate = new VidNomenklaturyUpdate(id_view_tools, view_tools);
            vidNomenklaturyUpdate.ShowDialog();
        }
    }
}
