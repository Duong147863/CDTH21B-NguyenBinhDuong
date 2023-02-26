using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace Đồ_Án_C_Shape.Resources
{
    public class btnDangnhap : Button
    {

       public btnDangnhap() {
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            int radius = 20; // Đặt bán kính cho viền cong tại đây

            path.AddArc(0, 0, radius * 2, radius * 2, 180, 90);
            path.AddArc(this.Width - (radius * 2), 0, radius * 2, radius * 2, 270, 90);
            path.AddArc(this.Width - (radius * 2), this.Height - (radius * 2), radius * 2, radius * 2, 0, 90);
            path.AddArc(0, this.Height - (radius * 2), radius * 2, radius * 2, 90, 90);

            this.Region = new Region(path);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            using (Pen pen = new Pen(Color.Red, 1.75f))
            {
                pen.Alignment = PenAlignment.Inset;
                e.Graphics.DrawPath(pen, path);
            }

            e.Graphics.SetClip(path);
            base.OnPaint(e);
        }
    }
}
