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
using System.Windows.Navigation;
using System.Windows.Shapes;
using _10labaa.Model.dentistryDataSetTableAdapters;
using System.Data;
using System.Windows.Controls.Primitives;

namespace _10labaa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UsersTableAdapter userss = new UsersTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Autoriz_Click(object sender, RoutedEventArgs e)
        {
            var alllogeins = userss.GetData().Rows;
            for (int i = 0; i < alllogeins.Count; i++)
            {
                if (alllogeins[i][1].ToString() == LoginTbx.Text && alllogeins[i][2].ToString() != PasswordTbx.Password)
                {
                    MessageBox.Show("Вы ввели неправильный пароль)");

                }
                else if (alllogeins[i][1].ToString() != LoginTbx.Text && alllogeins[i][2].ToString() == PasswordTbx.Password)
                {
                    MessageBox.Show("Вы ввели неправильный логин)");

                }
                else if (alllogeins[i][1].ToString() == LoginTbx.Text && alllogeins[i][2].ToString() == PasswordTbx.Password)
                {
                    int role = (int)alllogeins[i][3];
                    switch (role)
                    {
                        case 1:
                            winadmin winadmin = new winadmin();
                            winadmin.Show();
                            Close();
                            break;
                        case 2:
                            winwork winawork = new winwork();
                            winawork.Show();
                            Close();
                            break;
                        case 3:
                            winpos winpos = new winpos();
                            winpos.Show();
                            Close();
                            break;
                    }
                    break;
                }

            }
        }
    }
}
