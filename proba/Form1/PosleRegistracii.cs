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
    public partial class PosleRegistracii : Form
    {
        public PosleRegistracii()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=ngknn.ru;Initial Catalog=Progect_MPGG1;Persist Security Info=True;User ID=31П;Password=12357");
            if(PoleReg2.Text == PoleReg3.Text)
            {
                string query = "Select *from Users where login = '" + PoleReg1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 0)
                {

                    String Proverka = "INSERT INTO  Users(login, password) values('" + PoleReg1.Text.Trim() + "', '" + PoleReg2.Text.Trim() + "')";
                    SqlDataAdapter sda1 = new SqlDataAdapter(Proverka, sqlconn);
                    DataTable dtbl1 = new DataTable();
                    sda1.Fill(dtbl1);
                    MessageBox.Show("Вы успешно зарегистрировались");
                    this.Hide();
                    PosleVHODA poslevhoda = new PosleVHODA();
                    poslevhoda.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Логин уже занят!!!");
                }
            }
            else
            {
                MessageBox.Show("Повторный пароль введён не верно!!!");
            }
        }
        private void button_back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Autorization autorization = new Autorization();
            autorization.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
