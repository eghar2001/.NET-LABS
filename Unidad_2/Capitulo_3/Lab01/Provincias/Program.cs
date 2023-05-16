namespace Provincias
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] provincias = { "Buenos Aires", "CABA", "Catamarca",
                "Chaco", "Chubut", "Córdoba", "Corrientes", "Entre Ríos",
                "Formosa", "Jujuy", "La Pampa", "La Rioja", "Mendoza",
                "Misiones", "Neuquén", "Río Negro", "Salta", "San Juan",
                "San Luis", "Santa Cruz", "Santa Fe", "Santiago del Estero", "Tucumán"
            };
            var provincias_buscadas = provincias.Where(p => p.StartsWith("S") || p.StartsWith("T"));
            Console.WriteLine("Provincias de Argentia que comienzan con P o con S");
            foreach (string prov in provincias_buscadas)
            {
                Console.WriteLine(prov);
            }
        }
    }
}