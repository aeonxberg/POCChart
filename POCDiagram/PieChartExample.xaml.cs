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
using LiveCharts;
using LiveCharts.Wpf;
using System.ComponentModel;

namespace POCDiagram
{
    public partial class PieChartExample : UserControl, INotifyPropertyChanged
    {
        // Series Series => new PieSeries<string> { "Kevin" };
        //change

        public SeriesCollection PieSeriesCollection { get; set; }

        public PieChartExample()
        {
            PointLabel = chartPoint => $"{chartPoint.Y} ({chartPoint.Participation:P})";

            PieSeriesCollection = new SeriesCollection
            {
                new PieSeries //Dit is een slice
                {
                    Title = "Juan",
                    Values = new ChartValues<int> {7},
                    DataLabels = true,
                    PushOut = 5,
                    LabelPoint = PointLabel
                },
                new PieSeries //Dit is een slice
                {
                    Title = "Maria",
                    Values = new ChartValues<int> {3},
                    DataLabels = true,
                    PushOut = 5,
                    LabelPoint = PointLabel
                },
                new PieSeries //Dit is een slice
                {
                    Title = "Pepe",
                    Values = new ChartValues<int> {2},
                    DataLabels = true,
                    PushOut = 5,
                    LabelPoint = PointLabel
                }
            };

            InitializeComponent();
        }

        public Func<ChartPoint, string> PointLabel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}