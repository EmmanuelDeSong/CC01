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
    public partial class ListeEleves : Form
    {
        public ListeEleves()
        {
            InitializeComponent();
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            Form form = new Students();
            form.Show();
        }
    }
}
