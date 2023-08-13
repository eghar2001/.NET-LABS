namespace Ejercicio2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            dsUniversidad miUniversidad = new dsUniversidad();

            dsUniversidad.dtAlumnosDataTable dtAlumnos = new dsUniversidad.dtAlumnosDataTable();
            dsUniversidad.dtCursosDataTable dtCursos = new dsUniversidad.dtCursosDataTable();

            dsUniversidad.dtAlumnosRow rwAlumno = dtAlumnos.NewdtAlumnosRow();

            rwAlumno.Nombre = "Marco";
            rwAlumno.Apellido = "Ruben";

            dtAlumnos.AdddtAlumnosRow(rwAlumno);


            dsUniversidad.dtCursosRow rwCurso = dtCursos.NewdtCursosRow();
            rwCurso.Curso = "Informatica";
            dtCursos.AdddtCursosRow(rwCurso);


            dsUniversidad.dtAlumnos_CursosDataTable dtAlumnos_Cursos = new dsUniversidad.dtAlumnos_CursosDataTable();


            dsUniversidad.dtAlumnos_CursosRow rwAlumno_Curso = dtAlumnos_Cursos.NewdtAlumnos_CursosRow();

            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rwAlumno, rwCurso);


            dsUniversidad.dtAlumnosRow rwAlumno2 = dtAlumnos.NewdtAlumnosRow();
            rwAlumno2.Nombre = "Taco";
            rwAlumno2.Apellido = "Herrera";
            dtAlumnos.AdddtAlumnosRow(rwAlumno2);


            dtAlumnos_Cursos.AdddtAlumnos_CursosRow(rwAlumno2, rwCurso);

        }
    }
}