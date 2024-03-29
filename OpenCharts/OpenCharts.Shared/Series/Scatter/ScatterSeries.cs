﻿using OpenCharts.Charts;
using OpenCharts.Charts.Series;

namespace OpenCharts.Series.Charts.Scatter;

/// <summary>
/// Scatter
/// </summary>
public class ScatterSeries : XYChartSeries
{
    /// <summary>
    /// Gets or sets the size.
    /// </summary>
    /// <value>
    /// The size.
    /// </value>
    public OpenSize Size { get; set; }

    /// <summary>
    /// Gets the scatter data.
    /// </summary>
    /// <value>
    /// The scatter data.
    /// </value>
    public ScatterSeriesData ScatterData => (ScatterSeriesData)this.Data;

    /// <summary>
    /// Draws the asynchronous.
    /// </summary>
    /// <param name="src">The source.</param>
    /// <returns>Mat</returns>
    public override async Task<object> DrawAsync(object src)
    {
        await Task.Factory.StartNew(() =>
        {
            var data = ScatterData.DistinctBy(m=> $"{m.X}_{m.Y}" ).ToList();

            for (int i = 0; i < data.Count; i++)
            {
                var point = data[i];
                point.Shape.Draw(src, point, this.Size);
            }
        });

        return src;
    }
}
