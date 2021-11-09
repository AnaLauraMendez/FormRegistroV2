using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormRegistroV2
{
    public class Usuario
    { 
        /// Creo las propiedades de la clase usuario en public para usarlas en el form
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Nacimiento { get; set; }

        //METODOS
        public string mostrarDatos() 
        {
            return "REGISTRO INGRESADO \r\n" + "Usuario:\r\n" + Nombre + " " + Apellido + "\r\nFecha de nacimiento:\r\n" + Nacimiento;
        }

        public string validarCampo()
        {
            ///Valido los campos vacios
            if (Nombre == String.Empty)
                return "*Campo obligatorio";
            else return "";

            if (Apellido == String.Empty)
                return "*Campo obligatorio";
            else return "";  
            



        }


    }
}
