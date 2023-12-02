using ClassLibrarySchool;
using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
    /// Логика взаимодействия для adminPage.xaml
    /// </summary>
    public partial class adminPage : Page
    {
        public ObservableCollection<Account> Accounts { get; set; }
      
       
        public adminPage()
        {
            InitializeComponent();

            Binding headlist = new Binding();
            Accounts = new ObservableCollection<Account>(MainWindow.connection.Accounts.Where(x => x.Role != 3 && x.Role != 4));
            headlist.Source = Accounts;
            headlists.SetBinding(ListView.ItemsSourceProperty, headlist);        
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.autho);
        }
        private void AddRoleT(object sender, RoutedEventArgs e)
        {
            var nickNameA = tbnickName.Text.Trim();
            var firstNameA = tbuserFirstName.Text.Trim();
            var lastNameA = tbuserLastName.Text.Trim();
            var patronymicA = tbPatronymic.Text.Trim();
            var passwordA = tbuserPassword.Text.Trim();

            var acoount = new Account()
            {
                NickName = nickNameA,
                FirstName = firstNameA,
                LastName = lastNameA,
                Patronymic = patronymicA,
                PasswordA = passwordA,
                Role = 2

            };
            MainWindow.connection.Accounts.Add(acoount);
            MainWindow.connection.SaveChanges();
            Accounts.Add(acoount);

        }
        private void AddRoleH(object sender, RoutedEventArgs e)
        {
            var nickNameA = tbnickName.Text.Trim();
            var firstNameA = tbuserFirstName.Text.Trim();
            var lastNameA = tbuserLastName.Text.Trim();
            var patronymicA = tbPatronymic.Text.Trim();
            var passwordA = tbuserPassword.Text.Trim();

            var acoount = new Account()
            {
                NickName = nickNameA,
                FirstName = firstNameA,
                LastName = lastNameA,
                Patronymic = patronymicA,
                PasswordA = passwordA,
                Role = 1

            };
            MainWindow.connection.Accounts.Add(acoount);
            MainWindow.connection.SaveChanges();
            Accounts.Add(acoount);
        }
        
        private void DeleteRole(object sender, RoutedEventArgs e)
        {
            if(headlists.SelectedItems.Count > 0) {
                var delH = headlists.SelectedItem as Account;
                Accounts.Remove(delH);
                MainWindow.connection.Accounts.Remove(delH);
                MainWindow.connection.SaveChanges();
            }     

        }

   
    }
}
