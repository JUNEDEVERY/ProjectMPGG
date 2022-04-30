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
        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            Prodaja prodaja = new Prodaja();
            prodaja.Show();
        }

        private void ButtonPostavshiki_Click(object sender, EventArgs e)
        {
            this.Close();
            Postavshiki postavshiki = new Postavshiki();
            postavshiki.Show();
        }

        private void ButtonSotrudniki_Click(object sender, EventArgs e)
        {
            this.Close();
            Sotrudniki sotrudniki = new Sotrudniki();
            sotrudniki.Show();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void ButtonNomenklatura_Click(object sender, EventArgs e)
        {
            this.Hide();
            Nomenklatura nomenklatura = new Nomenklatura();
            nomenklatura.ShowDialog();
        }

        private void label8_Click(object sender, EventArgs e)
        {
            this.Hide();
            VidNomenkatury vidNomenkatury = new VidNomenkatury();
            vidNomenkatury.ShowDialog();
        }
    }
}
