using System;

namespace Agenda
{
    class Program
    {
        static void Main(string[] args)
        {
            DatosCitas datos = new DatosCitas();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Citas");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Pacientes");
                Console.WriteLine("2 - Crear Cita");
                Console.WriteLine("3 - Lista de Doctores");
                Console.WriteLine("4 - Lista de Especialistas");
                Console.WriteLine("5 - Lista de Citas");
                Console.WriteLine("0 - Salir");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        datos.ListarPacientes();
                        break;
                    
                    case "2":
                        datos.crearCita();
                        break;

                    case "3":
                        datos.ListarDoctores();
                        break;

                    case "4":
                        datos.ListarEspecialistas();
                        break;

                    case "5":
                        datos.ListarCitas();
                        break;
                                                         
                    default:
                        break;
                }

                if (opcion == "0") {
                    break;
                }
            }
        }
    }
}
