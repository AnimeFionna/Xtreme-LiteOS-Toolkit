using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200001B RID: 27
	public class RJToggleButton : CheckBox
	{
		// Token: 0x1700001B RID: 27
		// (get) Token: 0x060001B4 RID: 436 RVA: 0x00038C70 File Offset: 0x00036E70
		// (set) Token: 0x060001B5 RID: 437 RVA: 0x00038C88 File Offset: 0x00036E88
		[Category("RJ Code Advance")]
		public Color OnBackColor
		{
			get
			{
				return this.onBackColor;
			}
			set
			{
				this.onBackColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x060001B6 RID: 438 RVA: 0x00038C9C File Offset: 0x00036E9C
		// (set) Token: 0x060001B7 RID: 439 RVA: 0x00038CB4 File Offset: 0x00036EB4
		[Category("RJ Code Advance")]
		public Color OnToggleColor
		{
			get
			{
				return this.onToggleColor;
			}
			set
			{
				this.onToggleColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x060001B8 RID: 440 RVA: 0x00038CC8 File Offset: 0x00036EC8
		// (set) Token: 0x060001B9 RID: 441 RVA: 0x00038CE0 File Offset: 0x00036EE0
		[Category("RJ Code Advance")]
		public Color OffBackColor
		{
			get
			{
				return this.offBackColor;
			}
			set
			{
				this.offBackColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x060001BA RID: 442 RVA: 0x00038CF4 File Offset: 0x00036EF4
		// (set) Token: 0x060001BB RID: 443 RVA: 0x00038D0C File Offset: 0x00036F0C
		[Category("RJ Code Advance")]
		public Color OffToggleColor
		{
			get
			{
				return this.offToggleColor;
			}
			set
			{
				this.offToggleColor = value;
				base.Invalidate();
			}
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x060001BC RID: 444 RVA: 0x00038D20 File Offset: 0x00036F20
		// (set) Token: 0x060001BD RID: 445 RVA: 0x00002095 File Offset: 0x00000295
		[Browsable(false)]
		public override string Text
		{
			get
			{
				return base.Text;
			}
			set
			{
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x060001BE RID: 446 RVA: 0x00038D38 File Offset: 0x00036F38
		// (set) Token: 0x060001BF RID: 447 RVA: 0x00038D50 File Offset: 0x00036F50
		[Category("RJ Code Advance")]
		[DefaultValue(true)]
		public bool SolidStyle
		{
			get
			{
				return this.solidStyle;
			}
			set
			{
				this.solidStyle = value;
				base.Invalidate();
			}
		}

		// Token: 0x060001C0 RID: 448 RVA: 0x00038D64 File Offset: 0x00036F64
		public RJToggleButton()
		{
			this.MinimumSize = new Size(45, 22);
		}

		// Token: 0x060001C1 RID: 449 RVA: 0x00038DBC File Offset: 0x00036FBC
		private GraphicsPath GetFigurePath()
		{
			int num = base.Height - 1;
			Rectangle rect = new Rectangle(0, 0, num, num);
			Rectangle rect2 = new Rectangle(base.Width - num - 2, 0, num, num);
			GraphicsPath graphicsPath = new GraphicsPath();
			graphicsPath.StartFigure();
			graphicsPath.AddArc(rect, 90f, 180f);
			graphicsPath.AddArc(rect2, 270f, 180f);
			graphicsPath.CloseFigure();
			return graphicsPath;
		}

		// Token: 0x060001C2 RID: 450 RVA: 0x00038E34 File Offset: 0x00037034
		protected override void OnPaint(PaintEventArgs pevent)
		{
			int num = base.Height - 5;
			pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
			pevent.Graphics.Clear(base.Parent.BackColor);
			bool @checked = base.Checked;
			if (@checked)
			{
				bool flag = this.solidStyle;
				if (flag)
				{
					pevent.Graphics.FillPath(new SolidBrush(this.onBackColor), this.GetFigurePath());
				}
				else
				{
					pevent.Graphics.DrawPath(new Pen(this.onBackColor, 2f), this.GetFigurePath());
				}
				pevent.Graphics.FillEllipse(new SolidBrush(this.onToggleColor), new Rectangle(base.Width - base.Height + 1, 2, num, num));
			}
			else
			{
				bool flag2 = this.solidStyle;
				if (flag2)
				{
					pevent.Graphics.FillPath(new SolidBrush(this.offBackColor), this.GetFigurePath());
				}
				else
				{
					pevent.Graphics.DrawPath(new Pen(this.offBackColor, 2f), this.GetFigurePath());
				}
				pevent.Graphics.FillEllipse(new SolidBrush(this.offToggleColor), new Rectangle(2, 2, num, num));
			}
		}

		// Token: 0x0400034D RID: 845
		private Color onBackColor = Color.MediumSlateBlue;

		// Token: 0x0400034E RID: 846
		private Color onToggleColor = Color.WhiteSmoke;

		// Token: 0x0400034F RID: 847
		private Color offBackColor = Color.Gray;

		// Token: 0x04000350 RID: 848
		private Color offToggleColor = Color.Gainsboro;

		// Token: 0x04000351 RID: 849
		private bool solidStyle = true;
	}
}
