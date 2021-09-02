using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000E RID: 14
	public partial class custom : Form
	{
		// Token: 0x0600010E RID: 270
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600010F RID: 271 RVA: 0x0002B38C File Offset: 0x0002958C
		public custom()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(custom.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x1700000E RID: 14
		// (get) Token: 0x06000110 RID: 272 RVA: 0x0002B3DC File Offset: 0x000295DC
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

		// Token: 0x06000111 RID: 273 RVA: 0x0002B40B File Offset: 0x0002960B
		private void button7_Click(object sender, EventArgs e)
		{
			Process.Start("explorer.exe", "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\");
			base.Close();
		}

		// Token: 0x06000112 RID: 274 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000113 RID: 275
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000114 RID: 276
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000115 RID: 277 RVA: 0x0002B428 File Offset: 0x00029628
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				custom.ReleaseCapture();
				custom.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000267 RID: 615
		private Point mouseOffset;

		// Token: 0x04000268 RID: 616
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000269 RID: 617
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400026A RID: 618
		public const int HT_CAPTION = 2;
	}
}
