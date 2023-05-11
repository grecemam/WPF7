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

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для winwork.xaml
    /// </summary>
    public partial class winwork : Window
    {
        public winwork()
        {
            InitializeComponent();
        }

        private void visitsBtn_Click(object sender, RoutedEventArgs e)
        {
            visits2 visits = new visits2();
            visits.Show();
            Close();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void visitorsBtn_Click(object sender, RoutedEventArgs e)
        {
            visitors2 visitors = new visitors2();
            visitors.Show();
            Close();
        }

        private void diagbtn_Click(object sender, RoutedEventArgs e)
        {
            diagnosis1 diagnosis = new diagnosis1();
            diagnosis.Show();
            Close();
        }

        private void visitsBtnCopy_Click(object sender, RoutedEventArgs e)
        {
            visitorsdiagnos2 visitorsdiagnos = new visitorsdiagnos2();
            visitorsdiagnos.Show();
            Close();
        }

        private void visservicebtn_Click(object sender, RoutedEventArgs e)
        {
            Services2 services = new Services2();
            services.Show();
            Close();
        }

        private void Officebtn_Click(object sender, RoutedEventArgs e)
        {
            Offices2 Offices2 = new Offices2();
            Offices2.Show();
            Close();
        }

        private void dicbtn_Click(object sender, RoutedEventArgs e)
        {
            discount2 discount = new discount2();
            discount.Show();
            Close();
        }

        private void drugdiagbtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
