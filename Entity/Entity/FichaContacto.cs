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
    public partial class FichaContacto : Form
    {
        public AGENDAEntities db { get; set; }
        private Contacto CN = new Contacto();
        public Contacto CSelec { get; set; }
        public FichaContacto()
        {
            InitializeComponent();
        }

        public void actualizarCombos()
        {
            comboBoxGrupo.DataSource = db.Grupo.ToList();
            comboBoxGrupo.DisplayMember = "Descripcion";
            comboBoxGrupo.ValueMember = "Id";
        }
        private void FichaContacto_Load(object sender, EventArgs e)
        {
            idTextBox.Enabled = false;
            actualizarCombos();
            


            if (CSelec != null)
            {
                contactoBindingSource.DataSource = CSelec;
            }
            else
            {
                contactoBindingSource.DataSource = CN;
            }
            
          
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
          
            if (CSelec != null)
            {
                CSelec.Grupo_Id = int.Parse(comboBoxGrupo.SelectedValue.ToString());
                    contactoBindingSource.EndEdit();
               
            }
            else
            {
               
                    CN.Grupo_Id = int.Parse(comboBoxGrupo.SelectedValue.ToString());
                    contactoBindingSource.EndEdit();
                    db.Contacto.AddObject(CN);
               
               

            }

            db.SaveChanges();
            this.Close();
        }

        private void FichaContacto_Activated(object sender, EventArgs e)
        {
            actualizarCombos();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FichaGrupo fg = new FichaGrupo();
            fg.db = this.db;
            fg.MdiParent = this.MdiParent;
            fg.Show();
        }

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
