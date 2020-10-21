using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.Primernombre = "Juan";
            a.Segundonombre = "Perez";

            Alumno b = new Alumno();
            b.Id = 2;
            b.Primernombre =  "Maria";
            b.Segundonombre = "Martinez";

            Alumno c = new Alumno(3);
            c.Primernombre = "Pedro";

            Alumno d = new Alumno("Jose", "Dubon");


            Console.WriteLine(a.Id);
            Console.WriteLine(b.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.Primernombre + " " + d.Segundonombre);
        }
    }
}
