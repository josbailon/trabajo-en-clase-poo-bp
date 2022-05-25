using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajo_en_clase_poo_bp
{
    public class profesor : Facultadmiembro
    {
        private string departamento;
        public profesor(string departamento, string nombre, string apellidos, int id,
            string Civilestado, string tipo) : base(nombre, apellidos, Civilestado, id, tipo)
        {
            this.departamento = departamento;
        }

        public void cambioDepart(string departamento)
        {
            this.departamento = departamento;
        }
        public override string ToString()
        {
            return "Departamento " + departamento;
        }
        public void ImprimirProfesor()
        {
            Console.WriteLine("Nombre: " + nombres + "\nApellidos: " + apellidos + "\nID: " + id + "\nEstado Civil: " + Civilestado + "\nTipo: " + tipo + "\nDepartamento: " + departamento + "\n");
        }
    }
}
