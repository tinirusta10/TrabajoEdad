using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EDAD
{
    public class Persona
    {
        public Persona()
        {
                
        }

        public Persona( string nomb, double documento,DateTime fecha)
        {
            Nombre = nomb;
            DNI=documento;
            FechaNac=fecha;
        }

        #region atributos
        string Nombre;
        double DNI;
        DateTime FechaNac;
        #endregion

        #region propiedad
        public string p_nombre
        {

            set { Nombre = value; }
            get { return Nombre; }


        }

        public double p_dni
        {

            set { DNI = value; }
            get { return DNI; }


        }

        public DateTime p_fecha
        {

            set { FechaNac = value; }
            get { return FechaNac; }


        }
        #endregion

        public double Edad()
       {

                DateTime fechaActual = DateTime.Now;

                TimeSpan diferencia = fechaActual - FechaNac;
                double dias = diferencia.TotalDays;
                double años = Math.Floor(dias / 365);

                return años;            
           
        }
    }
}
