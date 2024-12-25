using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinDescCalc;
public class CalcButton : Button
{
	private int borderSize = 0;
	private int borderRadius = 50;
	private Color borderColor = Color.DodgerBlue;

	public int BorderSize { get => borderSize; set { borderSize = value; Invalidate(); } }
	public int BorderRadius { get => borderRadius; set { borderRadius = (value <= Height) ? value : Height; Invalidate(); } }
	public Color BorderColor { get => borderColor; set => borderColor = value; }
	public Color BackgroundColor { get => BackColor; set => BackColor = value; }
	public Color TextColor { get => ForeColor; set => ForeColor = value; }

    public CalcButton()
    {
		this.Size = new Size(200, 100);
		this.FlatAppearance.BorderSize = 0;
		this.FlatStyle = FlatStyle.Flat;
		this.BackColor = Color.DodgerBlue;
		this.ForeColor = Color.White;

		this.Resize += new EventHandler(Button_Resize);
    }

	protected override void OnPaint(PaintEventArgs pevent)
	{
		base.OnPaint(pevent);
		pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

		var rectSurface = new RectangleF(0, 0, Width, Height);
		var rectBorder = new RectangleF(1, 1, Width - 0.5f, Height - 1);

		if (this.borderRadius > 1)
		{
			using (var graphicsPathSurface = GetFigurePath(rectSurface, borderRadius))
			using (var graphicsPathBorder = GetFigurePath(rectBorder, borderRadius - 1f))
			using (var penSurface = new Pen(Parent.BackColor, 2))
			using (var penBorder = new Pen(borderColor, borderSize))
			{
				penBorder.Alignment = PenAlignment.Inset;
				Region = new Region(graphicsPathSurface);
				pevent.Graphics.DrawPath(penBorder, graphicsPathSurface);

				if (borderSize >= 1)
				{
					pevent.Graphics.DrawPath(penBorder, graphicsPathBorder);
				}
			}
		}
		else
		{
			Region = new Region(rectSurface);
			if (borderSize >= 1)
				using (var penBorder = new Pen(TextColor, borderSize))
				{
					penBorder.Alignment = PenAlignment.Inset;
					pevent.Graphics.DrawRectangle(penBorder, 0, 0, Width - 1, Height - 1);
				}
		}
	}

	protected override void OnHandleCreated(EventArgs e)
	{
		base.OnHandleCreated(e);
		Parent.BackColorChanged += new EventHandler(Container_BackColorChanged);
	}

	private void Container_BackColorChanged(object? sender, EventArgs e)
	{
		if (DesignMode) Invalidate();
	}
	private void Button_Resize(object? sender, EventArgs e)
	{
		if (borderRadius > Height) borderRadius = Height;
	}

	private static GraphicsPath GetFigurePath(RectangleF rect, float radius)
	{
		var graphicsPath = new GraphicsPath();
		graphicsPath.StartFigure();
		graphicsPath.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
		graphicsPath.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
		graphicsPath.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
		graphicsPath.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
		graphicsPath.CloseFigure();

		return graphicsPath;
	}
}
