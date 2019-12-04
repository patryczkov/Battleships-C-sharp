using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships
{
    public class Square
    {
        Rectangle rectangle = new Rectangle();

        public int posX, posY, width, height;

        public bool isHit { get; set; }
        public bool isMiss { get; set; }

        public Square(Canvas canvas, int posX, int posY, int id)
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

            rectangle.MouseLeftButtonDown += OnMouseDown;

            canvas.Children.Add(rectangle);
        }

        public void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (GameManager.playerTurn)
            {
                Console.WriteLine("PlayerShoot");
                isHit = true;
                CheckTypeOfSquare();
                GameManager.cpuTurn = true;
                GameManager.playerTurn = false;
                MainWindow.gameManager.HandleTurns();
            }
        }

        public string CheckTypeOfSquare()
        {
            if (isHit)
            {
                rectangle.Fill = Brushes.Red;
                return "hit";
            }
            else
            {
                rectangle.Fill = Brushes.Blue;
                return "miss";
            }
        }
    }
}
