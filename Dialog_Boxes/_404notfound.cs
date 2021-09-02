using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000011 RID: 17
	public partial class _404notfound : Form
	{
		// Token: 0x0600015C RID: 348
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600015D RID: 349 RVA: 0x00034EF4 File Offset: 0x000330F4
		public _404notfound()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(_404notfound.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000011 RID: 17
		// (get) Token: 0x0600015E RID: 350 RVA: 0x00034F44 File Offset: 0x00033144
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

		// Token: 0x0600015F RID: 351
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000160 RID: 352
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000161 RID: 353 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00034F74 File Offset: 0x00033174
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				_404notfound.ReleaseCapture();
				_404notfound.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x040002E8 RID: 744
		private Point mouseOffset;

		// Token: 0x040002E9 RID: 745
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002EA RID: 746
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002EB RID: 747
		public const int HT_CAPTION = 2;
	}
}
