using Colors.Properties;
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

namespace Colors
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Color color = new Color();
            color = DefaultSettings.ReadSettings();
            Rectangle.Fill = new SolidColorBrush(color);
            SliderR.Value = color.R;
            SliderG.Value = color.G;
            SliderB.Value = color.B;
        }

        

        private void Sliders_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            Color color = Color.FromRgb(
                (byte)SliderR.Value, 
                (byte)SliderG.Value, 
                (byte)SliderB.Value);
            ColorRectangle = color;
        }

        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Escape) Close();
        }

        private Color ColorRectangle
        {
            get
            {
                return (Rectangle.Fill as SolidColorBrush).Color;
            }
            set
            {
                (Rectangle.Fill as SolidColorBrush).Color = value;
            }

        }


        private void Window_Closed(object sender, EventArgs e)
        {
            DefaultSettings.SaveSettings(ColorRectangle);
        }
    }
}
