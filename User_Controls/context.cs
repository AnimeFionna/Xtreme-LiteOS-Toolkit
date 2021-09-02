using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000A RID: 10
	public class context : UserControl
	{
		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000066 RID: 102 RVA: 0x0000A5F8 File Offset: 0x000087F8
		public static context Instance
		{
			get
			{
				bool flag = context._instace == null;
				if (flag)
				{
					context._instace = new context();
				}
				return context._instace;
			}
		}

		// Token: 0x06000067 RID: 103 RVA: 0x0000A625 File Offset: 0x00008825
		public context()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000068 RID: 104 RVA: 0x0000A640 File Offset: 0x00008840
		private void button5_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\CMD.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x06000069 RID: 105 RVA: 0x0000A68C File Offset: 0x0000888C
		private void button8_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RCMD.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x0600006A RID: 106 RVA: 0x0000A6D8 File Offset: 0x000088D8
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\POW.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x0600006B RID: 107 RVA: 0x0000A724 File Offset: 0x00008924
		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RPOW.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x0600006C RID: 108 RVA: 0x0000A770 File Offset: 0x00008970
		private void button2_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\TO.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x0600006D RID: 109 RVA: 0x0000A7BC File Offset: 0x000089BC
		private void button10_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RTO.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x0600006E RID: 110 RVA: 0x0000A808 File Offset: 0x00008A08
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\GOD.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x0600006F RID: 111 RVA: 0x0000A854 File Offset: 0x00008A54
		private void button11_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RGOD.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x06000070 RID: 112 RVA: 0x0000A8A0 File Offset: 0x00008AA0
		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\HASH.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x06000071 RID: 113 RVA: 0x0000A8EC File Offset: 0x00008AEC
		private void button12_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RHASH.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x06000072 RID: 114 RVA: 0x0000A938 File Offset: 0x00008B38
		private void button6_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\KILL.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x06000073 RID: 115 RVA: 0x0000A984 File Offset: 0x00008B84
		private void button13_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RKILL.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x06000074 RID: 116 RVA: 0x0000A9D0 File Offset: 0x00008BD0
		private void button7_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\SHUT.reg");
			using (added added = new added())
			{
				added.ShowDialog(this);
			}
		}

		// Token: 0x06000075 RID: 117 RVA: 0x0000AA1C File Offset: 0x00008C1C
		private void button14_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RSHUT.reg");
			using (removed removed = new removed())
			{
				removed.ShowDialog(this);
			}
		}

		// Token: 0x06000076 RID: 118 RVA: 0x00002370 File Offset: 0x00000570
		private void button19_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x06000077 RID: 119 RVA: 0x0000AA68 File Offset: 0x00008C68
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000078 RID: 120 RVA: 0x0000AAA0 File Offset: 0x00008CA0
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(context));
			this.label1 = new Label();
			this.button19 = new Button();
			this.button18 = new Button();
			this.button17 = new Button();
			this.button15 = new Button();
			this.button5 = new Button();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.label9 = new Label();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			this.button8 = new Button();
			this.button9 = new Button();
			this.button10 = new Button();
			this.button11 = new Button();
			this.button12 = new Button();
			this.button13 = new Button();
			this.button14 = new Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(243, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Context Menu";
			this.button19.BackColor = Color.FromArgb(38, 38, 38);
			this.button19.BackgroundImage = (Image)componentResourceManager.GetObject("button19.BackgroundImage");
			this.button19.BackgroundImageLayout = ImageLayout.Stretch;
			this.button19.Cursor = Cursors.Hand;
			this.button19.FlatAppearance.BorderSize = 0;
			this.button19.FlatStyle = FlatStyle.Flat;
			this.button19.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button19.ForeColor = Color.White;
			this.button19.Location = new Point(807, 5);
			this.button19.Margin = new Padding(1);
			this.button19.Name = "button19";
			this.button19.Size = new Size(32, 32);
			this.button19.TabIndex = 35;
			this.button19.TabStop = false;
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += this.button19_Click;
			this.button18.BackColor = Color.FromArgb(38, 38, 38);
			this.button18.BackgroundImage = (Image)componentResourceManager.GetObject("button18.BackgroundImage");
			this.button18.BackgroundImageLayout = ImageLayout.Stretch;
			this.button18.Cursor = Cursors.Hand;
			this.button18.FlatAppearance.BorderSize = 0;
			this.button18.FlatStyle = FlatStyle.Flat;
			this.button18.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button18.ForeColor = Color.White;
			this.button18.Location = new Point(841, 5);
			this.button18.Margin = new Padding(1);
			this.button18.Name = "button18";
			this.button18.Size = new Size(32, 32);
			this.button18.TabIndex = 34;
			this.button18.TabStop = false;
			this.button18.UseVisualStyleBackColor = false;
			this.button17.BackColor = Color.FromArgb(38, 38, 38);
			this.button17.BackgroundImage = (Image)componentResourceManager.GetObject("button17.BackgroundImage");
			this.button17.BackgroundImageLayout = ImageLayout.Stretch;
			this.button17.Cursor = Cursors.Hand;
			this.button17.FlatAppearance.BorderSize = 0;
			this.button17.FlatStyle = FlatStyle.Flat;
			this.button17.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button17.ForeColor = Color.White;
			this.button17.Location = new Point(875, 5);
			this.button17.Margin = new Padding(1);
			this.button17.Name = "button17";
			this.button17.Size = new Size(32, 32);
			this.button17.TabIndex = 33;
			this.button17.TabStop = false;
			this.button17.UseVisualStyleBackColor = false;
			this.button15.BackColor = Color.FromArgb(38, 38, 38);
			this.button15.BackgroundImage = (Image)componentResourceManager.GetObject("button15.BackgroundImage");
			this.button15.BackgroundImageLayout = ImageLayout.Stretch;
			this.button15.Cursor = Cursors.Hand;
			this.button15.FlatAppearance.BorderSize = 0;
			this.button15.FlatStyle = FlatStyle.Flat;
			this.button15.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button15.ForeColor = Color.White;
			this.button15.Location = new Point(773, 5);
			this.button15.Margin = new Padding(1);
			this.button15.Name = "button15";
			this.button15.Size = new Size(32, 32);
			this.button15.TabIndex = 32;
			this.button15.TabStop = false;
			this.button15.UseVisualStyleBackColor = false;
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(463, 144);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(121, 32);
			this.button5.TabIndex = 36;
			this.button5.TabStop = false;
			this.button5.Text = "Add";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(32, 146);
			this.label3.Name = "label3";
			this.label3.Size = new Size(280, 30);
			this.label3.TabIndex = 37;
			this.label3.Text = "Command Prompt (As Admin)";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(32, 208);
			this.label2.Name = "label2";
			this.label2.Size = new Size(211, 30);
			this.label2.TabIndex = 38;
			this.label2.Text = "Powershell (As Admin)";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(32, 270);
			this.label4.Name = "label4";
			this.label4.Size = new Size(268, 30);
			this.label4.TabIndex = 39;
			this.label4.Text = "Take Ownership (File/Folder)";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(32, 456);
			this.label5.Name = "label5";
			this.label5.Size = new Size(244, 30);
			this.label5.TabIndex = 40;
			this.label5.Text = "Kill Not Responding Tasks";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(32, 394);
			this.label6.Name = "label6";
			this.label6.Size = new Size(95, 30);
			this.label6.TabIndex = 41;
			this.label6.Text = "File Hash";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(32, 518);
			this.label7.Name = "label7";
			this.label7.Size = new Size(249, 30);
			this.label7.TabIndex = 42;
			this.label7.Text = "Shutdown / Power Options";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(32, 332);
			this.label8.Name = "label8";
			this.label8.Size = new Size(249, 30);
			this.label8.TabIndex = 43;
			this.label8.Text = "Control Panel + God Mode";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(23, 75);
			this.label9.Name = "label9";
			this.label9.Size = new Size(274, 19);
			this.label9.TabIndex = 44;
			this.label9.Text = "Add useful options to the context menu for ease";
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(463, 206);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 32);
			this.button1.TabIndex = 45;
			this.button1.TabStop = false;
			this.button1.Text = "Add";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(463, 268);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(121, 32);
			this.button2.TabIndex = 46;
			this.button2.TabStop = false;
			this.button2.Text = "Add";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(463, 330);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(121, 32);
			this.button3.TabIndex = 47;
			this.button3.TabStop = false;
			this.button3.Text = "Add";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(463, 392);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(121, 32);
			this.button4.TabIndex = 48;
			this.button4.TabStop = false;
			this.button4.Text = "Add";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(463, 454);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(121, 32);
			this.button6.TabIndex = 49;
			this.button6.TabStop = false;
			this.button6.Text = "Add";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(463, 516);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(121, 32);
			this.button7.TabIndex = 50;
			this.button7.TabStop = false;
			this.button7.Text = "Add";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(659, 147);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(121, 32);
			this.button8.TabIndex = 51;
			this.button8.TabStop = false;
			this.button8.Text = "Remove";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button9.BackColor = Color.FromArgb(38, 38, 38);
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button9.ForeColor = Color.White;
			this.button9.ImageAlign = ContentAlignment.MiddleLeft;
			this.button9.Location = new Point(659, 209);
			this.button9.Margin = new Padding(1);
			this.button9.Name = "button9";
			this.button9.Size = new Size(121, 32);
			this.button9.TabIndex = 52;
			this.button9.TabStop = false;
			this.button9.Text = "Remove";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.button10.BackColor = Color.FromArgb(38, 38, 38);
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(659, 271);
			this.button10.Margin = new Padding(1);
			this.button10.Name = "button10";
			this.button10.Size = new Size(121, 32);
			this.button10.TabIndex = 53;
			this.button10.TabStop = false;
			this.button10.Text = "Remove";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click;
			this.button11.BackColor = Color.FromArgb(38, 38, 38);
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.ImageAlign = ContentAlignment.MiddleLeft;
			this.button11.Location = new Point(659, 333);
			this.button11.Margin = new Padding(1);
			this.button11.Name = "button11";
			this.button11.Size = new Size(121, 32);
			this.button11.TabIndex = 54;
			this.button11.TabStop = false;
			this.button11.Text = "Remove";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += this.button11_Click;
			this.button12.BackColor = Color.FromArgb(38, 38, 38);
			this.button12.Cursor = Cursors.Hand;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button12.ForeColor = Color.White;
			this.button12.ImageAlign = ContentAlignment.MiddleLeft;
			this.button12.Location = new Point(659, 395);
			this.button12.Margin = new Padding(1);
			this.button12.Name = "button12";
			this.button12.Size = new Size(121, 32);
			this.button12.TabIndex = 55;
			this.button12.TabStop = false;
			this.button12.Text = "Remove";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += this.button12_Click;
			this.button13.BackColor = Color.FromArgb(38, 38, 38);
			this.button13.Cursor = Cursors.Hand;
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button13.ForeColor = Color.White;
			this.button13.ImageAlign = ContentAlignment.MiddleLeft;
			this.button13.Location = new Point(659, 454);
			this.button13.Margin = new Padding(1);
			this.button13.Name = "button13";
			this.button13.Size = new Size(121, 32);
			this.button13.TabIndex = 56;
			this.button13.TabStop = false;
			this.button13.Text = "Remove";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += this.button13_Click;
			this.button14.BackColor = Color.FromArgb(38, 38, 38);
			this.button14.Cursor = Cursors.Hand;
			this.button14.FlatAppearance.BorderSize = 0;
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button14.ForeColor = Color.White;
			this.button14.ImageAlign = ContentAlignment.MiddleLeft;
			this.button14.Location = new Point(659, 516);
			this.button14.Margin = new Padding(1);
			this.button14.Name = "button14";
			this.button14.Size = new Size(121, 32);
			this.button14.TabIndex = 57;
			this.button14.TabStop = false;
			this.button14.Text = "Remove";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += this.button14_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.button14);
			base.Controls.Add(this.button13);
			base.Controls.Add(this.button12);
			base.Controls.Add(this.button11);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.button19);
			base.Controls.Add(this.button18);
			base.Controls.Add(this.button17);
			base.Controls.Add(this.button15);
			base.Controls.Add(this.label1);
			base.Name = "context";
			base.Size = new Size(918, 664);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000085 RID: 133
		private static context _instace;

		// Token: 0x04000086 RID: 134
		private IContainer components = null;

		// Token: 0x04000087 RID: 135
		private Label label1;

		// Token: 0x04000088 RID: 136
		private Button button19;

		// Token: 0x04000089 RID: 137
		private Button button18;

		// Token: 0x0400008A RID: 138
		private Button button17;

		// Token: 0x0400008B RID: 139
		private Button button15;

		// Token: 0x0400008C RID: 140
		private Button button5;

		// Token: 0x0400008D RID: 141
		private Label label3;

		// Token: 0x0400008E RID: 142
		private Label label2;

		// Token: 0x0400008F RID: 143
		private Label label4;

		// Token: 0x04000090 RID: 144
		private Label label5;

		// Token: 0x04000091 RID: 145
		private Label label6;

		// Token: 0x04000092 RID: 146
		private Label label7;

		// Token: 0x04000093 RID: 147
		private Label label8;

		// Token: 0x04000094 RID: 148
		private Label label9;

		// Token: 0x04000095 RID: 149
		private Button button1;

		// Token: 0x04000096 RID: 150
		private Button button2;

		// Token: 0x04000097 RID: 151
		private Button button3;

		// Token: 0x04000098 RID: 152
		private Button button4;

		// Token: 0x04000099 RID: 153
		private Button button6;

		// Token: 0x0400009A RID: 154
		private Button button7;

		// Token: 0x0400009B RID: 155
		private Button button8;

		// Token: 0x0400009C RID: 156
		private Button button9;

		// Token: 0x0400009D RID: 157
		private Button button10;

		// Token: 0x0400009E RID: 158
		private Button button11;

		// Token: 0x0400009F RID: 159
		private Button button12;

		// Token: 0x040000A0 RID: 160
		private Button button13;

		// Token: 0x040000A1 RID: 161
		private Button button14;
	}
}
