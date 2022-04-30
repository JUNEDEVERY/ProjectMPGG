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
        Modified,
        ModifiedNew,
        Deleted
    }
    public partial class VidInstrumenta : Form
    {
        //DataBase dataBase1 = new DataBase();
        int selectedrow;
        public VidInstrumenta()
        {
            InitializeComponent();
        }

        private void VidInstrumenta_Load(object sender, EventArgs e)
        {
            this.Size = new Size(758, 449);
            this.MaximumSize = new Size(758, 449);
            this.MinimumSize = new Size(758, 449);
        }

        private void CreateColumns()
        {
            DataGridView1.Columns.Add("id", "id");
        }
    }
}
