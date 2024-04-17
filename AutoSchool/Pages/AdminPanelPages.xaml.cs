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

namespace AutoSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для AdminPanelPages.xaml
    /// </summary>
    public partial class AdminPanelPages : Page
    {
        public AdminPanelPages()
        {
            InitializeComponent();
        }

        private void btnEmployee_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigationClass.AdminPanelNav = 1;
            ClassHelper.NavigationClass.navFrame.Navigate(new ChangePeopleAndCars());
        }

        private void btnStudent_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigationClass.AdminPanelNav = 2;
            ClassHelper.NavigationClass.navFrame.Navigate(new ChangePeopleAndCars());
        }

        private void btnAuto_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigationClass.AdminPanelNav = 3;
            ClassHelper.NavigationClass.navFrame.Navigate(new ChangePeopleAndCars());
        }

        private void btnAutoService_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigationClass.AdminPanelNav = 4;
            ClassHelper.NavigationClass.navFrame.Navigate(new ChangePeopleAndCars());
        }
    }
}
