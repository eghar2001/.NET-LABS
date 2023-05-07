namespace Programa;
public class Juego
{
    private int _record;

    public Juego()
    {
        _record = 0;
    }

    public void ComenzarJuego()
    {
        const int maximo_numero = 10;
        Jugada jugada = new Jugada(maximo_numero);
        Console.WriteLine("Bienvenido al juego de adivinar numeros!");
        Console.WriteLine("Presione S para comenzar el juego\n");
        ConsoleKeyInfo tecla_presionada = Console.ReadKey();
        while (tecla_presionada.Key == ConsoleKey.S)
        {
            Console.WriteLine($"Tiene que adivinar un numero entre el 1 y el {maximo_numero}");
            Console.Write($"Inserte el numero que piensa que es: ");
            int numero_intentado = 0;
            try
            {
                numero_intentado = Int32.Parse(Console.ReadLine());
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("Ingresó un numero fuera de rango");
                Console.WriteLine(e.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
            bool acerto_numero = jugada.Comparar(numero_intentado);
            if (acerto_numero)
            {
                Console.WriteLine($"Felicidades!! Acertaste el numero! ");
                Console.WriteLine($"El numero que era: {jugada.Numero}");
                Console.WriteLine($"La cantidad de intentos fue: {jugada.Intentos}\n\n");
                if (CompararRecord(jugada.Intentos))
                {
                    Console.WriteLine($"Mejoraste el ultimo record de {_record} intentos");
                    _record = jugada.Intentos;
                }
                Console.WriteLine("Presione S para jugar de nuevo\n");
                tecla_presionada = Console.ReadKey();
            }
            else
            {
                Console.WriteLine("No acertaste el numero :( ");
                Console.WriteLine("Intente de nuevo");
            }
        }
    }
    

    public bool CompararRecord(int intentos)
    {
    return intentos < _record;
    }

    private void Continuar()
    {
    
        throw new System.NotImplementedException();
    }

    private void PreguntarMaximo()
    {
        throw new System.NotImplementedException();
    }

    private void PreguntarMinimo()
    {
        throw new System.NotImplementedException();
    }
}
}