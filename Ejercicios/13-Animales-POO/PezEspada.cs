using System;

public class PezEspada: Peces // Herencia
{
    public string Alimentacion { get; set; }
    public string Color { get; set; }

    public void ComeCarne()
    {
       Carnivoro();
    }
    private void Carnivoro() // Encapsulamiento
    {
        Console.WriteLine("Es carnivoro");
    }
}