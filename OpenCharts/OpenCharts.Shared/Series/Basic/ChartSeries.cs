﻿namespace OpenCharts.Charts.Series;

/// <summary>
/// Series
/// </summary>
public abstract class ChartSeries : IChartSeries
{
    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    public string Name { get; set; }

    /// <summary>
    /// Gets or sets the title.
    /// </summary>
    /// <value>
    /// The title.
    /// </value>
    public string Title { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether [show label].
    /// </summary>
    /// <value>
    ///   <c>true</c> if [show label]; otherwise, <c>false</c>.
    /// </value>
    public bool ShowLabel { get; set; }

    /// <summary>
    /// Gets or sets the type.
    /// </summary>
    /// <value>
    /// The type.
    /// </value>
    public ChartType Type { get; set; }

    /// <summary>
    /// Gets or sets the data.
    /// </summary>
    /// <value>
    /// The data.
    /// </value>
    public IChartSeriesData Data { get; set; }

    /// <summary>
    /// Draws the asynchronous.
    /// </summary>
    /// <param name="src">The source.</param>
    /// <returns>Mat or Skia</returns>
    public abstract Task<object> DrawAsync(object src);
}
