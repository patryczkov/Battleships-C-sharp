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
        public bool isPlayer { get; set; }
        public bool isShip { get; set; }

        public Square(Canvas canvas, int posX, int posY, int id, bool isPlayer)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(255, 255, 255);
            rectangle.Fill = color;

            rectangle.Stroke = Brushes.Black;
            this.isPlayer = isPlayer;

            width = 50;
            height = 50;
            rectangle.Width = width;
            rectangle.Height = height;

            this.posX = posX;
            this.posY = posY;

            Canvas.SetLeft(rectangle, posX);
            Canvas.SetTop(rectangle, posY);

            if(!isPlayer)
                rectangle.MouseLeftButtonDown += OnMouseDown;

            canvas.Children.Add(rectangle);
        }

        public void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (GameManager.playerTurn)
            {
                Console.WriteLine("PlayerShoot");
                isMiss = true;
                CheckTypeOfSquare();
                GameManager.cpuTurn = true;
                GameManager.playerTurn = false;
                MainWindow.TurnTextBlock.Text = "Turn ==>";
                MainWindow.gameManager.HandleTurns();
            }
        }

        public void CheckTypeOfSquare()
        {
            if (isHit)
                rectangle.Fill = Brushes.Red;
            else if (isShip)
                rectangle.Fill = Brushes.Green;
            else
                rectangle.Fill = Brushes.Blue;
        }
    }
}
