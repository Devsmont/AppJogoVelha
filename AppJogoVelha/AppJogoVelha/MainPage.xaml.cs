using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AppJogoVelha
{
    // método = função 
    //método de hereditariedade de classes
    public partial class MainPage : ContentPage
    {
        int jogada = 0;
        string vez = "X";

        public MainPage()
        {
            //Método construtor (constrói a interface grafica)
            InitializeComponent();
        }
                                         //parâmetros sender = quem dispara 
        private async void Button_Clicked(object sender, EventArgs e)
        {
            //contador de jogadas

            jogada++;

            //jogada = jogada + 1

            // Identificando qual botão disparou o evento
            Button btn = (Button)sender;
            
            // Desabilitando o botão
            btn.IsEnabled = false;

            // Trocando texto do botão de acordo com quem é a vez.
            // == comparação  = atribuição
            if (vez == "X")
            {
                btn.Text = "X";                
                vez = "O";
            } else
            {
                btn.Text = "O";
                vez = "X";
            }
            // || = nova regra (pipe, operador logico OU)  && = e (operador lógico AND)
            // Verificando se a linha 1 teve ganhador.
            if((btn10.Text == "X" && btn11.Text == "X" && btn12.Text == "X") || 
               (btn20.Text == "X" && btn21.Text == "X" && btn22.Text == "X") || 
               (btn30.Text == "X" && btn31.Text == "X" && btn32.Text == "X") ||
               (btn10.Text == "X" && btn20.Text == "X" && btn30.Text == "X") ||
               (btn11.Text == "X" && btn21.Text == "X" && btn31.Text == "X") ||
               (btn12.Text == "X" && btn22.Text == "X" && btn32.Text == "X") ||
               (btn10.Text == "X" && btn21.Text == "X" && btn32.Text == "X") ||
               (btn12.Text == "X" && btn21.Text == "X" && btn30.Text == "X"))
               
            {
                await DisplayAlert("Parabéns", "O X ganhou!", "OK");
                zerar();




            } else if ((btn10.Text == "O" && btn11.Text == "O" && btn12.Text == "O") ||
               (btn20.Text == "O" && btn21.Text == "O" && btn22.Text == "O") ||
               (btn30.Text == "O" && btn31.Text == "O" && btn32.Text == "O") ||
               (btn10.Text == "O" && btn20.Text == "O" && btn30.Text == "O") ||
               (btn11.Text == "O" && btn21.Text == "O" && btn31.Text == "O") ||
               (btn12.Text == "O" && btn22.Text == "O" && btn32.Text == "O") ||
               (btn10.Text == "O" && btn21.Text == "O" && btn32.Text == "O") ||
               (btn12.Text == "O" && btn21.Text == "O" && btn30.Text == "O"))
            {
                await DisplayAlert("Parabéns", "A O ganhou!", "OK");
                zerar();

            } else if (jogada == 9)
            {
                await DisplayAlert("A GranY Mano", "De VeiA", "OK");
                jogada = 0;
            }

            void zerar()
            {
                btn10.IsEnabled = true;
                btn10.Text = "";
                btn11.IsEnabled = true;
                btn11.Text = "";
                btn12.IsEnabled = true;
                btn12.Text = "";
                btn20.IsEnabled = true;
                btn20.Text = "";
                btn21.IsEnabled = true;
                btn21.Text = "";
                btn22.IsEnabled = true;
                btn22.Text = "";
                btn30.IsEnabled = true;
                btn30.Text = "";
                btn31.IsEnabled = true;
                btn31.Text = "";
                btn32.IsEnabled = true;
                btn32.Text = "";
                jogada = 0;
            }

        }

        
    }
}
