using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Usuario
    {
        //Propiedades, Características, Atributos

        //Atributos
        private string apellidos;



        //Propiedades
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Apellidos
        {
            set
            {
                apellidos = value;
            }
            get
            {
                return apellidos;
            }
        }
        public int Edad { get; set; }
        public string Correo { get; set; }
        public string Contrasena { get; set; }

        //Constractores
        public Usuario() 
        { 
        }

        public Usuario(string codigo, string correo)
        {
            Codigo = codigo;
            Correo = correo;
        }

        public Usuario(string codigo, string nombre, string apellidos, int edad, string correo, string contrasena) : this(codigo, nombre)
        {
            Apellidos = apellidos;
            Edad = edad;
            Correo = correo;
            Contrasena = contrasena;
        }

        //Metodos

        public string GetNombreCompleto(string nombre, string apellidos)
        {
            string nombreCompleto = nombre + " " + apellidos;
            return nombreCompleto;
        }

    }
}
