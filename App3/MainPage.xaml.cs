using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace App3
{
    public partial class MainPage : ContentPage
    {
        public MainPage(string usuario, string contraseña)
        {
            InitializeComponent();

            lblusuario.Text = usuario;
            lblcontrasena.Text = contraseña;
            

        }

        private void btnMostrar_Clicked(object sender, EventArgs e)
        {
            string estado;
            try
            {
                //PARCIAL 1
                double valor1 = Convert.ToDouble(txtNota1.Text)*0.3;
                double valor2 = Convert.ToDouble(txtExamen1.Text)*0.2;

                double suma1 = valor1 + valor2;

                //PARCIAL 2
                double valor3 = Convert.ToDouble(txtNota2.Text) * 0.3;
                double valor4 = Convert.ToDouble(txtExamen2.Text) * 0.2;

                double suma2 = valor3 + valor4;
                //NOTA FINAL

                double notafinal = suma1 + suma2;

                //ESTADO


                if (notafinal >= 7)
                {
                    estado = "Aprobado";
                    txtEstado.Text = estado;
                }

                if (notafinal >= 5 && notafinal <= 6.9)
                {
                    estado = "Complementario";
                    txtEstado.Text = estado;
                }
                
                if (notafinal < 5)
                        {
                            estado = "Reprobado";
                            txtEstado.Text = estado;
                        }
                    
                
                //VISUALIZAR EL RESULTADO EN PANTALLA
                txtNotaParcial1.Text = suma1.ToString();
                txtNotaParcial2.Text = suma2.ToString();
                txtNotaFinal.Text = notafinal.ToString();
                




            }
            
            catch (Exception ex)
            {
                DisplayAlert("MENSAJE DE ALERTA", ex.Message, "ok");
            }

        }

       
    }
}
