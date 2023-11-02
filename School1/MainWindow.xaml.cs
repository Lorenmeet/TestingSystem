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
        private readonly SchoolLibrary.TestingSystemEntities connection;
        public ObservableCollection<SchoolLibrary.student> Students { get; set; }
        public ObservableCollection<SchoolLibrary.group> Groups { get; set; }


        public MainWindow()
        {
            InitializeComponent();

            connection = new SchoolLibrary.TestingSystemEntities();
            if (connection.Database.Exists() == false) { 
            MessageBox.Show("Подключение к базе данных не было выполнено. Приложение будет завершено", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                Application.Current.Shutdown();
            }
            Students = new ObservableCollection<SchoolLibrary.student>(connection.students);
            Groups = new ObservableCollection<SchoolLibrary.group>(connection.groups);
            DataContext = this;
            
        
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            var idStudent = int.Parse(tbIDStudent.Text.Trim());
            var fullName = tbFullName.Text.Trim();
            var password = tbPassword.Text.Trim();
            var GroupID = (cbGroup.SelectedItem as SchoolLibrary.group).id;

            var student1 = new SchoolLibrary.student()
            {
                id = idStudent,
                username = fullName,
                password = password,
               groupId = GroupID,

            } ;
            connection.students.Add(student1);
            connection.SaveChanges();

            Students.Add(student1);
             
        }
    }
}
