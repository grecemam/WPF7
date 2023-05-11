using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
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
    /// Логика взаимодействия для discount.xaml
    /// </summary>
    public partial class discount2 : Window
    {
        DiscountTableAdapter DiscountTableAdapter = new DiscountTableAdapter();

        public discount2()
        {
            InitializeComponent();
            disdatagrid.ItemsSource = DiscountTableAdapter.GetData();
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winwork winadmin = new winwork();
            winadmin.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            int d;
            if (int.TryParse(distb.Text, out d))
            {
                int dis = Convert.ToInt32(distb.Text);
                DiscountTableAdapter.InsertQuery(opis.Text, dis);
                disdatagrid.ItemsSource = DiscountTableAdapter.GetData();
                opis.Text = "";
                distb.Text = "";
            }
            else
            {
                MessageBox.Show("Вводи цифры");
                return;
            }
        }


        private void backbtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            int d;
            if (int.TryParse(distb.Text, out d))
            {

                object id = (disdatagrid.SelectedItem as DataRowView).Row[0];
                int dis = Convert.ToInt32(distb.Text);
                DiscountTableAdapter.UpdateQuery(opis.Text, dis, Convert.ToInt32(id));
                opis.Text = "";
                distb.Text = "";
                disdatagrid.ItemsSource = DiscountTableAdapter.GetData();

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
            if (int.TryParse(distb.Text, out d))
            {
                object id = (disdatagrid.SelectedItem as DataRowView).Row[0];
                DiscountTableAdapter.DeleteQuery(Convert.ToInt32(id));
                opis.Text = "";
                distb.Text = "";
                disdatagrid.ItemsSource = DiscountTableAdapter.GetData();
            }
            else
            {
                MessageBox.Show("Вводи цифры");
                return;
            }
        }

        private void disdatagrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (disdatagrid.SelectedItem as DataRowView != null)
            {
                object namedis = (disdatagrid.SelectedItem as DataRowView).Row[1];
                object proc = (disdatagrid.SelectedItem as DataRowView).Row[2];
                opis.Text = namedis.ToString();
                distb.Text = proc.ToString();

            }
        }
    }
}
