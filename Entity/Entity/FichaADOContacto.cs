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
    public partial class FichaADOContacto : Form
    {
        private SqlConnection cnn;
        private SqlDataAdapter da;
        private DataTable dt;
        private SqlCommand comando;
        private SqlDataReader dr;

        public int cs { get; set; }
        public FichaADOContacto()
        {
            InitializeComponent();
        }

        private void FichaADOContacto_Load(object sender, EventArgs e)
        {
            actualizarCombos();
            if (cs!=0)
            {
                string st = Properties.Settings.Default.AGENDAConnectionString;
                cnn = new SqlConnection(st);
                cnn.Open();
                comando = new SqlCommand(string.Format("select * from contacto where id={0}",cs),cnn);
                dr = comando.ExecuteReader();
                dr.Read();
                    idTextBox.Text=dr.GetInt32(0).ToString();
                    nombreTextBox.Text= dr.GetString(1);
                    direccionTextBox.Text=dr.GetString(2);
                    telefonoTextBox.Text = dr.GetString(3);
                    cnn.Close();
                
            }


        }
        public void actualizarCombos()
        {
            string st = Properties.Settings.Default.AGENDAConnectionString;
            cnn = new SqlConnection(st);
            cnn.Open();
            da = new SqlDataAdapter("select * from grupo",cnn);
            dt = new DataTable();
            da.Fill(dt);
            comboBoxGrupo.DataSource = dt;
            comboBoxGrupo.DisplayMember = "Descripcion";
            comboBoxGrupo.ValueMember = "Id";
            cnn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (cs != 0)
            {// la consulta cambia a update
                Close();
            }
            else {//insert 

                string st = Properties.Settings.Default.AGENDAConnectionString;
                cnn = new SqlConnection(st);
                cnn.Open();
                comando = new SqlCommand(string.Format("inserT into contacto"
          + "([Nombre]"
          + ",[Direccion]"
          + ",[Telefono]"
          + ",[Grupo_Id])"
          + "values ('{0}','{1}',{2},{3})",
           nombreTextBox.Text, direccionTextBox.Text, telefonoTextBox.Text, comboBoxGrupo.SelectedValue.ToString()), cnn);
                comando.ExecuteNonQuery();
                cnn.Close();

            }

         
        }

    }
}
