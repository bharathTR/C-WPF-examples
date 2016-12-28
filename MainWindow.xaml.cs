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

namespace WpfApplication3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
            public WpfApplication3.employee emp;
        public MainWindow()
        {
            InitializeComponent();
            emp = new WpfApplication3.employee { Name = "ABC", Title = "CBX" };
            DataContext = emp;
           
        }

        public void button_Click(object sender, RoutedEventArgs e)
        {
            emp.Name = "ASHA";
            emp.Title = "SE";
        }
    }
}
