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
           /* float areaRectangulo = float.Parse(txtRectanguloBase.Text) * float.Parse(txtRectanguloAltura.Text);
            lblRectanguloArea.Text = areaRectangulo.ToString();*/
        }

        private void btnCalcularTriangulo_Click(object sender, RoutedEventArgs e)
        {
            /*float areaTriangulo = float.Parse(txtTrianguloAltura.Text) * float.Parse(txtTrianguloBase.Text) / 2;
            lblTrianguloArea.Text = areaTriangulo.ToString();*/
        }

        private void btnCalcularCirculo_Click(object sender, RoutedEventArgs e)
        {
           /* float Pi = Convert.ToSingle(Math.PI);
            float areaCirculo = float.Parse(txtCirculoRadio.Text) * float.Parse(txtCirculoRadio.Text) * Pi;
            lblCirculoArea.Text = areaCirculo.ToString();*/
        }

        private void btnCalcularTrapecio_Click(object sender, RoutedEventArgs e)
        {
           /* float sumas = float.Parse(txtTrapecioBaseMenor.Text) + float.Parse(txtTrapecioBaseMayor.Text);
            float areaTrapecio = float.Parse(txtTrapecioAltura.Text) / 2 * sumas;
            lblTrapecioArea.Text = areaTrapecio.ToString();*/
        }

        private void cbTipoFigura_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            panelConfiguracion.Children.Clear();
            switch (cbTipoFigura.SelectedIndex)
            {
                case 0: //rectangulo
                    panelConfiguracion.Children.Add(new ControlAreaRectangulo());
                    break;
                case 1: //triangulo
                    panelConfiguracion.Children.Add(new ControlTriangulo());
                    break;
                case 2: //circulo
                    panelConfiguracion.Children.Add(new ControlCirculo());
                    break;
                case 3: //trapecio
                    panelConfiguracion.Children.Add(new ControlTrapecio());
                    break;
                default:
                    break;
            }
         }

        private void btnCalcular(object sender, RoutedEventArgs e)
        {
            double area = 0.0;
            
            switch(cbTipoFigura.SelectedIndex)
            {
                case 0: //rectangulo
                    var controlAreaRectangulo = ((ControlAreaRectangulo)(panelConfiguracion.Children[0]));

                    float alturaRec = float.Parse(controlAreaRectangulo.txtRectanguloAltura.Text);
                    float baseRec = float.Parse(controlAreaRectangulo.txtRectanguloBase.Text);

                    area = baseRec * alturaRec;
                    break;
                case 1: //triangulo
                    var controlAreaTriangulo = ((ControlTriangulo)(panelConfiguracion.Children[0]));
                    float alturaTri = float.Parse(controlAreaTriangulo.txtTrianguloAltura.Text);
                    float baseTri = float.Parse(controlAreaTriangulo.txtTrianguloBase.Text);

                    area = baseTri * alturaTri / 2;
                    break;
                case 2: //circulo
                    var controlCirculo = (ControlCirculo)(panelConfiguracion.Children[0]);
                    float radio = float.Parse(controlCirculo.txtCirculoRadio.Text);
                    float pi = Convert.ToSingle(Math.PI);
                    area = pi * radio * radio;
                    break;
                case 3: //trapecio
                    var controlAreaTrapecio = (ControlTrapecio)(panelConfiguracion.Children[0]);
                    float baseMenor = float.Parse(controlAreaTrapecio.txtTrapecioBaseMenor.Text);
                    float baseMayor = float.Parse(controlAreaTrapecio.txtTrapecioBaseMayor.Text);
                    float alturaTra = float.Parse(controlAreaTrapecio.txtTrapecioAltura.Text);

                    area = (baseMayor + baseMenor) * (alturaTra / 2);

                    break;
                default:
                    break;
            }
            lblArea.Text = area.ToString();
        }
        }
    }

