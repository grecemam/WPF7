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
    /// Логика взаимодействия для Position.xaml
    /// </summary>
    public partial class Position : Window
    {
        PositionTableAdapter PositionTableAdapter = new PositionTableAdapter();
        public Position()
        {
            InitializeComponent();
            posdatagrid.ItemsSource = PositionTableAdapter.GetData();
        }

        private void DataGridus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                object pos = (posdatagrid.SelectedItem as DataRowView).Row[1];
                namepos.Text = pos.ToString();
            }
            catch (Exception ex)
            {


            }

        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winadmin ad = new winadmin();
            ad.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (namepos.Text == "")
            {
                MessageBox.Show("Заполниете поле");
            }
            else
            {

                PositionTableAdapter.InsertQuery(namepos.Text);
                namepos.Text = "";
                posdatagrid.ItemsSource = PositionTableAdapter.GetData();
            }
        }

        private void backbtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (namepos.Text == "")
            {
                MessageBox.Show("Заполниете поле");
            }
            else
            {
                object id = (posdatagrid.SelectedItem as DataRowView).Row[0];
                PositionTableAdapter.UpdateQuery(namepos.Text, Convert.ToInt32(id));
                namepos.Text = "";
                posdatagrid.ItemsSource = PositionTableAdapter.GetData();
            }
        }

        private void backbtn_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (namepos.Text == "")
            {
                MessageBox.Show("Заполниете поле");
            }
            else
            {
                object id = (posdatagrid.SelectedItem as DataRowView).Row[0];
                PositionTableAdapter.DeleteQuery(Convert.ToInt32(id));
                namepos.Text = "";
                posdatagrid.ItemsSource = PositionTableAdapter.GetData();
            }
        }
    }
}
