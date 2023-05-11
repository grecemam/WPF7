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
using _10labaa.Model;
//using _10labaa.Model;

namespace _10labaa.View_Model
{
    internal class workersVM : BindingHelper
    {

        #region господи помилуй
        private WorkersDataTable workers;
        public WorkersDataTable Workers
        {
            get { return workers; }
            set
            {
                workers = value;
                OnPropertyChanged();
            }
        }
        private UsersDataTable users;

        public  UsersDataTable Users
        {
            get { return users; }
            set { users = value;
                OnPropertyChanged();
            }
        }
        private PositionDataTable positionTable;

        public PositionDataTable PositionTable
        {
            get { return positionTable; }
            set
            {
                positionTable = value;
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



        #endregion

        #region команды черлидерш

        public BindableCommand AddCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }
        public BindableCommand SelectionCommand { get; set; }

        #endregion

        PositionTableAdapter PositionTableAdapter = new PositionTableAdapter();
        UsersTableAdapter UsersTableAdapter = new UsersTableAdapter();
        WorkersTableAdapter WorkersTableAdapter = new WorkersTableAdapter();
        public workersVM()
        {
            AddCommand = new BindableCommand(_ => addbtn_Click());
            UpdateCommand = new BindableCommand(_ => updatebtn_Click());
            DeleteCommand = new BindableCommand(_ => delbtn_Click());
            SelectionCommand = new BindableCommand(_ => DataGrid_SelectionChanged());


            Workers = WorkersTableAdapter.GetData();
            PositionTable = PositionTableAdapter.GetData();
            DontHurtMe.posdis = "name_of_the_position";
            DontHurtMe.posselvalpath = "position_id";
            Users = UsersTableAdapter.GetData();
            DontHurtMe.usercbdis = "login";
            DontHurtMe.usercbselvalpath = "users_id";

        }

        private void DataGrid_SelectionChanged()
        {
            if (GovnaPojralo != null)
            {
                object Surname = GovnaPojralo.Row[1];
                object Name = GovnaPojralo.Row[2];
                object middle = GovnaPojralo.Row[3];
                object pos = GovnaPojralo.Row[4];
                object exp = GovnaPojralo.Row[5];
                object user = GovnaPojralo.Row[6];
                DontHurtMe.surname = Convert.ToString(Surname);
                DontHurtMe.name = Convert.ToString(Name);
                DontHurtMe.middle = Convert.ToString(middle);
                DontHurtMe.ex = Convert.ToString(exp);
                DontHurtMe.usersel = user.ToString();
                DontHurtMe.possel = pos.ToString();
            }
        }


        private void addbtn_Click()
        {
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.middle == "" || DontHurtMe.possel == null || DontHurtMe.ex == "" || DontHurtMe.usersel == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                int d;
                if (int.TryParse(DontHurtMe.ex, out d))
                {
                    object Surname = GovnaPojralo.Row[1];
                    object Name = GovnaPojralo.Row[2];
                    object middle = GovnaPojralo.Row[3];
                    object pos = GovnaPojralo.Row[4];
                    object exp = GovnaPojralo.Row[5];
                    object user = GovnaPojralo.Row[6];
                    DontHurtMe.surname = Convert.ToString(Surname);
                    DontHurtMe.name = Convert.ToString(Name);
                    DontHurtMe.middle = Convert.ToString(middle);
                    DontHurtMe.ex = Convert.ToString(exp);
                    DontHurtMe.usersel = user.ToString();
                    DontHurtMe.possel = pos.ToString();

                    //int exp = Convert.ToInt32(DontHurtMe.ex);
                    WorkersTableAdapter.InsertQuery(DontHurtMe.surname, DontHurtMe.name, DontHurtMe.middle, (int?)Convert.ToInt64(DontHurtMe.possel), Convert.ToInt32(DontHurtMe.ex), Convert.ToInt32(DontHurtMe.usersel));
                    Workers = WorkersTableAdapter.GetData();
                    DontHurtMe.surname = "";
                    DontHurtMe.name = "";
                    DontHurtMe.middle = "";
                    DontHurtMe.ex = "";
                    DontHurtMe.possel = null;
                    DontHurtMe.usersel = null;


                }
                else
                {
                    MessageBox.Show("Вводи цифры");
                    return;
                }
            }
        }

        private void updatebtn_Click()
        {
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.middle == "" || DontHurtMe.possel == null || DontHurtMe.ex == "" || DontHurtMe.usersel == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                int d;
                if (int.TryParse(DontHurtMe.ex, out d))
                {
                    object Surname = GovnaPojralo.Row[1];
                    object Name = GovnaPojralo.Row[2];
                    object middle = GovnaPojralo.Row[3];
                    object pos = GovnaPojralo.Row[4];
                    object exp = GovnaPojralo.Row[5];
                    object user = GovnaPojralo.Row[6];
                    DontHurtMe.surname = Convert.ToString(Surname);
                    DontHurtMe.name = Convert.ToString(Name);
                    DontHurtMe.middle = Convert.ToString(middle);
                    DontHurtMe.ex = Convert.ToString(exp);
                    DontHurtMe.usersel = user.ToString();
                    DontHurtMe.possel = pos.ToString();
                    //int exp = Convert.ToInt32(DontHurtMe.ex);
                    object id = GovnaPojralo.Row[0];
                    WorkersTableAdapter.UpdateQuery(DontHurtMe.surname, DontHurtMe.name, DontHurtMe.middle, (int?)Convert.ToInt64(DontHurtMe.possel), Convert.ToInt32(DontHurtMe.ex), Convert.ToInt32(DontHurtMe.usersel), Convert.ToInt32(id));
                    Workers = WorkersTableAdapter.GetData();
                    DontHurtMe.surname = "";
                    DontHurtMe.name = "";
                    DontHurtMe.middle = "";
                    DontHurtMe.ex = "";
                    DontHurtMe.possel = null;
                    DontHurtMe.usersel = null;
                }
                else
                {
                    MessageBox.Show("Вводи цифры");
                    return;
                }
            }
        }

        private void delbtn_Click()
        {
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.middle == "" || DontHurtMe.possel == null || DontHurtMe.ex == "" || DontHurtMe.usersel == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object Surname = GovnaPojralo.Row[1];
                object Name = GovnaPojralo.Row[2];
                object middle = GovnaPojralo.Row[3];
                object pos = GovnaPojralo.Row[4];
                object exp = GovnaPojralo.Row[5];
                object user = GovnaPojralo.Row[6];
                DontHurtMe.surname = Convert.ToString(Surname);
                DontHurtMe.name = Convert.ToString(Name);
                DontHurtMe.middle = Convert.ToString(middle);
                DontHurtMe.ex = Convert.ToString(exp);
                DontHurtMe.usersel = user.ToString();
                DontHurtMe.possel = pos.ToString();
                object id = GovnaPojralo.Row[0];
                WorkersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                Workers = WorkersTableAdapter.GetData();
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.middle = "";
                DontHurtMe.ex = "";
                DontHurtMe.possel = null;
                DontHurtMe.usersel = null;
            }
        }
    }
}
