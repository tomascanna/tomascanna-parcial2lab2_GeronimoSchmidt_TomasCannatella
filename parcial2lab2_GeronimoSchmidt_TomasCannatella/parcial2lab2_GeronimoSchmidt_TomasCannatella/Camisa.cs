using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial2lab2_GeronimoSchmidt_TomasCannatella
{
    class Camisa:Prenda
    {
        private bool mangasCorta;

        public Camisa(double precioBase, bool calidad,bool mangasCorta) : base(precioBase,calidad)
        {
            this.mangasCorta = mangasCorta;
        }

        public override double calcularPrecio()
        {
            double porcentaje = base.calcularPrecio();

            if (mangasCorta == true)
            {
                if (porcentaje == 30)
                {
                    porcentaje -= 10;
                    this.precioFinal = precioBase + (precioBase * porcentaje / 100);
                }
                else
                {
                    porcentaje = 10;
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
