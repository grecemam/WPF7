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

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для Visits.xaml
    /// </summary>
    public partial class visits1 : Window
    {
        WorkersTableAdapter workersTableAdapter = new WorkersTableAdapter();
        VisitorsTableAdapter visitorsTableAdapter = new VisitorsTableAdapter();
        OfficeTableAdapter officeTable = new OfficeTableAdapter();
        DiscountTableAdapter discountTableAdapter = new DiscountTableAdapter();
        VisitsTableAdapter VisitsTableAdapter = new VisitsTableAdapter();
        public visits1()
        {
            InitializeComponent();
            visDataGrid.ItemsSource = VisitsTableAdapter.GetData();
            poscb.ItemsSource = visitorsTableAdapter.GetData();
            poscb.DisplayMemberPath = "Surname";
            poscb.SelectedValuePath = "visitors_id";
            workcb.ItemsSource = workersTableAdapter.GetData();
            workcb.DisplayMemberPath = "Surname";
            workcb.SelectedValuePath = "workers_id";
            ofcb.ItemsSource = officeTable.GetData();
            ofcb.DisplayMemberPath = "number_of_office";
            ofcb.SelectedValuePath = "office_id";
            discb.ItemsSource = discountTableAdapter.GetData();
            discb.DisplayMemberPath = "percentage_of_the_discount";
            discb.SelectedValuePath = "discount_id";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (visDataGrid.SelectedItem as DataRowView != null)
            {
                object wor = (visDataGrid.SelectedItem as DataRowView).Row[1];
                object pos = (visDataGrid.SelectedItem as DataRowView).Row[2];
                object of = (visDataGrid.SelectedItem as DataRowView).Row[3];
                object dis = (visDataGrid.SelectedItem as DataRowView).Row[4];
                workcb.SelectedValue = wor;
                poscb.SelectedValue = pos;
                ofcb.SelectedValue = of;
                discb.SelectedValue = dis;
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winpos winpos = new winpos();
            winpos.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (workcb.SelectedValue == null || poscb.SelectedValue == null || ofcb.SelectedValue == null || discb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                VisitsTableAdapter.InsertQuery(Convert.ToInt32(workcb.SelectedValue), Convert.ToInt32(poscb.SelectedValue), Convert.ToInt32(ofcb.SelectedValue),
                Convert.ToInt32(discb.SelectedValue));
                visDataGrid.ItemsSource = VisitsTableAdapter.GetData();
                workcb.SelectedValue = null;
                poscb.SelectedValue = null;
                ofcb.SelectedValue = null;
                discb.SelectedValue = null;
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (visDataGrid.SelectedItem as DataRowView).Row[0];
            VisitsTableAdapter.UpdateQuery(Convert.ToInt32(workcb.SelectedValue), Convert.ToInt32(poscb.SelectedValue), Convert.ToInt32(ofcb.SelectedValue),
                Convert.ToInt32(discb.SelectedValue), Convert.ToInt32(id));
            visDataGrid.ItemsSource = VisitsTableAdapter.GetData();
            workcb.SelectedValue = null;
            poscb.SelectedValue = null;
            ofcb.SelectedValue = null;
            discb.SelectedValue = null;
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (visDataGrid.SelectedItem as DataRowView).Row[0];
            VisitsTableAdapter.DeleteQuery(Convert.ToInt32(id));
            visDataGrid.ItemsSource = VisitsTableAdapter.GetData();
            workcb.SelectedValue = null;
            poscb.SelectedValue = null;
            ofcb.SelectedValue = null;
            discb.SelectedValue = null;
        }
    }
}
