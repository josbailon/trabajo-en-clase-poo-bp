using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_poo_bp
{

    public class personal : Facultadmiembro
    {
        private string seccion;
        public personal(string seccion, string nombre, string apellidos, int id,
            string Civilestado, string tipo) : base(nombre, apellidos, Civilestado, id, tipo)
        {
            this.seccion = seccion;
        }

        public void Seccioncambio(string seccion)
        {
            this.seccion = seccion;
        }
        public override string ToString()
        {
            return "Seccion " + seccion;
        }
        public void ImprimirPersonal()
        {
            
            Console.WriteLine("" + "\nNombre: " + nombres + "\nApellidos: " + apellidos + "\nID: " + id + "\nEstado Civil: " + Civilestado + "\nTipo: " + tipo + "\nSeccion: " + seccion + "\n");
        }
    }
}

