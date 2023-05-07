namespace Clases
{
    public class A
    {
        private string nombreInstancia;

        //CONSTRUCTORES
        public A()
        {
            this.nombreInstancia = "Instancia sin nombre";
        }

        public A(string nombreInstancia){
            this.nombreInstancia = nombreInstancia;
        }

        //PROPIEDADES
        public string NombreInstancia
        {
            get
            {
                return nombreInstancia;
            }
            set { 
                nombreInstancia = value;
            }
        }

        //METODOS
        public void MostrarNombre()
        {
            Console.WriteLine(this.nombreInstancia);
        }
        public void M1() {
            Console.WriteLine("Se invocó el metodo M1");
        }
        protected void M2()
        {
            Console.WriteLine("Se invocó el metodo M2");
        }
        public void M3()
        {
            Console.WriteLine("Se invocó el metodo M3");
        }


    }
}