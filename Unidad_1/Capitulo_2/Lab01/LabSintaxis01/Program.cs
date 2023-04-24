// See https://aka.ms/new-console-template for more information
Console.Write("Ingrese un texto: ");
string?  inputTexto = Console.ReadLine();
if (String.IsNullOrEmpty(inputTexto))
{
    Console.WriteLine("Ingresá un texto salamin");
}
else
{
    Console.WriteLine("Gracias genio,ahora elegí una opcion");
    Console.Write("1-Mayuscula  2-Minuscula     3-Largo : ");
    ConsoleKeyInfo opcion = Console.ReadKey();
    Console.WriteLine();
    if(opcion.Key == ConsoleKey.D1)
    {
        Console.Write("Su texto en mayuscula es: ");
        Console.WriteLine(inputTexto.ToUpper());
        
    }
    else if(opcion.Key == ConsoleKey.D2)
    {
        Console.Write("Su texto en minuscula es: ");
        Console.WriteLine(inputTexto.ToLower());
    }
    else if(opcion.Key == ConsoleKey.D3)
    {
        Console.Write("El largo de su texto es: ");
        Console.WriteLine(inputTexto.Length);
    }
    else
    {
        Console.WriteLine("Pusiste cualquier cosa ");
    }
    Console.ReadKey();
}
