using System;

namespace _13_Animles_POO
{
    class Program
    {
        static void Main(string[] args)
        {
           Perro p = new Perro();
            Console.WriteLine("|Perro|");
            Console.WriteLine("-------");
            p.Nombre = "Enzo";
            p.CuantasPatas = 4;
            p.EsDomestico = true;
            p.Comer();
            p.Orden = "Carnivora";
            p.Caminar();
            p.Ladrar();
            p.Tamano();

            Console.WriteLine("Nombre: " + p.Nombre);
            Console.WriteLine("Cuantas Patas: " + p.CuantasPatas);
            if (p.EsDomestico == true)
            {
                Console.WriteLine("Es domestico");
            }

            Console.WriteLine();

            Gato g = new Gato();
            Console.WriteLine("|Gato|");
            Console.WriteLine("------");
            g.Nombre = "Amarillo";
            g.CuantasPatas = 4;
            g.Pelaje = "Pelo Corto";
            g.Raza = "Britanico de pelo corto";
            g.Orden = "Carnivora";
            g.Comer();
            g.Caminar();
            g.Maullar();
            g.EsArisco = true;

            Console.WriteLine("Nombre: " + g.Nombre);
            Console.WriteLine("Cuantas Patas: " + g.CuantasPatas);
            Console.WriteLine("Tipo de pelaje: " + g.Pelaje);
            Console.WriteLine("Raza: " + g.Raza);

            Console.WriteLine();

            Nutria n = new Nutria();
            Console.WriteLine("|Nutria|");
            Console.WriteLine("--------");
            n.Nombre = "Robert";
            n.CuantasPatas = 4;
            n.Orden = "Carnivora";
            n.EsSalvaje = true;
            n.Comer();
            n.Caminar();

            Console.WriteLine("Nombre: " + n.Nombre);
            Console.WriteLine("Cuantas Patas: " + n.CuantasPatas);
            Console.WriteLine("Orden: " + n.Orden);
            if (n.EsSalvaje == true)
            {
                Console.WriteLine("Es salvaje");
            }

            Console.WriteLine();

            Colibri c = new Colibri();
            Console.WriteLine("|Colibri|");
            Console.WriteLine("---------");
            c.Nombre = "Richard";
            c.CuantasPatas = 2;
            c.Pico = "Pico algo largo y afilado";
            c.Genero = "Chalcostigma";
            c.Orden = "Apodiformes";
            c.Alimentacion = "se alimentan del néctar y los pequeños insectos que encuentran en el interior de las flores.";
            c.Comer();
            c.Volar();
            c.Zumbido();

            Console.WriteLine("Nombre: " + c.Nombre);
            Console.WriteLine("Cuantas patas: " + c.CuantasPatas);
            Console.WriteLine("Tipo de pico: " + c.Pico);
            Console.WriteLine("Tipo de genero: " + c.Genero);
            Console.WriteLine("Tipo de Orden: " + c.Orden);
            Console.WriteLine("Alimentacion: " + c.Alimentacion);

            Console.WriteLine();

            Pinguino pi = new Pinguino();
            Console.WriteLine("|Pinguino|");
            Console.WriteLine("----------");
            pi.Nombre = "Ruidoso";
            pi.CuantasPatas = 2;
            pi.Orden = "Sphenisciformes";
            pi.Alimentacion = "Unas especies se alimentan fundamentalmente de peces y otras de placton";
            pi.Incubacion = "El periodo de incubación oscila entre 33 y 62 días según la especie";
            pi.graznido();
            pi.Comer();
            
            Console.WriteLine("Nombre: " + pi.Nombre);
            Console.WriteLine("Cuantas patas: " + pi.CuantasPatas);
            Console.WriteLine("Tipo de Orden: " + pi.Orden);
            Console.WriteLine("Alimentacion: " + pi.Alimentacion);
            Console.WriteLine("Periodo de incubacion: " + pi.Incubacion);

            Console.WriteLine();

            PezEspada pe = new PezEspada();
            Console.WriteLine("|Pez Espada|");
            Console.WriteLine("------------");
            pe.Nombre = "Picudo";
            pe.Aletas = 5;
            pe.Orden = "Perciformes";
            pe.Alimentacion = "peces pelágicos como el atún, barracuda, pez volador, verdel, etc.";
            pe.Nadar();
            pe.ComeCarne(); 

            Console.WriteLine("Nombre: " + pe.Nombre);
            Console.WriteLine("Cuantas aletas: " + pe.Aletas);
            Console.WriteLine("Tipo de Orden: " + pe.Orden);
            Console.WriteLine("Alimentacion: " + pe.Alimentacion);

        }
    }
}
