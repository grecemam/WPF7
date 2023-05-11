using _10labaa.Model.dentistryDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows;
using static _10labaa.Model.dentistryDataSet;
using _10labaa.View_Model.Helpers;

namespace _10labaa.View_Model
{
    public class ServicesVM : BindingHelper 
    {
        ServicesTableAdapter ServicesTableAdapter = new ServicesTableAdapter();
        public ServicesDataTable services;

        public BindableCommand AddCommand { get; set; }
        public BindableCommand UpdateCommand { get; set; }
        public BindableCommand DeleteCommand { get; set; }
        public BindableCommand SelectionCommand { get; set; }
        public BindableCommand ImportCommand { get;  set; }

        public ServicesDataTable Services
        {
            get { return services; }
            set { services = value;
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
        private string number;

        public string Name
        {
            get { return number; }
            set { number = value;
                OnPropertyChanged();
            }
        }
        private string price;

        public string Price
        {
            get { return price; }
            set
            {
                price = value;
                OnPropertyChanged();
            }
        }






        public ServicesVM()
        {
            AddCommand = new BindableCommand(_ => addbtn_Click_1());
            UpdateCommand = new BindableCommand(_ => backbtn_Copy1_Click());
            DeleteCommand = new BindableCommand(_ => backbtn_Copy2_Click());
            SelectionCommand = new BindableCommand(_ => DataGridus_SelectionChanged());
            ImportCommand = new BindableCommand(_ => updatebtn_Copy_Click());


            Services = ServicesTableAdapter.GetData();
        }

        private void DataGridus_SelectionChanged()
        {
            if (GovnaPojralo != null)
            {
                object num = GovnaPojralo.Row[1];
                object pricee = GovnaPojralo.Row[2];
                Price = pricee.ToString();
                Name = num.ToString();
            }
        }


        private void addbtn_Click_1()
        {
            object num = GovnaPojralo.Row[1];
            object pricee = GovnaPojralo.Row[2];
            Price = pricee.ToString();
            Name = num.ToString();
            if (Name == "" || Price == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                int d;
                if (int.TryParse(Price, out d))
                {

                    ServicesTableAdapter.InsertQuery(Name, Convert.ToInt32(Price));
                    Name = "";
                    Price = "";
                    Services = ServicesTableAdapter.GetData();
                }
                else
                {
                    MessageBox.Show("Вводи цифры");
                    return;
                }
            }
        }

        private void backbtn_Copy1_Click()
        {
            object num = GovnaPojralo.Row[1];
            object pricee = GovnaPojralo.Row[2];
            Price = pricee.ToString();
            Name = num.ToString();
            if (Name == "" || Price == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                int d;
                if (int.TryParse(Price, out d))
                {

                    object id = GovnaPojralo.Row[0];
                    ServicesTableAdapter.UpdateQuery(Name, Convert.ToInt32(Price), Convert.ToInt32(id));
                    Name = "";
                    Price = "";
                    Services = ServicesTableAdapter.GetData();
                }
                else
                {
                    MessageBox.Show("Вводи цифры");
                    return;
                }
            }

        }

        private void backbtn_Copy2_Click()
        {
            object num = GovnaPojralo.Row[1];
            object pricee = GovnaPojralo.Row[2];
            Price = pricee.ToString();
            Name = num.ToString();
            if (Name == "" || Price == "")
            {
                MessageBox.Show("Не все поля заполнены");
            }
            else
            {
                int d;
                if (int.TryParse(Price, out d))
                {
                    object id = GovnaPojralo.Row[0];
                    ServicesTableAdapter.DeleteQuery(Convert.ToInt32(id));
                    Name = "";
                    Price = "";
                    Services = ServicesTableAdapter.GetData();
                }
                else
                {
                    MessageBox.Show("Вводи цифры");
                    return;
                }
            }
        }

        private void updatebtn_Copy_Click()
        {
            List<import> forimport = LabaConverter.Deserialize0bject<List<import>>();
            foreach (var import in forimport)
            {
                ServicesTableAdapter.InsertQuery(import.name, import.price);
            }
            Services = ServicesTableAdapter.GetData();
        }
    }
}
