using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000018 RID: 24
	public partial class update : Form
	{
		// Token: 0x0600019E RID: 414
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x0600019F RID: 415 RVA: 0x000380E4 File Offset: 0x000362E4
		public update()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(update.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000018 RID: 24
		// (get) Token: 0x060001A0 RID: 416 RVA: 0x00038134 File Offset: 0x00036334
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

		// Token: 0x060001A1 RID: 417
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x060001A2 RID: 418
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x060001A3 RID: 419 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x060001A4 RID: 420 RVA: 0x00038164 File Offset: 0x00036364
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				update.ReleaseCapture();
				update.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0400033A RID: 826
		private Point mouseOffset;

		// Token: 0x0400033B RID: 827
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400033C RID: 828
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400033D RID: 829
		public const int HT_CAPTION = 2;
	}
}
