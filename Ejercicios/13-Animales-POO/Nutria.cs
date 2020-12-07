using System;

public class Nutria: Mamifero
{
    public bool EsSalvaje { get; set; }
    public string Pelaje { get; set; }
public Nutria() // Polimorfismo
   {
      EsSalvaje = true;
   }
public Nutria(bool esSalvaje) // Polimorfismo
   {
     EsSalvaje = esSalvaje;   
   }
}