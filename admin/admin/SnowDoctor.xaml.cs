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
using Hospital;

namespace admin
{
    /// <summary>
    /// Interaction logic for View.xaml
    /// </summary>
    public partial class View : Window
    {
        public View()
        {
            InitializeComponent();
        }

        private void chenge_Doc(object sender, DependencyPropertyChangedEventArgs e)
        {

        }

        private void loadViewDoc(object sender, RoutedEventArgs e)
        {
            HospitalModelDataContext data = new HospitalModelDataContext();
            IEnumerable<Doctor> doctors = data.Doctors.Select(s => s);
            dataGrid.ItemsSource = doctors;
        }
    }
}
