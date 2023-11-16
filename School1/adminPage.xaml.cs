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
        public ObservableCollection<headTeacher> HeadTeacher { get; set; }
        public ObservableCollection<teacher> Teacher { get; set; }
       
   
        public adminPage()
        {
            InitializeComponent();

            Binding headlist = new Binding();
            HeadTeacher = new ObservableCollection<headTeacher>(MainWindow.connection.headTeachers);
            headlist.Source = HeadTeacher;
            headlists.SetBinding(ListView.ItemsSourceProperty, headlist);


            Binding teachlist = new Binding();
            Teacher= new ObservableCollection<teacher>(MainWindow.connection.teachers);
            teachlist.Source = Teacher;
            teachlists.SetBinding(ListView.ItemsSourceProperty, teachlist);
            
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.autho);
        }
        private void AddRoleT(object sender, RoutedEventArgs e)
        {
            var idH = int.Parse(tbID.Text.Trim());
            var userName = tbuserName.Text.Trim();
            var password = tbPassword.Text.Trim();

            var headTeacher1 = new SchoolLibrary.headTeacher()
            {
                id = idH,
                userName = userName,
                passwordH = password,
            };
            MainWindow.connection.headTeachers.Add(headTeacher1);
            MainWindow.connection.SaveChanges();
            HeadTeacher.Add(headTeacher1);

        }
        private void AddRoleH(object sender, RoutedEventArgs e)
        {
            var idH = int.Parse(tbID.Text.Trim());
            var userName = tbuserName.Text.Trim();
            var password = tbPassword.Text.Trim();

            var Teacher1 = new SchoolLibrary.teacher()
            {
                id = idH,
                userName = userName,
                passwordT = password,
            };
            MainWindow.connection.teachers.Add(Teacher1);
            MainWindow.connection.SaveChanges();
            Teacher.Add(Teacher1);
        }
        
        private void DeleteRole(object sender, RoutedEventArgs e)
        {
            if(headlists.SelectedItems.Count > 0) {
                var delH = headlists.SelectedItem as headTeacher;
                HeadTeacher.Remove(delH);
                MainWindow.connection.headTeachers.Remove(delH);
                MainWindow.connection.SaveChanges();
            }
           if(teachlists.SelectedItems.Count >0)
            {
                var delT = teachlists.SelectedItem as teacher;
                Teacher.Remove(delT);
                MainWindow.connection.teachers.Remove(delT);
                MainWindow.connection.SaveChanges();
            }
           

        }
    }
}
