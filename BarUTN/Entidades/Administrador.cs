using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Administrador : Usuario
    {
        public static List<Administrador> listaAdministradores;

        public Administrador (string nombre, string apellido, string user, string password) 
            : base(nombre, apellido, user, password)
        {
            listaAdministradores = new List<Administrador> ();
        }

        public static void HardcodearAdministradores()
        {
            Administrador administrador1 = new Administrador("Lionel", "Messi", "lmessi", "copaamerica");
            Administrador administrador2 = new Administrador("Charly", "Garcia", "cgarcia", "botaslocas");

            listaAdministradores.Add(administrador1);
            listaAdministradores.Add(administrador2);
        }

        public override string MostrarDato()
        {
            return base.MostrarDato() + "tipo: Administrador";
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Administrador administrador in listaAdministradores)
            {
                sb.AppendLine($"{administrador.MostrarDato()}");
            }

            return sb.ToString();
        }

    }
}
