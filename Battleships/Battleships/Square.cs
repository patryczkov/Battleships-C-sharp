using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships
{
    class Square
    {
        Rectangle rectangle = new Rectangle();

        public int posX, posY, width, height;

        public Square(Canvas canvas, int posX, int posY)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(255, 255, 255);
            rectangle.Fill = color;
            rectangle.Stroke = Brushes.Black;
            width = 50;
            height = 50;
            rectangle.Width = width;
            rectangle.Height = height;

            this.posX = posX;
            this.posY = posY;

            Canvas.SetLeft(rectangle, posX);
            Canvas.SetTop(rectangle, posY);

            rectangle.MouseLeftButtonDown += OnRectangleMouseLeftButtonDown;

            canvas.Children.Add(rectangle);
        }

        void OnRectangleMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            rectangle.Fill = Brushes.Black;
        }
    }
}
