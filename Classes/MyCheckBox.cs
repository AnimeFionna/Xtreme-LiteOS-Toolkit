using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x02000019 RID: 25
	internal class MyCheckBox : CheckBox
	{
		// Token: 0x060001A7 RID: 423 RVA: 0x000386BB File Offset: 0x000368BB
		public MyCheckBox()
		{
			this.TextAlign = ContentAlignment.MiddleRight;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x060001A8 RID: 424 RVA: 0x000386D0 File Offset: 0x000368D0
		// (set) Token: 0x060001A9 RID: 425 RVA: 0x000386E8 File Offset: 0x000368E8
		public override bool AutoSize
		{
			get
			{
				return base.AutoSize;
			}
			set
			{
				base.AutoSize = false;
			}
		}

		// Token: 0x060001AA RID: 426 RVA: 0x000386F4 File Offset: 0x000368F4
		protected override void OnPaint(PaintEventArgs e)
		{
			base.OnPaint(e);
			int num = base.ClientSize.Height - 2;
			Rectangle rectangle = new Rectangle(new Point(0, 1), new Size(num, num));
			ControlPaint.DrawCheckBox(e.Graphics, rectangle, base.Checked ? ButtonState.Checked : ButtonState.Normal);
		}
	}
}
