using System;

namespace Inventario
{
    class Program
    {
        static string[,] productos = new string[5,3]
        {
            {"001", "Iphone 11 pro", "2"},
            {"002", "Monitor Asus", "3"},
            {"003", "Laptop MSI", "1"},
            {"004", "Ipad pro 2", "1"},
            {"005", "Mouse Gamer Asus", "50"},
        };

        static void listaProductos()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion y Existencias");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i,0] + "|" + productos[i,1]);
            }
        }
        static void Main(string[] args)
        {
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Inventario");
                Console.WriteLine("*********************");
                Console.WriteLine("");
                Console.WriteLine("1. Productos");
                Console.WriteLine("2. Ingreso de Inventario");
                Console.WriteLine("3. Salida de Inventario");
                Console.WriteLine("0. Salir");

                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                    listaProductos();
                    break;
                    default:
                    break;
                }

                    Console.ReadLine();

                if (opcion == "0")
                {
                    break;
                }

            }
        }
    }
}
