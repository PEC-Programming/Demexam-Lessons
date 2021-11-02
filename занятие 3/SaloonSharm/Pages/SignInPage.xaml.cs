using SaloonSharm.Helpers;
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

namespace SaloonSharm.Pages
{
    /// <summary>
    /// Interaction logic for SignInPage.xaml
    /// </summary>
    public partial class SignInPage : Page
    {
        public SignInPage()
        {
            InitializeComponent();

            PageHelper.PageName.Text = "Вход в систему";
        }

        private void btnSignIn_Click(object sender, RoutedEventArgs e)
        {
            if (tbLogin.Text == null && pbPassword.Password == null)
            {
                MessageBox.Show("Не введены данные для входа", "Ошибка ввода");
                return;
            }

            if (PageHelper.ConnectDb.Employee.Where(x => x.Login == tbLogin.Text).FirstOrDefault() == null)
            {
                MessageBox.Show("Пользователя с таким логином не существует", "Ошибка");
                return;
            }

            if (PageHelper.ConnectDb.Employee.Where(x => x.Login == tbLogin.Text && x.Password == pbPassword.Password).FirstOrDefault() != null)
            {
                MessageBox.Show($"Добро пожаловать, {tbLogin.Text}", "Успех");
                PageHelper.MainFrame.Navigate(new OrderPage());
            }
            else
            {
                MessageBox.Show("Введен неверный пароль", "Ошибка");
                return;
            }
        }
    }
}
