using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace WpfApp12.Models
{
    public class Ellipse_model
    {
        private Ellipse ellipse = new Ellipse();
        public Ellipse _Ellipse
        {
            get { return ellipse; }
            set { ellipse = value; }

        }
        public Ellipse_model()
        {
            _Ellipse.Width = 50;
            _Ellipse.Height = 50;
            _Ellipse.Fill = Brushes.Transparent;
            _Ellipse.StrokeThickness = 15;
            _Ellipse.Stroke = new ImageBrush(new BitmapImage(new Uri(@"C:\\Users\\kasta\\source\\repos\\WpfApp12\\sampleImages\\index.000jpg.jpg", UriKind.Relative)));
        }
    }
}
