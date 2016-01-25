using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestionProjet.Vues
{
    public partial class FrmAccueil : Form
    {
        FrmCreationProjet gestionProjet;
        Prévisions gestionprev;
        public FrmAccueil()
        {
            InitializeComponent();
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
            //statusStripDate.Text = DateTime.Now.ToShortTimeString();
            tStripDatenow.Text = DateTime.Now.ToString();
        }

        private void quitterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Affiche la MessageBox.
            result = MessageBox.Show("Fin de l'appliction", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Si yes est appuier sur la message box cela ferme l'application
            if (result == System.Windows.Forms.DialogResult.Yes) this.Close();
        }

        private void gestionProjetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gestionProjet != null && gestionProjet.Visible)
            {
                gérerProjetsToolStripMenuItem1.Enabled = false;
            }
            else
            {
                gérerProjetsToolStripMenuItem1.Enabled = true;
            }
            if (gestionprev != null && gestionprev.Visible)
            {
                prévisionToolStripMenuItem.Enabled = false;
            }
            else
            {
                prévisionToolStripMenuItem.Enabled = true;
            }
        }

        private void gérerProjetsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gestionProjet = new FrmCreationProjet();
            gestionProjet.MdiParent = this;
            gestionProjet.Show();
        }

        private void prévisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionprev = new Prévisions();
            gestionprev.MdiParent = this;
            gestionprev.Show();
        }

        private void cascadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);
        }

        private void verticaleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }
    }
}
