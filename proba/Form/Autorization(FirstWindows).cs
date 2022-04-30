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
    public partial class Autorization : Form
    {
        public Autorization()
        {
            InitializeComponent();
        }
       private void knopka_vhod(object sender, EventArgs e)
        {
            this.Hide();
            PosleVHODA posleVHODA = new PosleVHODA();
            posleVHODA.Show();
        }

       
        Point lastpoint;//класс для координат
        private void panel1_MouseMove(object sender, MouseEventArgs e) // метод для того, чтобы двигали окно при нажатии на ЛКМ
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastpoint.X;
                this.Top += e.Y - lastpoint.Y;
            }
        }
        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastpoint = new Point(e.X, e.Y);
        }
        private void Autorization_Load(object sender, EventArgs e)
        {
            this.Size = new Size(758, 449);
            this.MaximumSize = new Size(758, 449);
            this.MinimumSize = new Size(758, 449);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            PosleRegistracii posleRegistracii = new PosleRegistracii();
            posleRegistracii.Show();
        }
        public void global_FormClosed(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
