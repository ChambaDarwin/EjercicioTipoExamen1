using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioTipoExamen1
{
    public  class AtributosIguales
    {

        protected String nombre;
        protected int numeroSerie;
        protected bool estaDisponible;

        public AtributosIguales(String nombre)

        {
            this.nombre = nombre;
            this.estaDisponible = true;

        }

        public String Nombre
        {
            get { return nombre; }  
            set { nombre = value; }
        }

        public int NumeroSerie
        {
            get { return numeroSerie; }
            set {  numeroSerie = value; }

        }

        public bool EstaDisponible
        {
            get { return estaDisponible; }
            set { estaDisponible = value;}
        }



    }
}
