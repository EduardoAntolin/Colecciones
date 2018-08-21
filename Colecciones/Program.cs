using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {

            //Alumno 1
            Alumno alumno = new Alumno();
            alumno.Nombre = "Juan loco";
            alumno.Matricula = "194278";

            //Alumno 2
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Carlos Rodriguez";
            alumno1.Matricula = "289384";

            //Alumno 3
            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Cesar Savedra";
            alumno2.Matricula = "190232";
            
            //Materias 
            Materia matematicas = new Materia();
            matematicas.Nombre = "Matematicas";
            matematicas.Identificador = "MT12358";

            Materia Geografia = new Materia();
            Geografia.Nombre = "Geografia";
            Geografia.Identificador = "MT192394";

            alumno.Materias.Add(new Materia());
            alumno.Materias.Add(matematicas);

            alumno.Materias[0].Nombre = "Historia";
            alumno.Materias[0].Identificador = "HT96465";

            alumno.Materias.Add(new Materia());
            alumno.Materias[2].Nombre = "Español";
            alumno.Materias[2].Identificador = "ES852";


            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.RemoveAt(1);
            //alumno.Materias.Clear();
            

            Console.WriteLine("Alumno: " + alumno.Nombre);
            //Console.WriteLine("Materia: " + alumno.Materias[0].Nombre);
            //Console.WriteLine("Materia: " + alumno.Materias[1].Nombre);

            Console.WriteLine("Numero de materias: " + alumno.Materias.Count);
         
            foreach(Materia materia in alumno.Materias)
            {
                Console.WriteLine("Materia: " + materia.Nombre);
                //alumno.Materias[i].Nombre; 
            }
            Console.ReadLine();
        }
    }
}
