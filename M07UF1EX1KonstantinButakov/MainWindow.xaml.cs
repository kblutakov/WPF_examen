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

namespace M07UF1EX1KonstantinButakov
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private static int count = 0;
        private static bool mostrar = true;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (count % 2 == 0)
            {
                img_background.Source = new BitmapImage(new Uri("pack://Application:,,,/Image/satelit.png"));
                img_satelit.Source = new BitmapImage(new Uri("pack://Application:,,,/Image/mapa.png"));
                count++;
            }
            else
            {
                img_background.Source = new BitmapImage(new Uri("pack://Application:,,,/Image/mapa.png"));
                img_satelit.Source = new BitmapImage(new Uri("pack://Application:,,,/Image/satelit.png"));
                count++;
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(txt_cerca.Text, "Informació", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (mostrar)
            {
                mostrar = !mostrar;
                txt_cerca.Visibility = Visibility.Hidden;
                grid_casa.Visibility = Visibility.Hidden;
                btn_casa.Visibility = Visibility.Hidden;
                btn_cerca.Visibility = Visibility.Hidden;
                btn_feina.Visibility = Visibility.Hidden;
                btn_guardar.Visibility = Visibility.Hidden;
                rectangle.Visibility = Visibility.Hidden;
                
                img_hide.Source=  new BitmapImage(new Uri("pack://Application:,,,/Image/cursor_dreta.png"));
            }
            else
            {
                mostrar = !mostrar;
                txt_cerca.Visibility = Visibility.Visible;
                grid_casa.Visibility = Visibility.Visible;
                btn_casa.Visibility = Visibility.Visible;
                btn_cerca.Visibility = Visibility.Visible;
                btn_feina.Visibility = Visibility.Visible;
                rectangle.Visibility = Visibility.Visible;
                
                img_hide.Source = new BitmapImage(new Uri("pack://Application:,,,/Image/cursor_esquerra.png"));
            }
        }

        private void btn_casa_Click(object sender, RoutedEventArgs e)
        {
            lbl_1.Visibility = Visibility.Visible;
            lbl2.Visibility = Visibility.Visible;
            txt_casa.Visibility = Visibility.Visible;
            txt_notes.Visibility = Visibility.Visible;
            btn_guardar.Visibility = Visibility.Visible;
            check_mapa.Visibility = Visibility.Visible;
            btn_tancar.Visibility = Visibility.Visible;
        }

        private void btn_tancar_Click(object sender, RoutedEventArgs e)
        {
            lbl_1.Visibility = Visibility.Hidden;
            lbl2.Visibility = Visibility.Hidden;
            txt_casa.Visibility = Visibility.Hidden;
            txt_notes.Visibility = Visibility.Hidden;
            btn_guardar.Visibility = Visibility.Hidden;
            check_mapa.Visibility = Visibility.Hidden;
            btn_tancar.Visibility = Visibility.Hidden;
        }
    }
}
