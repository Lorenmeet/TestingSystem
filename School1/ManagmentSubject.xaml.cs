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
using System.Xml.Linq;

namespace School1
{
    /// <summary>
    /// Логика взаимодействия для ManagmentSubject.xaml
    /// </summary>
    public partial class ManagmentSubject : Page
    {
        public ObservableCollection<Subject> Subjects { get; set; }
        public ManagmentSubject()
        {
            InitializeComponent();
            Binding subgectLists = new Binding();
            Subjects = new ObservableCollection<Subject>(MainWindow.connection.Subjects);
            subgectLists.Source = Subjects;
            subjectList.SetBinding(ListView.ItemsSourceProperty, subgectLists);
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow.page.Navigate(Class1.headTeacher);
        }
        private void AddSubject(object sender, RoutedEventArgs e)
        {
        
            var nameS = tbsSubject.Text.Trim();
         
            var subject = new Subject()
            {
                Name = nameS,
               
            };
            MainWindow.connection.Subjects.Add(subject);
            MainWindow.connection.SaveChanges();
            Subjects.Add(subject);
        }
        private void DeleteSubject(object sender, RoutedEventArgs e)
        {
            var delSubject = subjectList.SelectedItem as Subject;
            Subjects.Remove(delSubject);
            MainWindow.connection.Subjects.Remove(delSubject);
            MainWindow.connection.SaveChanges();

        }
    }
}
