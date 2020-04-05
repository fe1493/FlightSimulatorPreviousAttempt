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

namespace FlightSimulatorApp.Views
{
    /// <summary>
    /// Interaction logic for Joystick.xaml
    /// </summary>
    public partial class Joystick : UserControl
    {
        private Point firstPoint = new Point();
        public Joystick()
        {
            InitializeComponent();
        }
        //public double XCoordinates
        //{
        //    get { return (double)GetValue(XCoordinatesProperty); }
        //    set { SetValue(XCoordinatesProperty, value); }
        //}

        //public static readonly DependencyProperty XCoordinatesProperty = DependencyProperty.Register("XCoordinates", typeof(double), typeof(Joystick), new PropertyMetadata(0));
        //public static readonly DependencyProperty YCoordinatesProperty = DependencyProperty.Register("YCoordinates", typeof(double), typeof(Joystick), new PropertyMetadata(0));

        private void Knob_MouseUp(object sender, MouseEventArgs e)
        {
            //return to the middle once we let go of the mouse
            knobPosition.X = 0;
            knobPosition.Y = 0;
        }

        private void Knob_MouseMove(object sender, MouseEventArgs e)
        {

            if (e.LeftButton == MouseButtonState.Pressed)
            {
                double x = e.GetPosition(this).X - firstPoint.X;
                double y = e.GetPosition(this).Y - firstPoint.Y;
                if (Math.Sqrt(x * x + y * y) < (Base.Width / 2 - KnobBase.Width / 2)+10)
                {
                    knobPosition.X = x;
                    knobPosition.Y = y;
                }
 
            }
        }

        //private void Knob_MouseLeave(object sender, MouseEventArgs e)
        //{

        //    knobPosition.X = 0;
        //    knobPosition.Y = 0;

        //}

        private void Knob_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.ChangedButton == MouseButton.Left)
            {
                firstPoint = e.GetPosition(this);

            }
        }
        private void centerKnob_Completed(object sender, EventArgs e) { }



        private void Knob_MouseLeave(object sender, MouseEventArgs e)
        {

            knobPosition.X = 0;
            knobPosition.Y = 0;

        }
    }

}
