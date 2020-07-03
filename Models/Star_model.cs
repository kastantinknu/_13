using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp12.Models
{
    public class Star_model
    {
        private Polygon star = new Polygon();
        public Polygon _Star
        {
            get { return star; }
            set { star = value; }

        }
        private PointCollection star_PointCollection = new PointCollection();
        public PointCollection _Star_PointCollection
        {
            get { return star_PointCollection; }
            set { star_PointCollection = value; }
        }

        public void Moving(int _x, int _y)
        {
            PointCollection _Starollection1 = new PointCollection();
            System.Windows.Point Point1_star = new System.Windows.Point(44 + _x, 18 + _y);
            System.Windows.Point Point2_star = new System.Windows.Point(47 + _x, 39 + _y);
            System.Windows.Point Point3_star = new System.Windows.Point(67 + _x, 33 + _y);
            System.Windows.Point Point4_star = new System.Windows.Point(50 + _x, 44 + _y);
            System.Windows.Point Point5_star = new System.Windows.Point(66 + _x, 57 + _y);
            System.Windows.Point Point6_star = new System.Windows.Point(47 + _x, 50 + _y);
            System.Windows.Point Point7_star = new System.Windows.Point(44 + _x, 71 + _y);
            System.Windows.Point Point8_star = new System.Windows.Point(41 + _x, 50 + _y);
            System.Windows.Point Point9_star = new System.Windows.Point(22 + _x, 55 + _y);
            System.Windows.Point Point10_star = new System.Windows.Point(38 + _x, 44 + _y);
            System.Windows.Point Point11_star = new System.Windows.Point(22 + _x, 33 + _y);
            System.Windows.Point Point12_star = new System.Windows.Point(41 + _x, 39 + _y);
            _Starollection1.Add(Point1_star);
            _Starollection1.Add(Point2_star);
            _Starollection1.Add(Point3_star);
            _Starollection1.Add(Point4_star);
            _Starollection1.Add(Point5_star);
            _Starollection1.Add(Point6_star);
            _Starollection1.Add(Point7_star);
            _Starollection1.Add(Point8_star);
            _Starollection1.Add(Point9_star);
            _Starollection1.Add(Point10_star);
            _Starollection1.Add(Point11_star);
            _Starollection1.Add(Point12_star);
            _Star.Points = _Starollection1;
            _Star.Stroke = System.Windows.Media.Brushes.DarkRed;
            _Star.Fill = System.Windows.Media.Brushes.Yellow;
            _Star.StrokeThickness = 2;
        }
        public Star_model()
        {
            System.Windows.Point Point1_star = new System.Windows.Point(44, 18);
            System.Windows.Point Point2_star = new System.Windows.Point(47, 39);
            System.Windows.Point Point3_star = new System.Windows.Point(67, 33);
            System.Windows.Point Point4_star = new System.Windows.Point(50, 44);
            System.Windows.Point Point5_star = new System.Windows.Point(66, 57);
            System.Windows.Point Point6_star = new System.Windows.Point(47, 50);
            System.Windows.Point Point7_star = new System.Windows.Point(44, 71);
            System.Windows.Point Point8_star = new System.Windows.Point(41, 50);
            System.Windows.Point Point9_star = new System.Windows.Point(22, 55);
            System.Windows.Point Point10_star = new System.Windows.Point(38, 44);
            System.Windows.Point Point11_star = new System.Windows.Point(22, 33);
            System.Windows.Point Point12_star = new System.Windows.Point(41, 39);
            PointCollection _Starollection = new PointCollection();
            _Starollection.Add(Point1_star);
            _Starollection.Add(Point2_star);
            _Starollection.Add(Point3_star);
            _Starollection.Add(Point4_star);
            _Starollection.Add(Point5_star);
            _Starollection.Add(Point6_star);
            _Starollection.Add(Point7_star);
            _Starollection.Add(Point8_star);
            _Starollection.Add(Point9_star);
            _Starollection.Add(Point10_star);
            _Starollection.Add(Point11_star);
            _Starollection.Add(Point12_star);
            _Star.Points = _Starollection;
            _Star.Stroke = System.Windows.Media.Brushes.DarkRed;
            _Star.Fill = System.Windows.Media.Brushes.Yellow;
            _Star.StrokeThickness = 2;
        }
    }
}
