namespace PersonaName
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNac;
        private int dni;

        public Persona(string nombre, string apellido, DateTime fechaNac, int dni)
        {
            if (nombre == "")
            {
                throw new ArgumentException("Ingrese un nombre valido");
            }
            if (apellido == "")
            {
                throw new ArgumentException("Ingrese un nombre valido");
            }
            if (dni < 0)
            {
                throw new ArgumentException("Ingrese un nombre valido");
            }
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNac = fechaNac;
            this.dni = dni;
        }

        ~Persona()
        {
            throw new System.NotImplementedException();
        }

        public string Nombre
        {
            get => nombre;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Ingrese un nombre valido");
                }
                nombre = value;
            }
        }

        public string Apellido
        {
            get => apellido;
            set
            {
                if (value == "")
                {
                    throw new ArgumentException("Ingrese un apellido valido");
                }
                apellido = value;
            }
        }

        public DateTime FechaNac
        {
            get => fechaNac;
            set
            {
                fechaNac = value;
            }
        }

        public int Dni
        {
            get => dni;
            set
            {   if (value < 0)
                {
                    throw new ArgumentException("No ingreso un dni valido");
                }
                dni = value;
            }
        }

        public string GetFullName()
        {
            return $"{nombre} {apellido}";
        }

        public int GetAge()
        {
            DateTime diaActual =  DateTime.Now;
            int diasVividos = diaActual.Subtract(fechaNac).Days;

            return diasVividos / 365;
        }
    }
}