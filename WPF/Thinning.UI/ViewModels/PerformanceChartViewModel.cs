﻿namespace Thinning.UI.ViewModels
{
    using System;
    using System.Collections.Generic;
    using Caliburn.Micro;
    using LiveCharts;
    using LiveCharts.Wpf;

    public class PerformanceChartViewModel : Screen
    {
        public PerformanceChartViewModel()
        {
        }

        public PerformanceChartViewModel(List<double> values, string displayName)
        {
            this.DisplayName = displayName;

            var testValues = new ChartValues<double>(values);

            this.SeriesCollection = new SeriesCollection
            {
                new ColumnSeries
                {
                    Title = "Execute time (Ms)",
                    Values = testValues,
                },
            };

            var labels = new string[10];

            for (int i = 0; i < 10; i++)
            {
                labels[i] = $"Run {i + 1}";
            }

            this.Labels = labels;
            this.Formatter = value => value.ToString("N");
        }

        public SeriesCollection SeriesCollection { get; set; }

        public string[] Labels { get; set; }

        public Func<double, string> Formatter { get; set; }
    }
}