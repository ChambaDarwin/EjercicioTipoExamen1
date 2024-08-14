using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoExamen1
{
    public class GestionVideoJuegos
    {
        public static List<VideoJuego> listaJuegos= new List<VideoJuego>();
        public static List<VideoJuego> listaJuegosAlquilados = new List<VideoJuego>();
        public static List<VideoJuego> listaJuegosDisponibles = new List<VideoJuego>();
        static int numero=1;


        public static void imprimirVideoJuegos()
        {
            foreach(VideoJuego juego in listaJuegos) {
                juego.imprimir();
            }

        }

        public static void videoJuegosDisponibles()
        {
            foreach (VideoJuego juego in listaJuegos)
            {
                if (juego.EstaDisponible)
                {
                    juego.imprimir();
                }
                
            }
        }

        public static void videoJuegosAlquilados()
        {
            foreach (VideoJuego juego in listaJuegos)
            {
                if (!juego.EstaDisponible)
                {
                    juego.imprimir();
                }

            }
        }


        public static void ingresarVideoJuego()
        {
            do
            {
                Console.WriteLine("Ingrese el nombre del videoJuego");
                String nombre=Console.ReadLine();

                Console.WriteLine("Ingrese el a;o de Edicion");
                int yearEdition = int.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese el sistema del videoJuego");
                String sistema = Console.ReadLine();

                Console.WriteLine("Ingrese la descripcion del videoJuego");
                String description = Console.ReadLine();

                VideoJuego juego = new VideoJuego(nombre, yearEdition, sistema,description);
                juego.NumeroSerie = numero++;
                listaJuegos.Add(juego);


                Console.WriteLine("Escriba 's' para continuar o presione cualquier tecla para finalizar");
                String salir=Console.ReadLine();
                if (salir.Equals("s")) continue; else break;
            }while(true);
        }


        public static void buscarVideoJuego()
        {
            Console.WriteLine("Ingrese el nombre del videoJuego");
            String nombre=Console.ReadLine();
            bool encontrado =false; ;
            foreach(VideoJuego juego in listaJuegos)
            {
                if (juego.Nombre.Equals(nombre))
                {
                    juego.imprimir();
                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Error: el nombre del video Juego no existe");
            }
        }

        public static void alquilarVideoJuego()
        {
            Console.WriteLine("Ingrese el numero de registro de la pelicula que desea alqular");

            int numeroRegistro=int.Parse(Console.ReadLine());

            bool encontrado =false;
            foreach(VideoJuego juego in listaJuegos)
            {
                if (juego.NumeroSerie.Equals(numeroRegistro))
                {
                    if (juego.EstaDisponible)
                    {
                        juego.EstaDisponible = false;
                        listaJuegosAlquilados.Add(juego);
                        listaJuegosDisponibles.Remove(juego);
                        juego.imprimir();
                        Console.WriteLine("Video juego alquilaodo con exito");

                    }
                    else
                    {
                        Console.WriteLine("No se puede alquilar el video juego");
                    }
                    
                    encontrado=true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Error: numero de serio incorrecto");
            }
        }

        public static void devolverVideoJuego()
        {
            Console.WriteLine("Ingrese el numero de registro del videoJuego que desea devolver");

            int numeroRegistro = int.Parse(Console.ReadLine());

            bool encontrado = false;
            foreach (VideoJuego juego in listaJuegos)
            {
                if (juego.NumeroSerie.Equals(numeroRegistro))
                {
                    if (!juego.EstaDisponible)
                    {
                        juego.EstaDisponible=true;
                        listaJuegosAlquilados.Remove(juego);
                        listaJuegosDisponibles.Add(juego);
                        juego.imprimir();
                        Console.WriteLine("Video juego alquilaodo con exito");

                    }
                    else
                    {
                        Console.WriteLine("No se puede devoler el video juego");
                    }

                    encontrado = true;
                }
            }
            if (!encontrado)
            {
                Console.WriteLine("Error: numero de serio incorrecto");
            }
        }
    }
}
