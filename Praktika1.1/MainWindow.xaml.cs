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
using Praktika1._1.DataBaseInfoTableAdapters;

namespace Praktika1._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
/*        private CompClubEntities context = new CompClubEntities(); // #!#Entity
*/
         EmployeeTableAdapter employee = new EmployeeTableAdapter();// #!#Dataset
         
        public MainWindow()
        {
            InitializeComponent();
             Kamen.ItemsSource = employee.GetData();  /*#!#Dataset*/
            /*Kamen.ItemsSource = context.Employee.ToList(); // #!#Entity*/
        }

        private void Kamen_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Bd2 window = new Bd2();
            window.Show();
            Close();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            Bd2 window = new Bd2();
            window.Show();
            Close();
        }
    }
}
