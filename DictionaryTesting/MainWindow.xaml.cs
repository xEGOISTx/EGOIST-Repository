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
//using System.Windows.Controls.DataVisualization.Charting;
using LiveCharts;

namespace DictionaryTesting
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Dictionary<int, int> test = new Dictionary<int, int>();
        LiveCharts.Wpf.ColumnSeries colS;
       

        public MainWindow()
        {
            InitializeComponent();

            DataContext = this;

            test.Add(1, 2);
            test.Add(3, 4);
            //colS.Values = new ChartValues()
            ///ch.Series.Add(colS)
           // Method();
        }

        void Method()
        {
            //IReadOnlyDictionary<int, IReadOnlyDictionary<int,int>> d = new Dictionary<int, IReadOnlyDictionary<int,int>>();

            //(d as Dictionary<int, IReadOnlyDictionary<int, int>>).Add(1, new Dictionary<int, int>());
            //(d[1] as Dictionary<int, int>).Add(2, 3);

            DateTime d1 = new DateTime(0002, 1, 1);
            DateTime d2 = d1.Subtract(new TimeSpan(365, 0, 0, 0, 0));

        }

        public Dictionary<int, int> Test
        {
            get { return test; }
        }

        public string[] Labels
        {
            get { return new string[2] { "01.01.2017", "02.01.2017" }; } 
        }

        public ChartValues<int> L
        {
            get { return new ChartValues<int> { 10, 20, 30,40,50,60 }; }
        }
    }
}
