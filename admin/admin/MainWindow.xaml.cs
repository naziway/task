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

namespace admin
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

        private void viewDoc(object sender, RoutedEventArgs e)
        {
            View showDoc = new View();
            showDoc.Show();
        }
        private void viewPas(object sender, RoutedEventArgs e)
        {
            ShowPas showPas = new ShowPas();
            showPas.Show();
        }

        private void viewObs(object sender, RoutedEventArgs e)
        {
            ShowObsteg showObsteg = new ShowObsteg();
            showObsteg.Show();
        }
    }
}
