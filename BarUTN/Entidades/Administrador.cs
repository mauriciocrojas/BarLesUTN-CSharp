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
            Administrador administrador1 = new Administrador("Napoleon", "Bonucci", "nbonucci", "napo");
            Administrador administrador2 = new Administrador("Marcos", "Galperin", "mgalperin", "marcus");

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
                //string auxSal = comida.sinSal ? "sin sal" : "con sal";
                sb.AppendLine($"{administrador.MostrarDato()}");
               //sb.AppendLine($"Empleado: Nombre: {empleado.nombre}, Nombre: {empleado.apellido}, usuario: {empleado.user}");
            }

            return sb.ToString();
        }

    }
}
