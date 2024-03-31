using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoSchool.ClassHelper;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static AutoSchool.ClassHelper.EF;
using AutoSchool.DataBase;


namespace AutoSchool.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }


        private void btnSigIn_Click(object sender, RoutedEventArgs e)
        {
            string[] mas = new string[] { tbxLoggin.Text, psbPassword.Password };
            for (int i = 0; i < mas.Length; i++)
            {
                if (!ValidationClass.ValidationNotClearString(mas[i]))
                {
                    MessageBox.Show("Заполните все строки");
                    break;
                }

                var userAuth = Context.Employee.Where(y => y.Loggin == tbxLoggin.Text && y.Password == psbPassword.Password).FirstOrDefault();
                if (userAuth == null)
                {
                    MessageBox.Show("Пользователь не найден", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                    return;
                }

                switch (userAuth.IdPost)
                {
                    case 1:
                        InvoiseUser(userAuth, "");

                        NavigationClass.navFrame.Navigate(new Pages.AdminPage());
                        break;

                    case 2:
                        
                        MessageBox.Show("Руководитель");
                        break;

                    case 3:


                        MessageBox.Show("Учитель");
                        break;

                    case 4:
  

                        MessageBox.Show("Админ");
                        break;

                    default:
                        break;
                }
            }
        }

        private void InvoiseUser(Employee UserAuth, string Position)
        { 
        }
        private void btnEnter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSignCatalog_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
