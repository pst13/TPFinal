using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;


namespace Entity
{
    public partial class GrillaAdo : Form
    {
        private SqlConnection cn;
        private SqlDataAdapter da;
        private DataTable dt=new DataTable();
        public GrillaAdo()
        {
            InitializeComponent();
        }

        private void GrillaAdo_Load(object sender, EventArgs e)
        {
            string sc = Properties.Settings.Default.AGENDAConnectionString;
            cn = new SqlConnection(sc);
            cn.Open();
            da = new SqlDataAdapter("select * from contacto",cn);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            cn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FichaADOContacto fadoc = new FichaADOContacto();
            fadoc.MdiParent = this.MdiParent;
            fadoc.Show();
        }

        private void butModificar_Click(object sender, EventArgs e)
        {
            int cod= int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            FichaADOContacto fadoc = new FichaADOContacto();
            fadoc.MdiParent = this.MdiParent;
            fadoc.cs = cod;
            fadoc.Show();
        }
    }
}
