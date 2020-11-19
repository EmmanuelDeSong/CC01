using CC01.BLL;
using System;
using CC01.BO;
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
    public partial class Eleve : Form
    {
        public Eleve()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {

            Eleve eleve = new Eleve();
            EleveBLO eleveBLO = new EleveBLO();
           

            MessageBox.Show
                (
                "Save done!",
                "Confirmation",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            txtNom.Clear();
            txtPrenom.Clear();
            txtTelephone.Clear();
            txtMatricule.Clear();
            txtVille.Clear();
            txtNaissance.Clear();
            txtEcole.Clear();
        }
    }
}
