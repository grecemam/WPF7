using System;
using System.Collections.Generic;
using System.Data;
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
using _10labaa.View_Model;

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для Services.xaml
    /// </summary>
    public partial class Services : Window
    {

        public Services()
        {
            InitializeComponent();
            DataContext = new ServicesVM();
        }


        private void backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            winadmin winadmin = new winadmin();
            winadmin.Show();
            Close();
        }

    }
}
