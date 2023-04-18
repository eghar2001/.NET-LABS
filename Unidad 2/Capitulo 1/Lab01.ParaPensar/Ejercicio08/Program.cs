namespace Ejercicio08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 8
            /*
             MIRAR IMAGEN
            Hay que hacer un programa basado en el algoritmo de la imagen
             */
            const int cantidadIntentos = 4;
            const string claveADescifrar = "1234";
            int intentos = 0;
            string clave="";

            while (intentos < cantidadIntentos && clave!= claveADescifrar)
            {
                Console.Write($"Escriba clave(intento {intentos+1} de {cantidadIntentos} ): ");
                clave = Console.ReadLine();
                Console.WriteLine();
                intentos++;
            }
            if(clave == claveADescifrar)
            {
                Console.WriteLine("La clave es correcta");
            }
            else
            {
                Console.WriteLine("Superó el numero de intentos");
            }
            
        }
    }
}