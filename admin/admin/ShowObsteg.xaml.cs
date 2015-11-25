using Hospital;
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
using System.Windows.Shapes;

namespace admin
{
    /// <summary>
    /// Interaction logic for ShowObsteg.xaml
    /// </summary>
    public partial class ShowObsteg : Window
    {
        public ShowObsteg()
        {
            InitializeComponent();
        }
        public void getDoc(string str)
        {
            HospitalModelDataContext data = new HospitalModelDataContext();
            IEnumerable<Obstegenya> obstegenya;                       
            obstegenya = data.Obstegenyas.Select(s => s);                                                   
            dataGrid.ItemsSource = obstegenya;
        }

        private void loadViewObsteg(object sender, RoutedEventArgs e)
        {
            getDoc("");
        }
                
    }
}
