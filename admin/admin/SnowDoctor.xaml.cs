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
using System.Text.RegularExpressions;

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
        public void getDoc(string str)
        {
            HospitalModelDataContext data = new HospitalModelDataContext();
            IEnumerable<Doctor> doctors;
            if (str == "")
            {
                doctors = data.Doctors.Select(s => s);
            }
            else
            {
                doctors = data.Doctors.Where(s => s.name.Contains(str));
            }
            dataGrid.ItemsSource = doctors;

        }
        
        private void loadViewDoc(object sender, RoutedEventArgs e)
        {
            //getDoc("");
            HospitalModelDataContext data = new HospitalModelDataContext();
            IEnumerable<Doctor> doctors;
            doctors = data.Doctors.Where(s => s.name.Contains("а"));
            dataGrid.ItemsSource = doctors;

        }        
        private void keyUpDoc(object sender, KeyEventArgs e)
        {
            getDoc(docResearch.Text);

        }
    }
}
