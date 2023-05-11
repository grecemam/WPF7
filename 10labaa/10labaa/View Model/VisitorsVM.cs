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
using _10labaa.Model;
using _10labaa.View_Model.Helpers;

namespace _10labaa.View_Model
{
    public class VisitorsVM : BindingHelper
    {
        VisitorsTableAdapter visitorsTableAdapter = new VisitorsTableAdapter();
        UsersTableAdapter UsersTableAdapter = new UsersTableAdapter();

        private VisitorsDataTable myVar;

        public VisitorsDataTable Visitors
        {
            get { return myVar; }
            set { myVar = value;
                OnPropertyChanged();
            }
        }
        private UsersDataTable users;

        public UsersDataTable Users
        {
            get { return users; }
            set { users = value;
                OnPropertyChanged();
            }
        }
        public BindableCommand AddCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }
        public BindableCommand SelectionCommand { get; set; }

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


        public VisitorsVM()
        {
            AddCommand = new BindableCommand(_ => addbtn_Click());
            UpdateCommand = new BindableCommand(_ => updatebtn_Click());
            DeleteCommand = new BindableCommand(_ => delbtn_Click());
            SelectionCommand = new BindableCommand(_ => DataGrid_SelectionChanged());

            Visitors = visitorsTableAdapter.GetData();
            Users = UsersTableAdapter.GetData();
            DontHurtMe.a = "login";
            DontHurtMe.b = "users_id";

        }


        private void DataGrid_SelectionChanged()
        {
            if (GovnaPojralo != null)
            {
                object Surname = GovnaPojralo.Row[1];
                object Name = GovnaPojralo.Row[2];
                object middle = GovnaPojralo.Row[3];
                object user = GovnaPojralo.Row[4];
                DontHurtMe.surname = Convert.ToString(Surname);
                DontHurtMe.name = Convert.ToString(Name);
                DontHurtMe.middle = Convert.ToString(middle);
                DontHurtMe.c =  user.ToString();
            }

        }
        private void addbtn_Click()
        {
            object Surname = GovnaPojralo.Row[1];
            object Name = GovnaPojralo.Row[2];
            object middle = GovnaPojralo.Row[3];
            object user = GovnaPojralo.Row[4];
            DontHurtMe.surname = Convert.ToString(Surname);
            DontHurtMe.name = Convert.ToString(Name);
            DontHurtMe.middle = Convert.ToString(middle);
            DontHurtMe.c = user.ToString();
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.middle == "" || DontHurtMe.c == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                visitorsTableAdapter.InsertQuery(DontHurtMe.surname, DontHurtMe.name, DontHurtMe.middle, Convert.ToInt32(DontHurtMe.c));
                Visitors = visitorsTableAdapter.GetData();
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.middle = "";
                DontHurtMe.c = null;
            }
        }

        private void updatebtn_Click()
        {
            object Surname = GovnaPojralo.Row[1];
            object Name = GovnaPojralo.Row[2];
            object middle = GovnaPojralo.Row[3];
            object user = GovnaPojralo.Row[4];
            DontHurtMe.surname = Convert.ToString(Surname);
            DontHurtMe.name = Convert.ToString(Name);
            DontHurtMe.middle = Convert.ToString(middle);
            DontHurtMe.c = user.ToString();
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.middle == "" || DontHurtMe.c == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = GovnaPojralo.Row[0];
                visitorsTableAdapter.UpdateQuery(DontHurtMe.surname, DontHurtMe.name, DontHurtMe.middle, Convert.ToInt32(DontHurtMe.c), Convert.ToInt32(id));
                Visitors = visitorsTableAdapter.GetData();
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.middle = "";
                DontHurtMe.c = null;
            }
        }

        private void delbtn_Click()
        {
            object Surname = GovnaPojralo.Row[1];
            object Name = GovnaPojralo.Row[2];
            object middle = GovnaPojralo.Row[3];
            object user = GovnaPojralo.Row[4];
            DontHurtMe.surname = Convert.ToString(Surname);
            DontHurtMe.name = Convert.ToString(Name);
            DontHurtMe.middle = Convert.ToString(middle);
            DontHurtMe.c = user.ToString();
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.middle == "" || DontHurtMe.c == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object id = GovnaPojralo.Row[0];
                visitorsTableAdapter.DeleteQuery(Convert.ToInt32(id));
                Visitors = visitorsTableAdapter.GetData();
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.middle = "";
                DontHurtMe.c = null;
            }
        }
    }
}
