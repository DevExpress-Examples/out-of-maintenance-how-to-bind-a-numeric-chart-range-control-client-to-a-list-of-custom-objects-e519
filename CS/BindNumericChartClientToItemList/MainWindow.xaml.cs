using System;
using System.Collections.Generic;
using System.Windows;

namespace BindNumericChartClientToItemList {

    public class NumericItem {
        public object Argument { get; set; }
        public object Value { get; set; }
    }

    public partial class MainWindow : Window {

        const int dataCount = 10;
        List<NumericItem> data = new List<NumericItem>();
        Random rand = new Random();

        List<NumericItem> GenerateNumericData() {
            for (int i = 0; i < dataCount; i++) {
                data.Add(new NumericItem() {
                    Argument = i,
                    Value = rand.Next(0, 30) + i
                });
            }
            return data;
        }

        public MainWindow() {
            InitializeComponent();
            this.DataContext = GenerateNumericData();
        }
    }
}
