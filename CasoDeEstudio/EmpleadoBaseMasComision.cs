using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CasoDeEstudio
{
    public class EmpleadoBaseMasComision: EmpleadoPorComision
    {
        private decimal salarioBase;//salario base por semana

        //constructor con seis parametros
        public EmpleadoBaseMasComision(string nombre, string apellido, string nss, decimal ventas, decimal tarifa, decimal salario): base(nombre, apellido, nss, ventas, tarifa)
        {
            SalarioBase = salario; //valida el salario base a traves de una propiedad
        }//fin del constructor de EmpleadoBaseMasComision con seis parametros

        //propiedad que obtiene y establece el salario base del empleado por comisión con salario base
        public decimal SalarioBase
        {
            get
            {
                return salarioBase;
            }//fin de get
            set
            {
                salarioBase = (value >= 0) ? value : 0; //validación
            }// fin de set
        }//fin de la propiedad SalarioBase

        //calcula los ingresos; redefine el método Ingresos en EmpleadoPorComision
        public override decimal Ingresos()
        {
            return SalarioBase + base.Ingresos();
        }//fin del metodo ingresos

        //devuelve representación String del objeto EmpleadoBaseMasComision
        public override string ToString()
        {
            return string.Format( "{0} {1}; {2}: {3:C}", "salario base +", base.ToString(), "salario base", SalarioBase);
        }//fin del metodo ToString
    }//din de la clase EmpleadoBaseMasComision
}
