using System;
using System.ComponentModel;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000008 RID: 8
	public partial class cancel : Form
	{
		// Token: 0x06000050 RID: 80
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000051 RID: 81 RVA: 0x000089E0 File Offset: 0x00006BE0
		public cancel()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(cancel.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000052 RID: 82 RVA: 0x00008A30 File Offset: 0x00006C30
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

		// Token: 0x06000053 RID: 83 RVA: 0x00008A5F File Offset: 0x00006C5F
		private void button1_Click(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000054 RID: 84
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x06000055 RID: 85
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x06000056 RID: 86 RVA: 0x00008A6C File Offset: 0x00006C6C
		private void panel1_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				cancel.ReleaseCapture();
				cancel.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x04000066 RID: 102
		private Point mouseOffset;

		// Token: 0x04000067 RID: 103
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x04000068 RID: 104
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x04000069 RID: 105
		public const int HT_CAPTION = 2;
	}
}
