using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormLaberinto
{
    public partial class FormPresentacion : Form
    {
       
        public FormPresentacion()
        {
            InitializeComponent();
        }

        private void FormPresentacion_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;// no se puede maximizar
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnContraReloj_Click(object sender, EventArgs e)
        {
            
            Form form=new Form1();


                this.Hide();//se oculta la ventana principal
                form.ShowDialog(this);//
               
             
                
            
            
           
            
            
        }
    }
}
