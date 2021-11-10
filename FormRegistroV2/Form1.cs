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
        //tengo que conectar back con front
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
            //aca asigno lo de cada elemento a cada propiedad
            Usuario.Nombre = txtNombre.Text;
            Usuario.Apellido = txtApellido.Text;
            Usuario.Nacimiento = dtFecha.Text;

        //aca llamo elmetodo de carga y le tiro el usuarioc omo argumento
            BackFormulario.CargarRegistro(Usuario); 

        }
    }
}
