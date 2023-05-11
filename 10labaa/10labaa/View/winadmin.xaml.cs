using _10labaa.Model.dentistryDataSetTableAdapters;
using _10labaa;
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
using System.Data;

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для winadmin.xaml
    /// </summary>
    public partial class winadmin : Window
    {
        UsersTableAdapter UsersTableAdapter = new UsersTableAdapter();
        WorkersTableAdapter WorkersTableAdapter = new WorkersTableAdapter();
        VisitorsTableAdapter VisitorsTableAdapter = new VisitorsTableAdapter();
        RoleTableAdapter RoleTableAdapter = new RoleTableAdapter();
        VisitsTableAdapter VisitsTableAdapter = new VisitsTableAdapter();
        Visitors_diagnosisTableAdapter visitors_DiagnosisTableAdapter = new Visitors_diagnosisTableAdapter();
        public winadmin()
        {
            //DataGrid.ItemsSource = RoleTableAdapter.GetData();
            InitializeComponent();
        }

        private void RoliBtn_Click(object sender, RoutedEventArgs e)
        {
            Roliwin roliwin = new Roliwin();
            roliwin.Show();
            Close();
            //DataGrid.ItemsSource = RoleTableAdapter.GetData();
        }

        private void workBtn_Click(object sender, RoutedEventArgs e)
        {
            workers workers = new workers();
            workers.Show();
            Close();
        }

        private void UsersBtn_Click(object sender, RoutedEventArgs e)
        {
            users users = new users();
            users.Show();
            Close();
            //DataGrid.ItemsSource = UsersTableAdapter.GetData();
        }

        private void visitorsBtn_Click(object sender, RoutedEventArgs e)
        {
            Position pos = new Position();
            pos.Show();
            Close();
            //DataGrid.ItemsSource = VisitorsTableAdapter.GetData();
        }

        private void visitsBtn_Click(object sender, RoutedEventArgs e)
        {
            Visits visits = new Visits();
            visits.Show();
            Close();

        }

        private void visitsBtn_Copy_Click(object sender, RoutedEventArgs e)
        {
            visitorsdiagnos visitorsdiagnos = new visitorsdiagnos();
            visitorsdiagnos.Show();
            Close();

           
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void visitorsBtn_Click_1(object sender, RoutedEventArgs e)
        {
            
        }

        private void Officebtn_Click(object sender, RoutedEventArgs e)
        {
            Offices offices = new Offices();
            offices.Show();
            Close();
        }

        private void visitorsBtn_Click_2(object sender, RoutedEventArgs e)
        {
            visitors visitors = new visitors();
            visitors.Show();
            Close();
        }

        private void dicbtn_Click(object sender, RoutedEventArgs e)
        {
            discount discount = new discount();
            discount.Show();
            Close();
        }

        private void diagbtn_Click(object sender, RoutedEventArgs e)
        {
            diagnosis diagnosis = new diagnosis();
            diagnosis.Show();
            Close();
        }

        private void drugdiagbtn_Click(object sender, RoutedEventArgs e)
        {
            drugrordiagnos diag = new drugrordiagnos();
            diag.Show();
            Close();
        }

        private void drugbtn_Click(object sender, RoutedEventArgs e)
        {
            Drugs drug = new Drugs();
            drug.Show();
            Close();
        }

        private void servicebtn_Click(object sender, RoutedEventArgs e)
        {
            Services service = new Services();
            service.Show();
            Close();
        }

        private void visservicebtn_Click(object sender, RoutedEventArgs e)
        {
            serpos serpos = new serpos();
            serpos.Show();
            Close();
        }
    }
}
