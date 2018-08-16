using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace ListBoxGallery
{
    public class ListBoxItemCustom
    {
        
        public BitmapImage ImageItem { get; set; } // картинка
        public string Title { get; set; } // название
        public double Angle { get; set; } // угол наклона
    }
}