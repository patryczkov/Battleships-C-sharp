using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships
{
    class Square
    {
        Rectangle rectangle = new Rectangle();

        public int posX, posY, width, height;

        public Square(Canvas canvas, int posX, int posY, Coord coord)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(255, 255, 255);
            rectangle.Fill = color;
            rectangle.Stroke = Brushes.Black;
            width = 50;
            height = 50;
            rectangle.Width = width;
            rectangle.Height = height;
            Label label = new Label();
            label.Content = coord.YAxis.ToString() + coord.XAxis.ToString();
            

            this.posX = posX;
            this.posY = posY;

            Canvas.SetLeft(rectangle, posX);
            Canvas.SetTop(rectangle, posY);

            Canvas.SetLeft(label, posX);
            Canvas.SetTop(label, posY);

            canvas.Children.Add(rectangle);
            canvas.Children.Add(label);
        }
    }
}
