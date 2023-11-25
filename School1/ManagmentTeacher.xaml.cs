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
using SchoolLibrary;

namespace School1
{
    /// <summary>
    /// Логика взаимодействия для ManagmentTeacher.xaml
    /// </summary>
    public partial class ManagmentTeacher : Page
    {
        public ObservableCollection<teacher> Teachers { get; set; }
        public ManagmentTeacher()
        {
            InitializeComponent();
            Binding teacherLists = new Binding();
            Teachers = new ObservableCollection<teacher>(MainWindow.connection.teachers);
            teacherLists.Source = Teachers;
            teacherList.SetBinding(ListView.ItemsSourceProperty, teacherLists);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.headTeacher);
        }
        private void AddTeacher(object sender, RoutedEventArgs e)
        {
            var idT = int.Parse(idTeaher.Text.Trim());
            var nameT = tbName.Text.Trim();
            var PasswordT = tbPassword.Text.Trim();
            var Teacher = new SchoolLibrary.teacher()
        {
            id = idT,
            userName = nameT,
            passwordT= PasswordT,
        };
        MainWindow.connection.teachers.Add(Teacher);
            MainWindow.connection.SaveChanges();
            Teachers.Add(Teacher);
        }
    private void DeleteTeacher(object sender, RoutedEventArgs e)
    {
        var delTeacher = teacherList.SelectedItem as teacher;
        Teachers.Remove(delTeacher);
        MainWindow.connection.teachers.Remove(delTeacher);
        MainWindow.connection.SaveChanges();

    }
}
}
