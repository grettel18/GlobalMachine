using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen1
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 2;
        [Flags]
        enum PrecioProducto
        {
            Frituras = 150,
            Reposteria = 250,
            RefrescoGaseoso = 50,
            RefrescoNatural = 250,
            Confiteria = 10,
        };
        struct producto
        {
            public int CodigoProducto;
            public string NombreProducto;
            public string TipoProducto;
            public string VencimientoProducto;
            public string Proveedor;
            public int PosicionProducto;
            public int PrecioProducto;
        };

        static producto[] productos;

        static void AgregarProducto()
        {
            
            int r = 0, i = 0;
            while (r != 1)
            {
                Console.Clear();
                if (i < productos.Length)
                {
                    Console.WriteLine("-* GLOBAL MACHINE  *-*");
                    Console.WriteLine("Ingreso de producto.             ");
                    Console.Write("Digite el codigo del producto:                  ");
                   productos[i].CodigoProducto(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el nombre del producto:    ");
                    productos[i].NombreProducto(Console.ReadLine());
                    Console.Write("Digite la fecha de vencimiento del producto:");
                    productos[i].VencimientoProducto(int.Parse(Console.ReadLine()));
                    Console.Write("Digite el Proveedor del Producto:");
                    productos[i].Proveedor(int.Parse(Console.ReadLine()));
                    Console.Write("Digite la posicion del producto:");
                    productos[i].PosicionProducto(int.Parse(Console.ReadLine()));
                    Console.Write("Digite elprecio del producto:");
                    productos[i].PrecioProducto(int.Parse(Console.ReadLine()));


                    if (producto.(productos) == true)
                        Console.WriteLine("producto agregado correctamente");
                    else
                        Console.WriteLine("Producto no agregado");
                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;
                }
                else
                {
                    Console.WriteLine("Registro de libros lleno..");
                    r = 1;
                    Console.ReadKey();
                }
            }

        }

        static void ListaProducto()
        {
            
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine("-* GLOBAL MACHINE  *-*");
            Console.WriteLine("Listado de Productos.             ");
            for (i = 0; i < producto.size; i++)
            {
                producto.PrintData(i);
                reg = i + 1;
                Console.WriteLine("Registro: " + reg);
                Console.WriteLine("ID:       " + Libro.GetBookID());
                Console.WriteLine("Nombre:   " + Libro.GetBookName());
                /*Console.WriteLine("Auto:     " + );
                Console.WriteLine("Precio:   " + );*/
            }
            Console.ReadKey();
        }

        static void BuscarProducto()
        {
            //buscar producto
            int CodigoProducto = 0, reg = 0, r = 0;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("-* GLOBAL MACHINE  *-*");
                Console.WriteLine("Búsquedad de productos.           ");
                Console.WriteLine("Digite e codigo del producto a buscar");
                CodigoProducto = int.Parse(Console.ReadLine());
                if (producto.SeekData(CodigoProducto) == true)
                {
                    reg = CodigoProducto;
                    Console.WriteLine("Registro: " + reg);
                    Console.WriteLine("ID:       " + CodigoProducto());
                    Console.WriteLine("Nombre:   " + NombreProducto());
                    /*Console.WriteLine("Auto:     " + );
                    Console.WriteLine("Precio:   " + );*/
                }
                else
                    Console.WriteLine("No se encontro ese codigo");
                Console.WriteLine("Desea buscar otro codigo del producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }
   



        static void Main()
        {
            //inicializar el objeto
            producto.SetSize(size);
            producto.Initdata();

          

            do
            {
                Console.Clear();
                Console.WriteLine("-* GLOBAL MACHINE  *-*");
                Console.WriteLine("1. Ingreso de productos.");
                Console.WriteLine("2. Modificación de productos.");
                Console.WriteLine("3. Eliminación de productos.");
                Console.WriteLine("4. Búsquedad de productos.");
                Console.WriteLine("5. Listado de productos.");
                Console.WriteLine("6. Venta de productos.");
                Console.WriteLine("7. Salir.");
                Console.WriteLine("Selecciones una opción");
                option = int.Parse(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        {
                            AgregarProducto();
                            break;
                        }
                    case 2:
                        {
                            //Modificar la información
                            ModificarProducto();
                            break;
                        }
                    case 3:
                        {
                            //Eliminar información dejando campos en 0 o vacío
                            EliminarProducto();
                            break;
                        }
                    case 4:
                        {
                            BuscarProducto();
                            break;
                        }
                    case 5:
                        {
                            ListaProducto();
                            break;
                        }
                    case 6:
                        {
                            //Venta similar a tarea1
                            VentaProducto();
                            break;
                        }
                    case 7:
                        //Salir
                        break;
                    default:
                        {
                            Console.WriteLine("Seleccione inválida..");
                            Console.ReadKey();
                            Console.Clear();
                            break;
                        }
                }
            } while (option != 7);
        }
    }
}

//Haciendo el cobro
static void Cancelar()
{
    Console.Write("\nMonto a Cancelar: ");
            Console.WriteLine("{0:N2}", SalesTotal);
            Console.Write("Monto Ahorro: ");
            Console.WriteLine("{0:N2}", TotalDiscount);
        returnflag:
            Console.Write("Digite el Monto con que Cancela: ");
            AmountTended = double.Parse(Console.ReadLine());
            if (AmountTended >= SalesTotal)
                Difference = AmountTended - SalesTotal;
            else
            {
                Console.WriteLine("Monto insuficiente..Intente de nuevo por favor");
                goto returnflag;
            }
            Console.WriteLine("Presione Enter para Imprimir la Factura");
            Console.ReadKey();

            //Imprimiendo la factura
            Console.Clear();
            Console.WriteLine("===================================================================");
            Console.WriteLine("*-*                          GLOBAL MACHINES                    *-*");
            Console.WriteLine("===================================================================");
            Console.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
            Console.Write(" Cliente : ");
            Console.WriteLine(NombreCliente);
            Console.Write(" Teléfono: ");
            Console.WriteLine(TelefonoCliente);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
            Console.WriteLine("-------------------------------------------------------------------");
       
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write(" Total Orden:    \t\t\t\t\t");
            Console.WriteLine("¢{0:N2}", TotalOrder);
            Console.Write(" Total Descuento:    \t\t\t\t\t");
            Console.WriteLine("¢{0:N2}", TotalDiscount);
            Console.Write(" Impuesto Venta: \t\t\t\t\t");
            Console.WriteLine(TaxRate * 100 + "%");
            Console.Write(" Impuesto Total: \t\t\t\t\t");
            Console.WriteLine("¢{0:N2}", TaxAmount);
            Console.Write(" Precio Neto:    \t\t\t\t\t");
            Console.WriteLine("¢{0:N2}", SalesTotal);
            Console.WriteLine("-------------------------------------------------------------------");
            Console.Write(" Monto Recibido:");
            Console.WriteLine("¢{0:N2}", AmountTended);
            Console.Write(" Monto Cambio  :");
            Console.WriteLine("¢{0:N2}", Difference);
            Console.WriteLine("===================================================================");
            Console.Write(" Gracias por comprar con nosotros...");
            Console.ReadKey();
            //return 0;
        }

    

   
        
