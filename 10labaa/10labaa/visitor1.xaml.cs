using _10labaa.Model.dentistryDataSetTableAdapters;
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
    public partial class visitor1 : Window
    {
        VisitorsTableAdapter visitorsTableAdapter = new VisitorsTableAdapter();
        UsersTableAdapter UsersTableAdapter = new UsersTableAdapter();
        public visitor1()
        {
            InitializeComponent();
            visDataGrid.ItemsSource = visitorsTableAdapter.GetData();
            usercb.ItemsSource = UsersTableAdapter.GetData();
            usercb.DisplayMemberPath = "login";
            usercb.SelectedValuePath = "users_id";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (visDataGrid.SelectedItem as DataRowView != null)
            {
                object Surname = (visDataGrid.SelectedItem as DataRowView).Row[1];
                object Name = (visDataGrid.SelectedItem as DataRowView).Row[2];
                object middle = (visDataGrid.SelectedItem as DataRowView).Row[3];
                object user = (visDataGrid.SelectedItem as DataRowView).Row[4];
                surnamebl.Text = Convert.ToString(Surname);
                namebl.Text = Convert.ToString(Name);
                mnbl.Text = Convert.ToString(middle);
                usercb.SelectedValue = user;
            }

        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winpos winadmin = new winpos();
            winadmin.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (surnamebl.Text == "" || namebl.Text == "" || mnbl.Text == "" || usercb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {

                visitorsTableAdapter.InsertQuery(surnamebl.Text, namebl.Text, mnbl.Text, Convert.ToInt32(usercb.SelectedValue));
                visDataGrid.ItemsSource = visitorsTableAdapter.GetData();
                surnamebl.Text = "";
                namebl.Text = "";
                mnbl.Text = "";
                usercb.SelectedValue = null;
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {

            object id = (visDataGrid.SelectedItem as DataRowView).Row[0];
            visitorsTableAdapter.UpdateQuery(surnamebl.Text, namebl.Text, mnbl.Text, Convert.ToInt32(usercb.SelectedValue), Convert.ToInt32(id));
            visDataGrid.ItemsSource = visitorsTableAdapter.GetData();
            surnamebl.Text = "";
            namebl.Text = "";
            mnbl.Text = "";
            usercb.SelectedValue = null;
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (visDataGrid.SelectedItem as DataRowView).Row[0];
            visitorsTableAdapter.DeleteQuery(Convert.ToInt32(id));
            visDataGrid.ItemsSource = visitorsTableAdapter.GetData();
            surnamebl.Text = "";
            namebl.Text = "";
            mnbl.Text = "";
            usercb.SelectedValue = null;
        }
    }
}
