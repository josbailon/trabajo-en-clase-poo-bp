using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_poo_bp
{

    public class Facultadmiembro
    {
        public string nombres, apellidos, Civilestado, tipo;
        public int id;

        public Facultadmiembro(string nombres, string apellidos, string Civilestado, int id, string tipo)
        {

            this.nombres = nombres;
            this.apellidos = apellidos;
            this.id = id;
            this.Civilestado = Civilestado;
            this.tipo = tipo;
        }

        public void cambioestaCivil(string Civilestado)
        {
            this.Civilestado = Civilestado;
        }

        public void imprimirMFacultad()
        {
            Console.WriteLine("Nombre: " + nombres + "\nApellidos: " + apellidos + "\nID: " + id + "\nEstado Civil: " + Civilestado + "\nTipo: " + tipo + "\n");
        }
    }
}

