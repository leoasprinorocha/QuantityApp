using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace QuantityApp
{
    public partial class MainPage : ContentPage
    {
        int quantidade = 1;

        public MainPage()
        {
            InitializeComponent();
            
        }

        private void Adicao(object sender, EventArgs e)
        {
            quantidade++;
            LblQuantidade.Text = quantidade.ToString();
        }

        private void Subtrair(object sender, EventArgs e)
        {
            quantidade--;
            LblQuantidade.Text = quantidade.ToString();
        }
    }
}
