using _10labaa.Model.dentistryDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using static _10labaa.Model.dentistryDataSet;
using _10labaa.View_Model.Helpers;
using System.Data.Common;

namespace _10labaa.View_Model
{
    public class DrugsVM : BindingHelper
    {
        #region команды черлидерш

        public BindableCommand AddCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }
        public BindableCommand SelectionCommand { get; set; }

        #endregion

        #region крутышки
        DrugsTableAdapter DrugsTableAdapter = new DrugsTableAdapter();

        private DrugsDataTable jopa;
        public DrugsDataTable Jopa
        {
            get { return jopa; }
            set
            {
                jopa = value;
                OnPropertyChanged();
            }
        }

        private DataRowView dataRowView;
        public DataRowView GovnaPojralo
        {
            get { return dataRowView; }
            set
            {
                dataRowView = value;
                OnPropertyChanged();
            }
        }

       /* private Vladislav vladislav;

        public Vladislav DontHurtMe
        {
            get { return vladislav; }
            set
            {
                vladislav = value;
                OnPropertyChanged();

            }
        }*/


        private string name;
        public string NameDrugs
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged();
            }
        }

        #endregion
        public DrugsVM()
        {
            AddCommand = new BindableCommand(_ => addbtn_Click());
            UpdateCommand = new BindableCommand(_ => update_Click());
            DeleteCommand = new BindableCommand(_ => delete_Click());
            SelectionCommand = new BindableCommand(_ => DataGridus_SelectionChanged());

            Jopa = DrugsTableAdapter.GetData();
        }

        private void DataGridus_SelectionChanged()
        {
            if (GovnaPojralo != null)
            {
                object num = GovnaPojralo.Row[1];
                /* DontHurtMe.A = num.ToString();
                 DontHurtMe.B = num.ToString();
                 DontHurtMe.C = num.ToString();
                 DontHurtMe.V = num.ToString();*/

                NameDrugs = num.ToString();
            }
        }

        private void addbtn_Click()
        {
            if (NameDrugs == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                DrugsTableAdapter.InsertQuery(NameDrugs);
                NameDrugs = "";
                Jopa = DrugsTableAdapter.GetData();
            }
        }

        private void update_Click()
        {
            if (NameDrugs == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                object id = GovnaPojralo.Row[0];
                DrugsTableAdapter.UpdateQuery(NameDrugs, Convert.ToInt32(id));
                NameDrugs = "";
                Jopa = DrugsTableAdapter.GetData();
            }
        }

        private void delete_Click()
        {
            if (NameDrugs == "")
            {
                MessageBox.Show("Поля не заполнены");
            }
            else
            {
                object id = GovnaPojralo.Row[0];
                DrugsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                NameDrugs = "";
                Jopa = DrugsTableAdapter.GetData();
            }
        }
    }
}
