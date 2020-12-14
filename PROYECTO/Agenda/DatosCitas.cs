using System;
using System.Collections.Generic;

public class DatosCitas
{
    public List<Pacientes> ListadePacientes { get; set; }
    public List<Doctor> ListadeDoctor { get; set; }
    public List<Especialistas> ListadeEspecialistas { get; set; }
    public List<Cita> ListadeCitas { get; set; }

    public DatosCitas()
    {
        ListadeDoctor = new List<Doctor>();
        cargarDoctor();
        ListadePacientes = new List<Pacientes>();
        cargarPacientes();
        ListadeEspecialistas = new List<Especialistas>();
        cargarEspecialistas();

        ListadeCitas = new List<Cita>();
    }

    private void cargarDoctor()
    {
        Doctor d1 = new Doctor(1, "D001", "Hector", "Dubon", "95558484", "Lunes - Viernes / 8:00AM - 1:00PM");
        ListadeDoctor.Add(d1);
        Doctor d2 = new Doctor(2, "D002", "Carlos", "Sanchez", "96552184", "Lunes - Viernes / 1:00PM - 9:00PM");
        ListadeDoctor.Add(d2);
        Doctor d3 = new Doctor(3, "D003", "Karla", "Hernandez", "88512184", "Lunes - Viernes / 9:00PM - 6:00AM");
        ListadeDoctor.Add(d3);
        Doctor d4 = new Doctor(4, "D004", "Miguel", "Fernandez", "95668884", "Sabado - Domingo / 7:00AM - 2:00PM");
        ListadeDoctor.Add(d4);
    }

    private void cargarPacientes()
    {
        Pacientes p1 = new Pacientes(1, "Ana", "Paz", "98558877", "23", "ana88@gmail.com", "0501-1997-84849");
        ListadePacientes.Add(p1);
        Pacientes p2 = new Pacientes(2, "Fernando", "Guerra", "98555656", "22", "Nando98@gmail.com", "0501-1998-16512");
        ListadePacientes.Add(p2);
        Pacientes p3 = new Pacientes(3, "Felix", "Hernandez", "97854544", "31", "felix89@gmail.com", "0601-1989-55539");
        ListadePacientes.Add(p3);
        Pacientes p4 = new Pacientes(4, "Eduardo", "Dubon", "96885544", "31", "eduardodubon04@yahoo.com", "0101-1989-13301");
        ListadePacientes.Add(p4);
        Pacientes p5 = new Pacientes(5, "Carlos", "Lagos", "97445877", "27", "lagos07@gmail.com", "0501-1993-81349");
        ListadePacientes.Add(p5);
        Pacientes p6 = new Pacientes(6, "Julia", "Reina", "96885841", "45", " ", "0501-1975-45252");
        ListadePacientes.Add(p6);
    }

    private void cargarEspecialistas()
    {
        Especialistas e1 = new Especialistas(1, "E001", "Wilmer", "Cruz", "85842251", "8:00AM - 1:00PM", "Medicina Interna");
        ListadeEspecialistas.Add(e1);
        Especialistas e2 = new Especialistas(2, "E002", "Carlos", "Fernandez", "84789989", "11:00AM - 5:00PM", "Medicina Interna");
        ListadeEspecialistas.Add(e2);
        Especialistas e3 = new Especialistas(3, "E003", "Francis", "Hernandez", "99558844", "7:00AM - 3:00PM", "Ginecologia");
        ListadeEspecialistas.Add(e3);
        Especialistas e4 = new Especialistas(4, "E004", "Wilson", "Ramirez", "985558485", "11:00AM - 5:00PM", "Ginecologia");
        ListadeEspecialistas.Add(e4);
        Especialistas e5 = new Especialistas(5, "E005", "Lucia", "Garcia", "98774556", "10:00AM - 6:00PM", "Pediatria");
        ListadeEspecialistas.Add(e5);
        Especialistas e6 = new Especialistas(6, "E006", "Andrea", "Trochez", "99558856", "12:00PM - 6:00PM", "Pediatria");
        ListadeEspecialistas.Add(e6);
        Especialistas e7 = new Especialistas(7, "E007", "Pedro", "Trochez", "96558856", "12:00PM - 6:00PM", "Dermatologia");
        ListadeEspecialistas.Add(e7);
        Especialistas e8 = new Especialistas(8, "E008", "Luis", "Fernandez", "96884456", "6:00AM - 3:00PM", "Dermatologia");
        ListadeEspecialistas.Add(e8);
    }

    public void ListarPacientes()
    {
        Console.Clear();
        Console.WriteLine(" Lista de Pacientes");
        Console.WriteLine("====================");
        Console.WriteLine("");
        Console.WriteLine(" CD | Nombre | Apellido | Telefono |      | Edad || Identidad | Correo |");
        Console.WriteLine("===================================== ===================================");
        Console.WriteLine("");
        
        foreach (var Pacientes in ListadePacientes)
        {
            Console.WriteLine(Pacientes.Codigo + " | " + Pacientes.Nombre + " | " + Pacientes.Apellido + " | " + Pacientes.Telefono + " |                 | " + Pacientes.Edad + " | " + Pacientes.Identidad + " | " + Pacientes.Correo);
        }
        
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }

    public void ListarDoctores()
    {
        Console.Clear();
        Console.WriteLine(" Lista de Doctores");
        Console.WriteLine("====================");
        Console.WriteLine("");
        Console.WriteLine(" CD | Nombre | Apellido | Telefono | Horario | ");
        Console.WriteLine("===============================================");
        Console.WriteLine("");

        foreach (var Doctor in ListadeDoctor)
        {
            Console.WriteLine(Doctor.CodigoDoctor + " | " + Doctor.Nombre + " | " + Doctor.Apellido + " | " + Doctor.Telefono + " | " + Doctor.Horario );
        }

        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }

    public void ListarEspecialistas()
    {
        Console.Clear();
        Console.WriteLine(" Lista de Especialistas");
        Console.WriteLine("====================");
        Console.WriteLine("");
        Console.WriteLine(" CD | Nombre | Apellido | Telefono | Horario | Especialidad | ");
        Console.WriteLine("==============================================================");
        Console.WriteLine("");

        foreach (var Especialistas in ListadeEspecialistas)
        {
            Console.WriteLine(Especialistas.CodigoEspecialista + " | " + Especialistas.Nombre + " | " + Especialistas.Apellido + " | " + Especialistas.Telefono + " | " + Especialistas.Horario + " | " + Especialistas.Especialidad);
        }
        
        Console.WriteLine("");
        Console.Write("Presione la tecla enter para salir.");
        
        Console.ReadLine();
    }


public void crearCita()
{

            
        Console.Clear();
        Console.WriteLine(" Creando Cita");
        Console.WriteLine("==============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del paciente: ");
        string codigoPaciente = Console.ReadLine();

        Pacientes pacientes = ListadePacientes.Find(p => p.Codigo.ToString() == codigoPaciente);        
        if (pacientes == null)
        {
            Console.WriteLine("Paciente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Paciente: " + pacientes.Nombre);
            Console.WriteLine("");
        }
       
            Console.WriteLine("Ingrese el codigo del Doctor: ");
            string codigoDoctor = Console.ReadLine();

            Doctor doctor = ListadeDoctor.Find(d => d.Codigo.ToString() == codigoDoctor);
            if (doctor == null) 
            {
                Console.WriteLine("Doctor no encontrado");
                Console.ReadLine();
                return;
            } else {
                Console.WriteLine("Doctor: " + doctor.Nombre + " " + doctor.Apellido);
                Console.WriteLine("");
            }

            Console.WriteLine("Ingrese el codigo del Especialista: ");
            string codigoEspecialista = Console.ReadLine();

            Especialistas especialistas = ListadeEspecialistas.Find(e => e.Codigo.ToString() == codigoEspecialista);
            if (especialistas == null) 
            {
                Console.WriteLine("Especialista no encontrado");
                Console.ReadLine();
                return;
            } else {
                Console.WriteLine("Especialista: " + especialistas.Nombre + " " + especialistas.Apellido);
                Console.WriteLine("");
            }
            
            Console.WriteLine();
            Console.Write("Presione la tecla enter para salir.");
            Console.ReadLine();

        int nuevoCodigo = ListadeCitas.Count + 1; 

        Cita nuevaCita = new Cita (nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, pacientes, doctor, especialistas);
        ListadeCitas.Add(nuevaCita);
}
    
     public void ListarCitas()
     {
        Console.Clear();
        Console.WriteLine("Lista de Citas");
        Console.WriteLine("================");
        Console.WriteLine("");  
        Console.WriteLine(" Codigo | Fecha de creacion | ");
        Console.WriteLine("============================");
        Console.WriteLine("");  

        foreach (var Cita in ListadeCitas)
        {
            Console.WriteLine(" " + Cita.Codigo + " | " + Cita.fechaCita);
            Console.WriteLine();
            Console.WriteLine("   Paciente | Doctor | Especialista");
            Console.WriteLine("====================================");
            Console.WriteLine();
            Console.WriteLine(Cita.Pacientes.Nombre + " " + Cita.Pacientes.Apellido + " | " + Cita.Doctor.Nombre + " " + Cita.Doctor.Apellido +  " | " + Cita.Especialistas.Nombre + " " + Cita.Especialistas.Apellido);
        }

         Console.WriteLine();
         Console.Write("Presione la tecla enter para salir.");
         Console.ReadLine();
     }

     public void BuscarCita()
     {
         Console.WriteLine("Ingrese el codigo de la cita: ");
         string CodCita = Console.ReadLine();
        Cita cita = ListadeCitas.Find(c => c.Codigo.ToString() == CodCita);
            if (cita == null) 
            {
                Console.WriteLine("Cita no encontrada");
                Console.ReadLine();
                return;
            } else {
                Console.WriteLine("Su cita es: ");
                Console.WriteLine();
                Console.WriteLine(" Codigo | Fecha de creacion | ");
                Console.WriteLine("============================");
                Console.WriteLine(cita.Codigo + " | " + cita.fechaCita);     
                Console.WriteLine();
                Console.WriteLine("   Paciente | Doctor | Especialista");
                Console.WriteLine("====================================");
                Console.WriteLine();
                Console.WriteLine(cita.Pacientes.Nombre + " " + cita.Pacientes.Apellido + " | " + cita.Doctor.Nombre + " " + cita.Doctor.Apellido +  " | " + cita.Especialistas.Nombre + " " + cita.Especialistas.Apellido);     
                Console.WriteLine();
            }

                Console.WriteLine("");
                Console.WriteLine();
                Console.Write("Presione la tecla enter para salir.");
                Console.ReadLine();
     }
}

