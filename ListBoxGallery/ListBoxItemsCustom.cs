using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Imaging;

namespace ListBoxGallery
{
    class ListBoxItemsCustom : System.Collections.ObjectModel.ObservableCollection<ListBoxItemCustom>
    {
        public ListBoxItemsCustom()
        {
            BitmapImage bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img1.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example1", Angle = -40 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img2.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example2", Angle = -30 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img3.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example3", Angle = -20 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img4.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example4", Angle = -10 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img5.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example5", Angle = 0 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img6.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example6", Angle = 10 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img7.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example7", Angle = 20 });
            bi = new BitmapImage();
            bi.BeginInit();
            bi.UriSource = new Uri(@"Img\img8.jpg", UriKind.Relative);
            bi.EndInit();
            this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example8", Angle = 30 });
            //bi = new BitmapImage();
            //bi.BeginInit();
            //bi.UriSource = new Uri(@"Img\img0.png", UriKind.Relative);
            //bi.EndInit();
            //this.Add(new ListBoxItemCustom() { ImageItem = bi, Title = "Example0", Angle = 40 });
        }
    }
}
