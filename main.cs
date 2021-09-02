using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WindowsFormsApplication2.Dialog_Boxes;
using WindowsFormsApplication2.User_Controls;

namespace WindowsFormsApplication2
{
	// Token: 0x02000003 RID: 3
	public partial class main : Form
	{
		// Token: 0x06000014 RID: 20
		[DllImport("Gdi32.dll")]
		private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);

		// Token: 0x06000015 RID: 21 RVA: 0x00003AD8 File Offset: 0x00001CD8
		public main()
		{
			this.InitializeComponent();
			base.FormBorderStyle = FormBorderStyle.None;
			base.Region = Region.FromHrgn(main.CreateRoundRectRgn(0, 0, base.Width, base.Height, 20, 20));
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000016 RID: 22 RVA: 0x00003B28 File Offset: 0x00001D28
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

		// Token: 0x06000017 RID: 23 RVA: 0x00002095 File Offset: 0x00000295
		private void pictureBox3_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002095 File Offset: 0x00000295
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00003B57 File Offset: 0x00001D57
		private void button4_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(cleanup.Instance);
			cleanup.Instance.Dock = DockStyle.Fill;
			cleanup.Instance.BringToFront();
		}

		// Token: 0x0600001A RID: 26
		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

		// Token: 0x0600001B RID: 27
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		// Token: 0x0600001C RID: 28 RVA: 0x00003B88 File Offset: 0x00001D88
		private void panel3_Paint(object sender, MouseEventArgs e)
		{
			bool flag = e.Button == MouseButtons.Left;
			if (flag)
			{
				main.ReleaseCapture();
				main.SendMessage(base.Handle, 161, 2, 0);
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00003BC2 File Offset: 0x00001DC2
		private void button5_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(tweaks.Instance);
			tweaks.Instance.Dock = DockStyle.Fill;
			tweaks.Instance.BringToFront();
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00003BF2 File Offset: 0x00001DF2
		private void button6_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(gaming.Instance);
			gaming.Instance.Dock = DockStyle.Fill;
			gaming.Instance.BringToFront();
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00003C22 File Offset: 0x00001E22
		private void button7_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(compact.Instance);
			compact.Instance.Dock = DockStyle.Fill;
			compact.Instance.BringToFront();
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00003C52 File Offset: 0x00001E52
		private void button8_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(context.Instance);
			context.Instance.Dock = DockStyle.Fill;
			context.Instance.BringToFront();
		}

		// Token: 0x06000021 RID: 33 RVA: 0x00003C84 File Offset: 0x00001E84
		private void button9_Click(object sender, EventArgs e)
		{
			using (about about = new about())
			{
				about.ShowDialog(this);
			}
		}

		// Token: 0x06000022 RID: 34 RVA: 0x00003CC0 File Offset: 0x00001EC0
		private void button10_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(windowsapp.Instance);
			windowsapp.Instance.Dock = DockStyle.Fill;
			windowsapp.Instance.BringToFront();
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00003CF0 File Offset: 0x00001EF0
		private void button11_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(downloads.Instance);
			downloads.Instance.Dock = DockStyle.Fill;
			downloads.Instance.BringToFront();
		}

		// Token: 0x06000024 RID: 36 RVA: 0x00003D20 File Offset: 0x00001F20
		private void button12_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(activate.Instance);
			activate.Instance.Dock = DockStyle.Fill;
			activate.Instance.BringToFront();
		}

		// Token: 0x06000025 RID: 37 RVA: 0x00003D50 File Offset: 0x00001F50
		private void button3_Click(object sender, EventArgs e)
		{
			this.panel2.Controls.Add(home.Instance);
			home.Instance.Dock = DockStyle.Fill;
			home.Instance.BringToFront();
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002098 File Offset: 0x00000298
		private void button1_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

		// Token: 0x06000027 RID: 39 RVA: 0x00003D80 File Offset: 0x00001F80
		private void button2_Click(object sender, EventArgs e)
		{
			base.WindowState = FormWindowState.Minimized;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x00002095 File Offset: 0x00000295
		private void button14_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000029 RID: 41 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button17_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x0600002A RID: 42 RVA: 0x000020AF File Offset: 0x000002AF
		private void button18_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x0600002B RID: 43 RVA: 0x00002370 File Offset: 0x00000570
		private void button19_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x0600002C RID: 44 RVA: 0x000020BD File Offset: 0x000002BD
		private void button15_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00003D8B File Offset: 0x00001F8B
		private void button16_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.buymeacoffee.com/TheWorldOfPC");
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00003D9C File Offset: 0x00001F9C
		private void main_Load(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\Windows\\SysWOW64\\en-US\\Licenses\\Volume\\Professional\\11.dll");
			if (!flag)
			{
				base.Close();
			}
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00003DC8 File Offset: 0x00001FC8
		private void button13_Click(object sender, EventArgs e)
		{
			using (update update = new update())
			{
				update.ShowDialog(this);
			}
		}

		// Token: 0x04000019 RID: 25
		private Point mouseOffset;

		// Token: 0x0400001A RID: 26
		private const int CS_DROPSHADOW = 131072;

		// Token: 0x0400001B RID: 27
		public const int WM_NCLBUTTONDOWN = 161;

		// Token: 0x0400001C RID: 28
		public const int HT_CAPTION = 2;
	}
}
