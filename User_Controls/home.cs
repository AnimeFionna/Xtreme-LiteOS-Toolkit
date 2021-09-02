using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000D RID: 13
	public class home : UserControl
	{
		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000105 RID: 261 RVA: 0x00029E24 File Offset: 0x00028024
		public static home Instance
		{
			get
			{
				bool flag = home._instace == null;
				if (flag)
				{
					home._instace = new home();
				}
				return home._instace;
			}
		}

		// Token: 0x06000106 RID: 262 RVA: 0x00029E51 File Offset: 0x00028051
		public home()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x000020BD File Offset: 0x000002BD
		private void button15_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x06000108 RID: 264 RVA: 0x000020AF File Offset: 0x000002AF
		private void button18_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x06000109 RID: 265 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button17_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x0600010A RID: 266 RVA: 0x00003D8B File Offset: 0x00001F8B
		private void button16_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.buymeacoffee.com/TheWorldOfPC");
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002370 File Offset: 0x00000570
		private void button19_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x0600010C RID: 268 RVA: 0x00029E6C File Offset: 0x0002806C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010D RID: 269 RVA: 0x00029EA4 File Offset: 0x000280A4
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(home));
			this.label15 = new Label();
			this.label14 = new Label();
			this.label13 = new Label();
			this.label12 = new Label();
			this.pictureBox4 = new PictureBox();
			this.label11 = new Label();
			this.label10 = new Label();
			this.label9 = new Label();
			this.label8 = new Label();
			this.pictureBox3 = new PictureBox();
			this.label7 = new Label();
			this.label6 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label1 = new Label();
			this.pictureBox2 = new PictureBox();
			this.label16 = new Label();
			this.button16 = new Button();
			this.button19 = new Button();
			this.button18 = new Button();
			this.button17 = new Button();
			this.button15 = new Button();
			((ISupportInitialize)this.pictureBox4).BeginInit();
			((ISupportInitialize)this.pictureBox3).BeginInit();
			((ISupportInitialize)this.pictureBox2).BeginInit();
			base.SuspendLayout();
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label15.ForeColor = Color.Silver;
			this.label15.Location = new Point(108, 481);
			this.label15.Name = "label15";
			this.label15.Size = new Size(188, 19);
			this.label15.TabIndex = 42;
			this.label15.Text = "Software and support developer!";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label14.ForeColor = Color.Silver;
			this.label14.Location = new Point(108, 463);
			this.label14.Name = "label14";
			this.label14.Size = new Size(682, 19);
			this.label14.TabIndex = 41;
			this.label14.Text = "your Antivirus is giving you trouble please just allowed/exclude the file! If you don't trust any crack file, please buy Original";
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label13.ForeColor = Color.Silver;
			this.label13.Location = new Point(108, 444);
			this.label13.Name = "label13";
			this.label13.Size = new Size(689, 19);
			this.label13.TabIndex = 40;
			this.label13.Text = "Cracked softwares in downloads section contains cracked files/activators/keygens, anti-virus detects them as potental virus, if";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label12.ForeColor = Color.White;
			this.label12.Location = new Point(104, 410);
			this.label12.Name = "label12";
			this.label12.Size = new Size(363, 30);
			this.label12.TabIndex = 39;
			this.label12.Text = "Cracked Software in Downloads Section";
			this.pictureBox4.Image = (Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new Point(50, 391);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new Size(64, 64);
			this.pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 38;
			this.pictureBox4.TabStop = false;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = Color.Silver;
			this.label11.Location = new Point(105, 369);
			this.label11.Name = "label11";
			this.label11.Size = new Size(572, 19);
			this.label11.TabIndex = 37;
			this.label11.Text = "anything is wrong with the toolkit (broken links or some bug) that bug/issue will be fixed by an update";
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.Silver;
			this.label10.Location = new Point(105, 350);
			this.label10.Name = "label10";
			this.label10.Size = new Size(695, 19);
			this.label10.TabIndex = 36;
			this.label10.Text = "needs, the tweaks provided in the tool will perfectly optimize your gaming experience. Every software have bugs/issues in it, if";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(105, 331);
			this.label9.Name = "label9";
			this.label9.Size = new Size(696, 19);
			this.label9.TabIndex = 35;
			this.label9.Text = "The OS is already pre-tweaked by keeping compatibility with gaming in mind, however you still can tweak it according to your";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(104, 295);
			this.label8.Name = "label8";
			this.label8.Size = new Size(169, 30);
			this.label8.TabIndex = 34;
			this.label8.Text = "Tweaks/Basic Info";
			this.pictureBox3.Image = (Image)componentResourceManager.GetObject("pictureBox3.Image");
			this.pictureBox3.Location = new Point(50, 274);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new Size(64, 64);
			this.pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 33;
			this.pictureBox3.TabStop = false;
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.Silver;
			this.label7.Location = new Point(105, 252);
			this.label7.Name = "label7";
			this.label7.Size = new Size(385, 19);
			this.label7.TabIndex = 32;
			this.label7.Text = "100+ software (cracked/freeware) with ease. And much, MUCH more!";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.Silver;
			this.label6.Location = new Point(105, 233);
			this.label6.Name = "label6";
			this.label6.Size = new Size(699, 19);
			this.label6.TabIndex = 31;
			this.label6.Text = "or deleting them. Add handy context menus using a huge set of presets. Manage user account related settings. Download over";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.Silver;
			this.label5.Location = new Point(105, 213);
			this.label5.Name = "label5";
			this.label5.Size = new Size(711, 19);
			this.label5.TabIndex = 30;
			this.label5.Text = "(hidden features as well). Some advanced tweaks meant for gamers, Manage Windows apps ex. adding Microsoft Store or Xbox";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Silver;
			this.label4.Location = new Point(105, 194);
			this.label4.Name = "label4";
			this.label4.Size = new Size(714, 19);
			this.label4.TabIndex = 29;
			this.label4.Text = "Xtreme LiteOS Toolkit comes with plenty of features. Cleanup Windows, some basic tweaks to enable or disable windows features";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(104, 160);
			this.label3.Name = "label3";
			this.label3.Size = new Size(87, 30);
			this.label3.TabIndex = 28;
			this.label3.Text = "Features";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(158, 83);
			this.label2.Name = "label2";
			this.label2.Size = new Size(605, 30);
			this.label2.TabIndex = 26;
			this.label2.Text = "The Ultimate all-in-one tool exclusively available for Xtreme LiteOS";
			this.label1.AutoSize = true;
			this.label1.BackColor = Color.Transparent;
			this.label1.Font = new Font("Josefin Sans SemiBold", 30f, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(247, 18);
			this.label1.Name = "label1";
			this.label1.Size = new Size(438, 63);
			this.label1.TabIndex = 25;
			this.label1.Text = "Xtreme LiteOS Toolkit";
			this.pictureBox2.Image = (Image)componentResourceManager.GetObject("pictureBox2.Image");
			this.pictureBox2.Location = new Point(50, 141);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new Size(64, 64);
			this.pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 27;
			this.pictureBox2.TabStop = false;
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label16.ForeColor = Color.White;
			this.label16.Location = new Point(270, 533);
			this.label16.Name = "label16";
			this.label16.Size = new Size(353, 30);
			this.label16.TabIndex = 43;
			this.label16.Text = "Thank you for believing in this project!";
			this.button16.BackColor = Color.FromArgb(38, 38, 38);
			this.button16.BackgroundImage = (Image)componentResourceManager.GetObject("button16.BackgroundImage");
			this.button16.BackgroundImageLayout = ImageLayout.Stretch;
			this.button16.Cursor = Cursors.Hand;
			this.button16.FlatAppearance.BorderSize = 0;
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button16.ForeColor = Color.White;
			this.button16.ImageAlign = ContentAlignment.MiddleLeft;
			this.button16.Location = new Point(716, 563);
			this.button16.Margin = new Padding(1);
			this.button16.Name = "button16";
			this.button16.Size = new Size(198, 52);
			this.button16.TabIndex = 44;
			this.button16.TabStop = false;
			this.button16.TextAlign = ContentAlignment.MiddleRight;
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += this.button16_Click;
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
			this.button19.TabIndex = 48;
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
			this.button18.TabIndex = 47;
			this.button18.TabStop = false;
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += this.button18_Click;
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
			this.button17.TabIndex = 46;
			this.button17.TabStop = false;
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += this.button17_Click;
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
			this.button15.TabIndex = 45;
			this.button15.TabStop = false;
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += this.button15_Click;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.button19);
			base.Controls.Add(this.button18);
			base.Controls.Add(this.button17);
			base.Controls.Add(this.button15);
			base.Controls.Add(this.button16);
			base.Controls.Add(this.label16);
			base.Controls.Add(this.label15);
			base.Controls.Add(this.label14);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.pictureBox3);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.pictureBox2);
			base.Name = "home";
			base.Size = new Size(918, 664);
			((ISupportInitialize)this.pictureBox4).EndInit();
			((ISupportInitialize)this.pictureBox3).EndInit();
			((ISupportInitialize)this.pictureBox2).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400024D RID: 589
		private static home _instace;

		// Token: 0x0400024E RID: 590
		private IContainer components = null;

		// Token: 0x0400024F RID: 591
		private Label label15;

		// Token: 0x04000250 RID: 592
		private Label label14;

		// Token: 0x04000251 RID: 593
		private Label label13;

		// Token: 0x04000252 RID: 594
		private Label label12;

		// Token: 0x04000253 RID: 595
		private PictureBox pictureBox4;

		// Token: 0x04000254 RID: 596
		private Label label11;

		// Token: 0x04000255 RID: 597
		private Label label10;

		// Token: 0x04000256 RID: 598
		private Label label9;

		// Token: 0x04000257 RID: 599
		private Label label8;

		// Token: 0x04000258 RID: 600
		private PictureBox pictureBox3;

		// Token: 0x04000259 RID: 601
		private Label label7;

		// Token: 0x0400025A RID: 602
		private Label label6;

		// Token: 0x0400025B RID: 603
		private Label label5;

		// Token: 0x0400025C RID: 604
		private Label label4;

		// Token: 0x0400025D RID: 605
		private Label label3;

		// Token: 0x0400025E RID: 606
		private Label label2;

		// Token: 0x0400025F RID: 607
		private Label label1;

		// Token: 0x04000260 RID: 608
		private PictureBox pictureBox2;

		// Token: 0x04000261 RID: 609
		private Label label16;

		// Token: 0x04000262 RID: 610
		private Button button16;

		// Token: 0x04000263 RID: 611
		private Button button19;

		// Token: 0x04000264 RID: 612
		private Button button18;

		// Token: 0x04000265 RID: 613
		private Button button17;

		// Token: 0x04000266 RID: 614
		private Button button15;
	}
}
