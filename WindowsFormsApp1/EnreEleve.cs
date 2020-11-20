using CC01.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EnreEleve : Form
    {
        private EleveBLO eleveBLO;
        public EnreEleve()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            eleveBLO = new EleveBLO();

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ChargerEnregistrement(IEnumerable<Eleve> eleves)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = eleves;
            lblRowCount.Text = $"{dataGridView1.RowCount} rows";
            dataGridView1.ClearSelection();
           

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form f = new Eleve();
            f.Show();
        }

       
    }
}
