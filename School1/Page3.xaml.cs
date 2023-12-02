using ClassLibrarySchool;
using SchoolLibrary;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace School1
{
    /// <summary>
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : Page
    {
        public Account _account { get; set; }
       
        public ObservableCollection<Account> Accounts{ get; set; }
      

        public Page3()
        {
            InitializeComponent();

            Accounts = new ObservableCollection<Account>(MainWindow.connection.Accounts);
            _account = new Account();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _account.NickName = nickName.Text.Trim();
                _account.PasswordA = Password.Text.Trim();
                if (MainWindow.connection.Accounts.FirstOrDefault(x => x.NickName == _account.NickName && x.PasswordA == _account.PasswordA && x.Role == 4)!= null)
                {
                    MainWindow.page.Navigate(Class1.admin);
                    return;
                }

                if (MainWindow.connection.Accounts.FirstOrDefault(x => x.NickName == _account.NickName && x.PasswordA == _account.PasswordA && x.Role == 1) != null)
                {
                    MainWindow.page.Navigate(Class1.headTeacher);
                    return;
                }

                if (MainWindow.connection.Accounts.FirstOrDefault(x => x.NickName == _account.NickName && x.PasswordA == _account.PasswordA && x.Role == 2) != null)
                {
                    MainWindow.page.Navigate(Class1.teacher);
                    return;
                }
                if (MainWindow.connection.Accounts.FirstOrDefault(x => x.NickName == _account.NickName && x.PasswordA == _account.PasswordA && x.Role == 3) != null)
                {
                    MainWindow.page.Navigate(Class1.studentPage);
                    return;
                }
                throw new Exception("Не найдено");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
