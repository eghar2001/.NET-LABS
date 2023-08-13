namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ManejadorArchivo manejador;
            Console.WriteLine("1- Manejo con XML");
            Console.WriteLine("2- Manejo con TXT");
            if (Console.ReadLine() == "1")
            {
                manejador = new ManejadorArchivoXml();
            }
            else
            {
                manejador = new ManejadorArchivoTxt();
            }
            menu(manejador);
        }

        static void menu(ManejadorArchivo manejador)
        {
            string rta;
            do
            {
                Console.WriteLine("1 - Listar");
                Console.WriteLine("2 - Agregar");
                Console.WriteLine("3 - Modificar");
                Console.WriteLine("4 - Eliminar");
                Console.WriteLine("5 - Guardar Cambios");
                Console.WriteLine("6 - Salir");

                rta = Console.ReadLine();
                switch (rta)
                {
                    case "1":
                        manejador.listar();
                        break;
                    case "2":
                        manejador.nuevaFila();
                        break;
                    case "3":
                        manejador.editarFila();
                        break;
                    case "4":
                        manejador.eliminarFila();
                        break;
                    case "5":
                        manejador.aplicaCambios();
                        break;
                    default:
                        break;


                }
            } while (rta != "6");
        }
    }
}