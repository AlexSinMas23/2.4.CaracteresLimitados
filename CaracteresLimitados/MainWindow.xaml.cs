using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CaracteresLimitados
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void cajaDeTextoLimitado_TextChanged(object sender, TextChangedEventArgs e)
        {
            this.contador.Text = this.cajaDeTextoLimitado.Text.Length.ToString();
            if (this.contador.Text == "140")
            {
                this.contador.Foreground = Brushes.Red;
                this.contador.FontSize = 14;
            }
            else if(this.contador.Text != "140" && this.contador.Foreground == Brushes.Red)
            {
                this.contador.Foreground = Brushes.Black;
                this.contador.FontSize = 12;
            }
        }

        private void enterBoton_Click(object sender, RoutedEventArgs e)
        {
            this.cajaDeTextoLimitado.Text = "";
        }
    }
}
