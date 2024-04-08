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
using System.Data.SqlClient;
using System.Data;
using System.Reflection.Emit;
using System.Threading;


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
        AutoSchoolEntities e = new AutoSchoolEntities();

        private void btnSigIn_Click(object sender, RoutedEventArgs e)
        {
            string[] mas = new string[] { tbxLoggin.Text, psbPassword.Password };
            for (int i = 0; i < mas.Length; i++)
            {
                if (!ValidationClass.ValidationNotClearString(mas[i]))
                {
                    MessageBox.Show("Заполните все строки");
                    return;
                }
            }

            var userAuth = Context.Employee.Where(y => y.Loggin == tbxLoggin.Text && y.Password == psbPassword.Password).FirstOrDefault();
            if (userAuth == null)
            {
                MessageBox.Show("Неверный Логин или Пароль", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            
            switch (userAuth.IdPost)
            { 
                case 4:
                    InvoiseUser(userAuth, userAuth.IdPost);
                    NavigationClass.navFrame.Navigate(new AdminPanelPages());
                    return;

                default:
                    InvoiseUser(userAuth, userAuth.IdPost);
                    NavigationClass.navFrame.Navigate(new UserPanelPage());
                    return;
            }
        }

        private void InvoiseUser(Employee UserAuth, int Position)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-S0HAMEM;Initial Catalog=AutoSchool;Integrated Security=True");
            string Sql = $"select top 1 Title from [dbo].[Employee] e join [dbo].[Post] p on e.IdPost = p.Id where e.IdPost = '{Position}'";
            SqlCommand scmd = new SqlCommand(Sql, con);
            con.Open();
            SqlDataReader sur = scmd.ExecuteReader();

            while (sur.Read())
            {
                string Title = sur["Title"].ToString();
                LogginUser.Position = Title;
                LogginUser.Employee = UserAuth;
            }
            con.Close();
        }
    }
}
