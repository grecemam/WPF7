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
    /// Логика взаимодействия для drugrordiagnos.xaml
    /// </summary>
    public partial class drugrordiagnos1 : Window
    {
        DiagnosisTableAdapter diagnosisTableAdapter = new DiagnosisTableAdapter();
        DrugsTableAdapter drugsTableAdapter = new DrugsTableAdapter();
        Drugs_for_diagnosesTableAdapter drugs_For_DiagnosesTableAdapter = new Drugs_for_diagnosesTableAdapter();
        public drugrordiagnos1()
        {
            InitializeComponent();
            visdiagDataGrid.ItemsSource = drugs_For_DiagnosesTableAdapter.GetData();
            drugcb.ItemsSource = drugsTableAdapter.GetData();
            drugcb.DisplayMemberPath = "name_of_the_drug";
            drugcb.SelectedValuePath = "drugs_id";
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
                diagcb.SelectedValue = diag;
                drugcb.SelectedValue = pos;
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
            drugs_For_DiagnosesTableAdapter.InsertQuery(Convert.ToInt32(diagcb.SelectedValue), Convert.ToInt32(drugcb.SelectedValue));
            visdiagDataGrid.ItemsSource = drugs_For_DiagnosesTableAdapter.GetData();
            diagcb.SelectedValue = null;
            drugcb.SelectedValue = null;
        }

        private void updatebtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (visdiagDataGrid.SelectedItem as DataRowView).Row[0];
            drugs_For_DiagnosesTableAdapter.UpdateQuery(Convert.ToInt32(diagcb.SelectedValue), Convert.ToInt32(drugcb.SelectedValue), Convert.ToInt32(id));
            visdiagDataGrid.ItemsSource = drugs_For_DiagnosesTableAdapter.GetData();
            diagcb.SelectedValue = null;
            drugcb.SelectedValue = null;
        }

        private void delbtn_Click(object sender, RoutedEventArgs e)
        {
            object id = (visdiagDataGrid.SelectedItem as DataRowView).Row[0];
            drugs_For_DiagnosesTableAdapter.DeleteQuery(Convert.ToInt32(id));
            visdiagDataGrid.ItemsSource = drugs_For_DiagnosesTableAdapter.GetData();
            diagcb.SelectedValue = null;
            drugcb.SelectedValue = null;
        }
    }
}
