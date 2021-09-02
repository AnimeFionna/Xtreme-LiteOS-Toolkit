using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000015 RID: 21
	public partial class Error : Form
	{
		// Token: 0x06000182 RID: 386
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000183 RID: 387 RVA: 0x00036E88 File Offset: 0x00035088
		public Error()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(Error.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000015 RID: 21
		// (get) Token: 0x06000184 RID: 388 RVA: 0x00036ED8 File Offset: 0x000350D8
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

		// Token: 0x06000185 RID: 389
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000186 RID: 390
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000187 RID: 391 RVA: 0x00036F08 File Offset: 0x00035108
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				Error.ReleaseCapture();
				Error.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x06000188 RID: 392 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click_1(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000189 RID: 393 RVA: 0x00002370 File Offset: 0x00000570
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x0400031B RID: 795
		private Point mouseOffset;

		// Token: 0x0400031C RID: 796
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400031D RID: 797
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400031E RID: 798
		public const int HT_CAPTION = 2;
	}
}
