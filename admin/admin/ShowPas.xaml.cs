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
    /// Interaction logic for ShowPas.xaml
    /// </summary>
    public partial class ShowPas : Window
    {
        public ShowPas()
        {
            InitializeComponent();
        }
        public void getDoc(string str)
        {
            HospitalModelDataContext data = new HospitalModelDataContext();
            IEnumerable<Patient> patient;
            if (str == "")
            {
                patient = data.Patients.Select(s => s);
            }
            else
            {
                patient = data.Patients.Where(s => s.lastname.Contains(str));
            }
            dataGrid.ItemsSource = patient;
        }
        private void loadViewPas(object sender, RoutedEventArgs e)
        {
            getDoc("");
        }

        private void keyUpPas(object sender, KeyEventArgs e)
        {
            getDoc(pasResearch.Text);
        }
    }
}
