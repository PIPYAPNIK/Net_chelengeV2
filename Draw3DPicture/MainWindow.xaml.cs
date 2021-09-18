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

namespace Draw3DPicture
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DrawPicture();
        }

        private void DrawPicture()
        {
            int xLength = (int)canvas.Width;
            int yLength = (int)canvas.Height;
            int step = yLength / 50;

            for (int y = 0; y <= yLength; y += step)
            {
                DrawLine(0, y, yLength - y, 0);
                DrawLine(xLength, y, xLength - y, yLength);
            }
        }

        private void DrawLine(int x1, int y1, int x2, int y2)
        {
            var line = new Line();
            line.Stroke = Brushes.CadetBlue;
            line.X1 = x1;
            line.Y1 = y1;
            line.X2 = x2;
            line.Y2 = y2;

            canvas.Children.Add(line);
        }
    }
}
