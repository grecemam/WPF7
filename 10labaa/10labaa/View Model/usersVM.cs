using _10labaa.Model.dentistryDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static _10labaa.Model.dentistryDataSet;
using System.Windows;
using _10labaa.View_Model.Helpers;
using System.Data.Common;
using _10labaa.Model;

namespace _10labaa.View_Model
{
    public class usersVM : BindingHelper
    {
        private UsersDataTable Userss;
        public UsersDataTable userss
        {
            get { return Userss; }
            set
            {
                Userss = value;
                OnPropertyChanged();
            }
        }

        private RoleDataTable roles;

        public RoleDataTable Roles
        {
            get { return roles; }
            set
            {
                roles = value;
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

        #region команды черлидерш

        public BindableCommand AddCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }
        public BindableCommand SelectionCommand { get; set; }

        #endregion
        UsersTableAdapter UsersTableAdapter = new UsersTableAdapter();

        RoleTableAdapter RoleTableAdapter = new RoleTableAdapter();
        public usersVM()
        {
            AddCommand = new BindableCommand(_ => addbtn_Click());
            UpdateCommand = new BindableCommand(_ => backbtn_Copy1_Click());
            DeleteCommand = new BindableCommand(_ => backbtn_Copy2_Click());
            SelectionCommand = new BindableCommand(_ => DataGridus_SelectionChanged());

            userss = UsersTableAdapter.GetData();
            Roles = RoleTableAdapter.GetData();
            DontHurtMe.posdis = "name_role";
            DontHurtMe.posselvalpath = "role_id";
        }



        private void DataGridus_SelectionChanged()
        {
            if (GovnaPojralo != null)
            {

                try
                {

                    object loginn = GovnaPojralo.Row[1];
                    object password = GovnaPojralo.Row[2];
                    object roli = GovnaPojralo.Row[3];
                    DontHurtMe.surname = Convert.ToString(loginn);
                    DontHurtMe.name = Convert.ToString(password);
                    DontHurtMe.usersel = Convert.ToString(roli);
                }
                catch (Exception ex)
                {

                }
            }
        }

        private void addbtn_Click()
        {
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.usersel == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object loginn = GovnaPojralo.Row[1];
                object password = GovnaPojralo.Row[2];
                object roli = GovnaPojralo.Row[3];
                DontHurtMe.surname = Convert.ToString(loginn);
                DontHurtMe.name = Convert.ToString(password);
                DontHurtMe.usersel = Convert.ToString(roli);

                UsersTableAdapter.InsertQuery(DontHurtMe.surname, DontHurtMe.name, (int?)Convert.ToInt64(DontHurtMe.usersel));
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.usersel = null;
                userss = UsersTableAdapter.GetData();
            }
        }
        private void backbtn_Copy2_Click()
        {
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.usersel == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object loginn = GovnaPojralo.Row[1];
                object password = GovnaPojralo.Row[2];
                object roli = GovnaPojralo.Row[3];
                DontHurtMe.surname = Convert.ToString(loginn);
                DontHurtMe.name = Convert.ToString(password);
                DontHurtMe.usersel = Convert.ToString(roli);
                object id = GovnaPojralo.Row[0];
                UsersTableAdapter.DeleteQuery(Convert.ToInt32(id));
                userss = UsersTableAdapter.GetData();
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.usersel = null;
            }
        }

        private void backbtn_Copy1_Click()
        {
            if (DontHurtMe.surname == "" || DontHurtMe.name == "" || DontHurtMe.usersel == null)
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                object loginn = GovnaPojralo.Row[1];
                object password = GovnaPojralo.Row[2];
                object roli = GovnaPojralo.Row[3];
                DontHurtMe.surname = Convert.ToString(loginn);
                DontHurtMe.name = Convert.ToString(password);
                DontHurtMe.usersel = Convert.ToString(roli);
                object id = GovnaPojralo.Row[0];
                UsersTableAdapter.UpdateQuery(DontHurtMe.surname, DontHurtMe.name, (int?)Convert.ToInt64(DontHurtMe.usersel), Convert.ToInt32(id));
                Userss = UsersTableAdapter.GetData();
                DontHurtMe.surname = "";
                DontHurtMe.name = "";
                DontHurtMe.usersel = null;
                userss = UsersTableAdapter.GetData();
            }
        }
    }
}

