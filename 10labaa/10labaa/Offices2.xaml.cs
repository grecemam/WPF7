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
using System.Windows.Controls.Primitives;

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для Offices.xaml
    /// </summary>
    public partial class Offices2 : Window
    {
        OfficeTableAdapter officeTableAdapter = new OfficeTableAdapter();
        public Offices2()
        {
            InitializeComponent();
            ofdatagrid.ItemsSource = officeTableAdapter.GetData();
        }

        private void DataGridus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ofdatagrid.SelectedItem as DataRowView != null)
            {
                object num = (ofdatagrid.SelectedItem as DataRowView).Row[1];
                nameoftb.Text = num.ToString();
            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winwork ad = new winwork();
            ad.Show();
            Close();
        }


        private void backbtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int d;
            if (int.TryParse(nameoftb.Text, out d))
            {
                object id = (ofdatagrid.SelectedItem as DataRowView).Row[0];
                officeTableAdapter.UpdateQuery(Convert.ToInt32(nameoftb.Text), Convert.ToInt32(id));
                nameoftb.Text = "";
                ofdatagrid.ItemsSource = officeTableAdapter.GetData();
            }
            else
            {
                MessageBox.Show("Вводи цифры");
                return;
            }
        }

        private void backbtn_Copy2_Click(object sender, RoutedEventArgs e)
        {
            int d;
            if (int.TryParse(nameoftb.Text, out d))
            {
                object id = (ofdatagrid.SelectedItem as DataRowView).Row[0];
                officeTableAdapter.DeleteQuery(Convert.ToInt32(id));
                nameoftb.Text = "";
                ofdatagrid.ItemsSource = officeTableAdapter.GetData();
            }


            else
            {
                MessageBox.Show("Вводи цифры");
                return;
            }
        }

        private void addbtn_Click_1(object sender, RoutedEventArgs e)
        {
            int d;
            if (int.TryParse(nameoftb.Text, out d))
            {
                officeTableAdapter.InsertQuery(Convert.ToInt32(nameoftb.Text));
                nameoftb.Text = "";
                ofdatagrid.ItemsSource = officeTableAdapter.GetData();
            }
            else
            {
                MessageBox.Show("Вводи цифры");
                return;
            }
        }

        private void backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            winwork ad = new winwork();
            ad.Show();
            Close();
        }
    }
}
