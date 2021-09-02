using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000014 RID: 20
	public partial class cleared : Form
	{
		// Token: 0x06000179 RID: 377
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600017A RID: 378 RVA: 0x00036978 File Offset: 0x00034B78
		public cleared()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(cleared.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000014 RID: 20
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000369C8 File Offset: 0x00034BC8
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

		// Token: 0x0600017C RID: 380
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600017D RID: 381
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600017E RID: 382 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600017F RID: 383 RVA: 0x000369F8 File Offset: 0x00034BF8
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				cleared.ReleaseCapture();
				cleared.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000312 RID: 786
		private Point mouseOffset;

		// Token: 0x04000313 RID: 787
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000314 RID: 788
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000315 RID: 789
		public const int HT_CAPTION = 2;
	}
}
