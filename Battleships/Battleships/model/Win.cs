using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Battleships.model
{
    public class Win
    {
        public Canvas Canvas { get; set; }

        public Win(Canvas canvas)
        {
           
            Rectangle rectangle = new Rectangle();
            SolidColorBrush color = new SolidColorBrush();
            Label label = new Label();

            Canvas = canvas;

            color.Color = Color.FromRgb(255, 0, 50);
            

            rectangle.Fill = color;
            rectangle.Width = 400;
            rectangle.Height = 300;
            label.Content = "  You won the match!";
            label.FontSize = 40;
            
           

            Canvas.SetLeft(label, 400);
            Canvas.SetTop(label, 350);

            Canvas.SetLeft(rectangle, 400);
            Canvas.SetTop(rectangle, 250);

            Canvas.Children.Add(rectangle);
            Canvas.Children.Add(label);





        }
    }
}
