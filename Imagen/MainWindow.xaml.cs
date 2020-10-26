using System.Windows;
using System.Windows.Media;

namespace Imagen
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

        private void Alta_Button_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Opacity = 1;
        }

        private void Media_Button_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Opacity = 0.6;
        }

        private void Baja_Button_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Opacity = 0.3;
        }

        private void Relleno_Button_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.Fill;
        }

        private void Uniforme_Button_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.Uniform;
        }

        private void RellenoUniforme_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.UniformToFill;
        }

        private void Sin_Ajuste_Checked(object sender, RoutedEventArgs e)
        {
            ImagenImage.Stretch = Stretch.None;
        }
    }
}
