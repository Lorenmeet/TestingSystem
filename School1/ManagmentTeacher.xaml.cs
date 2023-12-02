using ClassLibrarySchool;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Логика взаимодействия для ManagmentTeacher.xaml
    /// </summary>
    public partial class ManagmentTeacher : Page
    {
        public ObservableCollection<Account> Accounts { get; set; }
        public ManagmentTeacher()
        {
            InitializeComponent();
            Binding teacherLists = new Binding();
            Accounts = new ObservableCollection<Account>(MainWindow.connection.Accounts);
            teacherLists.Source = Accounts;
            teacherList.SetBinding(ListView.ItemsSourceProperty, teacherLists);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.headTeacher);
        }
        private void AddTeacher(object sender, RoutedEventArgs e)
        {

            var nickNameA = nickNameteacher.Text.Trim();
            var firstNameA = firstNameTeacher.Text.Trim();
            var lastNameA = lastNameTeacher.Text.Trim();
            var patronymicA = patronymicTeacher.Text.Trim();
            var passwordA = passwordTeacher.Text.Trim();

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
    private void DeleteTeacher(object sender, RoutedEventArgs e)
    {
        var delTeacher = teacherList.SelectedItem as Account;
        Accounts.Remove(delTeacher);
        MainWindow.connection.Accounts.Remove(delTeacher);
        MainWindow.connection.SaveChanges();

    }
}
}
