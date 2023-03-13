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

namespace Hello_World
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent(); //10101

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            txtShow.Text = "Hello World!";
        }

        private void txtShow_TextChanged(object sender, TextChangedEventArgs e)
        {
            txtShow.Text = "Hello World!";
        }
    }
}
