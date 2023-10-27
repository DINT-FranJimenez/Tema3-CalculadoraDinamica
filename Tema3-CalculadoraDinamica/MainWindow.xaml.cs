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

namespace Tema3_CalculadoraDinamica
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Button b0 = new Button();
            b0.Tag = "0";
            Viewbox v0 = new Viewbox();
            TextBlock t0 = new TextBlock();
            t0.Text = "0";
            v0.Child = t0;
            b0.Content = v0;

            Grid.SetColumn(b0, 0);
            Grid.SetRow(b0, 4);
            Grid.SetColumnSpan(b0, 3);

            principal.Children.Add(b0);

            int contador = 1;

            for (int i = 1; i < principal.RowDefinitions.Count - 1; i++) {
                
                for (int j = 0; j < principal.ColumnDefinitions.Count; j++) {

                     Button b1 = new Button();
                     b1.Tag = contador.ToString();

                     Viewbox v1 = new Viewbox();

                     TextBlock t1 = new TextBlock();
                     t1.Text = contador.ToString();

                     v1.Child = t1;
                     b1.Content = v1;

                     Grid.SetColumn(b1, j);
                     Grid.SetRow(b1, i);

                     principal.Children.Add(b1);

                     contador++;
                }
           }
        }

        private void AñadeNumeros(object sender, RoutedEventArgs e)
        {

            textBlockNumeros.Text += ((Button)sender).Tag.ToString();

        }
    }
}
