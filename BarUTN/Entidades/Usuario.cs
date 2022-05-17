using System.Text;

namespace Entidades
{
    public abstract class Usuario
    {
        public string nombre;
        public string apellido;
        public string user;
        public string password;

        public Usuario()
        {

        }
        public Usuario(string nombre, string apellido, string user, string password)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.user = user;
            this.password = password;
        }

        public string NombreCompleto
        {
            get { return $"{nombre} {apellido}"; }
        }

        public virtual string MostrarDato()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre: {NombreCompleto}, user: {user}, ");

            return sb.ToString();
        }

        public abstract string MostrarDatos();


    }
}
