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
        public static string Surname;
        public static string Name1;
        public static string Patronymic;
        public static string Login1;
        DataBase dataBase = new DataBase();
        public PosleRegistracii()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconn = new SqlConnection(@"Data Source=ngknn.ru;Initial Catalog=Progect_MPGG1;Persist Security Info=True;User ID=31П;Password=12357");
            if (PoleReg1.TextLength > 15) MessageBox.Show("Максимальная длина логина – 15 символов");
            else if (PoleReg2.TextLength > 25) MessageBox.Show("Максимальная длина пароля – 25 символов");
            else if (PoleReg1.Text.Replace(" ", "") == "") MessageBox.Show("Поле логина не может быть пусто");
            else if (PoleReg2.Text.Replace(" ", "") == "") MessageBox.Show("Поле пароля не может быть пусто");
            else if (surname.Text.Replace(" ", "") == "") MessageBox.Show("Поле фамилия не может быть пусто");
            else if (name.Text.Replace(" ", "") == "") MessageBox.Show("Поле имя не может быть пусто");
            else if (patronymic.Text.Replace(" ", "") == "") MessageBox.Show("Поле отчество не может быть пусто");
            else if (PoleReg2.Text == PoleReg3.Text)
            {
                string query = "Select * from Employee where login = '" + PoleReg1.Text.Trim() + "'";
                SqlDataAdapter sda = new SqlDataAdapter(query, sqlconn);
                DataTable dtbl = new DataTable();
                sda.Fill(dtbl);
                if (dtbl.Rows.Count == 0)
                {
                    dataBase.openConnection();
                    string pol;
                    SqlCommand sqlCommand2 = new SqlCommand($"SELECT id_pol From Pol WHERE pol = '{text_id_pol.Text}'", dataBase.GetConnection());
                    pol = sqlCommand2.ExecuteScalar().ToString();
                    String Proverka = "INSERT INTO  Employee(surname, name , patronymic,  id_pol, date_of_birth, phone, login, password  ) values('" + surname.Text.Trim() + "', '"+ name.Text.Trim() + "', '" + patronymic.Text.Trim() +"', + '" + pol +"', '" + date_of_birth.Text.Trim() +"', '" + phone.Text.Trim() + "', '" + PoleReg1.Text.Trim() + "', '" + PoleReg2.Text.Trim() + "')";
                    SqlDataAdapter sda1 = new SqlDataAdapter(Proverka, sqlconn);
                    DataTable dtbl1 = new DataTable();
                    sda1.Fill(dtbl1);
                    MessageBox.Show("Вы успешно зарегистрировались");
                    this.Hide();
                    Surname = surname.Text;
                    Name1 = name.Text;
                    Patronymic = patronymic.Text;
                    Login1 = PoleReg1.Text;
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

        private void PosleRegistracii_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "progect_MPGG1DataSet6.Pol". При необходимости она может быть перемещена или удалена.
            this.polTableAdapter.Fill(this.progect_MPGG1DataSet6.Pol);

        }

        private void PoleReg1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void PoleReg2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void PoleReg3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (int)Keys.Space)
                e.KeyChar = '\0';
        }

        private void phone_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры и клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void date_of_birth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 46) // цифры, точка и клавиша BackSpace
            {
                e.Handled = true;
            }
        }
    }
}
