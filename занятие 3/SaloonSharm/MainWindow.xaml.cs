using SaloonSharm.DbModel;
using SaloonSharm.Helpers;
using SaloonSharm.Pages;
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

namespace SaloonSharm
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            PageHelper.ConnectDb = new SaloonDbEntities();
            PageHelper.PageName = pageName;
            PageHelper.MainFrame = mainFrame;
            PageHelper.MainFrame.Navigate(new OrderPage());//(new SignInPage());
        }
    }
}
