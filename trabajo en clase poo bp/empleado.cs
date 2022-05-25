using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_poo_bp
{
    public class empleado : Facultadmiembro
    {
        public int fechaEntr;
        public short Despachonume;
        public empleado(int fechaEntr, short Despachonume, string nombre, string apellidos, int id, string Civilestado,
            string tipo) : base(nombre, apellidos, Civilestado, id, tipo)
        {
            this.fechaEntr = fechaEntr;
            this.Despachonume = Despachonume;

        }

        public void reasignarDespacho(short Despachonume)
        {
            this.Despachonume = Despachonume;
        }
        public override string ToString()
        {
            return "Fecha de ingreso: " + fechaEntr + "\nDespacho: " + Despachonume;
        }

        public void imprimirEmpleado()
        {
            Console.WriteLine("Nombre: " + nombres + "\nApellidos: " + apellidos + "\nID: " + id + "\nEstado Civil: " + Civilestado + "\nTipo: " + tipo + "\nFecha Ingreso: " + fechaEntr + "\nDespacho: " + Despachonume + "\n ");
        }


    }
}

