using ClassLibrarySchool;

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
    /// Логика взаимодействия для ManagmentClass.xaml
    /// </summary>
    public partial class ManagmentClass : Page
    {
        public ObservableCollection<Class> Classes { get; set; }
        public ManagmentClass()
        {
            InitializeComponent();
            Binding classlist = new Binding();
            Classes = new ObservableCollection<Class>(MainWindow.connection.Classes);
            classlist.Source = Classes;
            classlists.SetBinding(ListView.ItemsSourceProperty, classlist);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.headTeacher);
        }
        private void AddClass(object sender, RoutedEventArgs e)
        {
            var nameClass = tbName.Text.Trim();
            var Class1 = new Class()
            {
                Number = nameClass,
            };
            MainWindow.connection.Classes.Add(Class1);
            MainWindow.connection.SaveChanges();
            Classes.Add(Class1);
        }
        private void DeleteClass(object sender, RoutedEventArgs e)
        {  
            var delClass = classlists.SelectedItem as Class;
            Classes.Remove(delClass);
            MainWindow.connection.Classes.Remove(delClass);
            MainWindow.connection.SaveChanges();

        }
    } 
}
