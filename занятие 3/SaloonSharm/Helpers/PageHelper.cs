using SaloonSharm.DbModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SaloonSharm.Helpers
{
    class PageHelper
    {
        public static Frame MainFrame;
        public static TextBlock PageName;
        public static SaloonDbEntities ConnectDb = new SaloonDbEntities();
    }
}
