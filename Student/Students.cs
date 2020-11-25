using CC01.BLL;
using CC01.BO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student
{
    public partial class Students : Form
    {
        private Action callBack;
        private Eleve oldEleve;
        public Students()
        {
            InitializeComponent();
        }

        public Students(Action callBack) : this()
        {
            this.callBack = callBack;
        }

        public Students(Eleve eleve, Action callBack) : this(callBack)
        {
            this.oldEleve = eleve;
            txtMatricule.Text = eleve.Matricule;
            txtNom.Text = eleve.Nom;
            txtPrenom.Text = eleve.Prenom;
            txtNaissance.Text = eleve.Datedenaissance;
            txtVille.Text = eleve.Ville;
            if (eleve.Photo != null)
                pictureBox1.Image = Image.FromStream(new MemoryStream(eleve.Photo));
        }

        private void Students_Load(object sender, EventArgs e)
        {

        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            Close();
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
            try
            {
                Eleve newEleve = new Eleve
                (
                    txtMatricule.Text.ToUpper(),
                    txtNom.Text,
                    txtPrenom.Text,
                    txtEcole.Text,
                    txtNaissance.Text,
                    txtVille.Text,
                    !string.IsNullOrEmpty(pictureBox1.ImageLocation) ? File.ReadAllBytes(pictureBox1.ImageLocation) : this.oldEleve?.Photo
                );

                EleveBLO eleveBLo = new EleveBLO(ConfigurationManager.AppSettings["DbFolder"]);

                if (this.oldEleve == null)
                    eleveBLo.CreateEleve(newEleve);
                else
                    eleveBLo.EditEtudiant(oldEleve, newEleve);

                MessageBox.Show
                (
                    "Save done !",
                    "Confirmation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

                if (callBack != null)
                    callBack();

                if (oldEleve != null)
                    Close();

                txtMatricule.Clear();
                txtNom.Clear();
                txtPrenom.Clear();
                txtNaissance.Clear();
                txtVille.Clear();
                txtEcole.Clear();

            }
            catch (TypingException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Typing error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (DuplicateNameException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Duplicate error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (KeyNotFoundException ex)
            {
                MessageBox.Show
               (
                   ex.Message,
                   "Not found error",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Warning
               );
            }
            catch (Exception ex)
            {
                ex.WriteToFile();
                MessageBox.Show
               (
                   "An error occurred! Please try again later.",
                   "Erreur",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error
               );
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Title = "Choose a picture";
            ofd.Filter = "Image files|*.jpg;*.jpeg;*.png;*.gif";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.ImageLocation = ofd.FileName;
            }
        }
    }
}
