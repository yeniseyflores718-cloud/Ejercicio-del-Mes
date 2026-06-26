using EstacionamientoWinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_del_Mes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cboVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboVehiculo.Text=="Motocicleta")
            {
                lbl_extra.Text = "Cilindrada";
                txt_extra.Visible = true;
                lbl_extra.Visible = true;

            }
            else if (cboVehiculo.Text == "Automovil")
            {
                lbl_extra.Text = "plca:";
                txt_extra.Visible = true;
                lbl_extra.Visible = true;
            }
            else if(cboVehiculo.Text=="Camioneta")
            {
                lbl_extra.Text = "no. ejes:";
                txt_extra.Visible = true;
                lbl_extra.Visible = true;
            }
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            int horasEstancia = int.Parse(txt_horas.Text);
            ClaseVehiculo claseVehiculo = null;
            //Aqui trabajara Kevin
            if (cboVehiculo.Text == "Motocicleta")
            {
                int cilindrada = int.Parse(txt_extra.Text);
                motocicleta moto = new motocicleta(horasEstancia, cilindrada);
                
            }
            //Aqui Sonia
            else if (cboVehiculo.Text == "Automovil")
            {
                

            }
            //Aqui Juan
            else if (cboVehiculo.Text == "Camioneta")
            {
                int numeroEjes = int.Parse(txtHoras.text);

                claseVehiculo = new Camioneta(horasEstancia, numeroEjes);
            }
            if (claseVehiculo != null)
            {
                float pagoFinal = claseVehiculo.CalcularTarifa();
                lblTotal.Text= pagoFinal.ToString();

            }
            else
            {
                MessageBox.Show("Seleccione un tipo de boleto válido.");
            }
        }
    
    }
}
