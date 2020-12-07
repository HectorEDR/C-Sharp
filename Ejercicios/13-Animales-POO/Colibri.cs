using System;

public class Colibri: Aves
{
        public string Alimentacion { get; set; }
        public string Pico { get; set; }
        public string Genero { get; set; }

        public void Zumbido()
        {
            Console.WriteLine("Zzz Zzz Zzz");
        }
}