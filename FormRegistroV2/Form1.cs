using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FormRegistroV2
   
{
    public partial class Form1 : Form
    ///este es el constructor que inicializa todo
    {

        public Usuario Usuario = new Usuario();
        public BackFormulario BackFormulario = new BackFormulario();

     

        public Form1()
        {
            InitializeComponent();
            //aca leo la tabla
           dataGrid.DataSource = BackFormulario.daTa;
        }

     

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Cancelar formulario con mensaje de confirmacion
            DialogResult M = MessageBox.Show("¿Desea salir del registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (M == DialogResult.OK)
                this.Close();

        }
      
 
        private void btGuardar_Click(object sender, EventArgs e)
        {

            Usuario.Nombre = txtNombre.Text;
            Usuario.Apellido = txtApellido.Text;
            Usuario.Nacimiento = dtFecha.Text;
            BackFormulario.CargarRegistro(Usuario);

        }

        

      

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {

            //aca asigno a nombre,ap y nac lo que llene el usuario en los textbox
            Usuario.Nombre = txtNombre.Text;
            Usuario.Apellido = txtApellido.Text;
            Usuario.Nacimiento = dtFecha.Text;

        }
      
         

        

    }
}
