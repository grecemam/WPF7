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
using _10labaa.Model;

namespace _10labaa.View_Model
{
    public class VisitsVM : BindingHelper
    {
        VisitsTableAdapter VisitsTableAdapter = new VisitsTableAdapter();
        VisitorsTableAdapter visitorsTableAdapter = new VisitorsTableAdapter();
        WorkersTableAdapter workersTableAdapter = new WorkersTableAdapter();
        OfficeTableAdapter officeTable = new OfficeTableAdapter();
        DiscountTableAdapter discountTableAdapter = new DiscountTableAdapter();


        public VisitsDataTable visits;

        public VisitsDataTable Visits
        {
            get { return visits; }
            set {
                visits = value;
                OnPropertyChanged();
            }
        }

        public VisitorsDataTable visitor;

        public VisitorsDataTable Visitor
        {
            get { return visitor; }
            set
            {
                visitor = value;
                OnPropertyChanged();
            }
        }

        public WorkersDataTable workers;

        public WorkersDataTable Workers
        {
            get { return workers; }
            set
            {
                workers = value;
                OnPropertyChanged();
            }
        }
        public DiscountDataTable discounts;

        public DiscountDataTable Discounts
        {
            get { return discounts; }
            set
            {
                discounts = value;
                OnPropertyChanged();
            }
        }
        public OfficeDataTable office;

        public OfficeDataTable Office
        {
            get { return office; }
            set
            {
                office = value;
                OnPropertyChanged();
            }
        }





        public Vladislav vladislav = new Vladislav();

        public Vladislav DontHurtMe
        {
            get { return vladislav; }
            set
            {
                vladislav = value;
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
        public BindableCommand AddCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }
        public BindableCommand SelectionCommand { get; set; }

        public VisitsVM()
        {
            AddCommand = new BindableCommand(_ => addbtn_Click());
            UpdateCommand = new BindableCommand(_ => updatebtn_Click());
            DeleteCommand = new BindableCommand(_ => delbtn_Click());
            SelectionCommand = new BindableCommand(_ => DataGrid_SelectionChanged());


            Visits = VisitsTableAdapter.GetData();
            Visitor = visitorsTableAdapter.GetData();
            DontHurtMe.name = "Surname";
            DontHurtMe.surname = "visitors_id";
            Workers = workersTableAdapter.GetData();
            DontHurtMe.middle = "Surname";
            DontHurtMe.posdis = "workers_id";
            Office = officeTable.GetData();
            DontHurtMe.possel = "number_of_office";
            DontHurtMe.usersel = "office_id";
            Discounts = discountTableAdapter.GetData();
            DontHurtMe.usercbselvalpath = "percentage_of_the_discount";
            DontHurtMe.posselvalpath = "discount_id";
        }

        private void DataGrid_SelectionChanged()
        {
            if (GovnaPojralo != null)
            {
                object wor = GovnaPojralo.Row[1];
                object pos = GovnaPojralo.Row[2];
                object of = GovnaPojralo.Row[3];
                object dis = GovnaPojralo.Row[4];
                DontHurtMe.a = wor.ToString();
                DontHurtMe.a = pos.ToString();
                DontHurtMe.a = of.ToString();
                DontHurtMe.a = dis.ToString();
            }
        }


        private void addbtn_Click()
        {
            object wor = GovnaPojralo.Row[1];
            object pos = GovnaPojralo.Row[2];
            object of = GovnaPojralo.Row[3];
            object dis = GovnaPojralo.Row[4];
            DontHurtMe.a = wor.ToString();
            DontHurtMe.b = pos.ToString();
            DontHurtMe.c = of.ToString();
            DontHurtMe.d = dis.ToString();
            if (DontHurtMe.a == null || DontHurtMe.b == null || DontHurtMe.c == null || DontHurtMe.d == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                


                VisitsTableAdapter.InsertQuery(Convert.ToInt32(DontHurtMe.a), Convert.ToInt32(DontHurtMe.b), Convert.ToInt32(DontHurtMe.c),
                    Convert.ToInt32(DontHurtMe.d));
                Visits = VisitsTableAdapter.GetData();
                DontHurtMe.a = null;
                DontHurtMe.b = null;
                DontHurtMe.c = null;
                DontHurtMe.d = null;
            }

        }

        private void updatebtn_Click()
        {
            object wor = GovnaPojralo.Row[1];
            object pos = GovnaPojralo.Row[2];
            object of = GovnaPojralo.Row[3];
            object dis = GovnaPojralo.Row[4];
            DontHurtMe.a = wor.ToString();
            DontHurtMe.b = pos.ToString();
            DontHurtMe.c = of.ToString();
            DontHurtMe.d = dis.ToString();
            if (DontHurtMe.a == null || DontHurtMe.b == null || DontHurtMe.c == null || DontHurtMe.d == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                


                object id = GovnaPojralo.Row[0];
                VisitsTableAdapter.UpdateQuery(Convert.ToInt32(DontHurtMe.a), Convert.ToInt32(DontHurtMe.b), Convert.ToInt32(DontHurtMe.c),
                    Convert.ToInt32(DontHurtMe.d), Convert.ToInt32(id));
                Visits = VisitsTableAdapter.GetData();
                DontHurtMe.a = null;
                DontHurtMe.b = null;
                DontHurtMe.c = null;
                DontHurtMe.d = null;
            }
        }

        private void delbtn_Click()
        {
            object wor = GovnaPojralo.Row[1];
            object pos = GovnaPojralo.Row[2];
            object of = GovnaPojralo.Row[3];
            object dis = GovnaPojralo.Row[4];
            DontHurtMe.a = wor.ToString();
            DontHurtMe.b = pos.ToString();
            DontHurtMe.c = of.ToString();
            DontHurtMe.d = dis.ToString();
            if (DontHurtMe.a == null || DontHurtMe.b == null || DontHurtMe.c == null || DontHurtMe.d == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                

                object id = GovnaPojralo.Row[0];
                VisitsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                Visits = VisitsTableAdapter.GetData();
                DontHurtMe.a = null;
                DontHurtMe.b = null;
                DontHurtMe.c = null;
                DontHurtMe.d = null;
            }
        }
    }
}
