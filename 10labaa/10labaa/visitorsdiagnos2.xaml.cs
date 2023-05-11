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
    /// Логика взаимодействия для visitorsdiagnos.xaml
    /// </summary>
    public partial class visitorsdiagnos2 : Window
    {
        VisitorsTableAdapter visitorsTableAdapter = new VisitorsTableAdapter();
        DiagnosisTableAdapter diagnosisTableAdapter = new DiagnosisTableAdapter();
        Visitors_diagnosisTableAdapter visitors_DiagnosisTableAdapter = new Visitors_diagnosisTableAdapter();
        public visitorsdiagnos2()
        {
            InitializeComponent();
            visdiagDataGrid.ItemsSource = visitors_DiagnosisTableAdapter.GetData();
            poscb.ItemsSource = visitorsTableAdapter.GetData();
            poscb.DisplayMemberPath = "Surname";
            poscb.SelectedValuePath = "visitors_id";
            diagcb.ItemsSource = diagnosisTableAdapter.GetData();
            diagcb.DisplayMemberPath = "name_of_the_diagnos";
            diagcb.SelectedValuePath = "diagnosis_id";
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (visdiagDataGrid.SelectedItem as DataRowView != null)
            {
                object pos = (visdiagDataGrid.SelectedItem as DataRowView).Row[1];
                object diag = (visdiagDataGrid.SelectedItem as DataRowView).Row[2];
                poscb.SelectedValue = pos;
                diagcb.SelectedValue = diag;

            }
        }

        private void backbtn_Click(object sender, RoutedEventArgs e)
        {
            winwork winadmin = new winwork();
            winadmin.Show();
            Close();
        }

        private void addbtn_Click(object sender, RoutedEventArgs e)
        {
            if (poscb.SelectedValue == null || diagcb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                visitors_DiagnosisTableAdapter.InsertQuery(Convert.ToInt32(poscb.SelectedValue),
                Convert.ToInt32(diagcb.SelectedValue));
                visdiagDataGrid.ItemsSource = visitors_DiagnosisTableAdapter.GetData();
                poscb.SelectedValue = null;
                diagcb.SelectedValue = null;
            }
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            if (poscb.SelectedValue == null || diagcb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = (visdiagDataGrid.SelectedItem as DataRowView).Row[0];
                visitors_DiagnosisTableAdapter.UpdateQuery(Convert.ToInt32(poscb.SelectedValue),
                Convert.ToInt32(diagcb.SelectedValue), Convert.ToInt32(id));
                visdiagDataGrid.ItemsSource = visitors_DiagnosisTableAdapter.GetData();
                poscb.SelectedValue = null;
                diagcb.SelectedValue = null;
            }
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            if (poscb.SelectedValue == null || diagcb.SelectedValue == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = (visdiagDataGrid.SelectedItem as DataRowView).Row[0];
                visitors_DiagnosisTableAdapter.DeleteQuery(Convert.ToInt32(id));
                visdiagDataGrid.ItemsSource = visitors_DiagnosisTableAdapter.GetData();
                poscb.SelectedValue = null;
                diagcb.SelectedValue = null;
            }
        }
    }
}
