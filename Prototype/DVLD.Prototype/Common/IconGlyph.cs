using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using DVLD.Prototype.Theme;

namespace DVLD.Prototype.Common
{
    /// <summary>
    /// Self-drawn flat vector icon (no bitmap/font assets). Consistent 1.8px
    /// stroke, rounded joins, single tint color driven by AppTheme. Used in
    /// place of the original app's mismatched/reused bitmap icon set.
    /// </summary>
    [DefaultProperty("Icon")]
    public class IconGlyph : Control
    {
        private IconKind _icon = IconKind.Info;
        private Color _tint = AppTheme.Navy;

        public IconGlyph()
        {
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint |
                      ControlStyles.OptimizedDoubleBuffer | ControlStyles.ResizeRedraw |
                      ControlStyles.SupportsTransparentBackColor, true);
            BackColor = System.Drawing.Color.Transparent;
            Size = new Size(24, 24);
        }

        [Category("Appearance")]
        public IconKind Icon
        {
            get { return _icon; }
            set { _icon = value; Invalidate(); }
        }

        [Category("Appearance")]
        public Color Tint
        {
            get { return _tint; }
            set { _tint = value; Invalidate(); }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            var g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;
            var r = ClientRectangle;
            r.Inflate(-2, -2);
            float sw = System.Math.Max(1.6f, r.Width / 12f);
            using (var pen = new Pen(_tint, sw) { StartCap = LineCap.Round, EndCap = LineCap.Round, LineJoin = LineJoin.Round })
            using (var brush = new SolidBrush(_tint))
            {
                DrawIcon(g, pen, brush, r);
            }
        }

        private void DrawIcon(Graphics g, Pen pen, SolidBrush brush, Rectangle r)
        {
            switch (_icon)
            {
                case IconKind.Person:
                case IconKind.PersonAdd:
                    {
                        int headD = r.Width / 2;
                        var head = new Rectangle(r.X + (r.Width - headD) / 2, r.Y, headD, headD);
                        g.DrawEllipse(pen, head);
                        var body = new RectangleF(r.X + r.Width * 0.12f, r.Y + r.Height * 0.55f, r.Width * 0.76f, r.Height * 0.5f);
                        using (var path = RoundedTop(body, r.Width * 0.3f))
                            g.DrawPath(pen, path);
                        if (_icon == IconKind.PersonAdd)
                        {
                            g.DrawLine(pen, r.Right - 2, r.Y + r.Height * 0.55f, r.Right - 2, r.Bottom);
                            g.DrawLine(pen, r.Right - 2 - r.Width * 0.18f, r.Y + r.Height * 0.78f, r.Right - 2 + r.Width * 0.18f, r.Y + r.Height * 0.78f);
                        }
                        break;
                    }
                case IconKind.People:
                    {
                        var head1 = new Rectangle(r.X, r.Y + r.Height / 6, r.Width * 2 / 5, r.Width * 2 / 5);
                        var head2 = new Rectangle(r.X + r.Width * 3 / 5, r.Y + r.Height / 6, r.Width * 2 / 5, r.Width * 2 / 5);
                        g.DrawEllipse(pen, head1);
                        g.DrawEllipse(pen, head2);
                        g.DrawArc(pen, r.X - r.Width / 8, r.Bottom - r.Height / 3, r.Width * 3 / 5, r.Height / 2, 200, 140);
                        g.DrawArc(pen, r.X + r.Width * 2 / 5, r.Bottom - r.Height / 3, r.Width * 3 / 5, r.Height / 2, 200, 140);
                        break;
                    }
                case IconKind.IdCard:
                    {
                        g.DrawRectangle(pen, r);
                        var photo = new Rectangle(r.X + 2, r.Y + 2, r.Width / 3, r.Height - 4);
                        g.DrawEllipse(pen, photo.X + photo.Width / 4, photo.Y + 1, photo.Width / 2, photo.Width / 2);
                        float ly = r.Y + r.Height * 0.65f;
                        g.DrawLine(pen, photo.Right + 3, r.Y + r.Height * 0.3f, r.Right - 3, r.Y + r.Height * 0.3f);
                        g.DrawLine(pen, photo.Right + 3, ly, r.Right - 3, ly);
                        break;
                    }
                case IconKind.Mail:
                    {
                        g.DrawRectangle(pen, r);
                        g.DrawLine(pen, r.X, r.Y, r.X + r.Width / 2, r.Y + r.Height / 2);
                        g.DrawLine(pen, r.Right, r.Y, r.X + r.Width / 2, r.Y + r.Height / 2);
                        break;
                    }
                case IconKind.Phone:
                    {
                        using (var path = new GraphicsPath())
                        {
                            path.AddArc(r.X, r.Y, r.Width * 0.7f, r.Height * 0.7f, 90, 180);
                            g.DrawArc(pen, r.X, r.Y + r.Height * 0.05f, r.Width * 0.65f, r.Height * 0.65f, 120, 220);
                        }
                        g.DrawLine(pen, r.X + r.Width * 0.15f, r.Bottom - r.Height * 0.15f, r.Right, r.Bottom - r.Height * 0.15f);
                        g.DrawLine(pen, r.X + r.Width * 0.55f, r.Y + r.Height * 0.05f, r.Right, r.Y + r.Height * 0.5f);
                        break;
                    }
                case IconKind.Address:
                    {
                        PointF[] pts = {
                            new PointF(r.X + r.Width / 2f, r.Y),
                            new PointF(r.X, r.Y + r.Height * 0.45f),
                            new PointF(r.X + r.Width * 0.2f, r.Y + r.Height * 0.45f),
                            new PointF(r.X + r.Width * 0.2f, r.Bottom),
                            new PointF(r.Right - r.Width * 0.2f, r.Bottom),
                            new PointF(r.Right - r.Width * 0.2f, r.Y + r.Height * 0.45f),
                            new PointF(r.Right, r.Y + r.Height * 0.45f),
                        };
                        g.DrawLines(pen, pts);
                        break;
                    }
                case IconKind.Calendar:
                    {
                        var body = new Rectangle(r.X, r.Y + r.Height / 6, r.Width, r.Height - r.Height / 6);
                        g.DrawRectangle(pen, body);
                        g.DrawLine(pen, body.X, body.Y + body.Height / 4, body.Right, body.Y + body.Height / 4);
                        g.DrawLine(pen, r.X + r.Width / 4, r.Y, r.X + r.Width / 4, body.Y + 3);
                        g.DrawLine(pen, r.Right - r.Width / 4, r.Y, r.Right - r.Width / 4, body.Y + 3);
                        break;
                    }
                case IconKind.Globe:
                    {
                        g.DrawEllipse(pen, r);
                        g.DrawEllipse(pen, r.X + r.Width * 0.28f, r.Y, r.Width * 0.44f, r.Height);
                        g.DrawLine(pen, r.X, r.Y + r.Height / 2, r.Right, r.Y + r.Height / 2);
                        break;
                    }
                case IconKind.Gender:
                    {
                        g.DrawEllipse(pen, r.X, r.Y + r.Height * 0.3f, r.Width * 0.6f, r.Width * 0.6f);
                        g.DrawLine(pen, r.X + r.Width * 0.45f, r.Y + r.Height * 0.35f, r.Right, r.Y);
                        g.DrawLine(pen, r.Right - r.Width * 0.25f, r.Y, r.Right, r.Y);
                        g.DrawLine(pen, r.Right, r.Y, r.Right, r.Y + r.Height * 0.25f);
                        break;
                    }
                case IconKind.Car:
                    {
                        var body = new RectangleF(r.X, r.Y + r.Height * 0.35f, r.Width, r.Height * 0.35f);
                        using (var path = RoundedTop(body, r.Width * 0.25f))
                            g.DrawPath(pen, path);
                        g.DrawEllipse(pen, r.X + r.Width * 0.08f, r.Bottom - r.Height * 0.22f, r.Width * 0.22f, r.Width * 0.22f);
                        g.DrawEllipse(pen, r.Right - r.Width * 0.3f, r.Bottom - r.Height * 0.22f, r.Width * 0.22f, r.Width * 0.22f);
                        break;
                    }
                case IconKind.Search:
                    {
                        var circle = new Rectangle(r.X, r.Y, (int)(r.Width * 0.68f), (int)(r.Width * 0.68f));
                        g.DrawEllipse(pen, circle);
                        g.DrawLine(pen, circle.Right - 2, circle.Bottom - 2, r.Right, r.Bottom);
                        break;
                    }
                case IconKind.Money:
                    {
                        g.DrawEllipse(pen, r);
                        using (var f = new Font("Segoe UI", r.Height * 0.5f, System.Drawing.FontStyle.Bold))
                        {
                            var sz = g.MeasureString("$", f);
                            g.DrawString("$", f, brush, r.X + (r.Width - sz.Width) / 2, r.Y + (r.Height - sz.Height) / 2);
                        }
                        break;
                    }
                case IconKind.Lock:
                    {
                        var body = new Rectangle(r.X, r.Y + r.Height * 2 / 5, r.Width, r.Height * 3 / 5);
                        g.DrawRectangle(pen, body);
                        g.DrawArc(pen, r.X + r.Width / 5, r.Y, r.Width * 3 / 5, r.Height * 2 / 5, 180, 180);
                        break;
                    }
                case IconKind.Test:
                    {
                        g.DrawRectangle(pen, r.X + r.Width / 6, r.Y, r.Width * 2 / 3, r.Height);
                        g.DrawLine(pen, r.X + r.Width / 3, r.Y + r.Height / 4, r.Right - r.Width / 3, r.Y + r.Height / 4);
                        g.DrawLine(pen, r.X + r.Width / 3, r.Y + r.Height / 2, r.Right - r.Width / 3, r.Y + r.Height / 2);
                        g.DrawLine(pen, r.X + r.Width / 3, r.Y + r.Height * 3 / 4, r.Right - r.Width / 2, r.Y + r.Height * 3 / 4);
                        break;
                    }
                case IconKind.History:
                    {
                        g.DrawArc(pen, r, 40, 280);
                        var c = new PointF(r.X + r.Width / 2f, r.Y + r.Height / 2f);
                        g.DrawLine(pen, c.X, c.Y, c.X, c.Y - r.Height * 0.3f);
                        g.DrawLine(pen, c.X, c.Y, c.X + r.Width * 0.2f, c.Y);
                        break;
                    }
                case IconKind.Warning:
                    {
                        PointF[] tri = { new PointF(r.X + r.Width / 2f, r.Y), new PointF(r.X, r.Bottom), new PointF(r.Right, r.Bottom) };
                        g.DrawPolygon(pen, tri);
                        g.DrawLine(pen, r.X + r.Width / 2f, r.Y + r.Height * 0.4f, r.X + r.Width / 2f, r.Y + r.Height * 0.68f);
                        g.FillEllipse(brush, r.X + r.Width / 2f - 1.2f, r.Y + r.Height * 0.78f, 2.4f, 2.4f);
                        break;
                    }
                case IconKind.Close:
                    {
                        g.DrawLine(pen, r.X, r.Y, r.Right, r.Bottom);
                        g.DrawLine(pen, r.Right, r.Y, r.X, r.Bottom);
                        break;
                    }
                case IconKind.Save:
                    {
                        g.DrawRectangle(pen, r);
                        var inner = new Rectangle(r.X + r.Width / 4, r.Y, r.Width / 2, r.Height / 3);
                        g.DrawRectangle(pen, inner);
                        break;
                    }
                case IconKind.Edit:
                    {
                        g.DrawLine(pen, r.X, r.Bottom, r.X + r.Width * 0.65f, r.Y + r.Height * 0.35f);
                        g.DrawLine(pen, r.X + r.Width * 0.65f, r.Y + r.Height * 0.35f, r.Right, r.Y + r.Height * 0.7f);
                        g.DrawLine(pen, r.Right, r.Y + r.Height * 0.7f, r.X + r.Width * 0.35f, r.Bottom);
                        g.DrawLine(pen, r.X, r.Bottom, r.X + r.Width * 0.35f, r.Bottom);
                        break;
                    }
                case IconKind.Delete:
                    {
                        g.DrawRectangle(pen, r.X + r.Width / 6, r.Y + r.Height / 5, r.Width * 2 / 3, r.Height * 4 / 5);
                        g.DrawLine(pen, r.X, r.Y + r.Height / 5, r.Right, r.Y + r.Height / 5);
                        g.DrawLine(pen, r.X + r.Width / 3, r.Y, r.Right - r.Width / 3, r.Y);
                        break;
                    }
                case IconKind.Check:
                    {
                        g.DrawEllipse(pen, r);
                        g.DrawLine(pen, r.X + r.Width * 0.25f, r.Y + r.Height * 0.5f, r.X + r.Width * 0.45f, r.Y + r.Height * 0.7f);
                        g.DrawLine(pen, r.X + r.Width * 0.45f, r.Y + r.Height * 0.7f, r.X + r.Width * 0.75f, r.Y + r.Height * 0.3f);
                        break;
                    }
                case IconKind.Error:
                    {
                        g.DrawEllipse(pen, r);
                        g.DrawLine(pen, r.X + r.Width * 0.3f, r.Y + r.Height * 0.3f, r.Right - r.Width * 0.3f, r.Bottom - r.Height * 0.3f);
                        g.DrawLine(pen, r.Right - r.Width * 0.3f, r.Y + r.Height * 0.3f, r.X + r.Width * 0.3f, r.Bottom - r.Height * 0.3f);
                        break;
                    }
                case IconKind.Info:
                    {
                        g.DrawEllipse(pen, r);
                        g.FillEllipse(brush, r.X + r.Width / 2f - 1.2f, r.Y + r.Height * 0.24f, 2.4f, 2.4f);
                        g.DrawLine(pen, r.X + r.Width / 2f, r.Y + r.Height * 0.45f, r.X + r.Width / 2f, r.Bottom - r.Height * 0.2f);
                        break;
                    }
                case IconKind.SignOut:
                    {
                        var doorR = new Rectangle(r.X, r.Y, (int)(r.Width * 0.6f), r.Height);
                        g.DrawRectangle(pen, doorR);
                        g.DrawLine(pen, r.X + r.Width * 0.35f, r.Y + r.Height / 2, r.Right, r.Y + r.Height / 2);
                        g.DrawLine(pen, r.Right - r.Width * 0.25f, r.Y + r.Height * 0.3f, r.Right, r.Y + r.Height / 2);
                        g.DrawLine(pen, r.Right - r.Width * 0.25f, r.Y + r.Height * 0.7f, r.Right, r.Y + r.Height / 2);
                        break;
                    }
                case IconKind.ChevronRight:
                    {
                        g.DrawLine(pen, r.X + r.Width * 0.3f, r.Y, r.X + r.Width * 0.7f, r.Y + r.Height / 2);
                        g.DrawLine(pen, r.X + r.Width * 0.7f, r.Y + r.Height / 2, r.X + r.Width * 0.3f, r.Bottom);
                        break;
                    }
                case IconKind.Filter:
                    {
                        PointF[] pts = {
                            new PointF(r.X, r.Y), new PointF(r.Right, r.Y),
                            new PointF(r.X + r.Width * 0.6f, r.Y + r.Height * 0.55f),
                            new PointF(r.X + r.Width * 0.6f, r.Bottom),
                            new PointF(r.X + r.Width * 0.4f, r.Bottom - r.Height * 0.2f),
                            new PointF(r.X + r.Width * 0.4f, r.Y + r.Height * 0.55f),
                        };
                        g.DrawPolygon(pen, pts);
                        break;
                    }
            }
        }

        private static GraphicsPath RoundedTop(RectangleF r, float radius)
        {
            var path = new GraphicsPath();
            path.AddArc(r.X, r.Y, radius, radius, 180, 90);
            path.AddArc(r.Right - radius, r.Y, radius, radius, 270, 90);
            path.AddLine(r.Right, r.Y + radius / 2, r.Right, r.Bottom);
            path.AddLine(r.Right, r.Bottom, r.X, r.Bottom);
            path.AddLine(r.X, r.Bottom, r.X, r.Y + radius / 2);
            path.CloseFigure();
            return path;
        }
    }
}
