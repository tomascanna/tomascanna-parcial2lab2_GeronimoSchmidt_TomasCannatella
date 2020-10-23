using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace parcial2lab2_GeronimoSchmidt_TomasCannatella
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            rbtnStandard.Checked = true;
        }

        private void rbtnCamisa_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnCamisa.Checked == true)
            {
                checkBoxBermuda.Enabled = false;
                checkBoxBermuda.Checked = false;
            }
            else
            {
                checkBoxBermuda.Enabled = true;
            }
        }

        private void rbtnPantalon_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnPantalon.Checked == true)
            {
                checkBoxMangaCorta.Enabled = false;
                checkBoxMangaCorta.Checked = false;
            }
            else
            {
                checkBoxMangaCorta.Enabled = true;
            }
        }

        private void btnCalcularPrecioFInal_Click(object sender, EventArgs e)
        {
            bool auxCalidad=false,verificacion=true;
            double auxPrecio = 0;
            int auxCantidad = 0;
            
            #region "TRYCATCH VERIFICACION DE VARIABLES"
            try
            {
                auxPrecio = Convert.ToDouble(txtPrecio.Text);
                if (auxPrecio < 0)
                {
                    auxPrecio = (auxPrecio * -1);
                }
            }
            catch
            {
                MessageBox.Show("Revise el dato ingresado en el campo precio","ERROR");
                verificacion = false;
            }

            try
            {
                auxCantidad = Convert.ToInt32(txtCantidad.Text);
                if (auxCantidad < 0)
                {
                    auxCantidad =(auxCantidad * -1);
                }
            }
            catch
            {
                MessageBox.Show("Revise el dato ingresado en el campo cantidad","ERROR");
                verificacion = false;
            }


            if (rbtnStandard.Checked == true)
            {
                auxCalidad = false;
            }
            else
            {
                auxCalidad = true;
            }
            #endregion

            #region CALCULO
            if (verificacion == true)
            {
                if (rbtnCamisa.Checked == true)
                {
                    Camisa c1 = new Camisa(auxPrecio, auxCalidad, checkBoxMangaCorta.Checked);
                    MessageBox.Show("El precio final es: $"+(c1.calcularPrecio()*auxCantidad));
                }

                if (rbtnPantalon.Checked == true)
                {
                    Pantalon p1 = new Pantalon(auxPrecio, auxCalidad, checkBoxBermuda.Checked);
                    MessageBox.Show("El precio final es: $"+(p1.calcularPrecio()*auxCantidad));
                }

                limpiarCampos();
            }
            #endregion
        }

        private void limpiarCampos()
        {
            txtCantidad.Text = "";
            txtPrecio.Text = "";
        }

        
    }
}
