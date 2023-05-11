using _10labaa.Model.dentistryDataSetTableAdapters;
using _10labaa.View_Model;
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

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для visitors.xaml
    /// </summary>
    public partial class visitors : Window
    {
        public visitors()
        {
            InitializeComponent();
            DataContext = new VisitorsVM();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winadmin winadmin = new winadmin();
            winadmin.Show();
            Close();
        }
    }
}
