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
    /// Логика взаимодействия для diagnosis.xaml
    /// </summary>
    public partial class diagnosis1 : Window
    {
        DiagnosisTableAdapter diagnosisTableAdapter = new DiagnosisTableAdapter();

        public diagnosis1()
        {
            InitializeComponent();
            diagdatagrid.ItemsSource = diagnosisTableAdapter.GetData();
        }

        private void DataGridus_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (diagdatagrid.SelectedItem as DataRowView != null)
            {
                object num = (diagdatagrid.SelectedItem as DataRowView).Row[1];
                namediagtb.Text = num.ToString();
            }
        }

        private void backbtn_Click_1(object sender, RoutedEventArgs e)
        {
            winwork winadmin = new winwork();
            winadmin.Show();
            Close();
        }

        private void addbtn_Click_1(object sender, RoutedEventArgs e)
        {
            if (namediagtb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {

                diagnosisTableAdapter.InsertQuery(namediagtb.Text);
                namediagtb.Text = "";
                diagdatagrid.ItemsSource = diagnosisTableAdapter.GetData();
            }

        }

        private void backbtn_Copy1_Click(object sender, RoutedEventArgs e)
        {
            if (namediagtb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = (diagdatagrid.SelectedItem as DataRowView).Row[0];
                diagnosisTableAdapter.UpdateQuery(namediagtb.Text, Convert.ToInt32(id));
                namediagtb.Text = "";
                diagdatagrid.ItemsSource = diagnosisTableAdapter.GetData();
            }
        }

        private void backbtn_Copy2_Click(object sender, RoutedEventArgs e)
        {
            if (namediagtb.Text == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = (diagdatagrid.SelectedItem as DataRowView).Row[0];
                diagnosisTableAdapter.DeleteQuery(Convert.ToInt32(id));
                namediagtb.Text = "";
                diagdatagrid.ItemsSource = diagnosisTableAdapter.GetData();
            }
        }
    }
}
