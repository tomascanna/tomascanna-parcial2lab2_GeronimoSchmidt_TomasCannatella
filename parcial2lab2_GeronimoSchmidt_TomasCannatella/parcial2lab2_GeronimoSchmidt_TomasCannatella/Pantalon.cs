using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_GeronimoSchmidt_TomasCannatella
{
    class Pantalon:Prenda
    {
        private bool bermuda;

        public Pantalon(double precioBase, bool calidad,bool bermuda):base(precioBase,calidad)
        {
            this.bermuda = bermuda;
        }

        public override double calcularPrecio()
        {
            double porcentaje = base.calcularPrecio();

            if (bermuda == true)
            {
                if (porcentaje == 30)
                {
                    porcentaje -= 20;
                    this.precioFinal = precioBase + (precioBase * porcentaje / 100);
                }
                else
                {
                    porcentaje = 20;
                    this.precioFinal = precioBase - (precioBase * porcentaje / 100);
                }
            }
            else
            {
                if (porcentaje == 30)
                {
                    this.precioFinal = precioBase + (precioBase * porcentaje / 100);
                }
                else
                {
                    this.precioFinal = precioBase;
                }
            }

            return this.precioFinal;
        }
    }
}
