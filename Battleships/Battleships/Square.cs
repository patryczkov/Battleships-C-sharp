using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships
{
    public class Square
    {
        Rectangle rectangle;

        public int posX, posY, width, height, id;

        public Coord Coord { get; private set; }
        public bool isHit { get; set; }
        public bool isMiss { get; set; }
        public bool IsShip { get; set; }
        public bool IsOccupied { get; set; }
        public Canvas Canvas { get; set; }
  
        public Rectangle Rectangle { get => rectangle; set => rectangle = value; }

        public bool Isclicked { get; set; }

        public Square(Canvas canvas, int posX, int posY, Coord coord, int id)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(255, 255, 255);
            Rectangle = new Rectangle();
            
            Rectangle.Fill = color;

            Rectangle.Stroke = Brushes.Black;
            IsOccupied = false;

            width = 50;
            height = 50;
            Rectangle.Width = width;
            Rectangle.Height = height;
            Canvas = canvas;
            this.posX = posX;
            this.posY = posY;
            this.Coord = coord;
            Label label = new Label();
            label.Content = id;
            

            Canvas.SetLeft(Rectangle, posX);
            Canvas.SetTop(Rectangle, posY);
            Canvas.SetLeft(label, posX);
            Canvas.SetTop(label, posY);

            Rectangle.MouseLeftButtonDown += OnRectangleMouseLeftButtonDown;
            
            canvas.Children.Add(Rectangle);
            canvas.Children.Add(label);
        }

        public void OnRectangleMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Isclicked = true;
            if (CheckTypeOfSquare().Equals("hit"))
            {
                Rectangle.Fill = Brushes.Red;
            }
            else if (CheckTypeOfSquare().Equals("ship"))
            {
                Rectangle.Fill = Brushes.Green;
            }
            else if (CheckTypeOfSquare().Equals("occupied"))
            {
                Rectangle.Fill = Brushes.Yellow;
            }
            else
            {
                Rectangle.Fill = Brushes.Blue;
            }
        }

        public string CheckTypeOfSquare()
        {
            if (isHit)
            {
                Rectangle.Fill = Brushes.Red;
                return "hit";
            }
            else if (IsShip)
            {
                Rectangle.Fill = Brushes.Green;
                return "ship";
            }
            else if (IsOccupied)
            {
                Rectangle.Fill = Brushes.Yellow;
                return "occupied";
            }
            else
            {
                Rectangle.Fill = Brushes.Blue;
                return "miss";
            }


        }
    }
}