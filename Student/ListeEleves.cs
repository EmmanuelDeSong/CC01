using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class ListeEleves : Form
    {
        private EleveBLO eleveBLO;
        public ListeEleves()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
            eleveBLO = new EleveBLO(ConfigurationManager.AppSettings["DbFolder"]);
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            Form f = new Students(loadData);
            f.Show();
        }

        private void ListeEleves_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void loadData()
        {
            string value = txtSearch.Text.ToLower();
            var eleves = eleveBLO.GetBy
            (
                x =>
                x.Matricule.ToLower().Contains(value) ||
                x.Nom.ToLower().Contains(value) ||
                x.Prenom.ToLower().Contains(value) ||
                x.Datedenaissance.ToLower().Contains(value) ||
                x.Ville.ToLower().Contains(value) ||
                x.Ecole.ToLower().Contains(value)
            ).OrderBy(x => x.Matricule).ToArray();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = eleves;
            dataGridView1.ClearSelection();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtSearch.Text))
                loadData();
            else
                txtSearch.Clear();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                {
                    Form f = new Students
                    (
                        dataGridView1.SelectedRows[i].DataBoundItem as Eleve,
                        loadData
                    );
                    f.ShowDialog();
                }
            }
        }
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnModifier_Click(sender, e);
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                if (
                    MessageBox.Show
                    (
                        "Do you really want to delete this students(s)?",
                        "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                    ) == DialogResult.Yes
                )
                {
                    for (int i = 0; i < dataGridView1.SelectedRows.Count; i++)
                    {
                        eleveBLO.DeleteEleve(dataGridView1.SelectedRows[i].DataBoundItem as Eleve);
                    }
                    loadData();
                }
            }
        }
    }
}
