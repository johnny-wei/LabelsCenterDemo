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
    /// Window1.xaml 的交互逻辑
    /// </summary>
    public partial class Productm : Window
    {
        public string classno { set; get; }
        public Productm()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            //提交新的数据到数据库，并更新父页面
            MainWindow mw = (MainWindow)Owner;
            List<producet> lp = new List<producet>();
            lp.Add(new producet { 产品类别编码 = "89759", 产品类别名称 = "鱼用饲料" });
            lp.Add(new producet { 产品类别编码 = "89760", 产品类别名称 = "牛用饲料" });
           // mw.dg.ItemsSource = lp;
            Close();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            textBox.Text = classno;
            List<string> ls = new List<string>();
            ls.Add("猪用饲料");
            ls.Add("鸡用饲料");
            ls.Add("鱼用饲料");
            ls.Add("羊用饲料");
            comboBox.ItemsSource =ls;
            comboBox.SelectedItem = "鱼用饲料";

        }

        
    }
}
