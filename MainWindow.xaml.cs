using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
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
using WpfApp12.Models;

namespace WpfApp12
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            canvas.Children.Add(star_Model._Star);
            canvas.Children.Add(rectangle_Model._Rectangle);
            canvas.Children.Add(ellipse_Model._Ellipse);
            ellipse_Model._Ellipse.MouseMove += El_MouseMove;
            star_Model._Star.MouseMove += _Star_MouseMove;
        }

        Ellipse_model ellipse_Model = new Ellipse_model();
        Star_model star_Model = new Star_model();
        Rectangle_model rectangle_Model = new Rectangle_model();

        int mX_star = 0;
        int mY_star = 0;
        int mX_ellipse = 0;
        int mY_ellipse = 0;

        public void Moving_star(MouseEventArgs e)
        {
            canvas.Children.Clear();
            //прямоугольник
            canvas.Children.Add(rectangle_Model._Rectangle);
            //звездочка
            mX_star = (int)e.GetPosition(canvas).X;
            mY_star = (int)e.GetPosition(canvas).Y;
            star_Model.Moving(mX_star - 43, mY_star - 44);
            canvas.Children.Add(star_Model._Star);
            //кольцо
            canvas.Children.Add(ellipse_Model._Ellipse);
        }

        public void Moving_ellipse(MouseEventArgs e)
        {
            canvas.Children.Clear();
            //прямоугольник
            canvas.Children.Add(rectangle_Model._Rectangle);
            //звездочка
            canvas.Children.Add(star_Model._Star);
            //кольцо
            mX_ellipse = (int)e.GetPosition(canvas).X;
            mY_ellipse = (int)e.GetPosition(canvas).Y;
            ellipse_Model._Ellipse.SetValue(Canvas.LeftProperty, (Double)mX_ellipse - 25);
            ellipse_Model._Ellipse.SetValue(Canvas.TopProperty, (Double)mY_ellipse - 25);
            canvas.Children.Add(ellipse_Model._Ellipse);
        }

        private void _Star_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (
                    //верх
                   ( star_Model._Star.Points[0].Y >= 10 && !(star_Model._Star.Points[0].Y >= 200 && star_Model._Star.Points[0].Y <= 205 && star_Model._Star.Points[0].X >= 130 && star_Model._Star.Points[0].X <= 170))

                   &&
                    (!(star_Model._Star.Points[2].Y >= 200 && star_Model._Star.Points[2].Y <= 205 && star_Model._Star.Points[2].X >= 130 && star_Model._Star.Points[2].X <= 170))
                   &&
                    (!(star_Model._Star.Points[10].Y >= 200 && star_Model._Star.Points[10].Y <= 205 && star_Model._Star.Points[10].X >= 130 && star_Model._Star.Points[10].X <= 170))
                   &&
                //право
                     (star_Model._Star.Points[2].X <= 280 && !(star_Model._Star.Points[2].X >= 125 && star_Model._Star.Points[2].X <= 130 && star_Model._Star.Points[2].Y >= 100 && star_Model._Star.Points[2].Y <= 200))
                &&
                //право2
                     (star_Model._Star.Points[4].X <= 280 && !(star_Model._Star.Points[4].X >= 125 && star_Model._Star.Points[4].X <= 130 && star_Model._Star.Points[4].Y >= 100 && star_Model._Star.Points[4].Y <= 200))
                //низ
                     &&
                  (star_Model._Star.Points[6].Y <= 290 && !(star_Model._Star.Points[6].Y >= 95 && star_Model._Star.Points[6].Y <= 100 && star_Model._Star.Points[6].X >= 130 && star_Model._Star.Points[6].X <= 170))
                     &&
                  (star_Model._Star.Points[4].Y <= 290 && !(star_Model._Star.Points[4].Y >= 95 && star_Model._Star.Points[4].Y <= 100 && star_Model._Star.Points[4].X >= 130 && star_Model._Star.Points[4].X <= 170))
                     &&
                  (star_Model._Star.Points[8].Y <= 290 && !(star_Model._Star.Points[8].Y >= 95 && star_Model._Star.Points[8].Y <= 100 && star_Model._Star.Points[8].X >= 130 && star_Model._Star.Points[8].X <= 170))

                &&
                //лево
                    (star_Model._Star.Points[8].X >= 10 && !(star_Model._Star.Points[8].X >= 170 && star_Model._Star.Points[8].X <= 175 && star_Model._Star.Points[8].Y >= 100 && star_Model._Star.Points[8].Y <= 200))
                &&
                //лево2
                    (star_Model._Star.Points[10].X >= 10 && !(star_Model._Star.Points[10].X >= 170 && star_Model._Star.Points[10].X <= 175 && star_Model._Star.Points[10].Y >= 100 && star_Model._Star.Points[10].Y <= 200))
                )
                {
                    Moving_star(e);
                }
                if (
                    (star_Model._Star.Points[0].Y <= 10 || (star_Model._Star.Points[0].Y >= 200 && star_Model._Star.Points[0].Y <= 205 && star_Model._Star.Points[0].X >= 130 && star_Model._Star.Points[0].X <= 170))
                       ||
                     ((star_Model._Star.Points[2].Y >= 200 && star_Model._Star.Points[2].Y <= 205 && star_Model._Star.Points[2].X >= 130 && star_Model._Star.Points[2].X <= 170))
                       ||
                     ((star_Model._Star.Points[10].Y >= 200 && star_Model._Star.Points[10].Y <= 205 && star_Model._Star.Points[10].X >= 130 && star_Model._Star.Points[10].X <= 170))
                       ||
                    (star_Model._Star.Points[2].X >= 280 || (star_Model._Star.Points[2].X >= 125 && star_Model._Star.Points[2].X <= 130 && star_Model._Star.Points[2].Y >= 100 && star_Model._Star.Points[2].Y <= 200))
                     ||
                       (star_Model._Star.Points[4].X >= 280 || (star_Model._Star.Points[4].X >= 125 && star_Model._Star.Points[4].X <= 130 && star_Model._Star.Points[4].Y >= 100 && star_Model._Star.Points[4].Y <= 200))
                       ||
                       (star_Model._Star.Points[6].Y >= 290 || (star_Model._Star.Points[6].Y >= 95 && star_Model._Star.Points[6].Y <= 100 && star_Model._Star.Points[6].X >= 130 && star_Model._Star.Points[6].X <= 170))
                     ||
                     (star_Model._Star.Points[4].Y >= 95 && star_Model._Star.Points[4].Y <= 100 && star_Model._Star.Points[4].X >= 130 && star_Model._Star.Points[4].X <= 170)
                     ||
                     (star_Model._Star.Points[8].Y >= 95 && star_Model._Star.Points[8].Y <= 100 && star_Model._Star.Points[8].X >= 130 && star_Model._Star.Points[8].X <= 170)
                     ||
                      (star_Model._Star.Points[8].X <= 10 || (star_Model._Star.Points[8].X >= 170 && star_Model._Star.Points[8].X <= 175 && star_Model._Star.Points[8].Y >= 100 && star_Model._Star.Points[8].Y <= 200))
                     ||
                      (star_Model._Star.Points[10].X <= 10 || (star_Model._Star.Points[10].X >= 170 && star_Model._Star.Points[10].X <= 175 && star_Model._Star.Points[10].Y >= 100 && star_Model._Star.Points[10].Y <= 200))
                  )
                {
                    if ((star_Model._Star.Points[0].Y <= 10 || (star_Model._Star.Points[0].Y >= 200 && star_Model._Star.Points[0].Y <= 205 && star_Model._Star.Points[0].X >= 130 && star_Model._Star.Points[0].X <= 170)))
                    {
                        if ((int)e.GetPosition(canvas).Y > mY_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if ((star_Model._Star.Points[2].X >= 280 || (star_Model._Star.Points[2].X >= 125 && star_Model._Star.Points[2].X <= 130 && star_Model._Star.Points[2].Y >= 100 && star_Model._Star.Points[2].Y <= 200)))
                    {
                        if ((int)e.GetPosition(canvas).X < mX_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if (((star_Model._Star.Points[2].Y >= 200 && star_Model._Star.Points[2].Y <= 205 && star_Model._Star.Points[2].X >= 130 && star_Model._Star.Points[2].X <= 170)))
                    {
                        if ((int)e.GetPosition(canvas).Y > mY_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if (((star_Model._Star.Points[10].Y >= 200 && star_Model._Star.Points[10].Y <= 205 && star_Model._Star.Points[10].X >= 130 && star_Model._Star.Points[10].X <= 170)))
                    {
                        if ((int)e.GetPosition(canvas).Y > mY_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if ((star_Model._Star.Points[4].X >= 280 || (star_Model._Star.Points[4].X >= 125 && star_Model._Star.Points[4].X <= 130 && star_Model._Star.Points[4].Y >= 100 && star_Model._Star.Points[4].Y <= 200)))
                    {
                        if ((int)e.GetPosition(canvas).X < mX_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if ((star_Model._Star.Points[6].Y >= 290 || (star_Model._Star.Points[6].Y >= 95 && star_Model._Star.Points[6].Y <= 100 && star_Model._Star.Points[6].X >= 130 && star_Model._Star.Points[6].X <= 170)))
                    {
                        if ((int)e.GetPosition(canvas).Y < mY_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if (( (star_Model._Star.Points[4].Y >= 95 && star_Model._Star.Points[4].Y <= 100 && star_Model._Star.Points[4].X >= 130 && star_Model._Star.Points[4].X <= 170)))
                    {
                        if ((int)e.GetPosition(canvas).Y < mY_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if (((star_Model._Star.Points[8].Y >= 95 && star_Model._Star.Points[8].Y <= 100 && star_Model._Star.Points[8].X >= 130 && star_Model._Star.Points[8].X <= 170)))
                    {
                        if ((int)e.GetPosition(canvas).Y < mY_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if (star_Model._Star.Points[8].X <= 10 || (star_Model._Star.Points[8].X >= 170 && star_Model._Star.Points[8].X <= 175 && star_Model._Star.Points[8].Y >= 100 && star_Model._Star.Points[8].Y <= 200))
                    {
                        if ((int)e.GetPosition(canvas).X > mX_star)
                        {
                            Moving_star(e);
                        }
                    }
                    if (star_Model._Star.Points[10].X <= 10 || (star_Model._Star.Points[10].X >= 170 && star_Model._Star.Points[10].X <= 175 && star_Model._Star.Points[10].Y >= 100 && star_Model._Star.Points[10].Y <= 200))
                    {
                        if ((int)e.GetPosition(canvas).X > mX_star)
                        {
                            Moving_star(e);
                        }
                    }
                }
            }
        }
        private void El_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
            {
                if (
                    mX_ellipse <= 300 - 41
                    &&
                    mX_ellipse >= 0 + 27
                    &&
                    mY_ellipse <= 300 - 32
                    &&
                    mY_ellipse >= 0 + 27
                    &&
                    (!(mX_ellipse >= 130 - 25 && mX_ellipse <= 135 - 25 && mY_ellipse >= 100 && mY_ellipse <= 200))
                    &&
                    (!(mX_ellipse >= 165 + 25 && mX_ellipse <= 170 + 25 && mY_ellipse >= 100 && mY_ellipse <= 200))
                    &&
                    (!(mY_ellipse >= 95 -20 && mY_ellipse <= 100 -20 && mX_ellipse >= 130 && mX_ellipse <= 170))
                    &&
                    (!(mY_ellipse >= 195 + 27 && mY_ellipse <= 200 + 27 && mX_ellipse >= 130 && mX_ellipse <= 170))


                    )
                {
                    Moving_ellipse(e);
                }
                if (
                    mX_ellipse >= 300 - 41
                    ||
                    mX_ellipse <= 0 + 27
                    ||
                    mY_ellipse >= 300 - 32
                    ||
                    mY_ellipse <= 0 + 27
                    ||
                    (mX_ellipse >= 130 - 25 && mX_ellipse <= 135 - 25 && mY_ellipse >= 100 && mY_ellipse <= 200)
                    ||
                    (mX_ellipse >= 165 + 25 && mX_ellipse <= 170 + 25 && mY_ellipse >= 100 && mY_ellipse <= 200)
                    ||
                    (mY_ellipse >= 95 - 20 && mY_ellipse <= 100 - 20 && mX_ellipse >= 130 && mX_ellipse <= 170)
                    ||
                    (mY_ellipse >= 195 + 27 && mY_ellipse <= 200 + 27 && mX_ellipse >= 130 && mX_ellipse <= 170)

                    )
                {
                    if (mX_ellipse >= 300 - 41)
                    {
                        if ((int)e.GetPosition(canvas).X < mX_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if (mX_ellipse <= 0 + 27)
                    {
                        if ((int)e.GetPosition(canvas).X > mX_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if (mY_ellipse >= 300 - 32)
                    {
                        if ((int)e.GetPosition(canvas).Y < mY_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if (mY_ellipse <= 0 + 27)
                    {
                        if ((int)e.GetPosition(canvas).Y > mY_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if ((mX_ellipse >= 130 - 25 && mX_ellipse <= 135 - 25 && mY_ellipse >= 100 && mY_ellipse <= 200))
                    {
                        if ((int)e.GetPosition(canvas).X < mX_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if ((mX_ellipse >= 165 + 25 && mX_ellipse <= 170 + 25 && mY_ellipse >= 100 && mY_ellipse <= 200))
                    {
                        if ((int)e.GetPosition(canvas).X > mX_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if ((mY_ellipse >= 95 - 20 && mY_ellipse <= 100 - 20 && mX_ellipse >= 130 && mX_ellipse <= 170))
                    {
                        if ((int)e.GetPosition(canvas).Y < mY_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }
                    if ((mY_ellipse >= 195 + 27 && mY_ellipse <= 200 + 27 && mX_ellipse >= 130 && mX_ellipse <= 170))
                    {
                        if ((int)e.GetPosition(canvas).Y > mY_ellipse)
                        {
                            Moving_ellipse(e);
                        }

                    }


                }
            }
        }
    }
}


