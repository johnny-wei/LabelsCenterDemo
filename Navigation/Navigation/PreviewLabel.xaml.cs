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

namespace Navigation
{
    /// <summary>
    /// PreviewLabel.xaml 的交互逻辑
    /// </summary>
    public partial class PreviewLabel : Window
    {

        public PreviewLabel()
        {
            InitializeComponent();

        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
      
            BitmapImage bi = new BitmapImage();
            // BitmapImage.UriSource must be in a BeginInit/EndInit block.  
            bi.BeginInit();
            bi.UriSource = new Uri(@"D:\\TestImg\\11170112071.jpg", UriKind.RelativeOrAbsolute);
            bi.EndInit();

            image.Source = bi;
        }
    }
}
