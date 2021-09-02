using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000012 RID: 18
	public partial class about : Form
	{
		// Token: 0x06000165 RID: 357
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000166 RID: 358 RVA: 0x00035584 File Offset: 0x00033784
		public about()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(about.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000012 RID: 18
		// (get) Token: 0x06000167 RID: 359 RVA: 0x000355D4 File Offset: 0x000337D4
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

		// Token: 0x06000168 RID: 360 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000169 RID: 361
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600016A RID: 362
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600016B RID: 363 RVA: 0x00035604 File Offset: 0x00033804
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				about.ReleaseCapture();
				about.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000020BD File Offset: 0x000002BD
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x0600016D RID: 365 RVA: 0x0003563E File Offset: 0x0003383E
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Xtreme_LiteOS_Toolkit\\Xtreme.LiteOS.Toolkit.Updater.x64.exe");
		}

		// Token: 0x040002F3 RID: 755
		private Point mouseOffset;

		// Token: 0x040002F4 RID: 756
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x040002F5 RID: 757
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x040002F6 RID: 758
		public const int HT_CAPTION = 2;
	}
}
