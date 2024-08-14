using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoExamen1
{
    public  class Pelicula:AtributosIguales
    {


        private String pais;
        private String clase;
        public Pelicula(string nombre, string clase,String pais):base(nombre)
        
        {
            this.pais = pais;
            this.clase = clase;
        }

        public void imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Nombre: {nombre} \nclase: {clase} \npais: {pais} " +
                $"\nestaDisponible: {estaDisponible}" +
                $"\nNumeroRegistro: {numeroSerie}");
            Console.WriteLine();
        }
    }
}
