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
    /// Логика взаимодействия для winpos.xaml
    /// </summary>
    public partial class winpos : Window
    {
        public winpos()
        {
            InitializeComponent();
        }

        private void visitsBtn_Click(object sender, RoutedEventArgs e)
        {
            visits1 visits = new visits1();
            visits.Show();
            Close();
        }

        private void visitorsBtn_Click(object sender, RoutedEventArgs e)
        {
            visitor1 visitor = new visitor1();
            visitor.Show();
            Close();
        }

        private void visservicebtn_Click(object sender, RoutedEventArgs e)
        {
            serpos1 visitor = new serpos1();
            visitor.Show();
            Close();
        }

        private void dicbtn_Click(object sender, RoutedEventArgs e)
        {
            discount1 discount = new discount1();
            discount.Show();
            Close();
        }

        private void visitsBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            visitorsdiagnos1 visitorsdiagnos = new visitorsdiagnos1();
            visitorsdiagnos.Show();
            Close();
        }

        private void drugdiagbtn_Click(object sender, RoutedEventArgs e)
        {
            drugrordiagnos1 diag = new drugrordiagnos1();
            diag.Show();
            Close();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
