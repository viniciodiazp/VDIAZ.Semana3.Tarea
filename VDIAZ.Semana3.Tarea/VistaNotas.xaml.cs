using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace VDIAZ.Semana3.Tarea
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VistaNotas : ContentPage
    {
        private string usuario;
        public VistaNotas(string usuario)
        {
            InitializeComponent();
            lblUsuarioConectado.Text = "Usuario conectado: " + usuario;
        }

        private void validateGradeEntry(object sender, String message)
        {
            Entry entry = ((Entry)sender);
            if (!String.IsNullOrEmpty(entry.Text))
            {
                double value = Convert.ToDouble(entry.Text);
                if (value < 0 || value > 10)
                {
                    entry.Text = "";
                    DisplayAlert("Error", message, "Aceptar");
                }
            }
        }

        private void txtAportesP1_TextChanged(object sender, TextChangedEventArgs e)
        {
            validateGradeEntry(sender, "Aporte 1 debe estar entre 0 y 10");
        }

        private void txtExamenP1_TextChanged(object sender, TextChangedEventArgs e)
        {
            validateGradeEntry(sender, "Examen 1 debe estar entre 0 y 10");

        }

        private void txtAportesP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            validateGradeEntry(sender, "Aporte 2 debe estar entre 0 y 10");

        }

        private void txtExamenP2_TextChanged(object sender, TextChangedEventArgs e)
        {
            validateGradeEntry(sender, "Examen 2 debe estar entre 0 y 10");

        }

        private void btnCalcular_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtAportesP1.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para aportes 1", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtAportesP2.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para aportes 2", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtExamenP1.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para examen 1", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(txtExamenP2.Text))
            {
                DisplayAlert("Error", "Ingrese un valor para examen 2", "Aceptar");
                return;
            }

            double a1 = Convert.ToDouble(txtAportesP1.Text) * 0.3;
            double e1 = Convert.ToDouble(txtExamenP1.Text) * 0.2;
            double a2 = Convert.ToDouble(txtAportesP2.Text) * 0.3;
            double e2 = Convert.ToDouble(txtExamenP2.Text) * 0.2;
            double n1 = a1 + e1;
            double n2 = a2 + e2;
            double total = n1 + n2;

            txtNotaP1.Text = n1.ToString();
            txtNotaP2.Text = n2.ToString();

            txtNotaFinal.Text = total.ToString();

            string obs = "";


            if (total >= 7)
            {
                obs = "APROBADO";
            }
            else if (total >= 5 && total <= 6.9)
            {
                obs = "COMPLEMENTARIO";
            }
            else
            {
                obs = "REPROBADO";
            }

            lblObservacion.Text = obs;
        }

        private void btnLimpiar_Clicked(object sender, EventArgs e)
        {
            txtAportesP1.Text = string.Empty;
            txtAportesP2.Text = string.Empty;
            txtExamenP1.Text = string.Empty;
            txtExamenP2.Text = string.Empty;
            txtNotaP1.Text = string.Empty;
            txtNotaP2.Text = string.Empty;
            txtNotaFinal.Text = string.Empty;
            lblObservacion.Text = string.Empty;
            txtAportesP1.Focus();
        }
    }
}