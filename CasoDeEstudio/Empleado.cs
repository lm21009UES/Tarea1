using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoDeEstudio
{
    public abstract class Empleado
    {
        private string primerNombre;
        private string apellidoPaterno;
        private string numeroSeguroSocial;
        
        //cosntructor con tres parámetros.
        public Empleado(string nombre, string apellido, string nss)
        {
            primerNombre = nombre;
            apellidoPaterno = apellido;
            numeroSeguroSocial = nss;
        }//fin de constructor de Empleado con tres parámetros
        
        //propiedad de solo lectura que obtiene el primer nombre del empleado
        public string PrimerNombre
        {
            get
            {
                return primerNombre;
            }//fin de get
        }//fin de la propiedad primerNombre

        //propiedad de solo lectura que obtiene el apellido paterno del empleado
        public string ApellidoPaterno
        {
            get
            {
                return apellidoPaterno;
            }//fin de get
        }//fin de la propiedad apellidoPaterno

        //propiedad de solo lectura que obtiene el número de seguro social del empleado
        public string NumeroSeguroSocial
        {
            get
            {
                return numeroSeguroSocial;
            }//fin de get
        }// fin de la propiedad NumeroSeguroSocial

        //devuelve representacion string del objeto Empleado, usando las propiedades
        public override string ToString()
        {
            return string.Format( "{0} {1}\nnúmero de seguro social: {2}", PrimerNombre, ApellidoPaterno, NumeroSeguroSocial);
        }//fin del metodo ToString

        //metod abstracto redifinido por las clases derivadas
        public abstract decimal Ingresos();//no hay implementacion aqui
    }//fin de la clase abstracta de Empleado
}