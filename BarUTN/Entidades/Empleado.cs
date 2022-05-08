using System.Collections.Generic;
using System.Text;

namespace Entidades
{
    public class Empleado : Usuario
    {
        public static List<Empleado> listaEmpleados;


        public Empleado()
        {
            listaEmpleados = new List<Empleado>();

        }

        public Empleado(string nombre, string apellido, string user, string password)
           : base(nombre, apellido, user, password)
        {
            listaEmpleados = new List<Empleado>();
        }

        public static void HardcodearEmpleados()
        {
            Empleado empleado1 = new Empleado("Juan", "Perez", "jperez", "juanse");
            Empleado empleado2 = new Empleado("Gianluca", "Rian", "grian", "gianse");
            Empleado empleado3 = new Empleado("Orlando", "Vietri", "ovietri", "juanse");
            Empleado empleado4 = new Empleado("Pedro", "Gerez", "pgerez", "pendre");
            Empleado empleado5 = new Empleado("Hector", "Pedroso", "hpedroso", "hecter");


            listaEmpleados.Add(empleado1);
            listaEmpleados.Add(empleado2);
            listaEmpleados.Add(empleado3);
            listaEmpleados.Add(empleado4);
            listaEmpleados.Add(empleado5);
        }

        public override string MostrarDato()
        {
            return base.MostrarDato() + "tipo: Empleado";
        }

        public override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();


            foreach (Empleado empleado in listaEmpleados)
            {
                //string auxSal = comida.sinSal ? "sin sal" : "con sal";
                sb.AppendLine($"{empleado.MostrarDato()}");
                //sb.AppendLine($"Empleado: Nombre: {empleado.nombre}, Nombre: {empleado.apellido}, usuario: {empleado.user}");
            }

            return sb.ToString();
        }
    }
}
