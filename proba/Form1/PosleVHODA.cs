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
            SqlConnection sqlconn = new SqlConnection(@"Data Source=ngknn.ru;Initial Catalog=Progect_MPGG1;Persist Security Info=True;User ID=31П;Password=12357");
            string query = "Select *from Users where login = '" + polelogina.Text.Trim() + "' and password = '" + polePassword.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count ==1)
            {
                this.Hide();
                MainMenu mainmenu = new MainMenu();
                mainmenu.ShowDialog();
            }
            else
            {
                MessageBox.Show("Неверный логин и/или пароль");
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
