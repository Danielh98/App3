using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ViewDos : ContentPage
    {
        public ViewDos()
        {
            InitializeComponent();
        }

        private async void btnAbrir_Clicked(object sender, EventArgs e)
        {
            try
            {
                //ALMACENO EN VARIABLES LO QUE EL USUARIO INGRESA
                string usuario = txtUsuario.Text;
                string contraseña = txtContraseña.Text;



                if (usuario == "estudiante2021" && contraseña == "uisrael2021")
                {
                    //Permite abrir la ventana 2
                    await Navigation.PushAsync(new MainPage(usuario, contraseña));
                }
                else
                {
                    await DisplayAlert("Error", "Contraseña o usuario inválidos", "OK");
                    txtContraseña.Text = " ";
                    txtUsuario.Text = "";
                }

            }
            catch (Exception ex)
            {
                await DisplayAlert("Mensaje de advertencia", ex.Message, "OK");

            }

        }
    }
}