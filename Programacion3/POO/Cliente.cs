using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO
{
    public class Cliente
    {
        public string Identida { get; set; }
        public string Nombre { get; set; }

        public Cliente() { }

        public Cliente(string identida, string nombre)
        {
            Identida = identida;
            Nombre = nombre;
        }
    }
}
