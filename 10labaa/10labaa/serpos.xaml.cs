using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
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

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для serpos.xaml
    /// </summary>
    public partial class serpos : Window
    {
        Visitor_servicesTableAdapter visservicesTableAdapter = new Visitor_servicesTableAdapter();
        VisitorsTableAdapter visitorsTableAdapter = new VisitorsTableAdapter();
        ServicesTableAdapter servicesTableAdapter = new ServicesTableAdapter();
        public serpos()
        {
            InitializeComponent();
            serposDataGrid.ItemsSource = visservicesTableAdapter.GetData();
            poscb.ItemsSource = visitorsTableAdapter.GetData();
            poscb.DisplayMemberPath = "Surname";
            poscb.SelectedValuePath = "visitors_id"; 
            sercb.ItemsSource = servicesTableAdapter.GetData();
            sercb.DisplayMemberPath = "name_of_the_service";
            sercb.SelectedValuePath = "services_id";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (serposDataGrid.SelectedItem as DataRowView != null)
            {
                object pos = (serposDataGrid.SelectedItem as DataRowView).Row[1];
                object of = (serposDataGrid.SelectedItem as DataRowView).Row[2];
                poscb.SelectedValue = pos;
                sercb.SelectedValue = of;

            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winadmin winadmin = new winadmin();
            winadmin.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (sercb.SelectedValue == null || poscb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                visservicesTableAdapter.InsertQuery(Convert.ToInt32(sercb.SelectedValue), Convert.ToInt32(poscb.SelectedValue));
                serposDataGrid.ItemsSource = visservicesTableAdapter.GetData();
                poscb.SelectedValue = null;
                sercb.SelectedValue = null;
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (sercb.SelectedValue == null || poscb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = (serposDataGrid.SelectedItem as DataRowView).Row[0];
                visservicesTableAdapter.UpdateQuery(Convert.ToInt32(poscb.SelectedValue), Convert.ToInt32(sercb.SelectedValue), Convert.ToInt32(id));
                serposDataGrid.ItemsSource = visservicesTableAdapter.GetData();
                poscb.SelectedValue = null;
                sercb.SelectedValue = null;
            }
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            if (sercb.SelectedValue == null || poscb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = (serposDataGrid.SelectedItem as DataRowView).Row[0];
                visservicesTableAdapter.DeleteQuery(Convert.ToInt32(id));
                serposDataGrid.ItemsSource = visservicesTableAdapter.GetData();
                poscb.SelectedValue = null;
                sercb.SelectedValue = null;
            }
        }
    }
}
