using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entity
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaPersonas gp = new GrillaPersonas();
            gp.MdiParent = this;
            gp.Show();
           // LaunchChildForm(gp);
        }

        private void gruposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
        }

        private void Menu_Load(object sender, EventArgs e)
        {

        }

        public void LaunchChildForm(Form ChildForm)
        {
            bool FormAlreadyExists = false;
            foreach (Form myForm in this.MdiParent.MdiChildren)
            {
                if (myForm.GetType() == ChildForm.GetType())
                {
                    FormAlreadyExists = true;
                    ChildForm = myForm;
                    break;
                }
            }
            if (FormAlreadyExists == true)
            {
                ChildForm.BringToFront();
            }
            else
            {
                ChildForm.MdiParent = this.MdiParent;
                ChildForm.WindowState = FormWindowState.Normal;
                ChildForm.Show();
            }
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void grillaAdoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GrillaAdo ga = new GrillaAdo();
            ga.MdiParent = this;
            ga.Show();
        }

   // }




    }
}
