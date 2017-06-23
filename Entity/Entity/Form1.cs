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
    public partial class Form1 : Form
    {
        AGENDAEntities db = new AGENDAEntities();
        public Form1()
        {
            InitializeComponent();
          //  contactoBindingSource.DataSource = db.Contacto.ToList();
          //  contactoDataGridView.DataSource = db.Contacto.ToList(); 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'aGENDADataSet.Grupo' Puede moverla o quitarla según sea necesario.
            grupoBindingSource.DataSource = db.Grupo.ToList();
            grupoDataGridView.DataSource = grupoBindingSource;
        }

        private void grupoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            

        }
    }
}
