using ClassLibrarySchool;

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
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
    /// Логика взаимодействия для ManagmentStudent.xaml
    /// </summary>
    public partial class ManagmentStudent : Page
    {
        public ObservableCollection<Student> Students { get; set; }
        public ObservableCollection<Class> Classes { get; set; }
        public ManagmentStudent()
        {
            InitializeComponent();
            Binding bindingCb = new Binding();
            Binding bindingList = new Binding();
            Students = new ObservableCollection<Student>(MainWindow.connection.Students);
            Classes = new ObservableCollection<Class>(MainWindow.connection.Classes);
            bindingCb.Source = Classes;
            bindingList.Source = Students;
            cbGroup.SetBinding(ComboBox.ItemsSourceProperty, bindingCb);
            listView.SetBinding(ListView.ItemsSourceProperty, bindingList);

        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.headTeacher);
        }
        private void AddStudent(object sender, RoutedEventArgs e)
        {
            var firstName = firstNameStudent.Text.Trim();
            var lastName = lastNameStudent.Text.Trim();
            var patronymic = patronymicStudent.Text.Trim();
            var ClassName = (cbGroup.SelectedItem as Class).Number;

            var student1 = new Student()
            {
                FirstName = firstName,
                LastName = lastName,
                Patronymic = patronymic,
                Class = ClassName,

            };
            MainWindow.connection.Students.Add(student1);
            MainWindow.connection.SaveChanges();
            Students.Add(student1);

        }

        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            var delStudent = listView.SelectedItem as Student;
            Students.Remove(delStudent);
            MainWindow.connection.Students.Remove(delStudent);
            MainWindow.connection.SaveChanges();

        }
    }
}
