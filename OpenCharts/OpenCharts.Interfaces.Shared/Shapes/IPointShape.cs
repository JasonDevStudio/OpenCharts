﻿namespace OpenCharts.Shapes;

/// <summary>
/// Shape
/// </summary>
public interface IPointShape
{
    /// <summary>
    /// Gets or sets the paint.
    /// </summary>
    /// <value>
    /// The paint.
    /// </value>
    OpenPaint FillPaint { get; set; }

    /// <summary>
    /// Gets or sets the paint.
    /// </summary>
    /// <value>
    /// The paint.
    /// </value>
    OpenPaint StrokePaint { get; set; }

    /// <summary>
    /// Gets or sets the name.
    /// </summary>
    /// <value>
    /// The name.
    /// </value>
    string Name { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is fill.
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is fill; otherwise, <c>false</c>.
    /// </value>
    bool IsFill { get; set; }

    /// <summary>
    /// Gets or sets the type of the shape.
    /// </summary>
    /// <value>
    /// The type of the shape.
    /// </value>
    ShapeTypes ShapeType { get; set; }

    /// <summary>
    /// Gets or sets the points.The PTS.多边形点集合，包含几个矩阵，就绘制几个多边形
    /// </summary>
    /// <value>
    /// The points.
    /// </value>
    IEnumerable<OpenPoint> Points { get; set; }
     
    /// <summary>
    /// Gets or sets the radius.圆半径
    /// </summary>
    /// <value>
    /// The radius.
    /// </value>
    int Radius { get; set; }

    /// <summary>
    /// Gets or sets the axes.椭圆长轴和短轴长度为边界的矩形区域，椭圆就绘制在这个矩形区域
    /// </summary>
    /// <value>
    /// The axes.
    /// </value>
    OpenSize Axes { get; set; }

    /// <summary>
    /// Gets or sets the angle.偏转的角度（逆时针旋转）
    /// </summary>
    /// <value>
    /// The angle.
    /// </value>
    double Angle { get; set; }

    /// <summary>
    /// Gets or sets the start angle.圆弧起始角的角度（逆时针旋转）
    /// </summary>
    /// <value>
    /// The start angle.
    /// </value>
    double StartAngle { get; set; }

    /// <summary>
    /// Gets or sets the end angle.圆弧终结角的角度（逆时针旋转）
    /// </summary>
    /// <value>
    /// The end angle.
    /// </value>
    double EndAngle { get; set; }

    /// <summary>
    /// Gets or sets the thickness. 线条粗细
    /// </summary>
    /// <value>
    /// The thickness.
    /// </value>
    int Thickness { get; set; }

    /// <summary>
    /// Gets or sets a value indicating whether this instance is closed.
    /// if set to <c>true</c> [is closed]. 是否闭合，如为False，您将获得连接所有点的折线，而不是闭合形状
    /// </summary>
    /// <value>
    ///   <c>true</c> if this instance is closed; otherwise, <c>false</c>.
    /// </value>
    bool IsClosed { get; set; }

    /// <summary>
    /// Gets or sets the shift.缩放参数 中心坐标和轴值中的小数位数
    /// </summary>
    /// <value>
    /// The shift.
    /// </value>
    int Shift { get; set; }

    /// <summary>
    /// Gets or sets the offset.偏移
    /// </summary>
    /// <value>
    /// The offset.
    /// </value>
    OpenPoint Offset { get; set; }

    /// <summary>
    /// Draws the specified src.
    /// </summary>
    /// <param name="src">The src.</param>
    /// <param name="point">The point.</param>
    /// <param name="size">The size.</param>
    void Draw(object src, OpenPoint point, OpenSize size);
}
