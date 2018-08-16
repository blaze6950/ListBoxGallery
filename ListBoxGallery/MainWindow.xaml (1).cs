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

namespace ListBoxGallery
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"example1.jpg", UriKind.Relative);
            bi.EndInit();
            var newImage = new Image
            {
                Stretch = Stretch.Uniform,
                Source = bi
            };
            var listBoxItemCustom = new ListBoxItemCustom() {ImageItem = bi, Title = "Example1"};
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            listBox.Items.Add(listBoxItemCustom);
            //Image2.Source = bi;
        }
    }
}
