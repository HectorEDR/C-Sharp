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
            Console.WriteLine();
            Console.WriteLine("Listado de productos");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("Codigo, Descripcion y Existencias");

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(productos[i,0] + " | " + productos[i,1] + " | " + productos[i,2]);
            }
            Console.WriteLine();
            Console.Write("Presione la tecla enter para salir.");
            Console.ReadLine();
            
        }

        static void movimientoInventario(string codigo, int cantidad, string tipoMovimiento)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (productos[i,0]== codigo)   
                    {
                        if (tipoMovimiento == "+")
                        {
                            productos[i,2] = (Int32.Parse(productos[i,2]) + cantidad).ToString();
                        }else
                        {
                            productos[i,2] = (Int32.Parse(productos[i,2]) - cantidad).ToString();
                        }
                    }
                }
            }

        static void ingresoDeInventario()
            {
                string codigo = "";
                string cantidad = "";

                Console.Clear();
                Console.WriteLine();
                Console.WriteLine(" Ingreso de productos al inventario");
                Console.WriteLine("------------------------------------");
                Console.WriteLine();
                Console.Write("Ingrese el codigo del producto: ");
                codigo = Console.ReadLine();
                Console.WriteLine();
                Console.Write("Ingrese la cantidad del producto: ");
                cantidad = Console.ReadLine();
                
                movimientoInventario(codigo, Int32.Parse(cantidad), "+");
            }

            static void salidaDeInventario()
                {
                    string codigo = "";
                    string cantidad = "";

                    Console.Clear();
                   
                    Console.WriteLine();
                    Console.WriteLine(" Ingreso de productos al inventario");
                    Console.WriteLine("------------------------------------");
                    Console.WriteLine();
                    Console.Write("Ingrese el codigo del producto: ");
                    codigo = Console.ReadLine();
                    Console.WriteLine();
                    Console.Write("Ingrese la cantidad del producto: ");
                    cantidad = Console.ReadLine();
                
                    movimientoInventario(codigo, Int32.Parse(cantidad), "-");
                }

                static void AjustePositivo()
                    {
                        string codigo = "";
                        string cantidad = "";

                        Console.Clear();
                        Console.WriteLine();
                        Console.WriteLine(" Ingreso de productos al inventario");
                        Console.WriteLine("------------------------------------");
                        Console.WriteLine();
                        Console.Write("Ingrese el codigo del producto: ");
                        codigo = Console.ReadLine();
                        Console.WriteLine();
                        Console.Write("Ingrese la cantidad del producto: ");
                        cantidad = Console.ReadLine();
                        
                        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
                    }

    static void AjusteNegativo()
    {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
                    
        Console.WriteLine();
        Console.WriteLine(" Ingreso de productos al inventario");
        Console.WriteLine("------------------------------------");
        Console.WriteLine();
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
                
        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
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
                Console.WriteLine("4. Ajuste Positivo");
                Console.WriteLine("5. Ajuste Negativo");
                Console.WriteLine("0. Salir");
                Console.WriteLine();
                Console.Write("Por favor seleccione una opcion: ");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                    listaProductos();
                    break;
                    case "2":
                    ingresoDeInventario();
                    break;
                    case "3":
                    salidaDeInventario();
                    break;
                    case "4":
                    AjustePositivo();
                    break;
                    case "5":
                    AjusteNegativo();
                    break;
                    default:
                    break;
                }

                if (opcion == "0")
                {
                    break;
                }

            }
        }
    }
}
