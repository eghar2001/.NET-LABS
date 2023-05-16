using System.Collections;
using System.Linq;
namespace Ciudades
{
    
    internal class Program
    {
        private record Ciudad(int cod_postal, string nombre );
        static void Main(string[] args)
        {


            const string CADENA_A_BUSCAR = "ros";
            ArrayList ciudades = new ArrayList();
            ciudades.Add(new Ciudad(2000, "Rosario"));
            ciudades.Add(new Ciudad(  1000,  "CABA" ));
            ciudades.Add(new Ciudad(  5000,"Córdoba" ));
            ciudades.Add(new Ciudad(  10000,  "San Luis" ));
            ciudades.Add(new Ciudad(  -1,  "Santa Rosa" ));
            ciudades.Add(new Ciudad(  6000, "Ushuaia" ));
            ciudades.Add(new Ciudad(  9000,  "Mendoza" ));
            ciudades.Add(new Ciudad(  8000, "Santa Fe" ));
            ciudades.Add(new Ciudad(  11000,  "Villa General Belgrano" ));
            ciudades.Add(new Ciudad(  12000,  "Roldan" ));
            //Hubiese convenido mucho mas usar otra estructura que sea fuertemente tipada
            var ciudades_encontradas = ciudades.Cast<Ciudad>().ToList().Where(c => c.nombre.ToLower().Contains(CADENA_A_BUSCAR.ToLower()));

            Console.WriteLine($"Ciudades que comienzan con '{CADENA_A_BUSCAR}'");
            foreach (Ciudad c in ciudades_encontradas)
            {
                Console.WriteLine($"cod postal: {c.cod_postal} -- nombre: {c.nombre}");
            }


                                    


        }
    }
}