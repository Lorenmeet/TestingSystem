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
        public static SchoolLibrary.TestingSystemEntities connection;
       
        public static Frame page;

        public MainWindow()
        {
           
            InitializeComponent();
            
            connection = new SchoolLibrary.TestingSystemEntities();
            if (connection.Database.Exists() == false) { 
            MessageBox.Show("Подключение к базе данных не было выполнено. Приложение будет завершено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
           
            DataContext = this;
            page = Authorization;
            if(connection.admins.Count() == 0) 
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
