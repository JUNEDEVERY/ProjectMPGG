using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proba
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void ButtonPostavshiki_Click(object sender, EventArgs e)
        {
            this.Hide();
            Postavshiki postavshiki = new Postavshiki();
            postavshiki.Show();
        }
        private void ButtonNomenklatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura nomenklatura = new Nomenklatura();
            nomenklatura.ShowDialog();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button_nomenklaturaAdd_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura_add nomenklatura_Add = new Nomenklatura_add();
            nomenklatura_Add.ShowDialog();
        }
        private void button_VidTools_Click(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenkatury vidNomenkatury = new VidNomenkatury();
            vidNomenkatury.ShowDialog();
        }
        private void ButtonProdaja_Click(object sender, EventArgs e)
        {
            this.Hide();
            Sales sales = new Sales();
            sales.ShowDialog();
        }

        private void label10_Click(object sender, EventArgs e)
        {
            this.Hide();           
            Postavshiki_add postavshiki_Add = new Postavshiki_add();
            postavshiki_Add.ShowDialog();
        }

        private void button_VidTools_Add_Click(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenklatury_add vidNomenklatury_Add = new VidNomenklatury_add();
            vidNomenklatury_Add.ShowDialog();
        }

        private void button_Country_Click(object sender, EventArgs e)
        {
            this.Hide();
            Country country = new Country();
            country.ShowDialog();
        }

        private void button_Country_add_Click(object sender, EventArgs e)
        {
            this.Hide();
            CountryAdd countryAdd = new CountryAdd();
            countryAdd.ShowDialog();
        }

        private void button_salesList_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }
    }
}
