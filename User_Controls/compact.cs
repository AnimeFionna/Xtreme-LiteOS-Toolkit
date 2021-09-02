using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000009 RID: 9
	public class compact : UserControl
	{
		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000059 RID: 89 RVA: 0x00008F04 File Offset: 0x00007104
		public static compact Instance
		{
			get
			{
				bool flag = compact._instace == null;
				if (flag)
				{
					compact._instace = new compact();
				}
				return compact._instace;
			}
		}

		// Token: 0x0600005A RID: 90 RVA: 0x00008F31 File Offset: 0x00007131
		public compact()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600005B RID: 91 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button23_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000020AF File Offset: 0x000002AF
		private void button22_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x0600005D RID: 93 RVA: 0x000020BD File Offset: 0x000002BD
		private void button24_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00008F4C File Offset: 0x0000714C
		private void button3_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "compact /c /s /a /i /exe:XPRESS4K C:\\Windows\\System32\\*",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00008F9C File Offset: 0x0000719C
		private void button2_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "compact /c /s /a /i /exe:XPRESS8K C:\\Windows\\System32\\*",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x06000060 RID: 96 RVA: 0x00008FEC File Offset: 0x000071EC
		private void button6_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "compact /c /s /a /i /exe:XPRESS16K C:\\Windows\\System32\\*",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000903C File Offset: 0x0000723C
		private void button4_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "compact /c /s /a /i /exe:LZX C:\\Windows\\System32\\*",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x06000062 RID: 98 RVA: 0x0000908C File Offset: 0x0000728C
		private void button7_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					FileName = "powershell.exe",
					Arguments = "compact /u /a /s /exe C:\\Windows\\System32\\*",
					Verb = "runas"
				}
			}.Start();
		}

		// Token: 0x06000063 RID: 99 RVA: 0x00002370 File Offset: 0x00000570
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000090DC File Offset: 0x000072DC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00009114 File Offset: 0x00007314
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(compact));
			this.label1 = new Label();
			this.label2 = new Label();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.label9 = new Label();
			this.button5 = new Button();
			this.button1 = new Button();
			this.label3 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button4 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(213, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "CompactOS";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(21, 141);
			this.label2.Name = "label2";
			this.label2.Size = new Size(229, 33);
			this.label2.TabIndex = 2;
			this.label2.Text = "Default Compression :-";
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
			this.button21.TabIndex = 91;
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
			this.button22.TabIndex = 90;
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
			this.button23.TabIndex = 89;
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
			this.button24.TabIndex = 88;
			this.button24.TabStop = false;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += this.button24_Click;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(23, 75);
			this.label9.Name = "label9";
			this.label9.Size = new Size(399, 19);
			this.label9.TabIndex = 92;
			this.label9.Text = "Compresses OS Binaries to save disk (have no impact on performance)";
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(202, 210);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(121, 32);
			this.button5.TabIndex = 93;
			this.button5.TabStop = false;
			this.button5.Text = "Enable";
			this.button5.UseVisualStyleBackColor = false;
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(581, 210);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 32);
			this.button1.TabIndex = 94;
			this.button1.TabStop = false;
			this.button1.Text = "Disable";
			this.button1.UseVisualStyleBackColor = false;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans", 15.75f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(21, 284);
			this.label3.Name = "label3";
			this.label3.Size = new Size(305, 33);
			this.label3.TabIndex = 95;
			this.label3.Text = "Other Compression Methods :-";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Silver;
			this.label4.Location = new Point(23, 333);
			this.label4.Name = "label4";
			this.label4.Size = new Size(183, 19);
			this.label4.TabIndex = 96;
			this.label4.Text = "XPRESS4K : Fastest but weakest";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.Silver;
			this.label5.Location = new Point(23, 362);
			this.label5.Name = "label5";
			this.label5.Size = new Size(373, 19);
			this.label5.TabIndex = 97;
			this.label5.Text = "XPRESS8K : Reasonable balanced between speed and compression";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.Silver;
			this.label6.Location = new Point(681, 333);
			this.label6.Name = "label6";
			this.label6.Size = new Size(191, 19);
			this.label6.TabIndex = 98;
			this.label6.Text = "XPRESS16K : Slower but stronger";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.Silver;
			this.label7.Location = new Point(681, 362);
			this.label7.Name = "label7";
			this.label7.Size = new Size(159, 19);
			this.label7.TabIndex = 99;
			this.label7.Text = "LZX : Slowest but strongest";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.Silver;
			this.label8.Location = new Point(204, 413);
			this.label8.Name = "label8";
			this.label8.Size = new Size(457, 19);
			this.label8.TabIndex = 100;
			this.label8.Text = "NOTE : LZX has a higher overhead, so only use if your CPU is reasonably strong";
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(208, 491);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(121, 32);
			this.button2.TabIndex = 102;
			this.button2.TabStop = false;
			this.button2.Text = "XPRESS8K";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(27, 491);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(121, 32);
			this.button3.TabIndex = 101;
			this.button3.TabStop = false;
			this.button3.Text = "XPRESS4K";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(570, 491);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(121, 32);
			this.button4.TabIndex = 104;
			this.button4.TabStop = false;
			this.button4.Text = "LZX";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(389, 491);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(121, 32);
			this.button6.TabIndex = 103;
			this.button6.TabStop = false;
			this.button6.Text = "XPRESS16K";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(751, 491);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(121, 32);
			this.button7.TabIndex = 105;
			this.button7.TabStop = false;
			this.button7.Text = "Revert";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Name = "compact";
			base.Size = new Size(918, 664);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400006F RID: 111
		private static compact _instace;

		// Token: 0x04000070 RID: 112
		private IContainer components = null;

		// Token: 0x04000071 RID: 113
		private Label label1;

		// Token: 0x04000072 RID: 114
		private Label label2;

		// Token: 0x04000073 RID: 115
		private Button button21;

		// Token: 0x04000074 RID: 116
		private Button button22;

		// Token: 0x04000075 RID: 117
		private Button button23;

		// Token: 0x04000076 RID: 118
		private Button button24;

		// Token: 0x04000077 RID: 119
		private Label label9;

		// Token: 0x04000078 RID: 120
		private Button button5;

		// Token: 0x04000079 RID: 121
		private Button button1;

		// Token: 0x0400007A RID: 122
		private Label label3;

		// Token: 0x0400007B RID: 123
		private Label label4;

		// Token: 0x0400007C RID: 124
		private Label label5;

		// Token: 0x0400007D RID: 125
		private Label label6;

		// Token: 0x0400007E RID: 126
		private Label label7;

		// Token: 0x0400007F RID: 127
		private Label label8;

		// Token: 0x04000080 RID: 128
		private Button button2;

		// Token: 0x04000081 RID: 129
		private Button button3;

		// Token: 0x04000082 RID: 130
		private Button button4;

		// Token: 0x04000083 RID: 131
		private Button button6;

		// Token: 0x04000084 RID: 132
		private Button button7;
	}
}
