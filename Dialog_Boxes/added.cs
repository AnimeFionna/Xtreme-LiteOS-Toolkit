using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000013 RID: 19
	public partial class added : Form
	{
		// Token: 0x06000170 RID: 368
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000171 RID: 369 RVA: 0x00036460 File Offset: 0x00034660
		public added()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(added.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000013 RID: 19
		// (get) Token: 0x06000172 RID: 370 RVA: 0x000364B0 File Offset: 0x000346B0
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

		// Token: 0x06000173 RID: 371
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000174 RID: 372
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000175 RID: 373 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000364E0 File Offset: 0x000346E0
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				added.ReleaseCapture();
				added.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000309 RID: 777
		private Point mouseOffset;

		// Token: 0x0400030A RID: 778
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400030B RID: 779
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400030C RID: 780
		public const int HT_CAPTION = 2;
	}
}
