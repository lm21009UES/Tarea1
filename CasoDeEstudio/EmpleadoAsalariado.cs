using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoDeEstudio
{
    public class EmpleadoAsalariado: Empleado
    {
        private decimal salarioSemanal;

        //constructor con cuatro parametros
        public EmpleadoAsalariado(string nombre, string apellido, string nss, decimal salario): base(nombre, apellido, nss)
        {
            SalarioSemanal = salario;//valida el salario a través de una propiedad
        }//din del constructor de EmpleadoAsalariado con cuatro parámetros

        //propiedad que obtiene y establece el salario del empleado asalariado
        public decimal SalarioSemanal
        {
            get
            {
                return salarioSemanal;
            }//fin del get
            set
            {
                salarioSemanal = ((value >= 0) ? value : 0);//validacíón
            }//fin del set
        }//fin de la propiedad SalarioSemanal

        //calcula los ingresos; redifine el método abastracto Ingresos en Empleado
        public override decimal Ingresos()
        {
            return SalarioSemanal;
        }//fin del método ingresos

        //devuelve representación string del objeto EmpleadoAsalariado
        public override string ToString()
        {
            return string.Format( "empleado asalariado: {0}\n{1}: {2:C}", base.ToString(), "salario semanal", SalarioSemanal);
        }//fin del metodo ToString
    }//fin de la clase EmpleadoAsalariado
}
