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
        ///este es el constructor que inicializa 
    {
        public object Confirmacion { get; private set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            //Cancelar formulario con mensaje de confirmacion
            DialogResult M = MessageBox.Show("¿Desea salir del registro?", "Atención", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            if (M == DialogResult.OK)
                this.Close();

        }
        public void mostrarConfirmacion()
        {
            ///Aca muestro un mensaje que diga contacto guardado
            DialogResult C = MessageBox.Show("Registro exitoso", "Confirmación", MessageBoxButtons.OK);
            if (C == DialogResult.OK)
                this.Close();
        }
 
        public void btGuardar_Click(object sender, EventArgs e)
        { 

            if (txtNombre.Text != String.Empty)
                mostrarConfirmacion();


        }

        
        
            private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dtFecha_ValueChanged(object sender, EventArgs e)
        {
            //aca estoy instanciando la class usuario y la inicializo
            Usuario usuarioParaMostrar;
            usuarioParaMostrar = new Usuario();
            usuarioParaMostrar.Nombre = txtNombre.Text;
            usuarioParaMostrar.Apellido = txtApellido.Text;
            usuarioParaMostrar.Nacimiento = dtFecha.Text;

            //aca llamo almetodo validarCampo
            lblOb1.Text = usuarioParaMostrar.validarCampo();
            lblOb2.Text = usuarioParaMostrar.validarCampo();

            //aca llamo a mi metodo para mostrar
            lblMostrar.Text = usuarioParaMostrar.mostrarDatos();
        }
    }
}
