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
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static ClassLibrarySchool.user3Entities connection;
       
        public static Frame page;

        public MainWindow()
        {
           
            InitializeComponent();
            
            connection = new ClassLibrarySchool.user3Entities();
            if (connection.Database.Exists() == false) { 
            MessageBox.Show("Подключение к базе данных не было выполнено. Приложение будет завершено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
           
            DataContext = this;
            page = Authorization;
            if(connection.Accounts.Where(x => x.Role == 4) == null) 
            {
                page.Navigate(Class1.reg);
            }
            else
            {
                page.Navigate(Class1.autho);
            }
            

        }
    
    }
}
