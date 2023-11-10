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
        public SchoolLibrary.student _student { get; set; }
        public ObservableCollection<student> Students { get; set; }
        public Page3()
        {
            InitializeComponent();
            Students = new ObservableCollection<student>(MainWindow.connection.students);
            _student = new student();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _student.username = FIO.Text.Trim();
            _student.password = Password.Text.Trim();
            if (MainWindow.connection.students.Any(x=> x.username == _student.username && x.password == _student.password))
            {
                MainWindow.page.Navigate(Class1.mainWindow);
            }
            else
            {
                MessageBox.Show("Не найдено");
            }

        }
    }
}
