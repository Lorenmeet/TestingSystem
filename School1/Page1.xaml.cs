
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
        private readonly ClassLibrarySchool.user3Entities connection;
        public ObservableCollection<ClassLibrarySchool.Account> Admins{ get; set; }
        public Page1()
        {
            InitializeComponent();
            connection = new ClassLibrarySchool.user3Entities();
            Admins = new ObservableCollection<ClassLibrarySchool.Account>(connection.Accounts);
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(nickName.Text == "" || lastName.Text == "" || firstName.Text == "" || patronymic.Text == "" || password.Text == "")
            {
                MessageBox.Show("Поля пустые");
                return;
            }

            var nickNameA  = nickName.Text.Trim();
            var firstNameA = firstName.Text.Trim();
            var lastNameA = lastName.Text.Trim();
            var patronymicA = patronymic.Text.Trim();
            var passwordA = password.Text.Trim();

            var acoount = new ClassLibrarySchool.Account()
            {
                NickName = nickNameA,
                FirstName = firstNameA,
                LastName = lastNameA,
                Patronymic = patronymicA,
                PasswordA = passwordA,
                Role = 4

            };
            connection.Accounts.Add(acoount);
            connection.SaveChanges();
            Admins.Add(acoount);

            MainWindow.page.Navigate(Class1.mainWindow);
        }
       
    }
}
