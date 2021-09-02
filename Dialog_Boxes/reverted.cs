using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000017 RID: 23
	public partial class reverted : Form
	{
		// Token: 0x06000195 RID: 405
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000196 RID: 406 RVA: 0x00037BCC File Offset: 0x00035DCC
		public reverted()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(reverted.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000017 RID: 23
		// (get) Token: 0x06000197 RID: 407 RVA: 0x00037C1C File Offset: 0x00035E1C
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

		// Token: 0x06000198 RID: 408
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000199 RID: 409
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600019A RID: 410 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x0600019B RID: 411 RVA: 0x00037C4C File Offset: 0x00035E4C
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				reverted.ReleaseCapture();
				reverted.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000331 RID: 817
		private Point mouseOffset;

		// Token: 0x04000332 RID: 818
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000333 RID: 819
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000334 RID: 820
		public const int HT_CAPTION = 2;
	}
}
