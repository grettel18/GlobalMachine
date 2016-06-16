using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text;


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
            public int DescuentoProducto;
            public int CantidadProducto;
        };
        static void AgregarProducto()
        {
            int i = 0;
            int size = 2;
            int Frituras = 0;
            int Reposteria = 0;
            int RefrescoGaseoso = 0;
            int RefrescoNatural = 0;
            int Confiteria = 0;


            Console.WriteLine("*-* GLOBAL MACHINE *-*");
            Console.WriteLine("Digite la cantidad que desea ingresar de producto: ");
            size = int.Parse(Console.ReadLine());
            int a = 0;
            while (a != 1)
            {

                Console.Clear();
                if (i < productos.Length)
                {

                    Console.Write("Digite el codigo del articulo: ");
                    productos[i].CodigoProducto = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del articulo: ");
                    productos[i].NombreProducto = Console.ReadLine();
                    Console.Write("Digite el tipo: \n 1 - frituras \n 2 - reposteria \n 3 - refrescos gaseosos \n 4 - refrescos naturales \n 5 - confiteria \n ");

                    int tipo = int.Parse(Console.ReadLine());
                    if (tipo == 1)
                   

                            {
                                productos[i].TipoProducto = "frituras";
                                Frituras = Frituras + 1;
                            }
                    if (tipo == 2)
                    {
                        productos[i].TipoProducto = "Reposteria";
                        Reposteria = Reposteria + 1;
                    }
                    if (tipo == 3)
                    {
                        productos[i].TipoProducto = "refrescos gaseosos";
                        RefrescoGaseoso = RefrescoGaseoso + 1;
                    }
                    if (tipo == 4)
                    {
                        productos[i].TipoProducto = "refrescos naturales";
                        RefrescoNatural = RefrescoNatural + 1;
                    }
                    if (tipo == 5)
                    {
                        productos[i].TipoProducto = "Confiteria";
                        Confiteria = Confiteria + 1;
                    }
                    Console.WriteLine("Digite la fecha de vencimiento:");
                    productos[i].VencimientoProducto = Console.ReadLine();
                    Console.WriteLine("Digite el nombre del proveedor:");
                    productos[i].Proveedor = Console.ReadLine();
                }
           
            }
            
        }
        static void ListaProducto()

        {
            int Frituras = 0;
            int Reposteria = 0;
            int RefrescoGaseoso = 0;
            int RefrescoNatural = 0;
            int Confiteria = 0;
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            int n5 = 0;
            string currentPath = Path.Combine(Directory.GetParent(System.IO.Directory.GetCurrentDirectory()).Parent.FullName);
            Console.WriteLine(currentPath + @"\reporte.txt");

            StreamWriter sw = new StreamWriter(currentPath + @"\reporte.txt");
            //listar productos
            int reg = 0, i;
            Console.Clear();
            Console.WriteLine(                           "*-* Global Machines  *-*");
            Console.WriteLine(                          "Listado de Productos.             ");
            Console.WriteLine("===================================================================================");
            Console.WriteLine("Reg Codigo Nombre \tTipo \tVencimiento \tProveedor \tPosicion \tPrecio");
            sw.WriteLine(                               " *-* Global Machines  *-*");
            sw.WriteLine(                               "Listado de Productos.             ");
            sw.WriteLine("===================================================================================");
            sw.WriteLine("Reg Codigo Nombre \tTipo \tVencimiento \tProveedor \tPosicion \tPrecio");
            for (i = 0; i < productos.Length; i++)
            {
                reg = i + 1;


                Console.WriteLine(reg + " " + productos[i].CodigoProducto + " " + productos[i].NombreProducto + "\t" + productos[i].TipoProducto + "\t" + productos[i].VencimientoProducto + "\t" + productos[i].Proveedor + "\t" + productos[i].PosicionProducto + "\t" + productos[i].PrecioProducto);
                sw.WriteLine(reg + " " +      productos[i].CodigoProducto + " " + productos[i].NombreProducto + "\t" + productos[i].TipoProducto + "\t" + productos[i].VencimientoProducto + "\t" + productos[i].Proveedor + "\t" + productos[i].PosicionProducto + "\t" + productos[i].PrecioProducto);
            }


            Console.WriteLine("*-* Global Machines  *-*");
            Console.WriteLine("================================");
            Console.WriteLine("Informe de inventario");
            Console.WriteLine("=================================");
            Console.WriteLine("Clasificacion       ||\t Cantidad");
            Console.WriteLine("Frituras            ||\t" + Frituras);
            Console.WriteLine("Reposteria          ||\t" + Reposteria);
            Console.WriteLine("Refrescos Gaseosos  ||\t" + RefrescoGaseoso);
            Console.WriteLine("Refrescos Naturales ||\t" + RefrescoNatural);
            Console.WriteLine("Confiteria          ||\t" + Confiteria);
            Console.WriteLine("Nivel               ||\t Cantidad");
            Console.WriteLine("   1                ||\t" + n1);
            Console.WriteLine("   2                ||\t" + n2);
            Console.WriteLine("   3                ||\t" + n3);
            Console.WriteLine("   4                ||\t" + n4);
            Console.WriteLine("   5                ||\t" + n5);
            sw.WriteLine("        *-* Global Machines  *-*");
            sw.WriteLine("================================");
            sw.WriteLine(       "Informe de inventario");
            sw.WriteLine("=================================");
            sw.WriteLine("Clasificacion       ||\t Cantidad");
            sw.WriteLine("Frituras            ||\t" + Frituras);
            sw.WriteLine("Reposteria          ||\t" + Reposteria);
            sw.WriteLine("Refrescos Gaseosos  ||\t" + RefrescoGaseoso);
            sw.WriteLine("Refrescos Naturales ||\t" + RefrescoNatural);
            sw.WriteLine("Confiteria          ||\t" + Confiteria);
            sw.WriteLine("                                              ");
            sw.WriteLine("Nivel               ||\t Cantidad");
            sw.WriteLine("   1                ||\t" + n1);
            sw.WriteLine("   2                ||\t" + n2);
            sw.WriteLine("   3                ||\t" + n3);
            sw.WriteLine("   4                ||\t" + n4);
            sw.WriteLine("   5                ||\t" + n5);
            sw.Close();

            Console.ReadKey();
        }

        static producto[] productos;

        static void Main()
        {
            productos = new producto[size];



            do
            {
                Console.Clear();
                Console.WriteLine("*-* GLOBAL MACHINE  *-*");
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
                            //ModificarProducto();
                            break;
                        }
                    case 3:
                        {
                            //Eliminar información dejando campos en 0 o vacío
                            //EliminarProducto();
                            break;
                        }
                    case 4:
                        {
                            //BuscarProducto();
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
                           // VentaProducto();
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

//       
//       

//        static producto[] productos;

//        static void AgregarProducto()
//        {

//            int r = 0, i = 0;
//            while (r != 1)
//            {
//                Console.Clear();
//                if (i < productos.Length)
//                {
//                    Console.WriteLine("-* GLOBAL MACHINE  *-*");
//                    Console.WriteLine("Ingreso de producto.             ");
//                    Console.Write("Digite el codigo del producto:                  ");
//                   productos[i].CodigoProducto(int.Parse(Console.ReadLine()));
//                    Console.Write("Digite el nombre del producto:    ");
//                    productos[i].NombreProducto(Console.ReadLine());
//                    Console.Write("Digite la fecha de vencimiento del producto:");
//                    productos[i].VencimientoProducto(int.Parse(Console.ReadLine()));
//                    Console.Write("Digite el Proveedor del Producto:");
//                    productos[i].Proveedor(int.Parse(Console.ReadLine()));
//                    Console.Write("Digite la posicion del producto:");
//                    productos[i].PosicionProducto(int.Parse(Console.ReadLine()));
//                    Console.Write("Digite elprecio del producto:");
//                    productos[i].PrecioProducto(int.Parse(Console.ReadLine()));


//                    if (productos.(productos) == true)
//                        Console.WriteLine("producto agregado correctamente");
//                    else
//                        Console.WriteLine("Producto no agregado");
//                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
//                    r = int.Parse(Console.ReadLine());
//                    i++;
//                }
//                else
//                {
//                    Console.WriteLine("Registro de libros lleno..");
//                    r = 1;
//                    Console.ReadKey();
//                }
//            }

//        }


//        static void BuscarProducto()
//        {
//            //buscar producto
//            int CodigoProducto = 0, reg = 0, r = 0;
//            while (a != 1)
//            {
//                Console.Clear();
//                Console.WriteLine("-* GLOBAL MACHINE  *-*");
//                Console.WriteLine("Búsquedad de productos.           ");
//                Console.WriteLine("Digite e codigo del producto a buscar");
//                CodigoProducto = int.Parse(Console.ReadLine());
//                if (producto.SeekData(CodigoProducto) == true)
//                {
//                    reg = CodigoProducto;
//                    Console.WriteLine("Registro: " + reg);
//                    Console.WriteLine("ID:       " + CodigoProducto());
//                    Console.WriteLine("Nombre:   " + NombreProducto());
//                    
//                    Console.WriteLine("Precio:   " + );*/
//                }
//                else
//                    Console.WriteLine("No se encontro ese codigo");
//                Console.WriteLine("Desea buscar otro codigo del producto 0-Sí 1-No");
//                r = int.Parse(Console.ReadLine());
//            }
//        }



//        }
//    }
//}

////Haciendo el cobro
//static void Cancelar()
//{
//    Console.Write("\nMonto a Cancelar: ");
//            Console.WriteLine("{0:N2}", SalesTotal);
//            Console.Write("Monto Ahorro: ");
//            Console.WriteLine("{0:N2}", TotalDiscount);
//        returnflag:
//            Console.Write("Digite el Monto con que Cancela: ");
//            AmountTended = double.Parse(Console.ReadLine());
//            if (AmountTended >= SalesTotal)
//                Difference = AmountTended - SalesTotal;
//            else
//            {
//                Console.WriteLine("Monto insuficiente..Intente de nuevo por favor");
//                goto returnflag;
//            }
//            Console.WriteLine("Presione Enter para Imprimir la Factura");
//            Console.ReadKey();

//            //Imprimiendo la factura
//            Console.Clear();
//            Console.WriteLine("===================================================================");
//            Console.WriteLine("*-*                          GLOBAL MACHINES                    *-*");
//            Console.WriteLine("===================================================================");
//            Console.WriteLine(" Factura Proforma\t\t\t\t\t    N°0001");
//            Console.Write(" Cliente : ");
//            Console.WriteLine(NombreCliente);
//            Console.Write(" Teléfono: ");
//            Console.WriteLine(TelefonoCliente);
//            Console.WriteLine("-------------------------------------------------------------------");
//            Console.WriteLine(" Item\t\t\t\tCtd\tPrecio\t\tSubTotal");
//            Console.WriteLine("-------------------------------------------------------------------");

//            Console.WriteLine("-------------------------------------------------------------------");
//            Console.Write(" Total Orden:    \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", TotalOrder);
//            Console.Write(" Total Descuento:    \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", TotalDiscount);
//            Console.Write(" Impuesto Venta: \t\t\t\t\t");
//            Console.WriteLine(TaxRate * 100 + "%");
//            Console.Write(" Impuesto Total: \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", TaxAmount);
//            Console.Write(" Precio Neto:    \t\t\t\t\t");
//            Console.WriteLine("¢{0:N2}", SalesTotal);
//            Console.WriteLine("-------------------------------------------------------------------");
//            Console.Write(" Monto Recibido:");
//            Console.WriteLine("¢{0:N2}", AmountTended);
//            Console.Write(" Monto Cambio  :");
//            Console.WriteLine("¢{0:N2}", Difference);
//            Console.WriteLine("===================================================================");
//            Console.Write(" Gracias por comprar con nosotros...");
//            Console.ReadKey();
//            //return 0;
//        }





