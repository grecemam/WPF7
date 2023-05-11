using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
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
using System.Windows.Controls.Primitives;

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для Roliwin.xaml
    /// </summary>
    public partial class Roliwin : Window
    {
        RoleTableAdapter RoleTableAdapter = new RoleTableAdapter();
        public Roliwin()
        {
            InitializeComponent();
            DataGridroli.ItemsSource = RoleTableAdapter.GetData();
        }

        private void DataGridus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {

                object nameroli = (DataGridroli.SelectedItem as DataRowView).Row[1];
                nameroletb.Text = nameroli.ToString();
            }
            catch (Exception ex)
            {

            }


        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winadmin win = new winadmin();
            win.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (nameroletb.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
            {

                RoleTableAdapter.InsertQuery(nameroletb.Text);
                nameroletb.Text = "";
                DataGridroli.ItemsSource = RoleTableAdapter.GetData();
            }
        }

        private void backbtn_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (nameroletb.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
            {
                object id = (DataGridroli.SelectedItem as DataRowView).Row[0];
                RoleTableAdapter.DeleteQuery(Convert.ToInt32(id));
                nameroletb.Text = "";
                DataGridroli.ItemsSource = RoleTableAdapter.GetData();
            }
        }

        private void backbtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (nameroletb.Text == "")
            {
                MessageBox.Show("Поле не заполнено");
            }
            else
            {
                object id = (DataGridroli.SelectedItem as DataRowView).Row[0];
                RoleTableAdapter.UpdateQuery(nameroletb.Text, Convert.ToInt32(id));
                nameroletb.Text = "";
                DataGridroli.ItemsSource = RoleTableAdapter.GetData();
            }
        }
    }
}
