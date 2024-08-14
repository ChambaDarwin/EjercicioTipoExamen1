using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoExamen1
{
    public  class VideoJuego: AtributosIguales
    {
        
        private int yearEdition;
        private String sistema;
        private String description;

        public VideoJuego(String nombre,int yearEdition, string sistema, string description):base(nombre)
        {
            this.yearEdition = yearEdition;
            this.sistema = sistema;
            this.description = description;
        }



        public void imprimir()
        {
            Console.WriteLine();
            Console.WriteLine($"Nombre: {nombre} \nyearEdition: {yearEdition} \nsistema: {sistema} " +
                $"\ndescription: {description}" +
                $"\nEsta disponible: {estaDisponible}");
            Console.WriteLine();
        }
    }
}
