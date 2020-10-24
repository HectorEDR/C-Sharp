public class Alumno
{
    public int Id { get; set; } 
    public string Primernombre { get; set; }
    public string Segundonombre { get; set; }
    public bool Activo { get; set; }


    public Alumno(int id, string primerNombre, string segundoNombre)
    {
        Id = id;
        Primernombre = primerNombre;
        Segundonombre = segundoNombre;
        Activo = true;
    }

    public string nombreCompleto()
    {
        if (Activo == true)
        {
            return Primernombre + " " + Segundonombre;
        }
        
        return "Alumno inactivo";
    }

    public void inactivarAlumno()
    {
        Activo = false;
    }

    public void activarAlumno()
    {
        Activo = true;
    }
}