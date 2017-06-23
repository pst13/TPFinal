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
    
    public partial class GrillaPersonas : Form
    {
        AGENDAEntities db = new AGENDAEntities();
        public GrillaPersonas()
        {
            InitializeComponent();
        }
        public void actualizarCombos()
        {
            comboBoxGrupo.DataSource = db.Grupo.ToList();
            comboBoxGrupo.DisplayMember = "Descripcion";
            comboBoxGrupo.ValueMember = "Id";
        }
        private void GrillaPersonas_Load(object sender, EventArgs e)
        {
            actualizarCombos();
            contactoBindingSource.DataSource = db.Contacto.ToList();
            contactoDataGridView.DataSource = contactoBindingSource;


        }

        private void butAlta_Click(object sender, EventArgs e)
        {
            FichaContacto fc = new FichaContacto();
            fc.db = this.db;
            fc.MdiParent = this.MdiParent;
            fc.Show();
        }

        private void refrescar()
        {
            contactoBindingSource.DataSource = null;
            contactoDataGridView.DataSource = null;

            contactoBindingSource.DataSource = db.Contacto.ToList();
            contactoDataGridView.DataSource = contactoBindingSource;
        }
        private void GrillaPersonas_Activated(object sender, EventArgs e)
        {
            refrescar();

        }

        private void butModif_Click(object sender, EventArgs e)
        {
            FichaContacto fc = new FichaContacto();
            fc.CSelec =(Contacto) contactoBindingSource.Current;
            fc.db = this.db;
            fc.MdiParent = this.MdiParent;
            fc.Show();
            
        }

        private void butSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void butElimina_Click(object sender, EventArgs e)
        {
            Contacto c = (Contacto)contactoBindingSource.Current;
            db.Contacto.DeleteObject(c);
            db.SaveChanges();
            refrescar();

        }

        private void comboBoxGrupo_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                contactoBindingSource.DataSource = null;
                contactoDataGridView.DataSource = null;
                if (comboBoxGrupo.SelectedValue != null)
                {
                    int cod = int.Parse(comboBoxGrupo.SelectedValue.ToString());
                    contactoBindingSource.DataSource = db.Contacto.Where(a => a.Grupo_Id == cod).ToList();
                    contactoDataGridView.DataSource = contactoBindingSource;
                }
           
            }
            catch (Exception)
            {
                
            }
         
        
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        
        }

       

        private void contactoDataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Contacto c = (Contacto)contactoBindingSource.Current;
                label1.Text = c.concatenaNombre();
            }
            catch (Exception)
            {
                
                
            }
            
        }
    }
}
