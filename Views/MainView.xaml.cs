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

namespace 知识产权数字化平台.Views
{
    /// <summary>
    /// MainView.xaml 的交互逻辑
    /// </summary>
    public partial class MainView : UserControl
    {
        private List<Expander> expanders = new List<Expander>();
        public MainView()
        {
            InitializeComponent();
        }

        private void TextBlock_MouseUp(object sender, MouseButtonEventArgs e)
        {

        }

        private void expander1_Expanded(object sender, RoutedEventArgs e)
        {
            Expander expander = (Expander)sender;
            if (expander == null) return;
            foreach (var item in expanders)
            {
                if (item.Name != expander.Name)
                {
                    item.IsExpanded = false;
                }
            }
        }
    }
}
