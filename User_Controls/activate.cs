using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000007 RID: 7
	public class activate : UserControl
	{
		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600003B RID: 59 RVA: 0x00006980 File Offset: 0x00004B80
		public static activate Instance
		{
			get
			{
				bool flag = activate._instace == null;
				if (flag)
				{
					activate._instace = new activate();
				}
				return activate._instace;
			}
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000069AD File Offset: 0x00004BAD
		public activate()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button23_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x0600003E RID: 62 RVA: 0x000020AF File Offset: 0x000002AF
		private void button22_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000020BD File Offset: 0x000002BD
		private void button24_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000069D0 File Offset: 0x00004BD0
		private void button5_Click(object sender, EventArgs e)
		{
			this.label6.Text = "Downloading HWID Activator...";
			this.label6.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/876070278197821460/876070380266197022/hwid.kms38.gen.mk6.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\hwid.kms38.gen.mk6.rar");
			this.sw.Start();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006A60 File Offset: 0x00004C60
		private void dl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.lblSpeed.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00"));
			this.lblDownload.Text = string.Format("{0} MB / {1} MB", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
			this.progressBar1.Value = e.ProgressPercentage;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006B30 File Offset: 0x00004D30
		private void dl_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			this.sw.Reset();
			this.progressBar1.Value = 0;
			this.lblSpeed.Text = "";
			this.lblDownload.Refresh();
			this.lblDownload.Text = "";
			this.lblDownload.Refresh();
			this.label6.Text = "Status : Idle...";
			this.label6.Refresh();
			bool cancelled = e.Cancelled;
			if (cancelled)
			{
				using (cancel cancel = new cancel())
				{
					cancel.ShowDialog(this);
				}
			}
			else
			{
				bool flag = e.Error != null;
				if (flag)
				{
					using (Error error = new Error())
					{
						error.ShowDialog(this);
					}
				}
				else
				{
					using (custom custom = new custom())
					{
						custom.ShowDialog(this);
					}
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006C54 File Offset: 0x00004E54
		private void button1_Click(object sender, EventArgs e)
		{
			this.label6.Text = "Downloading KMSpico...";
			this.label6.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/876070278197821460/876070382032019466/KMSpico-setup.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\KMSpico-setup.rar");
			this.sw.Start();
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006CE4 File Offset: 0x00004EE4
		private void button2_Click(object sender, EventArgs e)
		{
			this.label6.Text = "Downloading Windows Digital Activator...";
			this.label6.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/876070278197821460/876070372926193704/W10DigitalActivation.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\W10DigitalActivation.rar");
			this.sw.Start();
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006D74 File Offset: 0x00004F74
		private void button8_Click(object sender, EventArgs e)
		{
			this.label6.Text = "Downloading KMS Tools...";
			this.label6.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/876070278197821460/876071149644181504/KMS_Tools.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\KMS_Tools.rar");
			this.sw.Start();
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006E04 File Offset: 0x00005004
		private void button7_Click(object sender, EventArgs e)
		{
			this.label6.Text = "Downloading MS Toolkit...";
			this.label6.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/876070278197821460/876071769109331998/Microsoft_Toolkit.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Microsoft_Toolkit_v2.6.7.rar");
			this.sw.Start();
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006E94 File Offset: 0x00005094
		private void button6_Click(object sender, EventArgs e)
		{
			this.label6.Text = "Downloading MS Toolkit...";
			this.label6.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/876070278197821460/876070377409871933/Re-LoaderByR1n.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Re-LoaderByR@1n.rar");
			this.sw.Start();
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006F24 File Offset: 0x00005124
		private void button11_Click(object sender, EventArgs e)
		{
			this.lblSpeed.Text = "";
			this.lblDownload.Refresh();
			this.progressBar1.Value = 0;
			this.lblDownload.Text = "";
			this.lblDownload.Refresh();
			this.label6.Text = "Status : Idle...";
			this.label2.Refresh();
			this.dl.CancelAsync();
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006FA2 File Offset: 0x000051A2
		private void button3_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\System32\\lv-LV\\OS.exe");
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006FB0 File Offset: 0x000051B0
		private void button4_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\System32\\lv-LV\\13.exe");
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006FB0 File Offset: 0x000051B0
		private void button9_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\System32\\lv-LV\\13.exe");
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006FBE File Offset: 0x000051BE
		private void button10_Click(object sender, EventArgs e)
		{
			Process.Start("C:\\Windows\\System32\\lv-LV\\19.exe");
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00002370 File Offset: 0x00000570
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00006FCC File Offset: 0x000051CC
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007004 File Offset: 0x00005204
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(activate));
			this.label1 = new Label();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.label4 = new Label();
			this.label2 = new Label();
			this.label3 = new Label();
			this.button5 = new Button();
			this.button1 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.label5 = new Label();
			this.button4 = new Button();
			this.button6 = new Button();
			this.button7 = new Button();
			this.button8 = new Button();
			this.button9 = new Button();
			this.button10 = new Button();
			this.lblSpeed = new Label();
			this.lblDownload = new Label();
			this.label6 = new Label();
			this.button11 = new Button();
			this.progressBar1 = new ProgressBar();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(346, 53);
			this.label1.TabIndex = 5;
			this.label1.Text = "Activate OS / Office";
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
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.Silver;
			this.label4.Location = new Point(23, 77);
			this.label4.Name = "label4";
			this.label4.Size = new Size(255, 19);
			this.label4.TabIndex = 88;
			this.label4.Text = "Activate Windows or Office Products for free";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Silver;
			this.label2.Location = new Point(23, 96);
			this.label2.Name = "label2";
			this.label2.Size = new Size(537, 19);
			this.label2.TabIndex = 89;
			this.label2.Text = "Note : Anti-Virus may detect activators as potential virus, please allow the files or buy a legit key";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans SemiBold", 20f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(18, 143);
			this.label3.Name = "label3";
			this.label3.Size = new Size(192, 43);
			this.label3.TabIndex = 90;
			this.label3.Text = "OS Activation";
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(27, 228);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(151, 32);
			this.button5.TabIndex = 91;
			this.button5.TabStop = false;
			this.button5.Text = "HWID Activator";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(220, 228);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(151, 32);
			this.button1.TabIndex = 92;
			this.button1.TabStop = false;
			this.button1.Text = "KMSpico";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(413, 228);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(209, 32);
			this.button2.TabIndex = 93;
			this.button2.TabStop = false;
			this.button2.Text = "Windows Digital Activator";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(664, 228);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(209, 32);
			this.button3.TabIndex = 94;
			this.button3.TabStop = false;
			this.button3.Text = "Online OS Activator";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans SemiBold", 20f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(18, 295);
			this.label5.Name = "label5";
			this.label5.Size = new Size(232, 43);
			this.label5.TabIndex = 95;
			this.label5.Text = "Office Activation";
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(631, 378);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(241, 32);
			this.button4.TabIndex = 99;
			this.button4.TabStop = false;
			this.button4.Text = "Online Activator (Office 2013)";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(391, 378);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(209, 32);
			this.button6.TabIndex = 98;
			this.button6.TabStop = false;
			this.button6.Text = "Re-Loader For Office";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(209, 378);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(151, 32);
			this.button7.TabIndex = 97;
			this.button7.TabStop = false;
			this.button7.Text = "MS Toolkit";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(27, 378);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(151, 32);
			this.button8.TabIndex = 96;
			this.button8.TabStop = false;
			this.button8.Text = "KMS Tools";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button9.BackColor = Color.FromArgb(38, 38, 38);
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button9.ForeColor = Color.White;
			this.button9.ImageAlign = ContentAlignment.MiddleLeft;
			this.button9.Location = new Point(119, 447);
			this.button9.Margin = new Padding(1);
			this.button9.Name = "button9";
			this.button9.Size = new Size(241, 32);
			this.button9.TabIndex = 100;
			this.button9.TabStop = false;
			this.button9.Text = "Online Activator (Office 2016)";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.button10.BackColor = Color.FromArgb(38, 38, 38);
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(499, 447);
			this.button10.Margin = new Padding(1);
			this.button10.Name = "button10";
			this.button10.Size = new Size(241, 32);
			this.button10.TabIndex = 101;
			this.button10.TabStop = false;
			this.button10.Text = "Online Activator (Office 2019)";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click;
			this.lblSpeed.AutoSize = true;
			this.lblSpeed.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblSpeed.ForeColor = Color.White;
			this.lblSpeed.Location = new Point(408, 578);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new Size(0, 25);
			this.lblSpeed.TabIndex = 106;
			this.lblDownload.AutoSize = true;
			this.lblDownload.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblDownload.ForeColor = Color.White;
			this.lblDownload.Location = new Point(581, 577);
			this.lblDownload.Name = "lblDownload";
			this.lblDownload.Size = new Size(0, 25);
			this.lblDownload.TabIndex = 105;
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(22, 578);
			this.label6.Name = "label6";
			this.label6.Size = new Size(112, 25);
			this.label6.TabIndex = 104;
			this.label6.Text = "Status : Idle....";
			this.button11.BackColor = Color.FromArgb(38, 38, 38);
			this.button11.BackgroundImageLayout = ImageLayout.None;
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.ImageAlign = ContentAlignment.MiddleLeft;
			this.button11.Location = new Point(819, 546);
			this.button11.Margin = new Padding(1);
			this.button11.Name = "button11";
			this.button11.Size = new Size(84, 55);
			this.button11.TabIndex = 103;
			this.button11.TabStop = false;
			this.button11.Text = "Cancel";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += this.button11_Click;
			this.progressBar1.Location = new Point(27, 544);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(770, 23);
			this.progressBar1.Style = ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 102;
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.lblSpeed);
			base.Controls.Add(this.lblDownload);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.button11);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.button10);
			base.Controls.Add(this.button9);
			base.Controls.Add(this.button4);
			base.Controls.Add(this.button6);
			base.Controls.Add(this.button7);
			base.Controls.Add(this.button8);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.button2);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button5);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.label1);
			base.Name = "activate";
			base.Size = new Size(918, 619);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400004A RID: 74
		private WebClient dl;

		// Token: 0x0400004B RID: 75
		private Stopwatch sw = new Stopwatch();

		// Token: 0x0400004C RID: 76
		private static activate _instace;

		// Token: 0x0400004D RID: 77
		private IContainer components = null;

		// Token: 0x0400004E RID: 78
		private Label label1;

		// Token: 0x0400004F RID: 79
		private Button button21;

		// Token: 0x04000050 RID: 80
		private Button button22;

		// Token: 0x04000051 RID: 81
		private Button button23;

		// Token: 0x04000052 RID: 82
		private Button button24;

		// Token: 0x04000053 RID: 83
		private Label label4;

		// Token: 0x04000054 RID: 84
		private Label label2;

		// Token: 0x04000055 RID: 85
		private Label label3;

		// Token: 0x04000056 RID: 86
		private Button button5;

		// Token: 0x04000057 RID: 87
		private Button button1;

		// Token: 0x04000058 RID: 88
		private Button button2;

		// Token: 0x04000059 RID: 89
		private Button button3;

		// Token: 0x0400005A RID: 90
		private Label label5;

		// Token: 0x0400005B RID: 91
		private Button button4;

		// Token: 0x0400005C RID: 92
		private Button button6;

		// Token: 0x0400005D RID: 93
		private Button button7;

		// Token: 0x0400005E RID: 94
		private Button button8;

		// Token: 0x0400005F RID: 95
		private Button button9;

		// Token: 0x04000060 RID: 96
		private Button button10;

		// Token: 0x04000061 RID: 97
		private Label lblSpeed;

		// Token: 0x04000062 RID: 98
		private Label lblDownload;

		// Token: 0x04000063 RID: 99
		private Label label6;

		// Token: 0x04000064 RID: 100
		private Button button11;

		// Token: 0x04000065 RID: 101
		private ProgressBar progressBar1;
	}
}
