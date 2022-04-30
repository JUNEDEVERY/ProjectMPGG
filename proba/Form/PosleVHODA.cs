using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba
{
    public partial class PosleVHODA : Form
    {
        public static string login;
        public PosleVHODA()
        {
            InitializeComponent();
        }
        private void PosleVHODA_Load(object sender, EventArgs e)
        {
            this.Size = new Size(500, 300);
            this.MaximumSize = new Size(500, 300);
            this.MinimumSize = new Size(500, 300);
        }
        private void buttonlogin(object sender, EventArgs e)
        {
            if (polelogina.Text.Replace(" ", "") == "") MessageBox.Show("Поле логин не может быть пустым");
            else if (polePassword.Text.Replace(" ", "") == "") MessageBox.Show("Поле пароль не может быть пустым");
            else
            {
                SqlConnection sqlconn = new SqlConnection(@"Data Source=ngknn.ru;Initial Catalog=Progect_MPGG1;Persist Security Info=True;User ID=31П;Password=12357");
                string query = "Select *from Employee where login = '" + polelogina.Text.Trim() + "' and password = '" + polePassword.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 1)
                {
                    login = polelogina.Text.Trim();
                    this.Hide();
                    MainMenu mainmenu = new MainMenu();
                    mainmenu.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Неверный логин и/или пароль");
                }
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

        private void polelogina_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void polePassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }
    }
}
