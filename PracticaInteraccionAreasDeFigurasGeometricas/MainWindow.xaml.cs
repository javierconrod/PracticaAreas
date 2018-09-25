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

namespace PracticaInteraccionAreasDeFigurasGeometricas
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

        private void btnCalcularRectangulo_Click(object sender, RoutedEventArgs e)
        {
            float areaRectangulo = float.Parse(txtRectanguloBase.Text) * float.Parse(txtRectanguloAltura.Text);
            lblRectanguloArea.Text = areaRectangulo.ToString();
        }

        private void btnCalcularTriangulo_Click(object sender, RoutedEventArgs e)
        {
            float areaTriangulo = float.Parse(txtTrianguloAltura.Text) * float.Parse(txtTrianguloBase.Text) / 2;
            lblTrianguloArea.Text = areaTriangulo.ToString();
        }

        private void btnCalcularCirculo_Click(object sender, RoutedEventArgs e)
        {
            float Pi = Convert.ToSingle(Math.PI);
            float areaCirculo = float.Parse(txtCirculoRadio.Text) * float.Parse(txtCirculoRadio.Text) * Pi;
            lblCirculoArea.Text = areaCirculo.ToString();
        }

        private void btnCalcularTrapecio_Click(object sender, RoutedEventArgs e)
        {
            float sumas = float.Parse(txtTrapecioBaseMenor.Text) + float.Parse(txtTrapecioBaseMayor.Text);
            float areaTrapecio = float.Parse(txtTrapecioAltura.Text) / 2 * sumas;
            lblTrapecioArea.Text = areaTrapecio.ToString();
        }
    }
}
