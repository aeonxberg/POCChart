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

namespace POCDiagram
{
    /// <summary>
    /// Interaction logic for HeatMapExample.xaml
    /// </summary>
    public partial class HeatMapExample
    {
        public HeatMapExample()
        {
            InitializeComponent();
            var r = new Random();

            Values = new Dictionary<string, double>();
            /*Values = values*/

            /*Fill with random values*/
            Values["3558"] = r.Next(0, 100); //Noord Brabant
            Values["3559"] = r.Next(0, 100); //Utrecht
            Values["3560"] = r.Next(0, 100); //Zuid Holland
            Values["3557"] = r.Next(0, 100); //Noord Holland
            Values["914"] = r.Next(0, 100); //Drenthe
            Values["913"] = r.Next(0, 100); //Friesland
            Values["915"] = r.Next(0, 100); //Gelderland
            Values["918"] = r.Next(0, 100); //Groningen
            Values["917"] = r.Next(0, 100); //Overijssel
            Values["1511"] = r.Next(0, 100); //Flevoland
            Values["1508"] = r.Next(0, 100); //Zeeland
            //TODO: Enums for provinces?

            LanguagePack = new Dictionary<string, string>();
            LanguagePack["NL"] = "Netherlands"; // Change to Dutch Language

            DataContext = this;
        }

        public Dictionary<string, double> Values { get; set; }
        public Dictionary<string, string> LanguagePack { get; set; }
    }
}