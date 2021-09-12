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
            int XLength = (int)canvas.Width;
            int YLength = (int)canvas.Height;
            int step = YLength / 50;

            for (int y = 0; y <= YLength; y += step)
            {
                DrawLine(0, y, XLength - y, 0);
                DrawLine(XLength, y, XLength - y, YLength);
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
