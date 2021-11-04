using SaloonSharm.DbModel;
using SaloonSharm.Helpers;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Interaction logic for OrderPage.xaml
    /// </summary>
    public partial class OrderPage : Page
    {
        public OrderPage()
        {
            InitializeComponent();

            PageHelper.PageName.Text = "Сотрудники";

            var employee = PageHelper.ConnectDb.Employee;

            dgOrder.ItemsSource = employee.ToList();
            cmbPosition.ItemsSource = PageHelper.ConnectDb.Position.ToList();
        }

        private void dgOrder_CurrentCellChanged(object sender, EventArgs e)
        {
            PageHelper.ConnectDb.SaveChanges();
        }

        private void btnWatchClRecords_Click(object sender, RoutedEventArgs e)
        {
            var selectedEmployee = dgOrder.SelectedItem as Employee;

            if (PageHelper.ConnectDb.Order.Where(x => x.EmployeeId == selectedEmployee.Id).FirstOrDefault() != null)
            {
                if (MessageBox.Show("Вы хотите перейти к списку записей?", "Внимание", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    PageHelper.MainFrame.Navigate(new RecordsPage(selectedEmployee.Id));
                }
            }
            else
            {
                MessageBox.Show("Для данного работника записи не найдены", "Ошибка");
            }
        }
    }
}
