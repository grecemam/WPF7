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
using _10labaa.Model.dentistryDataSetTableAdapters;
using System.Data;
using _10labaa.View_Model;

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для Visits.xaml
    /// </summary>
    public partial class Visits : Window
    {

        public Visits()
        {
            InitializeComponent();
            DataContext = new VisitsVM();
        }

       

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winadmin winadmin = new winadmin();
            winadmin.Show();
            Close();
        }

        
    }
}
