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
using System.Windows.Shapes;
using prac2DS.BeautySalDataSetTableAdapters;

namespace prac2DS
{
    /// <summary>
    /// Логика взаимодействия для wndBooking.xaml
    /// </summary>
    public partial class wndBooking : Window
    {

        BookingsTableAdapter bookingsTableAdapter=new BookingsTableAdapter();
        public wndBooking()
        {
            InitializeComponent();
            dgBooking.ItemsSource=bookingsTableAdapter.GetData();
        }
    }
}
