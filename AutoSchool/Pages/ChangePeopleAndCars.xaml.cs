using AutoSchool.ClassHelper;
using AutoSchool.DataBase;
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
    /// Логика взаимодействия для ChangePeopleAndCars.xaml
    /// </summary>
    public partial class ChangePeopleAndCars : Page
    {

        AutoSchoolEntities e = new AutoSchoolEntities();
        public ChangePeopleAndCars()
        {
            InitializeComponent();
            GetList();
        }
        public void GetList()
        {
            //сотрудник
            if (NavigationClass.AdminPanelNav == 1)
            {
                var query =
                from Employee in e.Employee
                join P in e.Post on Employee.IdPost equals P.Id
                select new { Employee.LastName, Employee.FirstName, Employee.Patronymic, Employee.Age, Employee.Phone, P.Title };
                DG1.ItemsSource = query.ToList();
            }
            else if (NavigationClass.AdminPanelNav == 2)
            {
                //Студент
                var query =
                from Student in e.Student
                join GS in e.GroupStudent on Student.Id equals GS.IdStudent
                join G in e.Groups on GS.IdGroup equals G.Id
                orderby G.Id, Student.Patronymic
                select new { Student.LastName, Student.FirstName, Student.Patronymic, Student.Age, Student.Phone, NumberGroup = G.Id };
                DG1.ItemsSource = query.ToList();
            }
            else if (NavigationClass.AdminPanelNav == 3)
            {
                //Авто
                var query =
                from Car in e.Car
                join Tp in e.TypeKPP on Car.IdTypeKPP equals Tp.Id
                join Co in e.Color on Car.IdColor equals Co.Id
                join Ec in e.EngineCapacity on Car.IdEngineCapacity equals Ec.Id
                join Cb in e.CarBrand on Car.IdCarBrand equals Cb.id
                join Dr in e.Drive on Car.IdDrive equals Dr.Id
                select new { Cb.Title, Car.Model, Color = Co.Title,};
                DG1.ItemsSource = query.ToList();
            }
            else if (NavigationClass.AdminPanelNav == 4)
            {
                //Списанные авто
                var query =
                from Student in e.Student
                join GS in e.GroupStudent on Student.Id equals GS.IdStudent
                join G in e.Groups on GS.IdGroup equals G.Id
                select new { Student.LastName, Student.FirstName, Student.Patronymic, Student.Age, Student.Phone, G.Id };
                DG1.ItemsSource = query.ToList();
            }
        }

        private void btnBack_Click(object sender, RoutedEventArgs e)
        {
            ClassHelper.NavigationClass.navFrame.Navigate(new AdminPanelPages());
        }
    }
}
