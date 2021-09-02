using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Classes
{
	// Token: 0x0200001A RID: 26
	public partial class applied : Form
	{
		// Token: 0x060001AB RID: 427
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x060001AC RID: 428 RVA: 0x00038750 File Offset: 0x00036950
		public applied()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(applied.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x060001AD RID: 429 RVA: 0x000387A0 File Offset: 0x000369A0
		protected override CreateParams CreateParams
		{
			get
			{
				CreateParams createParams = base.CreateParams;
				CreateParams createParams2 = createParams;
				createParams2.ClassStyle |= 131072;
				return createParams;
			}
		}

		// Token: 0x060001AE RID: 430
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060001AF RID: 431
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060001B0 RID: 432 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x000387D0 File Offset: 0x000369D0
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				applied.ReleaseCapture();
				applied.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000344 RID: 836
		private Point mouseOffset;

		// Token: 0x04000345 RID: 837
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000346 RID: 838
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000347 RID: 839
		public const int HT_CAPTION = 2;
	}
}
