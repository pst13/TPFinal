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
    public partial class FichaGrupo : Form
    {
        public AGENDAEntities db { get; set; }
        public Grupo GN { get; set; }
        public FichaGrupo()
        {
            InitializeComponent();
        }

        private void FichaGrupo_Load(object sender, EventArgs e)
        {
            GN = new Grupo();
            grupoBindingSource.DataSource = GN;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            grupoBindingSource.EndEdit();
            db.Grupo.AddObject(GN);
            db.SaveChanges();

            this.Close();
        }
    }
}
