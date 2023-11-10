using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
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

namespace School1
{
    /// <summary>
    /// Логика взаимодействия для Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        private readonly SchoolLibrary.TestingSystemEntities connection;
        public ObservableCollection<SchoolLibrary.admin> Admins{ get; set; }
        public Page1()
        {
            InitializeComponent();
            connection = new SchoolLibrary.TestingSystemEntities();
            Admins = new ObservableCollection<SchoolLibrary.admin>(connection.admins);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(ID.Text == "" || FIO.Text == "" || Password.Text == "")
            {
                MessageBox.Show("Поля пустые");
                return;
            }

            var idadmin = int.Parse(ID.Text.Trim());
            var fullName = FIO.Text.Trim();
            var password = Password.Text.Trim();

            var admins = new SchoolLibrary.admin()
            {
                id = idadmin,
                userName= fullName,
                passwordA = password,
            };
            connection.admins.Add(admins);
            connection.SaveChanges();
            Admins.Add(admins);

            MainWindow.page.Navigate(Class1.mainWindow);
        }
       
    }
}
