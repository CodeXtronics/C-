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

        private void FrmAccueil_Load(object sender, EventArgs e)
        {
                        
        }

        private void sidentifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result;

            // Affiche la MessageBox.
            result = MessageBox.Show("Fin de l'appliction", "Quitter", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            //Si yes est appuier sur la message box cela ferme l'application
            if (result == System.Windows.Forms.DialogResult.Yes) this.Close();
        }

        private void gérerProjetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionProjet = new FrmCreationProjet();
            gestionProjet.MdiParent = this;
            gestionProjet.Show();            
        }

        private void prévisionnelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gestionprev = new Prévisions();
            gestionprev.MdiParent = this;
            gestionprev.Show();
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.Cascade);
        }

        private void horizontaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileHorizontal);           
        }

        private void verticaleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LayoutMdi(System.Windows.Forms.MdiLayout.TileVertical);
        }

        private void toolStripDropDownGestionProjet_Click(object sender, EventArgs e)
        {
            if (gestionProjet != null && gestionProjet.Visible)
            {
                gérerProjetsToolStripMenuItem.Enabled = false;
            }
            else
            {
                gérerProjetsToolStripMenuItem.Enabled = true;
            }
            if (gestionprev != null&&gestionprev.Visible)
            {
                prévisionnelToolStripMenuItem.Enabled = false;
            }
            else
            {
                prévisionnelToolStripMenuItem.Enabled = true;
            }
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //statusStripDate.Text = DateTime.Now.ToShortTimeString();
            tStripDatenow.Text = DateTime.Now.ToString();
        }
    }
}
