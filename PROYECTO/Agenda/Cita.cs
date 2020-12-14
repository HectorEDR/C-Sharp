using System;

public class Cita
{
    public int Codigo { get; set; }
    public DateTime fechaCita { get; set; }
    public string NumeroCita { get; set; }
    public Pacientes Pacientes { get; set; }
    public Doctor Doctor { get; set; }
    public Especialistas Especialistas { get; set; }

    public Cita (int codigo, DateTime fechacita, string Numcita, Pacientes pacientes, Doctor doctor, Especialistas especialistas)
    {
        Codigo = codigo;
        fechaCita = fechacita;
        NumeroCita = Numcita;
        Pacientes = pacientes;
        Doctor = doctor;
        Especialistas = especialistas;
    }
}