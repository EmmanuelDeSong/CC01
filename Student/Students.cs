using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Students : Form
    {
        public Students()
        {
            InitializeComponent();
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            txtNom.Clear();
            txtPrenom.Clear();
            txtVille.Clear();
            txtMatricule.Clear();
            txtEcole.Clear();
            txtNaissance.Clear();
        }

        private void btnValider_Click(object sender, EventArgs e)
        {
            string message = "Eleve enregistrés avec succès";
            string title = "Confirmation";
            MessageBoxButtons buttons = MessageBoxButtons.OK;

            DialogResult result = MessageBox.Show(message, title, buttons);

            
        }
    }
}
