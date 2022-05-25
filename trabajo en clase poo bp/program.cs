using System;

namespace trabajo_en_clase_poo_bp
{
    class Program
    {
        static void Main(string[] args)
        {
            Facultadmiembro facultad = new Facultadmiembro("julio", "mera", "Soltero", 565, "Estudiante");
            facultad.imprimirMFacultad();

            estudiante estudiante = new estudiante("9  B", "juan", "peres", 653, "Soltero", "Estudiante");
            estudiante.nuevoCurso("10 A");//Cambio de curso 
            estudiante.ToString();
            estudiante.ImprimirEstudiante();

            empleado empleado = new empleado(16, 09564, "Gabriel", "Cortez", 699, "Casado", "casado");
            empleado.reasignarDespacho(5632);//Cambio de despacho
            empleado.ToString();
            empleado.imprimirEmpleado();

            personal personal = new personal("Auxiliar", "Rebeca", "Hernandes", 56, "casado", "Personal");
            personal.Seccioncambio("Carga");//cambio de seccion
            personal.ToString();
            personal.ImprimirPersonal();

            profesor profesor = new profesor("Departamento de  Desarollo", "Marcos", " Luis Valdes", 985, " Casado", "Viudo");
            profesor.cambioDepart("Dep de Aprendisaje");//cambiao de departamento
            profesor.ToString();
            profesor.ImprimirProfesor();
        }
    }
}

