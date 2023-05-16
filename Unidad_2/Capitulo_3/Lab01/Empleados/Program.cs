namespace Empleados
{
    internal class Program
    {
    
        
        private class Empleado
        {   
            private static int last_id = 0;

            private int id;
            private string nombre;
            private decimal sueldo;

            public Empleado()
            {
                this.id = NextId();
            }
            public  int Id
            {
                get => id;
            }
            public string Nombre { 
                get => nombre;
                set
                {
                    if (EsNombreValido(value)) 
                    { 
                    nombre = value;
                    }
                }

            }

            public decimal Sueldo {
                get => sueldo;
                set
                { 
                    if (EsSueldoValido(value)) 
                    {
                        sueldo = value;
                    }
                }
            }
            public override string ToString()
            {
                return $"Empleado(id = {this.Id},nombre = {this.Nombre}, sueldo = {this.Sueldo})";
            }
            private static int NextId()
            {
                last_id++;
                return last_id;
            }
            public static bool EsNombreValido(string nombre)
            {
               
                return !(String.IsNullOrEmpty(nombre) || nombre.Any(c => Char.IsDigit(c)));
            }
            public static bool EsSueldoValido(decimal sueldo)
            {
                return (sueldo >= 0);
            }
        }
        static void MenuPrincipal()
        {
            Console.WriteLine("INGRESE");
            Console.WriteLine("A- para dar alta a un empleado");
            Console.WriteLine("L- para mostrar una lista ordenada por sueldo");
            Console.WriteLine("Otro- Salir del programa");
        }
        static void SaltarLineas(int cantidadLineas) 
        {
            string stringConLineas = "";
            for (int i = 0; i < cantidadLineas; i++)
            {
                stringConLineas += " \n";
            }
            Console.WriteLine(stringConLineas);
        }
        static void Main(string[] args)
        {
            const int LINEAS_SALTEADAS = 2;



            ConsoleKey[] teclas_posibles = { ConsoleKey.L, ConsoleKey.A };
            MenuPrincipal();
            ConsoleKeyInfo opcion_elegida = Console.ReadKey();
            SaltarLineas(LINEAS_SALTEADAS);
            List<Empleado> empleados = new List<Empleado>();
            while (teclas_posibles.Contains(opcion_elegida.Key)){
                if(opcion_elegida.Key == ConsoleKey.A)
                {
                    Console.WriteLine("MENU ALTA EMPLEADOS");
                    Console.Write("Ingrese nombre: ");
                    Empleado emp = new Empleado();
                    string nombre = Console.ReadLine();

                    while (!Empleado.EsNombreValido(nombre))
                    {
                        Console.WriteLine("Ingrese un nombre valido");
                        nombre = Console.ReadLine();
                    }
                    emp.Nombre = nombre;
                   
                    Console.Write("Ingrese sueldo: ");
                    decimal sueldo = -1;
                    try
                    {
                        sueldo = decimal.Parse(Console.ReadLine());
                        while (!Empleado.EsSueldoValido(sueldo))
                        {
                            Console.WriteLine("Ingrese un sueldo valido");
                            sueldo = decimal.Parse(Console.ReadLine());
                        }
                    }                    
                    catch(FormatException e)
                    {
                        Console.WriteLine("No ingreso un decimal");
                        Console.WriteLine(e);
                        Environment.Exit(0);
                    }
                    catch(Exception e)
                    {
                        Console.WriteLine(e);
                        Environment.Exit(0);
                    }
                    
                    emp.Sueldo = sueldo;
                    empleados.Add(emp);
                    Console.WriteLine("\n\nEmpleado ingresado con éxito!");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();

                }
                else if (opcion_elegida.Key == ConsoleKey.L)
                {
                    Console.WriteLine("MENU LISTA ORDENADA POR SUELDO");
                    Console.WriteLine("A- para ordenar ascendentemente");
                    Console.WriteLine("D- para ordenar descendentemente");
                    Console.WriteLine("OTRO- para salir ");
                    ConsoleKeyInfo tipo_ordenamiento =  Console.ReadKey();
                    Console.WriteLine();
                    List<Empleado> lista_ord = new List<Empleado>();
                    if (tipo_ordenamiento.Key == ConsoleKey.A)
                    {
                        Console.WriteLine("Lista ordenada por sueldo ascendentemente: ");
                        lista_ord = empleados.OrderBy(e => e.Sueldo).ToList();
                        
                    }
                    else if (tipo_ordenamiento.Key == ConsoleKey.D)
                    {
                        Console.WriteLine("Lista ordenada por sueldo descendentemente: ");
                        lista_ord = empleados.OrderByDescending(e => e.Sueldo).ToList();
                    }
                    if (    lista_ord.Count > 0) 
                    { 
                        foreach (Empleado e in lista_ord)
                        {
                            Console.WriteLine(e);
                        }
                    }
                    Console.ReadKey();
                }
                Console.Clear();
                MenuPrincipal();
                opcion_elegida = Console.ReadKey();
                SaltarLineas(LINEAS_SALTEADAS);
            }
        }
    }
}