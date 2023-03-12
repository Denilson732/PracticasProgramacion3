using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaS07
{
    internal class Program
    {
        class Program1
        {
            static void Main(string[] args)
            {
                // Crear una lista de tiendas de calzado
                List<Tienda> tiendas = new List<Tienda>();
                tiendas.Add(new Tienda("SIMÁN"));
                tiendas.Add(new Tienda("ADOC"));
                tiendas.Add(new Tienda("PAR2"));

                // Mostrar las opciones de tiendas disponibles
                Console.WriteLine("------------Bienvenido------------");
                Console.WriteLine("------------Elija una tienda------");
                for (int i = 0; i < tiendas.Count; i++)
                {
                    Console.WriteLine((i + 1) + ". " + tiendas[i].Nombre);
                }

                // Pedir al usuario que elija una tienda
                int opcionTienda = Convert.ToInt32(Console.ReadLine());
                Tienda tiendaSeleccionada = tiendas[opcionTienda - 1];

                // Mostrar el catálogo de zapatos de la tienda seleccionada
                Console.WriteLine("Catálogo de  " + tiendaSeleccionada.Nombre + ":");
                tiendaSeleccionada.MostrarCatalogo();

                // Pedir al usuario que elija un zapato del catálogo
                Console.WriteLine("Elija un zapato: ");
                int opcionZapato = Convert.ToInt32(Console.ReadLine());
                Zapato zapatoSeleccionado = tiendaSeleccionada.Catalogo[opcionZapato - 1];

                // Mostrar los detalles del zapato seleccionado
                Console.WriteLine("Tipo de zapato:" +zapatoSeleccionado.Estilo);
                Console.WriteLine("Marca: " + zapatoSeleccionado.Marca);
                Console.WriteLine("Talla: " + zapatoSeleccionado.Talla);
                Console.WriteLine("Descuento:" + zapatoSeleccionado.Descuento + "%");

            }
        }

        // Definir la clase Tienda
        class Tienda
        {
            public string Nombre { get; set; }
            public List<Zapato> Catalogo { get; set; }

            public Tienda(string nombre)
            {
                Nombre = nombre;
                Catalogo = new List<Zapato>();
                Catalogo.Add(new Zapato("Deportivo", "Nike", 9, 10));
                Catalogo.Add(new Zapato("Casual", "Adidas", 8, 5));
                Catalogo.Add(new Zapato("Gala", "Gucci", 10, 10));
            }

            public void MostrarCatalogo()
            {
                for (int i = 0; i < Catalogo.Count; i++)
                {
                    Console.WriteLine((i + 1) + "- " + Catalogo[i].Estilo);
                }
            }
        }

        // Definir la clase Zapato
        class Zapato
        {
            public Zapato(string estilo, string Marca, int Talla, double Descuento)
            {
                this.Estilo = estilo;
                this.Marca = Marca;
                this.Talla = Talla;
                this.Descuento = Convert.ToInt32(Descuento);


            }
            
            public string Estilo { get; set; }
            public string Marca { get; set; }
            public int Talla { get; set; }
            public int Descuento { get; set; }



        }



    }

}


    
        
    





