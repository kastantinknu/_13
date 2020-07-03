using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Media;
using System.Windows.Shapes;

namespace WpfApp12.Models
{
    public class Rectangle_model
    {
        private Polygon rectangle = new Polygon();
        public Polygon _Rectangle
        {
            get { return rectangle; }
            set { rectangle = value; }

        }
        public Rectangle_model()
        {
            System.Windows.Point Point1 = new System.Windows.Point(130, 100);
            System.Windows.Point Point2 = new System.Windows.Point(170, 100);
            System.Windows.Point Point3 = new System.Windows.Point(170, 200);
            System.Windows.Point Point4 = new System.Windows.Point(130, 200);
            PointCollection myPointCollection = new PointCollection();
            myPointCollection.Add(Point1);
            myPointCollection.Add(Point2);
            myPointCollection.Add(Point3);
            myPointCollection.Add(Point4);
            rectangle.Points = myPointCollection;
            rectangle.Fill = System.Windows.Media.Brushes.Green;
        }
    }
}
