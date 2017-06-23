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
    public partial class FICHA : Form
    {
        public FICHA()
        {
            InitializeComponent();
        }

        private void FICHA_Load(object sender, EventArgs e)
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

    }
}
