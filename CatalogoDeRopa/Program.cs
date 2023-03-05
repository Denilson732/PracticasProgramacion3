using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console; 

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------TIENDA DE ROPA----------\n");

            Console.WriteLine("\nELIGE LA OPCION:\n 1- Prendas de alta calidad " +
                "\n 2- Prendas de media calidad \n 3- Prendas de baja calidad");
            int opcion = int.Parse(Console.ReadLine());
            while (opcion <= 0 || opcion >= 3)
            {
                Clear();
                Console.WriteLine("----------TIENDA DE ROPA----------\n\n\n");
                ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("¡¡ asegurese de que la opción se encuentre en el menu!!");
                ResetColor();
                Console.WriteLine("\nELIGE LA OPCIÓN:" +
                    "\n 1- Prendas de alta calidad " +
                "\n 2- Prendas de media calidad \n 3- Prendas de baja calidad");
                opcion = int.Parse(Console.ReadLine());
            }
            CatalogoPrendas catalogo = new CatalogoPrendas();

            switch (opcion)
            {

                case 1:
                    Clear();
                    Console.WriteLine($"Elegiste la opcion {opcion}\n");
                    
                    PrendaAltaCalidad camisa1 = new PrendaAltaCalidad
                    {
                        Material = "Algodón",
                        Talla = "M",
                        Color = "Azul",
                        Precio = 49.99M,
                        Marca = "Hillfinger",
                        Diseño = "Camisa de casual"
                    };
                    catalogo.AgregarPrenda(camisa1);
                    catalogo.MostrarCatalogo("AltaCalidad");
                    break;
                case 2:
                    PrendaMediaCalidad pantalon1 = new PrendaMediaCalidad
                    {
                        Material = "Algodón",
                        Talla = "L",
                        Color = "Azul oscuro",
                        Precio = 29.99M,
                        Diseño = "Pantalón de vestir"
                    };
                    catalogo.AgregarPrenda(pantalon1);
                    catalogo.MostrarCatalogo("MediaCalidad");
                    break;
                case 3:
                    PrendaBajaCalidad vestido1 = new PrendaBajaCalidad
                    {
                        Material = "Algodón",
                        Talla = "S",
                        Color = "Gris",
                        Precio = 14.99M,
                        Estilo = "Vestido de verano"
                    };
                    catalogo.AgregarPrenda(vestido1);
                    catalogo.MostrarCatalogo("BajaCalidad");
                    break;
                default:
                    Console.WriteLine("Esa opcion no esta disponible");
                    Console.ReadLine();

                    break;


            }

        }
    }

    
}

