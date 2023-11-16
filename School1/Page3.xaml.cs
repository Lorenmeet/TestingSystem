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
        public admin _admin { get; set; }
        public headTeacher _headTeacher { get; set; }
        public teacher _teacher { get; set; }
        public ObservableCollection<student> Students { get; set; }
        public ObservableCollection<admin> Admin { get; set; }
        public ObservableCollection<headTeacher> HeadTeacher { get; set; }
        public ObservableCollection<teacher> Teacher { get; set; }

        public Page3()
        {
            InitializeComponent();
            Students = new ObservableCollection<student>(MainWindow.connection.students);
            Admin = new ObservableCollection<admin>(MainWindow.connection.admins);
            HeadTeacher = new ObservableCollection<headTeacher>(MainWindow.connection.headTeachers);
            Teacher = new ObservableCollection<teacher>(MainWindow.connection.teachers);
            _headTeacher = new headTeacher();
            _teacher= new teacher();
            _admin = new admin();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _admin.userName = FIO.Text.Trim();
                _admin.passwordA = Password.Text.Trim();
                if (MainWindow.connection.admins.Any(x => x.userName == _admin.userName && x.passwordA == _admin.passwordA))
                {
                    MainWindow.page.Navigate(Class1.admin);
                    return;
                }
                _headTeacher.userName = FIO.Text.Trim();
                _headTeacher.passwordH = Password.Text.Trim();
                if (MainWindow.connection.headTeachers.Any(x => x.userName == _headTeacher.userName && x.passwordH == _headTeacher.passwordH))
                {
                    MainWindow.page.Navigate(Class1.headTeacher);
                    return;
                }
                _teacher.userName = FIO.Text.Trim();
                _teacher.passwordT = Password.Text.Trim();
                if (MainWindow.connection.teachers.Any(x => x.userName == _teacher.userName && x.passwordT == _teacher.passwordT))
                {
                    MainWindow.page.Navigate(Class1.teacher);
                    return;
                }
                throw new Exception("Не найдено");
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }
    }
}
