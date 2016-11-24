using System.Collections.Generic;
using System.Windows;
using LiveCharts;
using LiveCharts.Wpf;
using System.ComponentModel;

namespace POCDiagram
{
    public partial class CartesianChartExample
    {
        public SeriesCollection CartesianSeriesCollection { get; set; }
        public Axis CartesianAxis { get; set; }

        private Visibility _availabilityVisibility = Visibility.Visible;
        private Visibility _plannedVisibility = Visibility.Visible;

        public CartesianChartExample()
        {
           NameList = new List<string> {"Fred", "Udolf", "Carl", "Kriss", "Yarick", "Otis", "Ugo"};

            CartesianSeriesCollection = new SeriesCollection()
            {
                //Dagen per maand
                new ColumnSeries()
                {
                    Title = "Beschikbaar",
                    Values = new ChartValues<int> {25, 26, 27, 27, 28, 26, 22}, //Elk value is van een ander persoon -> Zie Axis Labels
                    Visibility = Availability,
                    MaxWidth = 1000,
                    ColumnPadding = 0
                },

                new ColumnSeries()
                {
                    Title = "Ingepland",
                    Values = new ChartValues<int> {20, 22, 22, 25, 25, 20},
                    Visibility = Planned,
                    MaxWidth = 1000,
                    ColumnPadding = 0
                }

            };
            
            CartesianAxis = new Axis()
            {
                Labels = NameList,
                Separator = new Separator()
                    {Step = 1}
            };

            InitializeComponent();
        }

        public Visibility Availability
        {
            get { return _availabilityVisibility; }
            set
            {
                _availabilityVisibility = value;
                OnPropertyChanged("Availability");
            }
        }

        public Visibility Planned
        {
            get { return _plannedVisibility; }
            set
            {
                _plannedVisibility = value;
                OnPropertyChanged("Planned");
            }
        }

        public List<string> NameList { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}