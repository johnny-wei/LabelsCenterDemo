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

namespace Navigation
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public labelResult Result { set; get; }
        public MainWindow()
        {
            Result = new labelResult();
            InitializeComponent();
        }

   

      

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<producet> lp = new List<producet>();
            lp.Add(new producet { 产品类别编码 = "89757", 产品类别名称 = "猪用饲料" });
            lp.Add(new producet { 产品类别编码 = "89758", 产品类别名称 = "鸡用饲料" });
          //  dg.ItemsSource = lp;
            List<ProductLabel> lpl = new List<ProductLabel>();
            lpl.Add(new ProductLabel { 产品类别编码 = "89757", 产品类别名称 = "猪用饲料", 状态 = "已通过" });
            lpl.Add(new ProductLabel { 产品类别编码 = "89758", 产品类别名称 = "鸡用饲料", 状态 = "审核中" });
            productLabel.ItemsSource = lpl;
            List<ProductCategory> lpc = new List<ProductCategory>();
            lpc.Add(new ProductCategory
            {
                分类编号 = "89757",
                分类名称 = "猪用饲料",
                包含产品 = "232334i,3434234i",
                内模板 = "D:\\TestImg\\A类内.btw",
                外模板 = "D:\\TestImg\\A类外.btw"
            });
            lpc.Add(new ProductCategory
            {
                分类编号 = "89758",
                分类名称 = "鸡用饲料",
                包含产品 = "232335i,3434235i",
                内模板 = "D:\\TestImg\\B类内.btw",
                外模板 = "D:\\TestImg\\B类外.btw"
            });
      
            productCategory.ItemsSource = lpc;

        }


        private void TextBlock_MouseDown(object sender, MouseButtonEventArgs e)
        {
            TextBlock tb = (TextBlock)sender;
            Productm pm = new Productm();
            pm.Owner = this;
            pm.classno = tb.Text;
            pm.ShowDialog();
   
        }

 

        private void label_MouseDown(object sender, MouseButtonEventArgs e)
        {
           g1.Visibility = Visibility.Visible;
            g2.Visibility = Visibility.Hidden;
            g3.Visibility = Visibility.Hidden;
        }

        private void label1_MouseDown(object sender, MouseButtonEventArgs e)
        {
            g1.Visibility = Visibility.Hidden;
            g2.Visibility = Visibility.Visible;
            g3.Visibility = Visibility.Hidden;
        }

        private void label2_MouseDown(object sender, MouseButtonEventArgs e)
        {
            g1.Visibility = Visibility.Hidden;
            g2.Visibility = Visibility.Hidden;
            g3.Visibility = Visibility.Visible;
        }

        private void PreviewLabel(object sender, RoutedEventArgs e)
        {
            PreviewLabel pl = new PreviewLabel();
            pl.ShowDialog();
        }
        private void modifyLabel(object sender,RoutedEventArgs e) {
            ModifyLabel ml = new ModifyLabel();
            ml.ShowDialog();
        }
        private void sendtoSH(object sender, RoutedEventArgs e) {

        }
        public void updateContainProduct(object sender, RoutedEventArgs e) {
            UpdateContainProduct ucp = new UpdateContainProduct();
            ucp.ShowDialog();
        }
        public void Query(int size, int pageIndex)
        {
            Result.Total = LabelBean.LabelBeans.Count;
            Result.Labels = LabelBean.LabelBeans.Skip((pageIndex - 1) * size).Take(size).ToList();

        }

        private void PagingDataGrid_PagingChanged(object sender, CustomControlLibrary.PagingChangedEventArgs args)
        {
            Query(args.PageSize, args.PageIndex);
        }
    }
    class producet {
       public string 产品类别编码 { set; get; }
       public string 产品类别名称 { set; get; }
    }
    class ProductLabel {
        public string 产品类别编码 { set; get; }
        public string 产品类别名称 { set; get; }
        public string 状态 { set; get; }    
    }
    class ProductCategory {
        public string 分类编号 { set; get; }
        public string 分类名称 { set; get; }
        public string 包含产品 { set; get; }
        public string 外模板 { set; get; }
        public string 内模板 { set; get; }
    }



}
