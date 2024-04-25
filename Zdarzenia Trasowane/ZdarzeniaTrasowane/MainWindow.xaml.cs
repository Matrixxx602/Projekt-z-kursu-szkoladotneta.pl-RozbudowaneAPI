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

namespace ZdarzeniaTrasowane
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void przycisk_Click(object sender, RoutedEventArgs e)
        {
            //przycisk.Content = "Zdarzenie trasowe";
            //          LUB
            //(sender as Button).Content = "Zdarzenie trasowe";

            (sender as Button).Background = new SolidColorBrush(Colors.GreenYellow);

            lista_Zdarzen.Items.Add($"\"Clik\" nadawca: {(sender as Control).Name}, zrodlo: {(e.Source as Control).Name}, oryginalne zrodlo: {(e.OriginalSource as Control).Name}");
                
            if (pole_Opcji.IsChecked.Value) e.Handled = true;
        }

        private void przycisk_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            (sender as Button).Background = new SolidColorBrush(Colors.Orange);
            lista_Zdarzen.Items.Add($"\"PMD\" nadawca: {(sender as Control).Name}, zrodlo: {(e.Source as Control).Name}, oryginalne zrodlo: {(e.OriginalSource as UIElement).ToString()}");

        }
    }
}
