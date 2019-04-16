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

namespace StockMarketCharts
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.SizeChanged += OnWindowSizeChanged;
        }

        private void OnWindowSizeChanged(object sender, SizeChangedEventArgs e)
        {
            ChartCanvas.Children.Clear();
            Dispatcher.BeginInvoke(new Action(() => DrawChart(e.NewSize.Height, e.NewSize.Width)), System.Windows.Threading.DispatcherPriority.Normal);
        }

        private void DrawChart(double height, double width)
        {
            // ChartCanvas.Children.Clear();

            Line xAxis = new Line
            {
                Stroke = Brushes.Black,
                X1 = 10,
                Y1 = height - 100,

                X2 = width - 100,
                Y2 = height - 100,

                StrokeThickness = 2
            };

            Line yAxis = new Line
            {
                Stroke = Brushes.Black,
                X1 = 10,
                Y1 = height - 100,

                X2 = 10,
                Y2 = 10,

                StrokeThickness = 2
            };

            ChartCanvas.Children.Add(xAxis);
            ChartCanvas.Children.Add(yAxis);
        }
    }
}
