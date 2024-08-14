using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoExamen1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            GestionPeliculas.listaPelicula.Add(new Pelicula("pelicula1", "drama", "ecuador"));
            GestionVideoJuegos.listaJuegos.Add(new VideoJuego("juego1", 2024, "accion", "description1"));
            do
            {
                int opcion = mostrarMenu();
                gestionVideoclub(opcion);
                String salir = mensajeSalr();
                Console.WriteLine();
                if (salir.Equals("s")) continue; else break;

            }while(true);
        }
        private static String mensajeSalr()
        {
            Console.WriteLine("escriba 's' para continuar o presione cualquier tecla para continuar");
            String salir=Console.ReadLine();
            return salir;
        } 
        private static int  mostrarMenu()
        {
            String mensaje = "1.. mostrar todos los videojuegos o películas existentes" +
                "\n2..mostrar los que están actualmente alquilados (todas las copias) y los que están" +
                " sin alquilar." +
                "\n3..consultar si existe un cierto videojuego o película, utilizar el nombre " +
                "según corresponda." +
                "\n4..insertar una nueva película o videojuego en el sistema " +
                "\n5..El alquiler y devolución se realizará utilizando el número de registro.";
            Console.WriteLine(mensaje);
            int opcion=int.Parse(Console.ReadLine());
            return opcion;
                
        }
        private static void gestionVideoclub(int opcion)
        {
            switch(opcion)
            {
                case 1:
                    mostrarPeliculasVideoJuegos();
                    break;
                case 2:
                    PVJAlquiladosDisponibles();
                    break;
                case 3:
                    buscarPeliculasVideoJuegos();
                    break;
                case 4:
                    ingresarPeliculasVideoJuegos();
                    break;
                case 5:
                    AlquilarDevolverPeliculasVideoJuegos();
                      
                    break;
            }

        }
        private static void mostrarPeliculasVideoJuegos()
        {
            Console.WriteLine("Seleccione una opcion: " +
                "\n1..para mostrar las peliculas" +
                "\n2..para mostrar los video juegos");
            int opcion = int.Parse(Console.ReadLine());
            switch(opcion)
            {
                case 1:
                    GestionPeliculas.mostrarPeliculas();
                    break;
                case 2:
                    GestionVideoJuegos.imprimirVideoJuegos();
                    break;
                default: Console.WriteLine("opcion no valida"); break;
            }

        }

        private static void PVJAlquiladosDisponibles()
        {
            Console.WriteLine("Seleccione una opcion: " +
                "\n1..para mostrar las peliculas disponibles" +
                "\n2..para mostrar llas peliculas alquiladas" +
                "\n3..para mostrar los videoJuegos disponibles" +
                "\n4..para mostrar los videoJuegos alquilados");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    GestionPeliculas.peliculasDisponibles();
                    break;
                case 2:
                    GestionPeliculas.peliculasAlquiladas();
                    break;
                case 3:
                    GestionVideoJuegos.videoJuegosDisponibles();
                    break;
                case 4:
                    GestionVideoJuegos.videoJuegosAlquilados();
                    break;
                default: Console.WriteLine("opcion no valida"); break;
            }

        }

        private static void ingresarPeliculasVideoJuegos()
        {
            Console.WriteLine("Seleccione una opcion: " +
                "\n1..para ingresar  peliculas" +
                "\n2..para ingresar video juegos");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    GestionPeliculas.ingresarPelicula();
                    break;
                case 2:
                    GestionVideoJuegos.ingresarVideoJuego();
                    break;
                default: Console.WriteLine("opcion no valida"); break;
            }

        }

        private static void buscarPeliculasVideoJuegos()
        {
            Console.WriteLine("Seleccione una opcion: " +
                "\n1..para buscra peliculas" +
                "\n2..para buscar video juegos");
            int opcion = int.Parse(Console.ReadLine());
            switch (opcion)
            {
                case 1:
                    GestionPeliculas.buscarPelicula();
                    break;
                case 2:
                    GestionVideoJuegos.buscarVideoJuego();
                    break;
                default: Console.WriteLine("opcion no valida"); break;
            }

        }

        private static void AlquilarDevolverPeliculasVideoJuegos()
        {
            Console.WriteLine("Seleccione una opcion" +
                "\n1..para AlquilarPeliculas" +
                "\n2..para devolver Peliculas" +
                "\n3..para Alquilar videoJuegos" +
                "\n4..para devolver videoJuegos");
            Console.WriteLine();
            int opcion=int.Parse(Console.ReadLine()) ;
            switch(opcion)
            {
                case 1:
                    GestionPeliculas.alquilarPelicula();
                    break;
                case 2:
                    GestionPeliculas.devolverPelicula();
                    break;
                case 3:
                    GestionVideoJuegos.alquilarVideoJuego();
                    break;
                case 4:
                    GestionVideoJuegos.devolverVideoJuego();
                    break;
                default:
                    Console.WriteLine("Error opcion no valida");
                    break;
            }
        }

    }
}
