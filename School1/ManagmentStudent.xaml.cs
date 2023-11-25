using SchoolLibrary;
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
        public ObservableCollection<student> Students { get; set; }
        public ObservableCollection<group> Groups { get; set; }
        public ManagmentStudent()
        {
            InitializeComponent();
            Binding bindingCb = new Binding();
            Binding bindingList = new Binding();
            Students = new ObservableCollection<student>(MainWindow.connection.students);
            Groups = new ObservableCollection<group>(MainWindow.connection.groups);
            bindingCb.Source = Groups;
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

            };
            MainWindow.connection.students.Add(student1);
            MainWindow.connection.SaveChanges();

            Students.Add(student1);

        }

        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            var delStudent = listView.SelectedItem as student;
            Students.Remove(delStudent);
            MainWindow.connection.students.Remove(delStudent);
            MainWindow.connection.SaveChanges();

        }
    }
}
