using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace VDIAZ.Semana3.Tarea
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

        }

        private async void btnVista2_Clicked(object sender, EventArgs e)
        {
            string usuario = txtUsuario.Text;
            string contrasena = txtContrasena.Text;

            if (string.IsNullOrEmpty(usuario))
            {
                DisplayAlert("Inicio de sesión", "Ingrese usuario", "Aceptar");
                return;
            }

            if (string.IsNullOrEmpty(contrasena))
            {
                DisplayAlert("Inicio de sesión", "Ingrese contraseña", "Aceptar");
                return;
            }

            if ("estudiante2022".Equals(usuario) && "uisrael2022".Equals(contrasena))
            {
                await Navigation.PushAsync(new VistaNotas(usuario));
            }
            else
            {
                DisplayAlert("Inicio de sesión", "Usuario o contraseña incorrecto", "Aceptar");
            }
        }
    }
}
