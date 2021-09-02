using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2
{
	// Token: 0x02000002 RID: 2
	public class cleanup : UserControl
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public static cleanup Instance
		{
			get
			{
				bool flag = cleanup._instace == null;
				if (flag)
				{
					cleanup._instace = new cleanup();
				}
				return cleanup._instace;
			}
		}

		// Token: 0x06000002 RID: 2 RVA: 0x0000207D File Offset: 0x0000027D
		public cleanup()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00002095 File Offset: 0x00000295
		private void cleanup_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00002098 File Offset: 0x00000298
		private void pictureBox3_Click(object sender, EventArgs e)
		{
			Application.ExitThread();
		}

		// Token: 0x06000005 RID: 5 RVA: 0x00002095 File Offset: 0x00000295
		private void pictureBox2_Click(object sender, EventArgs e)
		{
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button23_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x06000007 RID: 7 RVA: 0x000020AF File Offset: 0x000002AF
		private void button22_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000020BD File Offset: 0x000002BD
		private void button24_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000020CC File Offset: 0x000002CC
		private void button1_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe /c Cleanmgr /sageset:65535 & Cleanmgr /sagerun:65535"
				}
			}.Start();
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00002118 File Offset: 0x00000318
		private void button5_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cleanmgr.exe",
					Verb = "runas"
				}
			}.Start();
			using (cleared cleared = new cleared())
			{
				cleared.ShowDialog(this);
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x0000219C File Offset: 0x0000039C
		private void button6_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Normal,
					FileName = "cmd.exe",
					Arguments = "/C Dism.exe /online /Cleanup-Image /StartComponentCleanup",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000021F4 File Offset: 0x000003F4
		private void button7_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Normal,
					FileName = "cmd.exe",
					Arguments = "/C Dism.exe /online /Cleanup-Image /StartComponentCleanup /ResetBase",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00002249 File Offset: 0x00000449
		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("cmd.exe", "/c del /s /q \"%temp%\"");
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000225C File Offset: 0x0000045C
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\System32\\lv-LV\\net_temp.exe");
			using (cleared cleared = new cleared())
			{
				cleared.ShowDialog(this);
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000022A4 File Offset: 0x000004A4
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\System32\\lv-LV\\Cookies.exe");
			using (cleared cleared = new cleared())
			{
				cleared.ShowDialog(this);
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x000022EC File Offset: 0x000004EC
		private void button8_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Normal,
					FileName = "cmd.exe",
					Arguments = "/C ipconfig /flushdns",
					Verb = "runas"
				}
			}.Start();
			using (cleared cleared = new cleared())
			{
				cleared.ShowDialog(this);
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00002370 File Offset: 0x00000570
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x06000012 RID: 18 RVA: 0x00002380 File Offset: 0x00000580
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000013 RID: 19 RVA: 0x000023B8 File Offset: 0x000005B8
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(cleanup));
			this.label1 = new Label();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.label9 = new Label();
			this.button5 = new Button();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			this.label10 = new Label();
			this.button8 = new Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(152, 53);
			this.label1.TabIndex = 0;
			this.label1.Text = "Cleanup";
			this.button21.BackColor = Color.FromArgb(38, 38, 38);
			this.button21.BackgroundImage = (Image)componentResourceManager.GetObject("button21.BackgroundImage");
			this.button21.BackgroundImageLayout = ImageLayout.Stretch;
			this.button21.Cursor = Cursors.Hand;
			this.button21.FlatAppearance.BorderSize = 0;
			this.button21.FlatStyle = FlatStyle.Flat;
			this.button21.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button21.ForeColor = Color.White;
			this.button21.Location = new Point(807, 5);
			this.button21.Margin = new Padding(1);
			this.button21.Name = "button21";
			this.button21.Size = new Size(32, 32);
			this.button21.TabIndex = 87;
			this.button21.TabStop = false;
			this.button21.UseVisualStyleBackColor = false;
			this.button21.Click += this.button21_Click;
			this.button22.BackColor = Color.FromArgb(38, 38, 38);
			this.button22.BackgroundImage = (Image)componentResourceManager.GetObject("button22.BackgroundImage");
			this.button22.BackgroundImageLayout = ImageLayout.Stretch;
			this.button22.Cursor = Cursors.Hand;
			this.button22.FlatAppearance.BorderSize = 0;
			this.button22.FlatStyle = FlatStyle.Flat;
			this.button22.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button22.ForeColor = Color.White;
			this.button22.Location = new Point(841, 5);
			this.button22.Margin = new Padding(1);
			this.button22.Name = "button22";
			this.button22.Size = new Size(32, 32);
			this.button22.TabIndex = 86;
			this.button22.TabStop = false;
			this.button22.UseVisualStyleBackColor = false;
			this.button22.Click += this.button22_Click;
			this.button23.BackColor = Color.FromArgb(38, 38, 38);
			this.button23.BackgroundImage = (Image)componentResourceManager.GetObject("button23.BackgroundImage");
			this.button23.BackgroundImageLayout = ImageLayout.Stretch;
			this.button23.Cursor = Cursors.Hand;
			this.button23.FlatAppearance.BorderSize = 0;
			this.button23.FlatStyle = FlatStyle.Flat;
			this.button23.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button23.ForeColor = Color.White;
			this.button23.Location = new Point(875, 5);
			this.button23.Margin = new Padding(1);
			this.button23.Name = "button23";
			this.button23.Size = new Size(32, 32);
			this.button23.TabIndex = 85;
			this.button23.TabStop = false;
			this.button23.UseVisualStyleBackColor = false;
			this.button23.Click += this.button23_Click;
			this.button24.BackColor = Color.FromArgb(38, 38, 38);
			this.button24.BackgroundImage = (Image)componentResourceManager.GetObject("button24.BackgroundImage");
			this.button24.BackgroundImageLayout = ImageLayout.Stretch;
			this.button24.Cursor = Cursors.Hand;
			this.button24.FlatAppearance.BorderSize = 0;
			this.button24.FlatStyle = FlatStyle.Flat;
			this.button24.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button24.ForeColor = Color.White;
			this.button24.Location = new Point(773, 5);
			this.button24.Margin = new Padding(1);
			this.button24.Name = "button24";
			this.button24.Size = new Size(32, 32);
			this.button24.TabIndex = 84;
			this.button24.TabStop = false;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += this.button24_Click;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(23, 75);
			this.label9.Name = "label9";
			this.label9.Size = new Size(192, 19);
			this.label9.TabIndex = 88;
			this.label9.Text = "Cleanup leftovers/temporary files";
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(457, 147);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(121, 32);
			this.button5.TabIndex = 89;
			this.button5.TabStop = false;
			this.button5.Text = "Clean";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(32, 146);
			this.label3.Name = "label3";
			this.label3.Size = new Size(129, 30);
			this.label3.TabIndex = 90;
			this.label3.Text = "Disk Cleanup";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(32, 254);
			this.label2.Name = "label2";
			this.label2.Size = new Size(219, 30);
			this.label2.TabIndex = 91;
			this.label2.Text = "Extended Disk Cleanup";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(32, 308);
			this.label4.Name = "label4";
			this.label4.Size = new Size(156, 30);
			this.label4.TabIndex = 92;
			this.label4.Text = "Internet Cookies";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(32, 362);
			this.label5.Name = "label5";
			this.label5.Size = new Size(226, 30);
			this.label5.TabIndex = 93;
			this.label5.Text = "Temporary Internet Files";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(32, 416);
			this.label6.Name = "label6";
			this.label6.Size = new Size(151, 30);
			this.label6.TabIndex = 94;
			this.label6.Text = "Temporary Files";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(32, 470);
			this.label7.Name = "label7";
			this.label7.Size = new Size(158, 30);
			this.label7.TabIndex = 95;
			this.label7.Text = "WinSxS Cleanup";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(32, 524);
			this.label8.Name = "label8";
			this.label8.Size = new Size(301, 30);
			this.label8.TabIndex = 96;
			this.label8.Text = "WinSxS Cleanup With ResetBase";
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(457, 255);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 32);
			this.button1.TabIndex = 97;
			this.button1.TabStop = false;
			this.button1.Text = "Clean";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(457, 309);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(121, 32);
			this.button2.TabIndex = 98;
			this.button2.TabStop = false;
			this.button2.Text = "Clean";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(457, 363);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(121, 32);
			this.button3.TabIndex = 99;
			this.button3.TabStop = false;
			this.button3.Text = "Clean";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(457, 417);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(121, 32);
			this.button4.TabIndex = 100;
			this.button4.TabStop = false;
			this.button4.Text = "Clean";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(457, 471);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(121, 32);
			this.button6.TabIndex = 101;
			this.button6.TabStop = false;
			this.button6.Text = "Clean";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(457, 525);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(121, 32);
			this.button7.TabIndex = 102;
			this.button7.TabStop = false;
			this.button7.Text = "Clean";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.White;
			this.label10.Location = new Point(32, 200);
			this.label10.Name = "label10";
			this.label10.Size = new Size(114, 30);
			this.label10.TabIndex = 103;
			this.label10.Text = "DNS Cache";
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(457, 201);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(121, 32);
			this.button8.TabIndex = 104;
			this.button8.TabStop = false;
			this.button8.Text = "Clean";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.label1);
			base.Name = "cleanup";
			base.Size = new Size(918, 664);
			base.Load += this.cleanup_Load;
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000001 RID: 1
		private static cleanup _instace;

		// Token: 0x04000002 RID: 2
		private IContainer components = null;

		// Token: 0x04000003 RID: 3
		private Label label1;

		// Token: 0x04000004 RID: 4
		private Button button21;

		// Token: 0x04000005 RID: 5
		private Button button22;

		// Token: 0x04000006 RID: 6
		private Button button23;

		// Token: 0x04000007 RID: 7
		private Button button24;

		// Token: 0x04000008 RID: 8
		private Label label9;

		// Token: 0x04000009 RID: 9
		private Button button5;

		// Token: 0x0400000A RID: 10
		private Label label3;

		// Token: 0x0400000B RID: 11
		private Label label2;

		// Token: 0x0400000C RID: 12
		private Label label4;

		// Token: 0x0400000D RID: 13
		private Label label5;

		// Token: 0x0400000E RID: 14
		private Label label6;

		// Token: 0x0400000F RID: 15
		private Label label7;

		// Token: 0x04000010 RID: 16
		private Label label8;

		// Token: 0x04000011 RID: 17
		private Button button1;

		// Token: 0x04000012 RID: 18
		private Button button2;

		// Token: 0x04000013 RID: 19
		private Button button3;

		// Token: 0x04000014 RID: 20
		private Button button4;

		// Token: 0x04000015 RID: 21
		private Button button6;

		// Token: 0x04000016 RID: 22
		private Button button7;

		// Token: 0x04000017 RID: 23
		private Label label10;

		// Token: 0x04000018 RID: 24
		private Button button8;
	}
}
