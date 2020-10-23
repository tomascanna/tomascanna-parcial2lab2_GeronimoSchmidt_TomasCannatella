using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_GeronimoSchmidt_TomasCannatella
{
    abstract class Prenda
    {
        protected double precioBase;
        protected double precioFinal;
        protected bool calidad;// false es calidad estandar y true es calidad premium
        

        public Prenda(double precioBase,bool calidad)
        {
            this.precioBase = precioBase;
            this.calidad = calidad;
        }

        public virtual double calcularPrecio()
        {
            double porcentaje=0;
            if (this.calidad == true)
            {
                porcentaje = 30;
            }
            
            return porcentaje;
        }
    }
}
