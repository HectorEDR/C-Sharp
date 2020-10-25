using System;
using System.Collections.Generic;

public class Inventario
{
    public List<Producto> ListadeProductos { get; set; }
    public Inventario()
    {
        ListadeProductos = new List<Producto>();

        Producto a = new Producto("001", "Iphone 11 pro", 2);
        Producto b = new Producto("002", "Monitor Asus", 3);
        Producto c = new Producto("003", "Laptop MSI", 2);
        Producto d = new Producto("004", "Ipad pro 2", 1);
        Producto e = new Producto("005", "Mouse Gamer Asus", 50);

        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);
    }

public void listaProductos()
    {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Listado de productos");
            Console.WriteLine("********************");
            Console.WriteLine();
            Console.WriteLine("Codigo, Descripcion y Existencias");

        foreach (var producto in ListadeProductos)
        {
            Console.WriteLine(producto.Codigo + " | " + producto.Descripcion + " | " + producto.Existencia.ToString());
        }
            Console.WriteLine();
            Console.Write("Presione la tecla enter para salir.");
            Console.ReadLine();
    }

private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
    foreach (var producto in ListadeProductos)
    {
        if (producto.Codigo == codigo) 
        {
            if (tipoMovimiento == "+")
            {
                 producto.Existencia = producto.Existencia + cantidad;
            }
                 else 
                {
                    producto.Existencia = producto.Existencia - cantidad;
                }
            }         
        }
    }

public void ingresoDeInventario()
{
        string codigo = "";
        string cantidad = "";

        Console.Clear();

        Console.WriteLine();
        Console.WriteLine("Ingreso de Productos al Inventario");
        Console.WriteLine("----------------------------------");
        Console.WriteLine();
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();

        movimientoInventario(codigo, Int32.Parse(cantidad), "+");
    }
public void salidaDeInventario()
{
     string codigo = "";
     string cantidad = "";

    Console.Clear();
                   
    Console.WriteLine();
    Console.WriteLine(" Salida de productos del inventario");
    Console.WriteLine("------------------------------------");
    Console.WriteLine();
    Console.Write("Ingrese el codigo del producto: ");
    codigo = Console.ReadLine();
    Console.WriteLine();
    Console.Write("Ingrese la cantidad del producto: ");
    cantidad = Console.ReadLine();
                
    movimientoInventario(codigo, Int32.Parse(cantidad), "-");
}

public void AjustePositivo()
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
public void AjusteNegativo()
    {
        string codigo = "";
        string cantidad = "";

        Console.Clear();
                    
        Console.WriteLine();
        Console.WriteLine(" Salida de productos del inventario");
        Console.WriteLine("------------------------------------");
        Console.WriteLine();
        Console.Write("Ingrese el codigo del producto: ");
        codigo = Console.ReadLine();
        Console.WriteLine();
        Console.Write("Ingrese la cantidad del producto: ");
        cantidad = Console.ReadLine();
        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
    }
                
}