using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    public class clsAgenda
    {
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }


        public clsAgenda(string Nombre, string Telefono, string Apellido, string Direccion)
        {
            this.Nombre = Nombre;
            this.Telefono = Telefono;
            this.Apellido = Apellido;
            this.Direccion = Direccion;

        }

        public clsAgenda(string Nombre, string Telefono)
        {
            this.Nombre= Nombre;
            this.Telefono= Telefono;
        }

        public void Simple (string Nombre, string Telefono)
        {
           clsAgenda simple = new clsAgenda(Nombre, Telefono);
        }

        public void Completa (string Nombre, string Telefono, string Apellido, string Direccion)
        {
            clsAgenda completa = new clsAgenda(Nombre, Telefono, Apellido, Direccion);
        }
       
    }
}
