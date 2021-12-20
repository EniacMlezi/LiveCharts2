﻿using System.Collections.Generic;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;

namespace ViewModelsSamples.Axes.LabelsFormat;

public class ViewModel
{
    public ViewModel()
    {
        Series = new ISeries[]
        {
            new ColumnSeries<double> { Values = new double[] { 426, 583, 104 } },
            new LineSeries<double> { Values = new double[] { 200, 558, 458 }, Fill = null },
        };

        XAxes = new List<Axis>
        {
            new Axis
            {
                Name = "Salesman/woman",
                NamePaint = new SolidColorPaint { Color = SKColors.Red },
                Labels = new string[] { "Sergio", "Lando", "Lewis" },
                LabelsRotation = 15
            }
        };

        YAxes = new List<Axis>
        {
            new Axis
            {
                Name = "Sales amount",
                NamePadding = new LiveChartsCore.Drawing.Padding(0, 15),

                // Now the Y axis we will display it as currency
                // LiveCharts provides some common formatters
                // in this case we are using the currency formatter.
                Labeler = Labelers.Currency

                // you could also build your own currency formatter
                // for example:
                // Labeler = (value) => value.ToString("C")

                // But the one that LiveCharts provides creates shorter labels when
                // the amount is in millions or trillions
            }
        };
    }

    public IEnumerable<ISeries> Series { get; set; }
    public List<Axis> XAxes { get; set; }
    public List<Axis> YAxes { get; set; }
}
