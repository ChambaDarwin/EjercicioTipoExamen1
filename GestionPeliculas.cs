using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoExamen1
{
    public class GestionPeliculas
    {

        public static List<Pelicula> listaPelicula= new List<Pelicula>();
        public static List<Pelicula> listaPeliculaAlquiladas = new List<Pelicula>();
        public static List<Pelicula> listaPeliculasDisponibles = new List<Pelicula>();

        static int numero = 1;




        public static void mostrarPeliculas()
        {
            Console.WriteLine("Lista de  peliculas");

            foreach(Pelicula p in listaPelicula)
            {
                p.imprimir();
               
            }
        }
        
        public static void peliculasAlquiladas()
        {
            Console.WriteLine("Peliculas Alquiladas");
            
            foreach (Pelicula p in listaPelicula)
            {
                if (!p.EstaDisponible == true)
                {
                    listaPeliculaAlquiladas.Add(p);
                    p.imprimir();
                }
                
            }
        }

        public static void peliculasDisponibles()
        {
            Console.WriteLine("Peliculas Disponibles");

            foreach (Pelicula p in listaPelicula)
            {
                if (p.EstaDisponible)
                {
                    listaPeliculasDisponibles.Add(p);
                    p.imprimir();
                }

            }
        }

        public static void ingresarPelicula()
        {
            do
            {
                    Console.WriteLine("Ingrese el pais ");
                    String pais = Console.ReadLine();

                    Console.WriteLine("Ingrese el nombre");
                    String nombre = Console.ReadLine();

                    Console.WriteLine("Ingrese el genero");
                    String genero = Console.ReadLine();

                    Pelicula p = new Pelicula(nombre, genero, pais);
                    p.NumeroSerie = numero ++;

                    listaPelicula.Add(p);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("escriba s para ingresar un nuevo alumno o presione cualquier tecla para finalizar");
                String salir = Console.ReadLine();

                if (salir.Equals("s")) continue; else break;
            } while (true);
            
        }

        public static void buscarPelicula()
        {
            Console.WriteLine("Buscar Pelicula\n");

            Console.WriteLine("Ingrese el nombre de la pelicula");
            String nombre=Console.ReadLine();

            bool encontrado = false;

            foreach(Pelicula p in listaPelicula)
            {
                if (p.Nombre == nombre)
                {
                    encontrado=true;
                    p.imprimir();
                    break;
                }
            }

            if (!encontrado) Console.WriteLine("Error: el nombre de la pelicula no existe");
        }
        public static void alquilarPelicula()
        {
            Console.WriteLine("Alquilar pelicula");
            Console.WriteLine("Ingrese el numero de registro");
            int numReistro=int.Parse(Console.ReadLine());
            bool encontrado =false;
            foreach (Pelicula pelicula in listaPelicula)
            {
                if(pelicula.NumeroSerie== numReistro)
                {
                    if (pelicula.EstaDisponible)
                    {
                        pelicula.EstaDisponible = false;
                        pelicula.imprimir();
                        listaPeliculasDisponibles.Remove(pelicula);
                        listaPeliculaAlquiladas.Add(pelicula);
                        
                    }
                    else
                    {
                        Console.WriteLine("No puedes Alquilar una pelicula");
                    }
                    encontrado = true;
                    break;
                    
                }
            }
            if(!encontrado)
            {
                Console.WriteLine("Error el numero de registro no existe");
            }
        }

        public static void devolverPelicula()
        {
            Console.WriteLine("Alquilar pelicula");
            Console.WriteLine("Ingrese el numero de registro");
            int numReistro = int.Parse(Console.ReadLine());
            bool encontrado = false;
            foreach (Pelicula pelicula in listaPelicula)
            {
                if (pelicula.NumeroSerie == numReistro )
                {
                    if (pelicula.EstaDisponible==false)
                    {
                        pelicula.EstaDisponible = true;
                        pelicula.imprimir();
                        listaPeliculasDisponibles.Add(pelicula);
                        listaPeliculaAlquiladas.Remove(pelicula);

                    }
                    else
                    {
                        Console.WriteLine("No puedes devolver  la pelicula");
                    }
                    encontrado = true;
                    break;

                }
                
            }
            if (!encontrado)
            {
                Console.WriteLine("Error el numero de registro no existe");
            }
        }

    }
}
