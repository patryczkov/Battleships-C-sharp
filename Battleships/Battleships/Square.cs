using System;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships
{
    public class Square
    {
        public int posX, posY, width, height, id;

        public Coord Coord { get; private set; }
        public bool isHit { get; set; }
        public bool isMiss { get; set; }
        public bool IsShip { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsClicked { get; set; }
        public bool isPlayer { get; set; }
        public Canvas Canvas { get; set; }

        public Rectangle Rectangle { get; set; }

        public Square(Canvas canvas, int posX, int posY, Coord coord, int id, bool isPlayer)
        {
            SolidColorBrush color = new SolidColorBrush();
            color.Color = Color.FromRgb(255, 255, 255);
            Rectangle = new Rectangle();

            Rectangle.Fill = color;

            Rectangle.Stroke = Brushes.Black;
            IsOccupied = false;

            this.isPlayer = isPlayer;

            width = 50;
            height = 50;
            Rectangle.Width = width;
            Rectangle.Height = height;
            Canvas = canvas;
            this.posX = posX;
            this.posY = posY;
            this.Coord = coord;

            Canvas.SetLeft(Rectangle, posX);
            Canvas.SetTop(Rectangle, posY);

            if (!isPlayer)
                Rectangle.MouseLeftButtonDown += OnMouseDown;

            canvas.Children.Add(Rectangle);
        }

        public void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (GameManager.playerTurn && !IsClicked)
            {
                Console.WriteLine("PlayerShoot");
                IsClicked = true;

                if (IsShip)
                {
                    isHit = true;
                    GameManager.hitCounterPlayer += 1;
                }
                else
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
            if (IsShip)
            {
                Rectangle.Fill = Brushes.Green;
            }

            if (IsClicked)
            {
                if (isHit)
                {
                    Rectangle.Fill = Brushes.Red;
                }
                else if (isMiss)
                {
                    Rectangle.Fill = Brushes.Blue;
                }
            }
        }
    }
}