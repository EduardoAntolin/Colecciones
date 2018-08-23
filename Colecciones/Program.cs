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
            //Declaracion e inicializacion de Lista de alumnos
            List<Alumno> alumnos = new List<Alumno>();
             
            //Declaracion y asignacion de valores de alumno1
            Alumno alumno1 = new Alumno();
            alumno1.Nombre = "Jose Perez";
            alumno1.Materias.Add(new Materia("Historia", "HSTT321"));
            alumno1.Materias.Add(new Materia("Matematicas", "MATT832"));
            alumno1.Materias.Add(new Materia("Civismo", "cvc732"));

            //Declaracion y asignacion de valores de alumno2
            Alumno alumno2 = new Alumno();
            alumno2.Nombre = "Josefa ortiz";
            alumno2.Materias.Add(new Materia("Geografia", "HTCVI321"));
            alumno2.Materias.Add(new Materia("Historia","HTCBI321"));
            alumno2.Materias.Add(new Materia("Fisica", "HTKE332"));

            //Declaracion y asignacion de valores de alumno 3
            Alumno alumno3 = new Alumno();
            alumno3.Nombre = "Javier el contreras";
            alumno3.Materias.Add(new Materia("Espanol","HJEE41"));
            alumno3.Materias.Add(new Materia("Geografia", "HJK3E42"));
            alumno3.Materias.Add(new Materia("Ciencas naturales", "JKDH321"));

            //Declaracion y asignacion de valores de alumno 4
            Alumno alumno4 = new Alumno();
            alumno4.Nombre = "Josefina vazquez mota";
            alumno4.Materias.Add(new Materia("Chihuahua", "HNKJ322"));
            alumno4.Materias.Add(new Materia("Geografia", "JKLK983"));
            alumno4.Materias.Add(new Materia("Fisica", "POJK993"));

            alumnos.Add(alumno1);
            alumnos.Add(alumno2);
            alumnos.Add(alumno3);
            alumnos.Add(alumno4);

            foreach(Alumno elemento in alumnos)
            {
                Console.WriteLine("Nombre: " + elemento.Nombre);

                foreach(Materia materia in elemento.Materias)
                {
                    Console.WriteLine("Materia: " + materia.Nombre);
                }
            }
            Console.ReadLine();
 
        }
    }
}
