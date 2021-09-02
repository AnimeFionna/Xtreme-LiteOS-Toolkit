using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000016 RID: 22
	public partial class removed : Form
	{
		// Token: 0x0600018C RID: 396
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600018D RID: 397 RVA: 0x000376B8 File Offset: 0x000358B8
		public removed()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(removed.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000016 RID: 22
		// (get) Token: 0x0600018E RID: 398 RVA: 0x00037708 File Offset: 0x00035908
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

		// Token: 0x0600018F RID: 399
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000190 RID: 400
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000191 RID: 401 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000192 RID: 402 RVA: 0x00037738 File Offset: 0x00035938
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				removed.ReleaseCapture();
				removed.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000328 RID: 808
		private Point mouseOffset;

		// Token: 0x04000329 RID: 809
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400032A RID: 810
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400032B RID: 811
		public const int HT_CAPTION = 2;
	}
}
