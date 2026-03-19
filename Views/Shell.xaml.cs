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

namespace 知识产权数字化平台.Views
{
    /// <summary>
    /// Shell.xaml 的交互逻辑
    /// </summary>
    public partial class Shell : Window
    {
        public Shell()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_CloseMainWindow(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Button_Min(object sender, RoutedEventArgs e)
        {
            this.WindowState=WindowState.Minimized;
        }

        private void Button_Max(object sender, RoutedEventArgs e)
        {
            this.WindowState= WindowState.Maximized;
        }
    }
}
