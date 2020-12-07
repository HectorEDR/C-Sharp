using System;

public class Pinguino: Aves
{
    public string Incubacion { get; set; }

    public string Alimentacion { get; set; }

    public void graznido()
    {
        Console.WriteLine("Los pingüinos se comunican a través de su graznido, lo cual les permite reconocerse");
    }
}