using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для HeadTeacher.xaml
    /// </summary>
    public partial class HeadTeacher : Page
    {
        public HeadTeacher()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.autho);
        }

        private void GoToTeacher(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.managmentTeacher);
        }
        private void GoToClass(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.managmentClass);
        }
        private void GoToStudent(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.managmentStudent);
        }
        private void GoToSubject(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.managmentSubject);
        }
    }
}
