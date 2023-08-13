using System.Data;
using Microsoft.Data.SqlClient;

namespace Ejercicio1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Creamos tabla y su estructura
            DataTable dtAlumnos = new DataTable();
            DataColumn colNombre = new DataColumn("Nombre", typeof(string));
            DataColumn colApellido = new DataColumn("Apellido", typeof(string));
            dtAlumnos.Columns.Add(colNombre);
            dtAlumnos.Columns.Add(colApellido);


            //insertamos Alumnos
            DataRow rowAlumno = dtAlumnos.NewRow();
            rowAlumno[colNombre] = "Marco";
            rowAlumno[colApellido] = "Ruben";
            dtAlumnos.Rows.Add(rowAlumno);

            DataRow rowAlumno2 = dtAlumnos.NewRow();
            rowAlumno2[colNombre] = "Taco";
            rowAlumno2[colApellido] = "Herrera";
            dtAlumnos.Rows.Add(rowAlumno2 );


            //Mostramos el listado de alumnos
            Console.WriteLine("Listado de papas de Nob");
            foreach(DataRow alumno  in dtAlumnos.Rows )
            {
                Console.WriteLine(alumno[colApellido].ToString() + "," + alumno[colNombre].ToString());
            }

        }
    }
}