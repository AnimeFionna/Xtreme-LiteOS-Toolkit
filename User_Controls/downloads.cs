using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000B RID: 11
	public class downloads : UserControl
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000079 RID: 121 RVA: 0x0000C848 File Offset: 0x0000AA48
		public static downloads Instance
		{
			get
			{
				bool flag = downloads._instace == null;
				if (flag)
				{
					downloads._instace = new downloads();
				}
				return downloads._instace;
			}
		}

		// Token: 0x0600007A RID: 122 RVA: 0x0000C875 File Offset: 0x0000AA75
		public downloads()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600007B RID: 123 RVA: 0x00002095 File Offset: 0x00000295
		private void downloads_Load(object sender, EventArgs e)
		{
		}

		// Token: 0x0600007C RID: 124 RVA: 0x00002095 File Offset: 0x00000295
		private void panel1_Paint(object sender, PaintEventArgs e)
		{
		}

		// Token: 0x0600007D RID: 125 RVA: 0x0000C898 File Offset: 0x0000AA98
		private void button1_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading 7-Zip...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/872796054129610804/873865244940861480/7z1900.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\7-Zip.exe");
			this.sw.Start();
		}

		// Token: 0x0600007E RID: 126 RVA: 0x0000C928 File Offset: 0x0000AB28
		private void dl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.lblSpeed.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00"));
			this.lblDownload.Text = string.Format("{0} MB / {1} MB", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
			this.progressBar1.Value = e.ProgressPercentage;
		}

		// Token: 0x0600007F RID: 127 RVA: 0x0000C9F8 File Offset: 0x0000ABF8
		private void dl_DownloadFileCompleted(object sender, AsyncCompletedEventArgs e)
		{
			this.sw.Reset();
			this.progressBar1.Value = 0;
			this.lblSpeed.Text = "";
			this.lblDownload.Refresh();
			this.lblDownload.Text = "";
			this.lblDownload.Refresh();
			this.label2.Text = "Status : Idle...";
			this.label2.Refresh();
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

		// Token: 0x06000080 RID: 128 RVA: 0x0000CB1C File Offset: 0x0000AD1C
		private void button3_Click(object sender, EventArgs e)
		{
			this.lblSpeed.Text = "";
			this.lblDownload.Refresh();
			this.progressBar1.Value = 0;
			this.lblDownload.Text = "";
			this.lblDownload.Refresh();
			this.label2.Text = "Status : Idle...";
			this.label2.Refresh();
			this.dl.CancelAsync();
		}

		// Token: 0x06000081 RID: 129 RVA: 0x0000CB9C File Offset: 0x0000AD9C
		private void button2_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Acrobat DC...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe.Acrobat.Pro.DC.2020.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe.Acrobat.Pro.DC.2020.zip");
			this.sw.Start();
		}

		// Token: 0x06000082 RID: 130 RVA: 0x0000CC2C File Offset: 0x0000AE2C
		private void button4_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe After Effects CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_After_Effects_2021_v18.0.1.1x64_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_After_Effects_2021_v18.0.1.1x64_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x06000083 RID: 131 RVA: 0x0000CCBC File Offset: 0x0000AEBC
		private void button5_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Audition CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Audition_2021_v14.0.0.36x64.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Audition_2021_v14.0.0.36x64.zip");
			this.sw.Start();
		}

		// Token: 0x06000084 RID: 132 RVA: 0x0000CD4C File Offset: 0x0000AF4C
		private void button6_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Animate CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Animate_v21.0.1.37179x64_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Animate_v21.0.1.37179x64_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x06000085 RID: 133 RVA: 0x0000CDDC File Offset: 0x0000AFDC
		private void button7_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Bridge CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Bridge.2020/Adobe.Bridge.2020.u6.Multilingual.iso"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe.Bridge.2020.u6.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x06000086 RID: 134 RVA: 0x0000CE6C File Offset: 0x0000B06C
		private void button8_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Character Animator CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Character_Animator_2021_v4.0.0.45x64.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Character_Animator_2021_v4.0.0.45x64.zip");
			this.sw.Start();
		}

		// Token: 0x06000087 RID: 135 RVA: 0x0000CEFC File Offset: 0x0000B0FC
		private void button9_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Dimension v3.3...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Dimension/Adobe.Dimension.v3.3.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.Dimension.v3.3.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x06000088 RID: 136 RVA: 0x0000CF74 File Offset: 0x0000B174
		private void button10_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Dreamveawer CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Dreamweaver.2020/Adobe.Dreamweaver.2020.u1.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.Dreamweaver.2020.u1.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x06000089 RID: 137 RVA: 0x0000D004 File Offset: 0x0000B204
		private void button19_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Fresco v1.9.0...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Fresco/Adobe.Fresco.v1.9.0.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.Fresco.v1.9.0.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x0600008A RID: 138 RVA: 0x0000D094 File Offset: 0x0000B294
		private void button18_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Illustrator CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Illustrator_2021_v25.2.0.220x64.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Illustrator_2021_v25.2.0.220x64.zip");
			this.sw.Start();
		}

		// Token: 0x0600008B RID: 139 RVA: 0x0000D124 File Offset: 0x0000B324
		private void button17_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe InCopy CC 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/InCopy.2020/Adobe.InCopy.2020.u6.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.InCopy.2020.u6.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000D1B4 File Offset: 0x0000B3B4
		private void button16_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe InDesign CC 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/InDesign.2020/Adobe.InDesign.2020.u6.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.InDesign.2020.u6.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x0600008D RID: 141 RVA: 0x0000D244 File Offset: 0x0000B444
		private void button15_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Lightroom Classic v9.4...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Lightroom.Classic/Adobe.Lightroom.Classic.v9.4.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.Lightroom.Classic.v9.4.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x0600008E RID: 142 RVA: 0x0000D2D4 File Offset: 0x0000B4D4
		private void button14_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Media Encoder CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Media_Encoder_2021_v15.0.0.37x64.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Media_Encoder_2021_v15.0.0.37x64.zip");
			this.sw.Start();
		}

		// Token: 0x0600008F RID: 143 RVA: 0x0000D364 File Offset: 0x0000B564
		private void button13_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Photoshop CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Photoshop_2021_v22.3.0.49x64_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Photoshop_2021_v22.3.0.49x64_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x06000090 RID: 144 RVA: 0x0000D3F4 File Offset: 0x0000B5F4
		private void button12_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Prelude CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Prelude_2021_v10.0.0.34x64.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Prelude_2021_v10.0.0.34x64.zip");
			this.sw.Start();
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000D484 File Offset: 0x0000B684
		private void button11_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Premiere Pro CC 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Adobe_Premiere_Pro_2021_v15.0.0.41x64_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Adobe_Premiere_Pro_2021_v15.0.0.41x64_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000D514 File Offset: 0x0000B714
		private void button37_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe Premiere Rush v1.5.8...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Premiere.Rush/Adobe.Premiere.Rush.v1.5.8.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.Premiere.Rush.v1.5.8.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x06000093 RID: 147 RVA: 0x0000D5A4 File Offset: 0x0000B7A4
		private void button36_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Adobe XD v32.00.22...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://main.rfsadobea.workers.dev/0:/Xd/Adobe.XD.v32.0.22.Multilingual.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Adobe.XD.v32.0.22.Multilingual.iso");
			this.sw.Start();
		}

		// Token: 0x06000094 RID: 148 RVA: 0x0000D634 File Offset: 0x0000B834
		private void button35_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Advanced System Care Pro 14...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Advanced%20System%20Care.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Advanced_System_Care_Pro.zip");
			this.sw.Start();
		}

		// Token: 0x06000095 RID: 149 RVA: 0x0000D6C4 File Offset: 0x0000B8C4
		private void button34_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading AOMEI Paritition Assistant 2021...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/AOMEI_Partition_Assistant_9.1.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\AOMEI_Partition_Assistant_9.1.zip");
			this.sw.Start();
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000D754 File Offset: 0x0000B954
		private void button33_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading AOMEI Backupper 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/AOMEI.Backupper.5.8.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\AOMEI.Backupper.5.8.zip");
			this.sw.Start();
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000D7E4 File Offset: 0x0000B9E4
		private void button31_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Audacity...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/audacity-win-3.0.0.exe"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\audacity-win-3.0.0.exe");
			this.sw.Start();
		}

		// Token: 0x06000098 RID: 152 RVA: 0x0000D874 File Offset: 0x0000BA74
		private void button30_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Bandicam...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Bandicam_4.6.4.1728.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Bandicam_4.6.4.1728.zip");
			this.sw.Start();
		}

		// Token: 0x06000099 RID: 153 RVA: 0x0000D904 File Offset: 0x0000BB04
		private void button29_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading BCUninstaller...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/BCUninstaller_4.16_setup.exe"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\BCUninstaller_4.16_setup.exe");
			this.sw.Start();
		}

		// Token: 0x0600009A RID: 154 RVA: 0x0000D994 File Offset: 0x0000BB94
		private void button28_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Betternet VPN...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Betternet.VPN.5.3.0.433.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Betternet.VPN.5.3.0.433.zip");
			this.sw.Start();
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000DA24 File Offset: 0x0000BC24
		private void button27_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Better Discord...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/BetterDiscord-Windows.exe"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\BetterDiscord-Windows.exe");
			this.sw.Start();
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000DAB4 File Offset: 0x0000BCB4
		private void button26_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Brave Browser...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/BraveBrowserStandaloneSetup.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\BraveBrowserStandaloneSetup.exe");
			this.sw.Start();
		}

		// Token: 0x0600009D RID: 157 RVA: 0x0000DB44 File Offset: 0x0000BD44
		private void button25_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Camtasia...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Camtasia_2020.0.13.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Camtasia_2020.0.13.zip");
			this.sw.Start();
		}

		// Token: 0x0600009E RID: 158 RVA: 0x0000DBD4 File Offset: 0x0000BDD4
		private void button24_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading CCleaner...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/837916532003962910/879672232530546698/CCleaner_Professional_Plus_5.74.0.1_2.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\CCleaner_Professional_Plus_5.74.0.1.zip");
			this.sw.Start();
		}

		// Token: 0x0600009F RID: 159 RVA: 0x0000DC64 File Offset: 0x0000BE64
		private void button23_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Cinema 4D...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Maxon_CINEMA_4D_Studio_R20.059_.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Maxon_CINEMA_4D_Studio_R20.059_.zip");
			this.sw.Start();
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x0000DCF4 File Offset: 0x0000BEF4
		private void button22_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading CorelCAD...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/CorelCAD_Build_21.0.1.1031.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\CorelCAD_Build_21.0.1.1031.rar");
			this.sw.Start();
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000DD84 File Offset: 0x0000BF84
		private void button21_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Corel Draw Graphics Suite...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/CorelDRAW_Graphics_Suite_2021_v23.0.0.363x64.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\CorelDRAW_Graphics_Suite_2021_v23.0.0.363x64.zip");
			this.sw.Start();
		}

		// Token: 0x060000A2 RID: 162 RVA: 0x0000DE14 File Offset: 0x0000C014
		private void button20_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Daum Pot Player...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://t1.daumcdn.net/potplayer/PotPlayer/Version/Latest/PotPlayerSetup64.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\PotPlayerSetup64.exe");
			this.sw.Start();
		}

		// Token: 0x060000A3 RID: 163 RVA: 0x0000DEA4 File Offset: 0x0000C0A4
		private void button55_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Discord...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://dl.discordapp.net/distro/app/stable/win/x86/1.0.9002/DiscordSetup.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\DiscordSetup.exe");
			this.sw.Start();
		}

		// Token: 0x060000A4 RID: 164 RVA: 0x0000DF34 File Offset: 0x0000C134
		private void button54_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading EaseUS Data Recovery 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/EaseUS_Data_Recovery_Wizard_Technician_13.6_Multilingual.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\EaseUS_Data_Recovery_Wizard_Technician_13.6_Multilingual.rar");
			this.sw.Start();
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x0000DFC4 File Offset: 0x0000C1C4
		private void button53_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading EaseUS Partition Manager 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/EaseUS_Partition_Master_13.8_Technician_Edition.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\EaseUS_Partition_Master_13.8_Technician_Edition.rar");
			this.sw.Start();
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000E054 File Offset: 0x0000C254
		private void button52_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Fl Studio...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/FL_Studio_Producer_Edition_20.7.2_Build_1863.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\FL_Studio_Producer_Edition_20.7.2_Build_1863.zip");
			this.sw.Start();
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000E0E4 File Offset: 0x0000C2E4
		private void button51_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading F-Secure Freedome VPN...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/F-Secure%20Freedome%20VPN%202.16.5289.0.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\F-Secure_Freedome_VPN_02.16.5289.0.zip");
			this.sw.Start();
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x0000E174 File Offset: 0x0000C374
		private void button50_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Handbrake...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/HandBrake-1.3.3-x86_64-Win_GUI.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\HandBrake-1.3.3-x86_64-Win_GUI.exe");
			this.sw.Start();
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x0000E204 File Offset: 0x0000C404
		private void button49_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading HTTP Downloader...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/HTTP%20Downloader.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\HTTP_Downloader.zip");
			this.sw.Start();
		}

		// Token: 0x060000AA RID: 170 RVA: 0x0000E294 File Offset: 0x0000C494
		private void button48_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Internet Download Manager...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.discordapp.com/attachments/837916532003962910/879674154167721984/Internet_Download_Manager_v6.39.2.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Internet_Download_Manager.zip");
			this.sw.Start();
		}

		// Token: 0x060000AB RID: 171 RVA: 0x0000E324 File Offset: 0x0000C524
		private void button47_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading iTunes...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/iTunes64Setup.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\iTunes64Setup.exe");
			this.sw.Start();
		}

		// Token: 0x060000AC RID: 172 RVA: 0x0000E3B4 File Offset: 0x0000C5B4
		private void button46_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading GIMP...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/gimp-2.10.24-setup-2.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\gimp-2.10.24-setup-2.exe");
			this.sw.Start();
		}

		// Token: 0x060000AD RID: 173 RVA: 0x0000E444 File Offset: 0x0000C644
		private void button45_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading GOM Player...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://cdn.gomlab.com/gretech/player/GOMPLAYERGLOBALSETUP_CHROME.EXE"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\GOMPLAYERGLOBALSETUP_CHROME.EXE");
			this.sw.Start();
		}

		// Token: 0x060000AE RID: 174 RVA: 0x0000E4D4 File Offset: 0x0000C6D4
		private void button44_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Google Chrome...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/92.0.4515.131_chrome_installer.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\92.0.4515.131_chrome_installer.exe");
			this.sw.Start();
		}

		// Token: 0x060000AF RID: 175 RVA: 0x0000E564 File Offset: 0x0000C764
		private void button43_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading K-Lite Codec Pack (STD)...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/K-Lite_Codec_Pack_1635_Standard.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\K-Lite_Codec_Pack_1635_Standard.exe");
			this.sw.Start();
		}

		// Token: 0x060000B0 RID: 176 RVA: 0x0000E5F4 File Offset: 0x0000C7F4
		private void button42_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading K-Lite Codec Pack (Full)...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/K-Lite_Codec_Pack_1635_Full.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\K-Lite_Codec_Pack_1635_Full.exe");
			this.sw.Start();
		}

		// Token: 0x060000B1 RID: 177 RVA: 0x0000E684 File Offset: 0x0000C884
		private void button41_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading K-Lite Codec Pack (Mega)...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/K-Lite_Codec_Pack_1635_Mega.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\K-Lite_Codec_Pack_1635_Mega.exe");
			this.sw.Start();
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000E714 File Offset: 0x0000C914
		private void button40_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Libre Office 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/LibreOffice_7.1.0.rar"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\LibreOffice_7.1.0.rar");
			this.sw.Start();
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x0000E7A4 File Offset: 0x0000C9A4
		private void button39_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Lightcord...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/LightcordSetup.exe"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\LightcordSetup.exe");
			this.sw.Start();
		}

		// Token: 0x060000B4 RID: 180 RVA: 0x0000E834 File Offset: 0x0000CA34
		private void button38_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading MAGIX Acid Pro 2020...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/TOOLKIT/MAGIX.ACID.Pro.10.0.2.20x64.zip"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\MAGIX.ACID.Pro.10.0.2.20x64.rar");
			this.sw.Start();
		}

		// Token: 0x060000B5 RID: 181 RVA: 0x0000E8C4 File Offset: 0x0000CAC4
		private void button73_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading MAGIX Vegas Movie Studio...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/TOOLKIT/Copy%20of%20MAGIX_VEGAS_Movie_Studio_Platinum_17.0.0.143.zip"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\MAGIX_VEGAS_Movie_Studio_Platinum_17.0.0.143.zip");
			this.sw.Start();
		}

		// Token: 0x060000B6 RID: 182 RVA: 0x0000E954 File Offset: 0x0000CB54
		private void button72_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading MAGIX Vegas Pro 18...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/MAGIX_VEGAS_Pro_v18.0.0.482x64.zip"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\MAGIX_VEGAS_Pro_v18.0.0.482x64.zip");
			this.sw.Start();
		}

		// Token: 0x060000B7 RID: 183 RVA: 0x0000E9E4 File Offset: 0x0000CBE4
		private void button71_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Media Player Classic...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/MPC-HC.1.7.9.x86.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\MPC-HC.1.7.9.x86.exe");
			this.sw.Start();
		}

		// Token: 0x060000B8 RID: 184 RVA: 0x0000EA74 File Offset: 0x0000CC74
		private void button70_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Office 2007...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://ia902905.us.archive.org/0/items/ms-office-2007/MS%20Office%202007.iso"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Microsoft.Office.2007.Enterprise.x64.CD.iso");
			this.sw.Start();
		}

		// Token: 0x060000B9 RID: 185 RVA: 0x0000EB04 File Offset: 0x0000CD04
		private void button69_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Office 2010...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://ia803100.us.archive.org/14/items/MicrosoftOffice2010ProfessionalPlus64bit/Microsoft%20Office%202010%20Professional%20Plus%2064bit.ISO"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Microsoft.Office.2010.Professional.Plus.64bit.ISO");
			this.sw.Start();
		}

		// Token: 0x060000BA RID: 186 RVA: 0x0000EB94 File Offset: 0x0000CD94
		private void button68_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Office 2013...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://iso.epubg691.workers.dev/0:/Office2013.x64.en-US.ISO"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Office2013.x64.en-US.ISO");
			this.sw.Start();
		}

		// Token: 0x060000BB RID: 187 RVA: 0x0000EC24 File Offset: 0x0000CE24
		private void button67_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Office 2016...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Copy%20of%20Microsoft.Office.2016.Pro.Plus.x64.en-US.img"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Microsoft.Office.2016.Pro.Plus.x64.en-US.img");
			this.sw.Start();
		}

		// Token: 0x060000BC RID: 188 RVA: 0x0000ECB4 File Offset: 0x0000CEB4
		private void button66_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Office 2019...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://iso.epubg691.workers.dev/0:/PROX64.OFF19.ENU.MAY2021.ISO"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\PROX64.OFF19.ENU.MAY2021.ISO");
			this.sw.Start();
		}

		// Token: 0x060000BD RID: 189 RVA: 0x0000ED44 File Offset: 0x0000CF44
		private void button65_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Office 365...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("http://officecdn.microsoft.com.edgesuite.net/db/492350F6-3A01-4F97-B9C0-C7C6DDF67D60/media/en-US/O365ProPlusRetail.img"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Office365ProPlusRetail.img");
			this.sw.Start();
		}

		// Token: 0x060000BE RID: 190 RVA: 0x0000EDD4 File Offset: 0x0000CFD4
		private void button64_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Minitool Partition Wizard...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/MiniTool_Partition_Wizard_12.0.zip"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\MiniTool_Partition_Wizard_12.0.zip");
			this.sw.Start();
		}

		// Token: 0x060000BF RID: 191 RVA: 0x0000EE64 File Offset: 0x0000D064
		private void button63_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Minitool Power Data Recovery...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/TOOLKIT/MiniTool_Power_Data_Recovery_Business_Technician_9.2.zip"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\MiniTool.Power.Data.Recovery.9.0.zip");
			this.sw.Start();
		}

		// Token: 0x060000C0 RID: 192 RVA: 0x0000EEF4 File Offset: 0x0000D0F4
		private void button62_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Mozilla Firefox...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Firefox%20Setup%2091.0b9.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Firefox Setup 91.0b9.exe");
			this.sw.Start();
		}

		// Token: 0x060000C1 RID: 193 RVA: 0x0000EF84 File Offset: 0x0000D184
		private void button61_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Mozilla Thunderbird...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://download-installer.cdn.mozilla.net/pub/thunderbird/releases/78.12.0/win64/en-US/Thunderbird%20Setup%2078.12.0.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Thunderbird_Setup_78.12.0.exe");
			this.sw.Start();
		}

		// Token: 0x060000C2 RID: 194 RVA: 0x0000F014 File Offset: 0x0000D214
		private void button60_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Net Limiter...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/NetLimiter_Pro_4.1.8_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\NetLimiter_Pro_4.1.8_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x060000C3 RID: 195 RVA: 0x0000F0A4 File Offset: 0x0000D2A4
		private void button32_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Net Speed Monitor...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/netspeedmonitor_2_5_4_0_x64_setup.msi"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\netspeedmonitor_2_5_4_0_x64_setup.msi");
			this.sw.Start();
		}

		// Token: 0x060000C4 RID: 196 RVA: 0x0000F134 File Offset: 0x0000D334
		private void button59_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Notepad++...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/npp.8.1.1.Installer.x64.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\npp.8.1.1.Installer.x64.exe");
			this.sw.Start();
		}

		// Token: 0x060000C5 RID: 197 RVA: 0x0000F1C4 File Offset: 0x0000D3C4
		private void button58_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading OBS Studio...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/OBS-Studio-27.0.1-Full-Installer-x64.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\OBS-Studio-27.0.1-Full-Installer-x64.exe");
			this.sw.Start();
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000F254 File Offset: 0x0000D454
		private void button57_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Opera GX...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Opera_GX_77.0.4054.257_Setup_x64.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Opera_GX_77.0.4054.257_Setup_x64.exe");
			this.sw.Start();
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x0000F2E4 File Offset: 0x0000D4E4
		private void button56_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Oracle Virtual Box...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/VirtualBox-6.1.18-142142-Win.exe"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\VirtualBox-6.1.18-142142-Win.exe");
			this.sw.Start();
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x0000F374 File Offset: 0x0000D574
		private void button91_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading PowerISO...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/PowerISO_v7.9.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\PowerISO_v7.9.zip");
			this.sw.Start();
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x0000F404 File Offset: 0x0000D604
		private void button90_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Razer Cortex...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/RazerCortexInstaller.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\RazerCortexInstaller.exe");
			this.sw.Start();
		}

		// Token: 0x060000CA RID: 202 RVA: 0x0000F494 File Offset: 0x0000D694
		private void button89_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Revo Uninstaller...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Revo_Uninstaller_Pro_4.4.2.zip"), "C:\\Xtreme_LiteOS_ToolKit\\Downloads\\Revo_Uninstaller_Pro_4.4.2.zip");
			this.sw.Start();
		}

		// Token: 0x060000CB RID: 203 RVA: 0x0000F524 File Offset: 0x0000D724
		private void button88_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Streamlabs OBS...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Streamlabs+OBS+Setup+1.3.2-7sBPCH6nkIHnbsf.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Streamlabs.OBS.Setup.1.3.2-7.exe");
			this.sw.Start();
		}

		// Token: 0x060000CC RID: 204 RVA: 0x0000F5B4 File Offset: 0x0000D7B4
		private void button87_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading StartIsBack...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/StartIsBack.v2.9.8.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\StartIsBack.v2.9.8.zip");
			this.sw.Start();
		}

		// Token: 0x060000CD RID: 205 RVA: 0x0000F644 File Offset: 0x0000D844
		private void button86_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Sublime Text...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Sublime_Text_3.2.2_Build_3211_Stable.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Sublime_Text_3.2.2_Build_3211_Stable.zip");
			this.sw.Start();
		}

		// Token: 0x060000CE RID: 206 RVA: 0x0000F6D4 File Offset: 0x0000D8D4
		private void button85_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Spotify...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/SpotifyFullSetup.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\SpotifyFullSetup.exe");
			this.sw.Start();
		}

		// Token: 0x060000CF RID: 207 RVA: 0x0000F764 File Offset: 0x0000D964
		private void button84_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading TeamViewer...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/teamviewer_15.19.5F.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Teamviewer_15.19.5.Full-Portable.zip");
			this.sw.Start();
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x0000F7F4 File Offset: 0x0000D9F4
		private void button83_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading µTorrent...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/ut_pack_1.2.3.50.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\uTorrent.1.2.3.50.Full-Portable.zip");
			this.sw.Start();
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x0000F884 File Offset: 0x0000DA84
		private void button82_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Visual Studio 2015...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/_vs2015.pro_enu.iso"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\vs2015.pro_enu.iso");
			this.sw.Start();
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x0000F914 File Offset: 0x0000DB14
		private void button81_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Visual Studio 2017...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://iso.epubg691.workers.dev/0:/en_ru_visual_studio_ent_pro_comm_testpro_2017_x86_x64_dvd.iso"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\en_ru_visual_studio_ent_pro_comm_testpro_2017_x86_x64_dvd.iso");
			this.sw.Start();
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x0000F9A4 File Offset: 0x0000DBA4
		private void button80_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading VLC Media Player...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://mirrors.estointernet.in/videolan/vlc/3.0.16/win64/vlc-3.0.16-win64.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\vlc-3.0.16-win64.exe");
			this.sw.Start();
		}

		// Token: 0x060000D4 RID: 212 RVA: 0x0000FA34 File Offset: 0x0000DC34
		private void button79_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading VM Ware Workstation 16...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/VMware_Workstation_Pro_16.0.0.59684.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\VMware_Workstation_Pro_16.0.0.59684.rar");
			this.sw.Start();
		}

		// Token: 0x060000D5 RID: 213 RVA: 0x0000FAC4 File Offset: 0x0000DCC4
		private void button78_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading WinRAR...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/winrar-x64-602.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\winrar-x64-602.zip");
			this.sw.Start();
		}

		// Token: 0x060000D6 RID: 214 RVA: 0x0000FB54 File Offset: 0x0000DD54
		private void button77_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Wondershare Filmora X...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Wondershare_Filmora_v10.0.0.94x64_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Wondershare_Filmora_v10.0.0.94x64_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x060000D7 RID: 215 RVA: 0x0000FBE4 File Offset: 0x0000DDE4
		private void button76_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Wonderfox HD Video Converter...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/WonderFox.HD.Video.Converter.Factory.Pro.19.2.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\WonderFox.HD.Video.Converter.Factory.Pro.19.2.zip");
			this.sw.Start();
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x0000FC74 File Offset: 0x0000DE74
		private void button75_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading WPS Office...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/WPS_Office%EF%BB%BF_2020_v11.2.0.9629_Multilingual.zip"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\WPS_Office_2020_v11.2.0.9629_Multilingual.zip");
			this.sw.Start();
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button93_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000020AF File Offset: 0x000002AF
		private void button92_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000020BD File Offset: 0x000002BD
		private void button94_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x060000DC RID: 220 RVA: 0x0000FD04 File Offset: 0x0000DF04
		private void button98_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading AMD Radeon Software...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/AMD%20Radeon%20Software.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\AMD_Radeon_Software.exe");
			this.sw.Start();
		}

		// Token: 0x060000DD RID: 221 RVA: 0x0000FD94 File Offset: 0x0000DF94
		private void button96_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Intel Driver And Support Assistant...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/Intel-Driver-and-Support-Assistant-Installer.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Intel-Driver-and-Support-Assistant-Installer.exe");
			this.sw.Start();
		}

		// Token: 0x060000DE RID: 222 RVA: 0x0000FE24 File Offset: 0x0000E024
		private void button97_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading NVIDIA GeForce Experience...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/GeForce_Experience_v3.23.0.74.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\GeForce_Experience_v3.23.0.74.exe");
			this.sw.Start();
		}

		// Token: 0x060000DF RID: 223 RVA: 0x00002370 File Offset: 0x00000570
		private void button74_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x060000E0 RID: 224 RVA: 0x0000FEB4 File Offset: 0x0000E0B4
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x060000E1 RID: 225 RVA: 0x0000FEEC File Offset: 0x0000E0EC
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(downloads));
			this.label1 = new Label();
			this.panel1 = new Panel();
			this.button98 = new Button();
			this.label273 = new Label();
			this.label274 = new Label();
			this.label275 = new Label();
			this.button97 = new Button();
			this.label270 = new Label();
			this.label271 = new Label();
			this.label272 = new Label();
			this.button96 = new Button();
			this.label267 = new Label();
			this.label268 = new Label();
			this.label269 = new Label();
			this.button75 = new Button();
			this.button76 = new Button();
			this.button77 = new Button();
			this.button78 = new Button();
			this.button79 = new Button();
			this.button80 = new Button();
			this.button81 = new Button();
			this.label33 = new Label();
			this.label135 = new Label();
			this.button82 = new Button();
			this.label134 = new Label();
			this.button83 = new Button();
			this.button32 = new Button();
			this.button84 = new Button();
			this.button85 = new Button();
			this.button86 = new Button();
			this.button87 = new Button();
			this.button88 = new Button();
			this.button89 = new Button();
			this.button90 = new Button();
			this.button91 = new Button();
			this.button56 = new Button();
			this.button57 = new Button();
			this.button58 = new Button();
			this.button59 = new Button();
			this.button60 = new Button();
			this.button61 = new Button();
			this.button62 = new Button();
			this.button63 = new Button();
			this.button64 = new Button();
			this.button65 = new Button();
			this.button66 = new Button();
			this.button67 = new Button();
			this.button68 = new Button();
			this.button69 = new Button();
			this.button70 = new Button();
			this.button71 = new Button();
			this.button72 = new Button();
			this.button73 = new Button();
			this.button38 = new Button();
			this.button39 = new Button();
			this.button40 = new Button();
			this.button41 = new Button();
			this.button42 = new Button();
			this.button43 = new Button();
			this.button44 = new Button();
			this.button45 = new Button();
			this.button46 = new Button();
			this.button47 = new Button();
			this.button48 = new Button();
			this.button49 = new Button();
			this.button50 = new Button();
			this.button51 = new Button();
			this.button52 = new Button();
			this.button53 = new Button();
			this.button54 = new Button();
			this.button55 = new Button();
			this.button20 = new Button();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.button25 = new Button();
			this.button26 = new Button();
			this.button27 = new Button();
			this.button28 = new Button();
			this.button29 = new Button();
			this.button30 = new Button();
			this.button31 = new Button();
			this.button33 = new Button();
			this.button34 = new Button();
			this.button35 = new Button();
			this.button36 = new Button();
			this.button37 = new Button();
			this.button11 = new Button();
			this.button12 = new Button();
			this.button13 = new Button();
			this.button14 = new Button();
			this.button15 = new Button();
			this.button16 = new Button();
			this.button17 = new Button();
			this.button18 = new Button();
			this.button19 = new Button();
			this.button10 = new Button();
			this.button9 = new Button();
			this.button8 = new Button();
			this.button7 = new Button();
			this.button6 = new Button();
			this.button5 = new Button();
			this.button4 = new Button();
			this.button2 = new Button();
			this.button1 = new Button();
			this.label264 = new Label();
			this.label265 = new Label();
			this.label262 = new Label();
			this.label263 = new Label();
			this.label260 = new Label();
			this.label261 = new Label();
			this.label258 = new Label();
			this.label259 = new Label();
			this.label256 = new Label();
			this.label257 = new Label();
			this.label254 = new Label();
			this.label255 = new Label();
			this.label252 = new Label();
			this.label253 = new Label();
			this.label250 = new Label();
			this.label251 = new Label();
			this.label248 = new Label();
			this.label249 = new Label();
			this.label246 = new Label();
			this.label247 = new Label();
			this.label244 = new Label();
			this.label245 = new Label();
			this.label242 = new Label();
			this.label243 = new Label();
			this.label240 = new Label();
			this.label241 = new Label();
			this.label238 = new Label();
			this.label239 = new Label();
			this.label236 = new Label();
			this.label237 = new Label();
			this.label234 = new Label();
			this.label235 = new Label();
			this.label232 = new Label();
			this.label233 = new Label();
			this.label230 = new Label();
			this.label231 = new Label();
			this.label228 = new Label();
			this.label229 = new Label();
			this.label226 = new Label();
			this.label227 = new Label();
			this.label224 = new Label();
			this.label225 = new Label();
			this.label222 = new Label();
			this.label223 = new Label();
			this.label220 = new Label();
			this.label221 = new Label();
			this.label218 = new Label();
			this.label219 = new Label();
			this.label216 = new Label();
			this.label217 = new Label();
			this.label214 = new Label();
			this.label215 = new Label();
			this.label212 = new Label();
			this.label213 = new Label();
			this.label210 = new Label();
			this.label211 = new Label();
			this.label208 = new Label();
			this.label209 = new Label();
			this.label206 = new Label();
			this.label207 = new Label();
			this.label204 = new Label();
			this.label205 = new Label();
			this.label202 = new Label();
			this.label203 = new Label();
			this.label200 = new Label();
			this.label201 = new Label();
			this.label198 = new Label();
			this.label199 = new Label();
			this.label196 = new Label();
			this.label197 = new Label();
			this.label194 = new Label();
			this.label195 = new Label();
			this.label192 = new Label();
			this.label193 = new Label();
			this.label190 = new Label();
			this.label191 = new Label();
			this.label188 = new Label();
			this.label189 = new Label();
			this.label186 = new Label();
			this.label187 = new Label();
			this.label184 = new Label();
			this.label185 = new Label();
			this.label182 = new Label();
			this.label183 = new Label();
			this.label180 = new Label();
			this.label181 = new Label();
			this.label178 = new Label();
			this.label179 = new Label();
			this.label176 = new Label();
			this.label177 = new Label();
			this.label174 = new Label();
			this.label175 = new Label();
			this.label172 = new Label();
			this.label173 = new Label();
			this.label170 = new Label();
			this.label171 = new Label();
			this.label168 = new Label();
			this.label169 = new Label();
			this.label166 = new Label();
			this.label167 = new Label();
			this.label164 = new Label();
			this.label165 = new Label();
			this.label162 = new Label();
			this.label163 = new Label();
			this.label160 = new Label();
			this.label161 = new Label();
			this.label158 = new Label();
			this.label159 = new Label();
			this.label156 = new Label();
			this.label157 = new Label();
			this.label154 = new Label();
			this.label155 = new Label();
			this.label152 = new Label();
			this.label153 = new Label();
			this.label150 = new Label();
			this.label151 = new Label();
			this.label148 = new Label();
			this.label149 = new Label();
			this.label146 = new Label();
			this.label147 = new Label();
			this.label144 = new Label();
			this.label145 = new Label();
			this.label142 = new Label();
			this.label143 = new Label();
			this.label140 = new Label();
			this.label141 = new Label();
			this.label138 = new Label();
			this.label139 = new Label();
			this.label136 = new Label();
			this.label137 = new Label();
			this.label132 = new Label();
			this.label133 = new Label();
			this.label130 = new Label();
			this.label131 = new Label();
			this.label128 = new Label();
			this.label129 = new Label();
			this.label126 = new Label();
			this.label127 = new Label();
			this.label124 = new Label();
			this.label125 = new Label();
			this.label122 = new Label();
			this.label123 = new Label();
			this.label120 = new Label();
			this.label121 = new Label();
			this.label118 = new Label();
			this.label119 = new Label();
			this.label116 = new Label();
			this.label117 = new Label();
			this.label114 = new Label();
			this.label115 = new Label();
			this.label112 = new Label();
			this.label113 = new Label();
			this.label110 = new Label();
			this.label111 = new Label();
			this.label108 = new Label();
			this.label109 = new Label();
			this.label106 = new Label();
			this.label107 = new Label();
			this.label104 = new Label();
			this.label105 = new Label();
			this.label102 = new Label();
			this.label103 = new Label();
			this.label83 = new Label();
			this.label101 = new Label();
			this.label81 = new Label();
			this.label82 = new Label();
			this.label79 = new Label();
			this.label80 = new Label();
			this.label77 = new Label();
			this.label78 = new Label();
			this.label76 = new Label();
			this.label75 = new Label();
			this.label84 = new Label();
			this.label85 = new Label();
			this.label86 = new Label();
			this.label87 = new Label();
			this.label88 = new Label();
			this.label89 = new Label();
			this.label90 = new Label();
			this.label91 = new Label();
			this.label92 = new Label();
			this.label93 = new Label();
			this.label94 = new Label();
			this.label95 = new Label();
			this.label96 = new Label();
			this.label97 = new Label();
			this.label98 = new Label();
			this.label99 = new Label();
			this.label100 = new Label();
			this.label39 = new Label();
			this.label40 = new Label();
			this.label41 = new Label();
			this.label42 = new Label();
			this.label43 = new Label();
			this.label44 = new Label();
			this.label45 = new Label();
			this.label46 = new Label();
			this.label47 = new Label();
			this.label48 = new Label();
			this.label49 = new Label();
			this.label50 = new Label();
			this.label51 = new Label();
			this.label52 = new Label();
			this.label53 = new Label();
			this.label54 = new Label();
			this.label55 = new Label();
			this.label56 = new Label();
			this.label57 = new Label();
			this.label58 = new Label();
			this.label59 = new Label();
			this.label60 = new Label();
			this.label61 = new Label();
			this.label62 = new Label();
			this.label63 = new Label();
			this.label64 = new Label();
			this.label65 = new Label();
			this.label66 = new Label();
			this.label67 = new Label();
			this.label68 = new Label();
			this.label69 = new Label();
			this.label70 = new Label();
			this.label71 = new Label();
			this.label72 = new Label();
			this.label73 = new Label();
			this.label74 = new Label();
			this.label21 = new Label();
			this.label22 = new Label();
			this.label23 = new Label();
			this.label24 = new Label();
			this.label25 = new Label();
			this.label26 = new Label();
			this.label27 = new Label();
			this.label28 = new Label();
			this.label29 = new Label();
			this.label30 = new Label();
			this.label31 = new Label();
			this.label32 = new Label();
			this.label34 = new Label();
			this.label35 = new Label();
			this.label36 = new Label();
			this.label37 = new Label();
			this.label38 = new Label();
			this.label15 = new Label();
			this.label16 = new Label();
			this.label17 = new Label();
			this.label18 = new Label();
			this.label19 = new Label();
			this.label20 = new Label();
			this.label9 = new Label();
			this.label10 = new Label();
			this.label11 = new Label();
			this.label12 = new Label();
			this.label13 = new Label();
			this.label14 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.progressBar1 = new ProgressBar();
			this.button3 = new Button();
			this.label2 = new Label();
			this.lblDownload = new Label();
			this.lblSpeed = new Label();
			this.button74 = new Button();
			this.button92 = new Button();
			this.button93 = new Button();
			this.button94 = new Button();
			this.label266 = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 5);
			this.label1.Name = "label1";
			this.label1.Size = new Size(193, 53);
			this.label1.TabIndex = 4;
			this.label1.Text = "Downloads";
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.button98);
			this.panel1.Controls.Add(this.label273);
			this.panel1.Controls.Add(this.label274);
			this.panel1.Controls.Add(this.label275);
			this.panel1.Controls.Add(this.button97);
			this.panel1.Controls.Add(this.label270);
			this.panel1.Controls.Add(this.label271);
			this.panel1.Controls.Add(this.label272);
			this.panel1.Controls.Add(this.button96);
			this.panel1.Controls.Add(this.label267);
			this.panel1.Controls.Add(this.label268);
			this.panel1.Controls.Add(this.label269);
			this.panel1.Controls.Add(this.button75);
			this.panel1.Controls.Add(this.button76);
			this.panel1.Controls.Add(this.button77);
			this.panel1.Controls.Add(this.button78);
			this.panel1.Controls.Add(this.button79);
			this.panel1.Controls.Add(this.button80);
			this.panel1.Controls.Add(this.button81);
			this.panel1.Controls.Add(this.label33);
			this.panel1.Controls.Add(this.label135);
			this.panel1.Controls.Add(this.button82);
			this.panel1.Controls.Add(this.label134);
			this.panel1.Controls.Add(this.button83);
			this.panel1.Controls.Add(this.button32);
			this.panel1.Controls.Add(this.button84);
			this.panel1.Controls.Add(this.button85);
			this.panel1.Controls.Add(this.button86);
			this.panel1.Controls.Add(this.button87);
			this.panel1.Controls.Add(this.button88);
			this.panel1.Controls.Add(this.button89);
			this.panel1.Controls.Add(this.button90);
			this.panel1.Controls.Add(this.button91);
			this.panel1.Controls.Add(this.button56);
			this.panel1.Controls.Add(this.button57);
			this.panel1.Controls.Add(this.button58);
			this.panel1.Controls.Add(this.button59);
			this.panel1.Controls.Add(this.button60);
			this.panel1.Controls.Add(this.button61);
			this.panel1.Controls.Add(this.button62);
			this.panel1.Controls.Add(this.button63);
			this.panel1.Controls.Add(this.button64);
			this.panel1.Controls.Add(this.button65);
			this.panel1.Controls.Add(this.button66);
			this.panel1.Controls.Add(this.button67);
			this.panel1.Controls.Add(this.button68);
			this.panel1.Controls.Add(this.button69);
			this.panel1.Controls.Add(this.button70);
			this.panel1.Controls.Add(this.button71);
			this.panel1.Controls.Add(this.button72);
			this.panel1.Controls.Add(this.button73);
			this.panel1.Controls.Add(this.button38);
			this.panel1.Controls.Add(this.button39);
			this.panel1.Controls.Add(this.button40);
			this.panel1.Controls.Add(this.button41);
			this.panel1.Controls.Add(this.button42);
			this.panel1.Controls.Add(this.button43);
			this.panel1.Controls.Add(this.button44);
			this.panel1.Controls.Add(this.button45);
			this.panel1.Controls.Add(this.button46);
			this.panel1.Controls.Add(this.button47);
			this.panel1.Controls.Add(this.button48);
			this.panel1.Controls.Add(this.button49);
			this.panel1.Controls.Add(this.button50);
			this.panel1.Controls.Add(this.button51);
			this.panel1.Controls.Add(this.button52);
			this.panel1.Controls.Add(this.button53);
			this.panel1.Controls.Add(this.button54);
			this.panel1.Controls.Add(this.button55);
			this.panel1.Controls.Add(this.button20);
			this.panel1.Controls.Add(this.button21);
			this.panel1.Controls.Add(this.button22);
			this.panel1.Controls.Add(this.button23);
			this.panel1.Controls.Add(this.button24);
			this.panel1.Controls.Add(this.button25);
			this.panel1.Controls.Add(this.button26);
			this.panel1.Controls.Add(this.button27);
			this.panel1.Controls.Add(this.button28);
			this.panel1.Controls.Add(this.button29);
			this.panel1.Controls.Add(this.button30);
			this.panel1.Controls.Add(this.button31);
			this.panel1.Controls.Add(this.button33);
			this.panel1.Controls.Add(this.button34);
			this.panel1.Controls.Add(this.button35);
			this.panel1.Controls.Add(this.button36);
			this.panel1.Controls.Add(this.button37);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.button12);
			this.panel1.Controls.Add(this.button13);
			this.panel1.Controls.Add(this.button14);
			this.panel1.Controls.Add(this.button15);
			this.panel1.Controls.Add(this.button16);
			this.panel1.Controls.Add(this.button17);
			this.panel1.Controls.Add(this.button18);
			this.panel1.Controls.Add(this.button19);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.label264);
			this.panel1.Controls.Add(this.label265);
			this.panel1.Controls.Add(this.label262);
			this.panel1.Controls.Add(this.label263);
			this.panel1.Controls.Add(this.label260);
			this.panel1.Controls.Add(this.label261);
			this.panel1.Controls.Add(this.label258);
			this.panel1.Controls.Add(this.label259);
			this.panel1.Controls.Add(this.label256);
			this.panel1.Controls.Add(this.label257);
			this.panel1.Controls.Add(this.label254);
			this.panel1.Controls.Add(this.label255);
			this.panel1.Controls.Add(this.label252);
			this.panel1.Controls.Add(this.label253);
			this.panel1.Controls.Add(this.label250);
			this.panel1.Controls.Add(this.label251);
			this.panel1.Controls.Add(this.label248);
			this.panel1.Controls.Add(this.label249);
			this.panel1.Controls.Add(this.label246);
			this.panel1.Controls.Add(this.label247);
			this.panel1.Controls.Add(this.label244);
			this.panel1.Controls.Add(this.label245);
			this.panel1.Controls.Add(this.label242);
			this.panel1.Controls.Add(this.label243);
			this.panel1.Controls.Add(this.label240);
			this.panel1.Controls.Add(this.label241);
			this.panel1.Controls.Add(this.label238);
			this.panel1.Controls.Add(this.label239);
			this.panel1.Controls.Add(this.label236);
			this.panel1.Controls.Add(this.label237);
			this.panel1.Controls.Add(this.label234);
			this.panel1.Controls.Add(this.label235);
			this.panel1.Controls.Add(this.label232);
			this.panel1.Controls.Add(this.label233);
			this.panel1.Controls.Add(this.label230);
			this.panel1.Controls.Add(this.label231);
			this.panel1.Controls.Add(this.label228);
			this.panel1.Controls.Add(this.label229);
			this.panel1.Controls.Add(this.label226);
			this.panel1.Controls.Add(this.label227);
			this.panel1.Controls.Add(this.label224);
			this.panel1.Controls.Add(this.label225);
			this.panel1.Controls.Add(this.label222);
			this.panel1.Controls.Add(this.label223);
			this.panel1.Controls.Add(this.label220);
			this.panel1.Controls.Add(this.label221);
			this.panel1.Controls.Add(this.label218);
			this.panel1.Controls.Add(this.label219);
			this.panel1.Controls.Add(this.label216);
			this.panel1.Controls.Add(this.label217);
			this.panel1.Controls.Add(this.label214);
			this.panel1.Controls.Add(this.label215);
			this.panel1.Controls.Add(this.label212);
			this.panel1.Controls.Add(this.label213);
			this.panel1.Controls.Add(this.label210);
			this.panel1.Controls.Add(this.label211);
			this.panel1.Controls.Add(this.label208);
			this.panel1.Controls.Add(this.label209);
			this.panel1.Controls.Add(this.label206);
			this.panel1.Controls.Add(this.label207);
			this.panel1.Controls.Add(this.label204);
			this.panel1.Controls.Add(this.label205);
			this.panel1.Controls.Add(this.label202);
			this.panel1.Controls.Add(this.label203);
			this.panel1.Controls.Add(this.label200);
			this.panel1.Controls.Add(this.label201);
			this.panel1.Controls.Add(this.label198);
			this.panel1.Controls.Add(this.label199);
			this.panel1.Controls.Add(this.label196);
			this.panel1.Controls.Add(this.label197);
			this.panel1.Controls.Add(this.label194);
			this.panel1.Controls.Add(this.label195);
			this.panel1.Controls.Add(this.label192);
			this.panel1.Controls.Add(this.label193);
			this.panel1.Controls.Add(this.label190);
			this.panel1.Controls.Add(this.label191);
			this.panel1.Controls.Add(this.label188);
			this.panel1.Controls.Add(this.label189);
			this.panel1.Controls.Add(this.label186);
			this.panel1.Controls.Add(this.label187);
			this.panel1.Controls.Add(this.label184);
			this.panel1.Controls.Add(this.label185);
			this.panel1.Controls.Add(this.label182);
			this.panel1.Controls.Add(this.label183);
			this.panel1.Controls.Add(this.label180);
			this.panel1.Controls.Add(this.label181);
			this.panel1.Controls.Add(this.label178);
			this.panel1.Controls.Add(this.label179);
			this.panel1.Controls.Add(this.label176);
			this.panel1.Controls.Add(this.label177);
			this.panel1.Controls.Add(this.label174);
			this.panel1.Controls.Add(this.label175);
			this.panel1.Controls.Add(this.label172);
			this.panel1.Controls.Add(this.label173);
			this.panel1.Controls.Add(this.label170);
			this.panel1.Controls.Add(this.label171);
			this.panel1.Controls.Add(this.label168);
			this.panel1.Controls.Add(this.label169);
			this.panel1.Controls.Add(this.label166);
			this.panel1.Controls.Add(this.label167);
			this.panel1.Controls.Add(this.label164);
			this.panel1.Controls.Add(this.label165);
			this.panel1.Controls.Add(this.label162);
			this.panel1.Controls.Add(this.label163);
			this.panel1.Controls.Add(this.label160);
			this.panel1.Controls.Add(this.label161);
			this.panel1.Controls.Add(this.label158);
			this.panel1.Controls.Add(this.label159);
			this.panel1.Controls.Add(this.label156);
			this.panel1.Controls.Add(this.label157);
			this.panel1.Controls.Add(this.label154);
			this.panel1.Controls.Add(this.label155);
			this.panel1.Controls.Add(this.label152);
			this.panel1.Controls.Add(this.label153);
			this.panel1.Controls.Add(this.label150);
			this.panel1.Controls.Add(this.label151);
			this.panel1.Controls.Add(this.label148);
			this.panel1.Controls.Add(this.label149);
			this.panel1.Controls.Add(this.label146);
			this.panel1.Controls.Add(this.label147);
			this.panel1.Controls.Add(this.label144);
			this.panel1.Controls.Add(this.label145);
			this.panel1.Controls.Add(this.label142);
			this.panel1.Controls.Add(this.label143);
			this.panel1.Controls.Add(this.label140);
			this.panel1.Controls.Add(this.label141);
			this.panel1.Controls.Add(this.label138);
			this.panel1.Controls.Add(this.label139);
			this.panel1.Controls.Add(this.label136);
			this.panel1.Controls.Add(this.label137);
			this.panel1.Controls.Add(this.label132);
			this.panel1.Controls.Add(this.label133);
			this.panel1.Controls.Add(this.label130);
			this.panel1.Controls.Add(this.label131);
			this.panel1.Controls.Add(this.label128);
			this.panel1.Controls.Add(this.label129);
			this.panel1.Controls.Add(this.label126);
			this.panel1.Controls.Add(this.label127);
			this.panel1.Controls.Add(this.label124);
			this.panel1.Controls.Add(this.label125);
			this.panel1.Controls.Add(this.label122);
			this.panel1.Controls.Add(this.label123);
			this.panel1.Controls.Add(this.label120);
			this.panel1.Controls.Add(this.label121);
			this.panel1.Controls.Add(this.label118);
			this.panel1.Controls.Add(this.label119);
			this.panel1.Controls.Add(this.label116);
			this.panel1.Controls.Add(this.label117);
			this.panel1.Controls.Add(this.label114);
			this.panel1.Controls.Add(this.label115);
			this.panel1.Controls.Add(this.label112);
			this.panel1.Controls.Add(this.label113);
			this.panel1.Controls.Add(this.label110);
			this.panel1.Controls.Add(this.label111);
			this.panel1.Controls.Add(this.label108);
			this.panel1.Controls.Add(this.label109);
			this.panel1.Controls.Add(this.label106);
			this.panel1.Controls.Add(this.label107);
			this.panel1.Controls.Add(this.label104);
			this.panel1.Controls.Add(this.label105);
			this.panel1.Controls.Add(this.label102);
			this.panel1.Controls.Add(this.label103);
			this.panel1.Controls.Add(this.label83);
			this.panel1.Controls.Add(this.label101);
			this.panel1.Controls.Add(this.label81);
			this.panel1.Controls.Add(this.label82);
			this.panel1.Controls.Add(this.label79);
			this.panel1.Controls.Add(this.label80);
			this.panel1.Controls.Add(this.label77);
			this.panel1.Controls.Add(this.label78);
			this.panel1.Controls.Add(this.label76);
			this.panel1.Controls.Add(this.label75);
			this.panel1.Controls.Add(this.label84);
			this.panel1.Controls.Add(this.label85);
			this.panel1.Controls.Add(this.label86);
			this.panel1.Controls.Add(this.label87);
			this.panel1.Controls.Add(this.label88);
			this.panel1.Controls.Add(this.label89);
			this.panel1.Controls.Add(this.label90);
			this.panel1.Controls.Add(this.label91);
			this.panel1.Controls.Add(this.label92);
			this.panel1.Controls.Add(this.label93);
			this.panel1.Controls.Add(this.label94);
			this.panel1.Controls.Add(this.label95);
			this.panel1.Controls.Add(this.label96);
			this.panel1.Controls.Add(this.label97);
			this.panel1.Controls.Add(this.label98);
			this.panel1.Controls.Add(this.label99);
			this.panel1.Controls.Add(this.label100);
			this.panel1.Controls.Add(this.label39);
			this.panel1.Controls.Add(this.label40);
			this.panel1.Controls.Add(this.label41);
			this.panel1.Controls.Add(this.label42);
			this.panel1.Controls.Add(this.label43);
			this.panel1.Controls.Add(this.label44);
			this.panel1.Controls.Add(this.label45);
			this.panel1.Controls.Add(this.label46);
			this.panel1.Controls.Add(this.label47);
			this.panel1.Controls.Add(this.label48);
			this.panel1.Controls.Add(this.label49);
			this.panel1.Controls.Add(this.label50);
			this.panel1.Controls.Add(this.label51);
			this.panel1.Controls.Add(this.label52);
			this.panel1.Controls.Add(this.label53);
			this.panel1.Controls.Add(this.label54);
			this.panel1.Controls.Add(this.label55);
			this.panel1.Controls.Add(this.label56);
			this.panel1.Controls.Add(this.label57);
			this.panel1.Controls.Add(this.label58);
			this.panel1.Controls.Add(this.label59);
			this.panel1.Controls.Add(this.label60);
			this.panel1.Controls.Add(this.label61);
			this.panel1.Controls.Add(this.label62);
			this.panel1.Controls.Add(this.label63);
			this.panel1.Controls.Add(this.label64);
			this.panel1.Controls.Add(this.label65);
			this.panel1.Controls.Add(this.label66);
			this.panel1.Controls.Add(this.label67);
			this.panel1.Controls.Add(this.label68);
			this.panel1.Controls.Add(this.label69);
			this.panel1.Controls.Add(this.label70);
			this.panel1.Controls.Add(this.label71);
			this.panel1.Controls.Add(this.label72);
			this.panel1.Controls.Add(this.label73);
			this.panel1.Controls.Add(this.label74);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.label29);
			this.panel1.Controls.Add(this.label30);
			this.panel1.Controls.Add(this.label31);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Controls.Add(this.label34);
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.label36);
			this.panel1.Controls.Add(this.label37);
			this.panel1.Controls.Add(this.label38);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Location = new Point(0, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(903, 449);
			this.panel1.TabIndex = 5;
			this.panel1.Paint += this.panel1_Paint;
			this.button98.BackColor = Color.FromArgb(38, 38, 38);
			this.button98.BackgroundImageLayout = ImageLayout.None;
			this.button98.Cursor = Cursors.Hand;
			this.button98.FlatAppearance.BorderSize = 0;
			this.button98.FlatStyle = FlatStyle.Flat;
			this.button98.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button98.ForeColor = Color.White;
			this.button98.Image = (Image)componentResourceManager.GetObject("button98.Image");
			this.button98.ImageAlign = ContentAlignment.MiddleLeft;
			this.button98.Location = new Point(753, 851);
			this.button98.Margin = new Padding(1);
			this.button98.Name = "button98";
			this.button98.Size = new Size(120, 30);
			this.button98.TabIndex = 364;
			this.button98.TabStop = false;
			this.button98.Text = "Download";
			this.button98.TextAlign = ContentAlignment.MiddleRight;
			this.button98.UseVisualStyleBackColor = false;
			this.button98.Click += this.button98_Click;
			this.label273.AutoSize = true;
			this.label273.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label273.ForeColor = Color.White;
			this.label273.Location = new Point(581, 852);
			this.label273.Name = "label273";
			this.label273.Size = new Size(124, 30);
			this.label273.TabIndex = 363;
			this.label273.Text = "| Size : 39MB";
			this.label274.AutoSize = true;
			this.label274.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label274.ForeColor = Color.White;
			this.label274.Location = new Point(408, 852);
			this.label274.Name = "label274";
			this.label274.Size = new Size(103, 30);
			this.label274.TabIndex = 362;
			this.label274.Text = "| Freeware";
			this.label275.AutoSize = true;
			this.label275.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label275.ForeColor = Color.White;
			this.label275.Location = new Point(18, 851);
			this.label275.Name = "label275";
			this.label275.Size = new Size(227, 30);
			this.label275.TabIndex = 361;
			this.label275.Text = "• AMD Radeon Software";
			this.button97.BackColor = Color.FromArgb(38, 38, 38);
			this.button97.BackgroundImageLayout = ImageLayout.None;
			this.button97.Cursor = Cursors.Hand;
			this.button97.FlatAppearance.BorderSize = 0;
			this.button97.FlatStyle = FlatStyle.Flat;
			this.button97.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button97.ForeColor = Color.White;
			this.button97.Image = (Image)componentResourceManager.GetObject("button97.Image");
			this.button97.ImageAlign = ContentAlignment.MiddleLeft;
			this.button97.Location = new Point(753, 2851);
			this.button97.Margin = new Padding(1);
			this.button97.Name = "button97";
			this.button97.Size = new Size(120, 30);
			this.button97.TabIndex = 360;
			this.button97.TabStop = false;
			this.button97.Text = "Download";
			this.button97.TextAlign = ContentAlignment.MiddleRight;
			this.button97.UseVisualStyleBackColor = false;
			this.button97.Click += this.button97_Click;
			this.label270.AutoSize = true;
			this.label270.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label270.ForeColor = Color.White;
			this.label270.Location = new Point(580, 2852);
			this.label270.Name = "label270";
			this.label270.Size = new Size(130, 30);
			this.label270.TabIndex = 359;
			this.label270.Text = "| Size : 123MB";
			this.label271.AutoSize = true;
			this.label271.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label271.ForeColor = Color.White;
			this.label271.Location = new Point(407, 2852);
			this.label271.Name = "label271";
			this.label271.Size = new Size(103, 30);
			this.label271.TabIndex = 358;
			this.label271.Text = "| Freeware";
			this.label272.AutoSize = true;
			this.label272.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label272.ForeColor = Color.White;
			this.label272.Location = new Point(17, 2851);
			this.label272.Name = "label272";
			this.label272.Size = new Size(273, 30);
			this.label272.TabIndex = 357;
			this.label272.Text = "• NVIDIA GeForce Experience";
			this.button96.BackColor = Color.FromArgb(38, 38, 38);
			this.button96.BackgroundImageLayout = ImageLayout.None;
			this.button96.Cursor = Cursors.Hand;
			this.button96.FlatAppearance.BorderSize = 0;
			this.button96.FlatStyle = FlatStyle.Flat;
			this.button96.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button96.ForeColor = Color.White;
			this.button96.Image = (Image)componentResourceManager.GetObject("button96.Image");
			this.button96.ImageAlign = ContentAlignment.MiddleLeft;
			this.button96.Location = new Point(753, 1731);
			this.button96.Margin = new Padding(1);
			this.button96.Name = "button96";
			this.button96.Size = new Size(120, 30);
			this.button96.TabIndex = 356;
			this.button96.TabStop = false;
			this.button96.Text = "Download";
			this.button96.TextAlign = ContentAlignment.MiddleRight;
			this.button96.UseVisualStyleBackColor = false;
			this.button96.Click += this.button96_Click;
			this.label267.AutoSize = true;
			this.label267.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label267.ForeColor = Color.White;
			this.label267.Location = new Point(581, 1732);
			this.label267.Name = "label267";
			this.label267.Size = new Size(114, 30);
			this.label267.TabIndex = 355;
			this.label267.Text = "| Size : 5MB";
			this.label268.AutoSize = true;
			this.label268.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label268.ForeColor = Color.White;
			this.label268.Location = new Point(408, 1732);
			this.label268.Name = "label268";
			this.label268.Size = new Size(103, 30);
			this.label268.TabIndex = 354;
			this.label268.Text = "| Freeware";
			this.label269.AutoSize = true;
			this.label269.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label269.ForeColor = Color.White;
			this.label269.Location = new Point(18, 1731);
			this.label269.Name = "label269";
			this.label269.Size = new Size(321, 30);
			this.label269.TabIndex = 353;
			this.label269.Text = "• Intel Driver and Support Assistant";
			this.button75.BackColor = Color.FromArgb(38, 38, 38);
			this.button75.BackgroundImageLayout = ImageLayout.None;
			this.button75.Cursor = Cursors.Hand;
			this.button75.FlatAppearance.BorderSize = 0;
			this.button75.FlatStyle = FlatStyle.Flat;
			this.button75.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button75.ForeColor = Color.White;
			this.button75.Image = (Image)componentResourceManager.GetObject("button75.Image");
			this.button75.ImageAlign = ContentAlignment.MiddleLeft;
			this.button75.Location = new Point(753, 3651);
			this.button75.Margin = new Padding(1);
			this.button75.Name = "button75";
			this.button75.Size = new Size(120, 30);
			this.button75.TabIndex = 351;
			this.button75.TabStop = false;
			this.button75.Text = "Download";
			this.button75.TextAlign = ContentAlignment.MiddleRight;
			this.button75.UseVisualStyleBackColor = false;
			this.button75.Click += this.button75_Click;
			this.button76.BackColor = Color.FromArgb(38, 38, 38);
			this.button76.BackgroundImageLayout = ImageLayout.None;
			this.button76.Cursor = Cursors.Hand;
			this.button76.FlatAppearance.BorderSize = 0;
			this.button76.FlatStyle = FlatStyle.Flat;
			this.button76.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button76.ForeColor = Color.White;
			this.button76.Image = (Image)componentResourceManager.GetObject("button76.Image");
			this.button76.ImageAlign = ContentAlignment.MiddleLeft;
			this.button76.Location = new Point(753, 3611);
			this.button76.Margin = new Padding(1);
			this.button76.Name = "button76";
			this.button76.Size = new Size(120, 30);
			this.button76.TabIndex = 350;
			this.button76.TabStop = false;
			this.button76.Text = "Download";
			this.button76.TextAlign = ContentAlignment.MiddleRight;
			this.button76.UseVisualStyleBackColor = false;
			this.button76.Click += this.button76_Click;
			this.button77.BackColor = Color.FromArgb(38, 38, 38);
			this.button77.BackgroundImageLayout = ImageLayout.None;
			this.button77.Cursor = Cursors.Hand;
			this.button77.FlatAppearance.BorderSize = 0;
			this.button77.FlatStyle = FlatStyle.Flat;
			this.button77.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button77.ForeColor = Color.White;
			this.button77.Image = (Image)componentResourceManager.GetObject("button77.Image");
			this.button77.ImageAlign = ContentAlignment.MiddleLeft;
			this.button77.Location = new Point(753, 3571);
			this.button77.Margin = new Padding(1);
			this.button77.Name = "button77";
			this.button77.Size = new Size(120, 30);
			this.button77.TabIndex = 349;
			this.button77.TabStop = false;
			this.button77.Text = "Download";
			this.button77.TextAlign = ContentAlignment.MiddleRight;
			this.button77.UseVisualStyleBackColor = false;
			this.button77.Click += this.button77_Click;
			this.button78.BackColor = Color.FromArgb(38, 38, 38);
			this.button78.BackgroundImageLayout = ImageLayout.None;
			this.button78.Cursor = Cursors.Hand;
			this.button78.FlatAppearance.BorderSize = 0;
			this.button78.FlatStyle = FlatStyle.Flat;
			this.button78.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button78.ForeColor = Color.White;
			this.button78.Image = (Image)componentResourceManager.GetObject("button78.Image");
			this.button78.ImageAlign = ContentAlignment.MiddleLeft;
			this.button78.Location = new Point(753, 3531);
			this.button78.Margin = new Padding(1);
			this.button78.Name = "button78";
			this.button78.Size = new Size(120, 30);
			this.button78.TabIndex = 348;
			this.button78.TabStop = false;
			this.button78.Text = "Download";
			this.button78.TextAlign = ContentAlignment.MiddleRight;
			this.button78.UseVisualStyleBackColor = false;
			this.button78.Click += this.button78_Click;
			this.button79.BackColor = Color.FromArgb(38, 38, 38);
			this.button79.BackgroundImageLayout = ImageLayout.None;
			this.button79.Cursor = Cursors.Hand;
			this.button79.FlatAppearance.BorderSize = 0;
			this.button79.FlatStyle = FlatStyle.Flat;
			this.button79.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button79.ForeColor = Color.White;
			this.button79.Image = (Image)componentResourceManager.GetObject("button79.Image");
			this.button79.ImageAlign = ContentAlignment.MiddleLeft;
			this.button79.Location = new Point(753, 3491);
			this.button79.Margin = new Padding(1);
			this.button79.Name = "button79";
			this.button79.Size = new Size(120, 30);
			this.button79.TabIndex = 347;
			this.button79.TabStop = false;
			this.button79.Text = "Download";
			this.button79.TextAlign = ContentAlignment.MiddleRight;
			this.button79.UseVisualStyleBackColor = false;
			this.button79.Click += this.button79_Click;
			this.button80.BackColor = Color.FromArgb(38, 38, 38);
			this.button80.BackgroundImageLayout = ImageLayout.None;
			this.button80.Cursor = Cursors.Hand;
			this.button80.FlatAppearance.BorderSize = 0;
			this.button80.FlatStyle = FlatStyle.Flat;
			this.button80.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button80.ForeColor = Color.White;
			this.button80.Image = (Image)componentResourceManager.GetObject("button80.Image");
			this.button80.ImageAlign = ContentAlignment.MiddleLeft;
			this.button80.Location = new Point(753, 3451);
			this.button80.Margin = new Padding(1);
			this.button80.Name = "button80";
			this.button80.Size = new Size(120, 30);
			this.button80.TabIndex = 346;
			this.button80.TabStop = false;
			this.button80.Text = "Download";
			this.button80.TextAlign = ContentAlignment.MiddleRight;
			this.button80.UseVisualStyleBackColor = false;
			this.button80.Click += this.button80_Click;
			this.button81.BackColor = Color.FromArgb(38, 38, 38);
			this.button81.BackgroundImageLayout = ImageLayout.None;
			this.button81.Cursor = Cursors.Hand;
			this.button81.FlatAppearance.BorderSize = 0;
			this.button81.FlatStyle = FlatStyle.Flat;
			this.button81.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button81.ForeColor = Color.White;
			this.button81.Image = (Image)componentResourceManager.GetObject("button81.Image");
			this.button81.ImageAlign = ContentAlignment.MiddleLeft;
			this.button81.Location = new Point(753, 3411);
			this.button81.Margin = new Padding(1);
			this.button81.Name = "button81";
			this.button81.Size = new Size(120, 30);
			this.button81.TabIndex = 345;
			this.button81.TabStop = false;
			this.button81.Text = "Download";
			this.button81.TextAlign = ContentAlignment.MiddleRight;
			this.button81.UseVisualStyleBackColor = false;
			this.button81.Click += this.button81_Click;
			this.label33.AutoSize = true;
			this.label33.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label33.ForeColor = Color.White;
			this.label33.Location = new Point(17, 2771);
			this.label33.Name = "label33";
			this.label33.Size = new Size(194, 30);
			this.label33.TabIndex = 23;
			this.label33.Text = "• Net Speed Monitor";
			this.label135.AutoSize = true;
			this.label135.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label135.ForeColor = Color.White;
			this.label135.Location = new Point(407, 2772);
			this.label135.Name = "label135";
			this.label135.Size = new Size(103, 30);
			this.label135.TabIndex = 131;
			this.label135.Text = "| Freeware";
			this.button82.BackColor = Color.FromArgb(38, 38, 38);
			this.button82.BackgroundImageLayout = ImageLayout.None;
			this.button82.Cursor = Cursors.Hand;
			this.button82.FlatAppearance.BorderSize = 0;
			this.button82.FlatStyle = FlatStyle.Flat;
			this.button82.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button82.ForeColor = Color.White;
			this.button82.Image = (Image)componentResourceManager.GetObject("button82.Image");
			this.button82.ImageAlign = ContentAlignment.MiddleLeft;
			this.button82.Location = new Point(753, 3371);
			this.button82.Margin = new Padding(1);
			this.button82.Name = "button82";
			this.button82.Size = new Size(120, 30);
			this.button82.TabIndex = 344;
			this.button82.TabStop = false;
			this.button82.Text = "Download";
			this.button82.TextAlign = ContentAlignment.MiddleRight;
			this.button82.UseVisualStyleBackColor = false;
			this.button82.Click += this.button82_Click;
			this.label134.AutoSize = true;
			this.label134.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label134.ForeColor = Color.White;
			this.label134.Location = new Point(580, 2772);
			this.label134.Name = "label134";
			this.label134.Size = new Size(113, 30);
			this.label134.TabIndex = 132;
			this.label134.Text = "| Size : 7MB";
			this.button83.BackColor = Color.FromArgb(38, 38, 38);
			this.button83.BackgroundImageLayout = ImageLayout.None;
			this.button83.Cursor = Cursors.Hand;
			this.button83.FlatAppearance.BorderSize = 0;
			this.button83.FlatStyle = FlatStyle.Flat;
			this.button83.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button83.ForeColor = Color.White;
			this.button83.Image = (Image)componentResourceManager.GetObject("button83.Image");
			this.button83.ImageAlign = ContentAlignment.MiddleLeft;
			this.button83.Location = new Point(753, 3331);
			this.button83.Margin = new Padding(1);
			this.button83.Name = "button83";
			this.button83.Size = new Size(120, 30);
			this.button83.TabIndex = 343;
			this.button83.TabStop = false;
			this.button83.Text = "Download";
			this.button83.TextAlign = ContentAlignment.MiddleRight;
			this.button83.UseVisualStyleBackColor = false;
			this.button83.Click += this.button83_Click;
			this.button32.BackColor = Color.FromArgb(38, 38, 38);
			this.button32.BackgroundImageLayout = ImageLayout.None;
			this.button32.Cursor = Cursors.Hand;
			this.button32.FlatAppearance.BorderSize = 0;
			this.button32.FlatStyle = FlatStyle.Flat;
			this.button32.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button32.ForeColor = Color.White;
			this.button32.Image = (Image)componentResourceManager.GetObject("button32.Image");
			this.button32.ImageAlign = ContentAlignment.MiddleLeft;
			this.button32.Location = new Point(753, 2771);
			this.button32.Margin = new Padding(1);
			this.button32.Name = "button32";
			this.button32.Size = new Size(120, 30);
			this.button32.TabIndex = 286;
			this.button32.TabStop = false;
			this.button32.Text = "Download";
			this.button32.TextAlign = ContentAlignment.MiddleRight;
			this.button32.UseVisualStyleBackColor = false;
			this.button32.Click += this.button32_Click;
			this.button84.BackColor = Color.FromArgb(38, 38, 38);
			this.button84.BackgroundImageLayout = ImageLayout.None;
			this.button84.Cursor = Cursors.Hand;
			this.button84.FlatAppearance.BorderSize = 0;
			this.button84.FlatStyle = FlatStyle.Flat;
			this.button84.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button84.ForeColor = Color.White;
			this.button84.Image = (Image)componentResourceManager.GetObject("button84.Image");
			this.button84.ImageAlign = ContentAlignment.MiddleLeft;
			this.button84.Location = new Point(753, 3291);
			this.button84.Margin = new Padding(1);
			this.button84.Name = "button84";
			this.button84.Size = new Size(120, 30);
			this.button84.TabIndex = 342;
			this.button84.TabStop = false;
			this.button84.Text = "Download";
			this.button84.TextAlign = ContentAlignment.MiddleRight;
			this.button84.UseVisualStyleBackColor = false;
			this.button84.Click += this.button84_Click;
			this.button85.BackColor = Color.FromArgb(38, 38, 38);
			this.button85.BackgroundImageLayout = ImageLayout.None;
			this.button85.Cursor = Cursors.Hand;
			this.button85.FlatAppearance.BorderSize = 0;
			this.button85.FlatStyle = FlatStyle.Flat;
			this.button85.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button85.ForeColor = Color.White;
			this.button85.Image = (Image)componentResourceManager.GetObject("button85.Image");
			this.button85.ImageAlign = ContentAlignment.MiddleLeft;
			this.button85.Location = new Point(753, 3251);
			this.button85.Margin = new Padding(1);
			this.button85.Name = "button85";
			this.button85.Size = new Size(120, 30);
			this.button85.TabIndex = 341;
			this.button85.TabStop = false;
			this.button85.Text = "Download";
			this.button85.TextAlign = ContentAlignment.MiddleRight;
			this.button85.UseVisualStyleBackColor = false;
			this.button85.Click += this.button85_Click;
			this.button86.BackColor = Color.FromArgb(38, 38, 38);
			this.button86.BackgroundImageLayout = ImageLayout.None;
			this.button86.Cursor = Cursors.Hand;
			this.button86.FlatAppearance.BorderSize = 0;
			this.button86.FlatStyle = FlatStyle.Flat;
			this.button86.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button86.ForeColor = Color.White;
			this.button86.Image = (Image)componentResourceManager.GetObject("button86.Image");
			this.button86.ImageAlign = ContentAlignment.MiddleLeft;
			this.button86.Location = new Point(753, 3211);
			this.button86.Margin = new Padding(1);
			this.button86.Name = "button86";
			this.button86.Size = new Size(120, 30);
			this.button86.TabIndex = 340;
			this.button86.TabStop = false;
			this.button86.Text = "Download";
			this.button86.TextAlign = ContentAlignment.MiddleRight;
			this.button86.UseVisualStyleBackColor = false;
			this.button86.Click += this.button86_Click;
			this.button87.BackColor = Color.FromArgb(38, 38, 38);
			this.button87.BackgroundImageLayout = ImageLayout.None;
			this.button87.Cursor = Cursors.Hand;
			this.button87.FlatAppearance.BorderSize = 0;
			this.button87.FlatStyle = FlatStyle.Flat;
			this.button87.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button87.ForeColor = Color.White;
			this.button87.Image = (Image)componentResourceManager.GetObject("button87.Image");
			this.button87.ImageAlign = ContentAlignment.MiddleLeft;
			this.button87.Location = new Point(753, 3171);
			this.button87.Margin = new Padding(1);
			this.button87.Name = "button87";
			this.button87.Size = new Size(120, 30);
			this.button87.TabIndex = 339;
			this.button87.TabStop = false;
			this.button87.Text = "Download";
			this.button87.TextAlign = ContentAlignment.MiddleRight;
			this.button87.UseVisualStyleBackColor = false;
			this.button87.Click += this.button87_Click;
			this.button88.BackColor = Color.FromArgb(38, 38, 38);
			this.button88.BackgroundImageLayout = ImageLayout.None;
			this.button88.Cursor = Cursors.Hand;
			this.button88.FlatAppearance.BorderSize = 0;
			this.button88.FlatStyle = FlatStyle.Flat;
			this.button88.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button88.ForeColor = Color.White;
			this.button88.Image = (Image)componentResourceManager.GetObject("button88.Image");
			this.button88.ImageAlign = ContentAlignment.MiddleLeft;
			this.button88.Location = new Point(753, 3131);
			this.button88.Margin = new Padding(1);
			this.button88.Name = "button88";
			this.button88.Size = new Size(120, 30);
			this.button88.TabIndex = 338;
			this.button88.TabStop = false;
			this.button88.Text = "Download";
			this.button88.TextAlign = ContentAlignment.MiddleRight;
			this.button88.UseVisualStyleBackColor = false;
			this.button88.Click += this.button88_Click;
			this.button89.BackColor = Color.FromArgb(38, 38, 38);
			this.button89.BackgroundImageLayout = ImageLayout.None;
			this.button89.Cursor = Cursors.Hand;
			this.button89.FlatAppearance.BorderSize = 0;
			this.button89.FlatStyle = FlatStyle.Flat;
			this.button89.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button89.ForeColor = Color.White;
			this.button89.Image = (Image)componentResourceManager.GetObject("button89.Image");
			this.button89.ImageAlign = ContentAlignment.MiddleLeft;
			this.button89.Location = new Point(753, 3091);
			this.button89.Margin = new Padding(1);
			this.button89.Name = "button89";
			this.button89.Size = new Size(120, 30);
			this.button89.TabIndex = 337;
			this.button89.TabStop = false;
			this.button89.Text = "Download";
			this.button89.TextAlign = ContentAlignment.MiddleRight;
			this.button89.UseVisualStyleBackColor = false;
			this.button89.Click += this.button89_Click;
			this.button90.BackColor = Color.FromArgb(38, 38, 38);
			this.button90.BackgroundImageLayout = ImageLayout.None;
			this.button90.Cursor = Cursors.Hand;
			this.button90.FlatAppearance.BorderSize = 0;
			this.button90.FlatStyle = FlatStyle.Flat;
			this.button90.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button90.ForeColor = Color.White;
			this.button90.Image = (Image)componentResourceManager.GetObject("button90.Image");
			this.button90.ImageAlign = ContentAlignment.MiddleLeft;
			this.button90.Location = new Point(753, 3051);
			this.button90.Margin = new Padding(1);
			this.button90.Name = "button90";
			this.button90.Size = new Size(120, 30);
			this.button90.TabIndex = 336;
			this.button90.TabStop = false;
			this.button90.Text = "Download";
			this.button90.TextAlign = ContentAlignment.MiddleRight;
			this.button90.UseVisualStyleBackColor = false;
			this.button90.Click += this.button90_Click;
			this.button91.BackColor = Color.FromArgb(38, 38, 38);
			this.button91.BackgroundImageLayout = ImageLayout.None;
			this.button91.Cursor = Cursors.Hand;
			this.button91.FlatAppearance.BorderSize = 0;
			this.button91.FlatStyle = FlatStyle.Flat;
			this.button91.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button91.ForeColor = Color.White;
			this.button91.Image = (Image)componentResourceManager.GetObject("button91.Image");
			this.button91.ImageAlign = ContentAlignment.MiddleLeft;
			this.button91.Location = new Point(753, 3011);
			this.button91.Margin = new Padding(1);
			this.button91.Name = "button91";
			this.button91.Size = new Size(120, 30);
			this.button91.TabIndex = 335;
			this.button91.TabStop = false;
			this.button91.Text = "Download";
			this.button91.TextAlign = ContentAlignment.MiddleRight;
			this.button91.UseVisualStyleBackColor = false;
			this.button91.Click += this.button91_Click;
			this.button56.BackColor = Color.FromArgb(38, 38, 38);
			this.button56.BackgroundImageLayout = ImageLayout.None;
			this.button56.Cursor = Cursors.Hand;
			this.button56.FlatAppearance.BorderSize = 0;
			this.button56.FlatStyle = FlatStyle.Flat;
			this.button56.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button56.ForeColor = Color.White;
			this.button56.Image = (Image)componentResourceManager.GetObject("button56.Image");
			this.button56.ImageAlign = ContentAlignment.MiddleLeft;
			this.button56.Location = new Point(753, 2971);
			this.button56.Margin = new Padding(1);
			this.button56.Name = "button56";
			this.button56.Size = new Size(120, 30);
			this.button56.TabIndex = 334;
			this.button56.TabStop = false;
			this.button56.Text = "Download";
			this.button56.TextAlign = ContentAlignment.MiddleRight;
			this.button56.UseVisualStyleBackColor = false;
			this.button56.Click += this.button56_Click;
			this.button57.BackColor = Color.FromArgb(38, 38, 38);
			this.button57.BackgroundImageLayout = ImageLayout.None;
			this.button57.Cursor = Cursors.Hand;
			this.button57.FlatAppearance.BorderSize = 0;
			this.button57.FlatStyle = FlatStyle.Flat;
			this.button57.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button57.ForeColor = Color.White;
			this.button57.Image = (Image)componentResourceManager.GetObject("button57.Image");
			this.button57.ImageAlign = ContentAlignment.MiddleLeft;
			this.button57.Location = new Point(753, 2931);
			this.button57.Margin = new Padding(1);
			this.button57.Name = "button57";
			this.button57.Size = new Size(120, 30);
			this.button57.TabIndex = 333;
			this.button57.TabStop = false;
			this.button57.Text = "Download";
			this.button57.TextAlign = ContentAlignment.MiddleRight;
			this.button57.UseVisualStyleBackColor = false;
			this.button57.Click += this.button57_Click;
			this.button58.BackColor = Color.FromArgb(38, 38, 38);
			this.button58.BackgroundImageLayout = ImageLayout.None;
			this.button58.Cursor = Cursors.Hand;
			this.button58.FlatAppearance.BorderSize = 0;
			this.button58.FlatStyle = FlatStyle.Flat;
			this.button58.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button58.ForeColor = Color.White;
			this.button58.Image = (Image)componentResourceManager.GetObject("button58.Image");
			this.button58.ImageAlign = ContentAlignment.MiddleLeft;
			this.button58.Location = new Point(753, 2891);
			this.button58.Margin = new Padding(1);
			this.button58.Name = "button58";
			this.button58.Size = new Size(120, 30);
			this.button58.TabIndex = 332;
			this.button58.TabStop = false;
			this.button58.Text = "Download";
			this.button58.TextAlign = ContentAlignment.MiddleRight;
			this.button58.UseVisualStyleBackColor = false;
			this.button58.Click += this.button58_Click;
			this.button59.BackColor = Color.FromArgb(38, 38, 38);
			this.button59.BackgroundImageLayout = ImageLayout.None;
			this.button59.Cursor = Cursors.Hand;
			this.button59.FlatAppearance.BorderSize = 0;
			this.button59.FlatStyle = FlatStyle.Flat;
			this.button59.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button59.ForeColor = Color.White;
			this.button59.Image = (Image)componentResourceManager.GetObject("button59.Image");
			this.button59.ImageAlign = ContentAlignment.MiddleLeft;
			this.button59.Location = new Point(753, 2811);
			this.button59.Margin = new Padding(1);
			this.button59.Name = "button59";
			this.button59.Size = new Size(120, 30);
			this.button59.TabIndex = 331;
			this.button59.TabStop = false;
			this.button59.Text = "Download";
			this.button59.TextAlign = ContentAlignment.MiddleRight;
			this.button59.UseVisualStyleBackColor = false;
			this.button59.Click += this.button59_Click;
			this.button60.BackColor = Color.FromArgb(38, 38, 38);
			this.button60.BackgroundImageLayout = ImageLayout.None;
			this.button60.Cursor = Cursors.Hand;
			this.button60.FlatAppearance.BorderSize = 0;
			this.button60.FlatStyle = FlatStyle.Flat;
			this.button60.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button60.ForeColor = Color.White;
			this.button60.Image = (Image)componentResourceManager.GetObject("button60.Image");
			this.button60.ImageAlign = ContentAlignment.MiddleLeft;
			this.button60.Location = new Point(753, 2731);
			this.button60.Margin = new Padding(1);
			this.button60.Name = "button60";
			this.button60.Size = new Size(120, 30);
			this.button60.TabIndex = 330;
			this.button60.TabStop = false;
			this.button60.Text = "Download";
			this.button60.TextAlign = ContentAlignment.MiddleRight;
			this.button60.UseVisualStyleBackColor = false;
			this.button60.Click += this.button60_Click;
			this.button61.BackColor = Color.FromArgb(38, 38, 38);
			this.button61.BackgroundImageLayout = ImageLayout.None;
			this.button61.Cursor = Cursors.Hand;
			this.button61.FlatAppearance.BorderSize = 0;
			this.button61.FlatStyle = FlatStyle.Flat;
			this.button61.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button61.ForeColor = Color.White;
			this.button61.Image = (Image)componentResourceManager.GetObject("button61.Image");
			this.button61.ImageAlign = ContentAlignment.MiddleLeft;
			this.button61.Location = new Point(753, 2691);
			this.button61.Margin = new Padding(1);
			this.button61.Name = "button61";
			this.button61.Size = new Size(120, 30);
			this.button61.TabIndex = 329;
			this.button61.TabStop = false;
			this.button61.Text = "Download";
			this.button61.TextAlign = ContentAlignment.MiddleRight;
			this.button61.UseVisualStyleBackColor = false;
			this.button61.Click += this.button61_Click;
			this.button62.BackColor = Color.FromArgb(38, 38, 38);
			this.button62.BackgroundImageLayout = ImageLayout.None;
			this.button62.Cursor = Cursors.Hand;
			this.button62.FlatAppearance.BorderSize = 0;
			this.button62.FlatStyle = FlatStyle.Flat;
			this.button62.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button62.ForeColor = Color.White;
			this.button62.Image = (Image)componentResourceManager.GetObject("button62.Image");
			this.button62.ImageAlign = ContentAlignment.MiddleLeft;
			this.button62.Location = new Point(753, 2651);
			this.button62.Margin = new Padding(1);
			this.button62.Name = "button62";
			this.button62.Size = new Size(120, 30);
			this.button62.TabIndex = 328;
			this.button62.TabStop = false;
			this.button62.Text = "Download";
			this.button62.TextAlign = ContentAlignment.MiddleRight;
			this.button62.UseVisualStyleBackColor = false;
			this.button62.Click += this.button62_Click;
			this.button63.BackColor = Color.FromArgb(38, 38, 38);
			this.button63.BackgroundImageLayout = ImageLayout.None;
			this.button63.Cursor = Cursors.Hand;
			this.button63.FlatAppearance.BorderSize = 0;
			this.button63.FlatStyle = FlatStyle.Flat;
			this.button63.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button63.ForeColor = Color.White;
			this.button63.Image = (Image)componentResourceManager.GetObject("button63.Image");
			this.button63.ImageAlign = ContentAlignment.MiddleLeft;
			this.button63.Location = new Point(753, 2611);
			this.button63.Margin = new Padding(1);
			this.button63.Name = "button63";
			this.button63.Size = new Size(120, 30);
			this.button63.TabIndex = 327;
			this.button63.TabStop = false;
			this.button63.Text = "Download";
			this.button63.TextAlign = ContentAlignment.MiddleRight;
			this.button63.UseVisualStyleBackColor = false;
			this.button63.Click += this.button63_Click;
			this.button64.BackColor = Color.FromArgb(38, 38, 38);
			this.button64.BackgroundImageLayout = ImageLayout.None;
			this.button64.Cursor = Cursors.Hand;
			this.button64.FlatAppearance.BorderSize = 0;
			this.button64.FlatStyle = FlatStyle.Flat;
			this.button64.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button64.ForeColor = Color.White;
			this.button64.Image = (Image)componentResourceManager.GetObject("button64.Image");
			this.button64.ImageAlign = ContentAlignment.MiddleLeft;
			this.button64.Location = new Point(753, 2571);
			this.button64.Margin = new Padding(1);
			this.button64.Name = "button64";
			this.button64.Size = new Size(120, 30);
			this.button64.TabIndex = 326;
			this.button64.TabStop = false;
			this.button64.Text = "Download";
			this.button64.TextAlign = ContentAlignment.MiddleRight;
			this.button64.UseVisualStyleBackColor = false;
			this.button64.Click += this.button64_Click;
			this.button65.BackColor = Color.FromArgb(38, 38, 38);
			this.button65.BackgroundImageLayout = ImageLayout.None;
			this.button65.Cursor = Cursors.Hand;
			this.button65.FlatAppearance.BorderSize = 0;
			this.button65.FlatStyle = FlatStyle.Flat;
			this.button65.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button65.ForeColor = Color.White;
			this.button65.Image = (Image)componentResourceManager.GetObject("button65.Image");
			this.button65.ImageAlign = ContentAlignment.MiddleLeft;
			this.button65.Location = new Point(753, 2531);
			this.button65.Margin = new Padding(1);
			this.button65.Name = "button65";
			this.button65.Size = new Size(120, 30);
			this.button65.TabIndex = 325;
			this.button65.TabStop = false;
			this.button65.Text = "Download";
			this.button65.TextAlign = ContentAlignment.MiddleRight;
			this.button65.UseVisualStyleBackColor = false;
			this.button65.Click += this.button65_Click;
			this.button66.BackColor = Color.FromArgb(38, 38, 38);
			this.button66.BackgroundImageLayout = ImageLayout.None;
			this.button66.Cursor = Cursors.Hand;
			this.button66.FlatAppearance.BorderSize = 0;
			this.button66.FlatStyle = FlatStyle.Flat;
			this.button66.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button66.ForeColor = Color.White;
			this.button66.Image = (Image)componentResourceManager.GetObject("button66.Image");
			this.button66.ImageAlign = ContentAlignment.MiddleLeft;
			this.button66.Location = new Point(753, 2491);
			this.button66.Margin = new Padding(1);
			this.button66.Name = "button66";
			this.button66.Size = new Size(120, 30);
			this.button66.TabIndex = 324;
			this.button66.TabStop = false;
			this.button66.Text = "Download";
			this.button66.TextAlign = ContentAlignment.MiddleRight;
			this.button66.UseVisualStyleBackColor = false;
			this.button66.Click += this.button66_Click;
			this.button67.BackColor = Color.FromArgb(38, 38, 38);
			this.button67.BackgroundImageLayout = ImageLayout.None;
			this.button67.Cursor = Cursors.Hand;
			this.button67.FlatAppearance.BorderSize = 0;
			this.button67.FlatStyle = FlatStyle.Flat;
			this.button67.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button67.ForeColor = Color.White;
			this.button67.Image = (Image)componentResourceManager.GetObject("button67.Image");
			this.button67.ImageAlign = ContentAlignment.MiddleLeft;
			this.button67.Location = new Point(753, 2451);
			this.button67.Margin = new Padding(1);
			this.button67.Name = "button67";
			this.button67.Size = new Size(120, 30);
			this.button67.TabIndex = 323;
			this.button67.TabStop = false;
			this.button67.Text = "Download";
			this.button67.TextAlign = ContentAlignment.MiddleRight;
			this.button67.UseVisualStyleBackColor = false;
			this.button67.Click += this.button67_Click;
			this.button68.BackColor = Color.FromArgb(38, 38, 38);
			this.button68.BackgroundImageLayout = ImageLayout.None;
			this.button68.Cursor = Cursors.Hand;
			this.button68.FlatAppearance.BorderSize = 0;
			this.button68.FlatStyle = FlatStyle.Flat;
			this.button68.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button68.ForeColor = Color.White;
			this.button68.Image = (Image)componentResourceManager.GetObject("button68.Image");
			this.button68.ImageAlign = ContentAlignment.MiddleLeft;
			this.button68.Location = new Point(753, 2411);
			this.button68.Margin = new Padding(1);
			this.button68.Name = "button68";
			this.button68.Size = new Size(120, 30);
			this.button68.TabIndex = 322;
			this.button68.TabStop = false;
			this.button68.Text = "Download";
			this.button68.TextAlign = ContentAlignment.MiddleRight;
			this.button68.UseVisualStyleBackColor = false;
			this.button68.Click += this.button68_Click;
			this.button69.BackColor = Color.FromArgb(38, 38, 38);
			this.button69.BackgroundImageLayout = ImageLayout.None;
			this.button69.Cursor = Cursors.Hand;
			this.button69.FlatAppearance.BorderSize = 0;
			this.button69.FlatStyle = FlatStyle.Flat;
			this.button69.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button69.ForeColor = Color.White;
			this.button69.Image = (Image)componentResourceManager.GetObject("button69.Image");
			this.button69.ImageAlign = ContentAlignment.MiddleLeft;
			this.button69.Location = new Point(753, 2371);
			this.button69.Margin = new Padding(1);
			this.button69.Name = "button69";
			this.button69.Size = new Size(120, 30);
			this.button69.TabIndex = 321;
			this.button69.TabStop = false;
			this.button69.Text = "Download";
			this.button69.TextAlign = ContentAlignment.MiddleRight;
			this.button69.UseVisualStyleBackColor = false;
			this.button69.Click += this.button69_Click;
			this.button70.BackColor = Color.FromArgb(38, 38, 38);
			this.button70.BackgroundImageLayout = ImageLayout.None;
			this.button70.Cursor = Cursors.Hand;
			this.button70.FlatAppearance.BorderSize = 0;
			this.button70.FlatStyle = FlatStyle.Flat;
			this.button70.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button70.ForeColor = Color.White;
			this.button70.Image = (Image)componentResourceManager.GetObject("button70.Image");
			this.button70.ImageAlign = ContentAlignment.MiddleLeft;
			this.button70.Location = new Point(753, 2331);
			this.button70.Margin = new Padding(1);
			this.button70.Name = "button70";
			this.button70.Size = new Size(120, 30);
			this.button70.TabIndex = 320;
			this.button70.TabStop = false;
			this.button70.Text = "Download";
			this.button70.TextAlign = ContentAlignment.MiddleRight;
			this.button70.UseVisualStyleBackColor = false;
			this.button70.Click += this.button70_Click;
			this.button71.BackColor = Color.FromArgb(38, 38, 38);
			this.button71.BackgroundImageLayout = ImageLayout.None;
			this.button71.Cursor = Cursors.Hand;
			this.button71.FlatAppearance.BorderSize = 0;
			this.button71.FlatStyle = FlatStyle.Flat;
			this.button71.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button71.ForeColor = Color.White;
			this.button71.Image = (Image)componentResourceManager.GetObject("button71.Image");
			this.button71.ImageAlign = ContentAlignment.MiddleLeft;
			this.button71.Location = new Point(753, 2291);
			this.button71.Margin = new Padding(1);
			this.button71.Name = "button71";
			this.button71.Size = new Size(120, 30);
			this.button71.TabIndex = 319;
			this.button71.TabStop = false;
			this.button71.Text = "Download";
			this.button71.TextAlign = ContentAlignment.MiddleRight;
			this.button71.UseVisualStyleBackColor = false;
			this.button71.Click += this.button71_Click;
			this.button72.BackColor = Color.FromArgb(38, 38, 38);
			this.button72.BackgroundImageLayout = ImageLayout.None;
			this.button72.Cursor = Cursors.Hand;
			this.button72.FlatAppearance.BorderSize = 0;
			this.button72.FlatStyle = FlatStyle.Flat;
			this.button72.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button72.ForeColor = Color.White;
			this.button72.Image = (Image)componentResourceManager.GetObject("button72.Image");
			this.button72.ImageAlign = ContentAlignment.MiddleLeft;
			this.button72.Location = new Point(753, 2251);
			this.button72.Margin = new Padding(1);
			this.button72.Name = "button72";
			this.button72.Size = new Size(120, 30);
			this.button72.TabIndex = 318;
			this.button72.TabStop = false;
			this.button72.Text = "Download";
			this.button72.TextAlign = ContentAlignment.MiddleRight;
			this.button72.UseVisualStyleBackColor = false;
			this.button72.Click += this.button72_Click;
			this.button73.BackColor = Color.FromArgb(38, 38, 38);
			this.button73.BackgroundImageLayout = ImageLayout.None;
			this.button73.Cursor = Cursors.Hand;
			this.button73.FlatAppearance.BorderSize = 0;
			this.button73.FlatStyle = FlatStyle.Flat;
			this.button73.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button73.ForeColor = Color.White;
			this.button73.Image = (Image)componentResourceManager.GetObject("button73.Image");
			this.button73.ImageAlign = ContentAlignment.MiddleLeft;
			this.button73.Location = new Point(753, 2211);
			this.button73.Margin = new Padding(1);
			this.button73.Name = "button73";
			this.button73.Size = new Size(120, 30);
			this.button73.TabIndex = 317;
			this.button73.TabStop = false;
			this.button73.Text = "Download";
			this.button73.TextAlign = ContentAlignment.MiddleRight;
			this.button73.UseVisualStyleBackColor = false;
			this.button73.Click += this.button73_Click;
			this.button38.BackColor = Color.FromArgb(38, 38, 38);
			this.button38.BackgroundImageLayout = ImageLayout.None;
			this.button38.Cursor = Cursors.Hand;
			this.button38.FlatAppearance.BorderSize = 0;
			this.button38.FlatStyle = FlatStyle.Flat;
			this.button38.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button38.ForeColor = Color.White;
			this.button38.Image = (Image)componentResourceManager.GetObject("button38.Image");
			this.button38.ImageAlign = ContentAlignment.MiddleLeft;
			this.button38.Location = new Point(753, 2171);
			this.button38.Margin = new Padding(1);
			this.button38.Name = "button38";
			this.button38.Size = new Size(120, 30);
			this.button38.TabIndex = 316;
			this.button38.TabStop = false;
			this.button38.Text = "Download";
			this.button38.TextAlign = ContentAlignment.MiddleRight;
			this.button38.UseVisualStyleBackColor = false;
			this.button38.Click += this.button38_Click;
			this.button39.BackColor = Color.FromArgb(38, 38, 38);
			this.button39.BackgroundImageLayout = ImageLayout.None;
			this.button39.Cursor = Cursors.Hand;
			this.button39.FlatAppearance.BorderSize = 0;
			this.button39.FlatStyle = FlatStyle.Flat;
			this.button39.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button39.ForeColor = Color.White;
			this.button39.Image = (Image)componentResourceManager.GetObject("button39.Image");
			this.button39.ImageAlign = ContentAlignment.MiddleLeft;
			this.button39.Location = new Point(753, 2131);
			this.button39.Margin = new Padding(1);
			this.button39.Name = "button39";
			this.button39.Size = new Size(120, 30);
			this.button39.TabIndex = 315;
			this.button39.TabStop = false;
			this.button39.Text = "Download";
			this.button39.TextAlign = ContentAlignment.MiddleRight;
			this.button39.UseVisualStyleBackColor = false;
			this.button39.Click += this.button39_Click;
			this.button40.BackColor = Color.FromArgb(38, 38, 38);
			this.button40.BackgroundImageLayout = ImageLayout.None;
			this.button40.Cursor = Cursors.Hand;
			this.button40.FlatAppearance.BorderSize = 0;
			this.button40.FlatStyle = FlatStyle.Flat;
			this.button40.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button40.ForeColor = Color.White;
			this.button40.Image = (Image)componentResourceManager.GetObject("button40.Image");
			this.button40.ImageAlign = ContentAlignment.MiddleLeft;
			this.button40.Location = new Point(753, 2091);
			this.button40.Margin = new Padding(1);
			this.button40.Name = "button40";
			this.button40.Size = new Size(120, 30);
			this.button40.TabIndex = 314;
			this.button40.TabStop = false;
			this.button40.Text = "Download";
			this.button40.TextAlign = ContentAlignment.MiddleRight;
			this.button40.UseVisualStyleBackColor = false;
			this.button40.Click += this.button40_Click;
			this.button41.BackColor = Color.FromArgb(38, 38, 38);
			this.button41.BackgroundImageLayout = ImageLayout.None;
			this.button41.Cursor = Cursors.Hand;
			this.button41.FlatAppearance.BorderSize = 0;
			this.button41.FlatStyle = FlatStyle.Flat;
			this.button41.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button41.ForeColor = Color.White;
			this.button41.Image = (Image)componentResourceManager.GetObject("button41.Image");
			this.button41.ImageAlign = ContentAlignment.MiddleLeft;
			this.button41.Location = new Point(753, 2051);
			this.button41.Margin = new Padding(1);
			this.button41.Name = "button41";
			this.button41.Size = new Size(120, 30);
			this.button41.TabIndex = 313;
			this.button41.TabStop = false;
			this.button41.Text = "Download";
			this.button41.TextAlign = ContentAlignment.MiddleRight;
			this.button41.UseVisualStyleBackColor = false;
			this.button41.Click += this.button41_Click;
			this.button42.BackColor = Color.FromArgb(38, 38, 38);
			this.button42.BackgroundImageLayout = ImageLayout.None;
			this.button42.Cursor = Cursors.Hand;
			this.button42.FlatAppearance.BorderSize = 0;
			this.button42.FlatStyle = FlatStyle.Flat;
			this.button42.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button42.ForeColor = Color.White;
			this.button42.Image = (Image)componentResourceManager.GetObject("button42.Image");
			this.button42.ImageAlign = ContentAlignment.MiddleLeft;
			this.button42.Location = new Point(753, 2011);
			this.button42.Margin = new Padding(1);
			this.button42.Name = "button42";
			this.button42.Size = new Size(120, 30);
			this.button42.TabIndex = 312;
			this.button42.TabStop = false;
			this.button42.Text = "Download";
			this.button42.TextAlign = ContentAlignment.MiddleRight;
			this.button42.UseVisualStyleBackColor = false;
			this.button42.Click += this.button42_Click;
			this.button43.BackColor = Color.FromArgb(38, 38, 38);
			this.button43.BackgroundImageLayout = ImageLayout.None;
			this.button43.Cursor = Cursors.Hand;
			this.button43.FlatAppearance.BorderSize = 0;
			this.button43.FlatStyle = FlatStyle.Flat;
			this.button43.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button43.ForeColor = Color.White;
			this.button43.Image = (Image)componentResourceManager.GetObject("button43.Image");
			this.button43.ImageAlign = ContentAlignment.MiddleLeft;
			this.button43.Location = new Point(753, 1971);
			this.button43.Margin = new Padding(1);
			this.button43.Name = "button43";
			this.button43.Size = new Size(120, 30);
			this.button43.TabIndex = 311;
			this.button43.TabStop = false;
			this.button43.Text = "Download";
			this.button43.TextAlign = ContentAlignment.MiddleRight;
			this.button43.UseVisualStyleBackColor = false;
			this.button43.Click += this.button43_Click;
			this.button44.BackColor = Color.FromArgb(38, 38, 38);
			this.button44.BackgroundImageLayout = ImageLayout.None;
			this.button44.Cursor = Cursors.Hand;
			this.button44.FlatAppearance.BorderSize = 0;
			this.button44.FlatStyle = FlatStyle.Flat;
			this.button44.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button44.ForeColor = Color.White;
			this.button44.Image = (Image)componentResourceManager.GetObject("button44.Image");
			this.button44.ImageAlign = ContentAlignment.MiddleLeft;
			this.button44.Location = new Point(753, 1931);
			this.button44.Margin = new Padding(1);
			this.button44.Name = "button44";
			this.button44.Size = new Size(120, 30);
			this.button44.TabIndex = 310;
			this.button44.TabStop = false;
			this.button44.Text = "Download";
			this.button44.TextAlign = ContentAlignment.MiddleRight;
			this.button44.UseVisualStyleBackColor = false;
			this.button44.Click += this.button44_Click;
			this.button45.BackColor = Color.FromArgb(38, 38, 38);
			this.button45.BackgroundImageLayout = ImageLayout.None;
			this.button45.Cursor = Cursors.Hand;
			this.button45.FlatAppearance.BorderSize = 0;
			this.button45.FlatStyle = FlatStyle.Flat;
			this.button45.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button45.ForeColor = Color.White;
			this.button45.Image = (Image)componentResourceManager.GetObject("button45.Image");
			this.button45.ImageAlign = ContentAlignment.MiddleLeft;
			this.button45.Location = new Point(753, 1891);
			this.button45.Margin = new Padding(1);
			this.button45.Name = "button45";
			this.button45.Size = new Size(120, 30);
			this.button45.TabIndex = 309;
			this.button45.TabStop = false;
			this.button45.Text = "Download";
			this.button45.TextAlign = ContentAlignment.MiddleRight;
			this.button45.UseVisualStyleBackColor = false;
			this.button45.Click += this.button45_Click;
			this.button46.BackColor = Color.FromArgb(38, 38, 38);
			this.button46.BackgroundImageLayout = ImageLayout.None;
			this.button46.Cursor = Cursors.Hand;
			this.button46.FlatAppearance.BorderSize = 0;
			this.button46.FlatStyle = FlatStyle.Flat;
			this.button46.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button46.ForeColor = Color.White;
			this.button46.Image = (Image)componentResourceManager.GetObject("button46.Image");
			this.button46.ImageAlign = ContentAlignment.MiddleLeft;
			this.button46.Location = new Point(753, 1851);
			this.button46.Margin = new Padding(1);
			this.button46.Name = "button46";
			this.button46.Size = new Size(120, 30);
			this.button46.TabIndex = 308;
			this.button46.TabStop = false;
			this.button46.Text = "Download";
			this.button46.TextAlign = ContentAlignment.MiddleRight;
			this.button46.UseVisualStyleBackColor = false;
			this.button46.Click += this.button46_Click;
			this.button47.BackColor = Color.FromArgb(38, 38, 38);
			this.button47.BackgroundImageLayout = ImageLayout.None;
			this.button47.Cursor = Cursors.Hand;
			this.button47.FlatAppearance.BorderSize = 0;
			this.button47.FlatStyle = FlatStyle.Flat;
			this.button47.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button47.ForeColor = Color.White;
			this.button47.Image = (Image)componentResourceManager.GetObject("button47.Image");
			this.button47.ImageAlign = ContentAlignment.MiddleLeft;
			this.button47.Location = new Point(753, 1811);
			this.button47.Margin = new Padding(1);
			this.button47.Name = "button47";
			this.button47.Size = new Size(120, 30);
			this.button47.TabIndex = 307;
			this.button47.TabStop = false;
			this.button47.Text = "Download";
			this.button47.TextAlign = ContentAlignment.MiddleRight;
			this.button47.UseVisualStyleBackColor = false;
			this.button47.Click += this.button47_Click;
			this.button48.BackColor = Color.FromArgb(38, 38, 38);
			this.button48.BackgroundImageLayout = ImageLayout.None;
			this.button48.Cursor = Cursors.Hand;
			this.button48.FlatAppearance.BorderSize = 0;
			this.button48.FlatStyle = FlatStyle.Flat;
			this.button48.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button48.ForeColor = Color.White;
			this.button48.Image = (Image)componentResourceManager.GetObject("button48.Image");
			this.button48.ImageAlign = ContentAlignment.MiddleLeft;
			this.button48.Location = new Point(753, 1771);
			this.button48.Margin = new Padding(1);
			this.button48.Name = "button48";
			this.button48.Size = new Size(120, 30);
			this.button48.TabIndex = 306;
			this.button48.TabStop = false;
			this.button48.Text = "Download";
			this.button48.TextAlign = ContentAlignment.MiddleRight;
			this.button48.UseVisualStyleBackColor = false;
			this.button48.Click += this.button48_Click;
			this.button49.BackColor = Color.FromArgb(38, 38, 38);
			this.button49.BackgroundImageLayout = ImageLayout.None;
			this.button49.Cursor = Cursors.Hand;
			this.button49.FlatAppearance.BorderSize = 0;
			this.button49.FlatStyle = FlatStyle.Flat;
			this.button49.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button49.ForeColor = Color.White;
			this.button49.Image = (Image)componentResourceManager.GetObject("button49.Image");
			this.button49.ImageAlign = ContentAlignment.MiddleLeft;
			this.button49.Location = new Point(753, 1691);
			this.button49.Margin = new Padding(1);
			this.button49.Name = "button49";
			this.button49.Size = new Size(120, 30);
			this.button49.TabIndex = 305;
			this.button49.TabStop = false;
			this.button49.Text = "Download";
			this.button49.TextAlign = ContentAlignment.MiddleRight;
			this.button49.UseVisualStyleBackColor = false;
			this.button49.Click += this.button49_Click;
			this.button50.BackColor = Color.FromArgb(38, 38, 38);
			this.button50.BackgroundImageLayout = ImageLayout.None;
			this.button50.Cursor = Cursors.Hand;
			this.button50.FlatAppearance.BorderSize = 0;
			this.button50.FlatStyle = FlatStyle.Flat;
			this.button50.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button50.ForeColor = Color.White;
			this.button50.Image = (Image)componentResourceManager.GetObject("button50.Image");
			this.button50.ImageAlign = ContentAlignment.MiddleLeft;
			this.button50.Location = new Point(753, 1651);
			this.button50.Margin = new Padding(1);
			this.button50.Name = "button50";
			this.button50.Size = new Size(120, 30);
			this.button50.TabIndex = 304;
			this.button50.TabStop = false;
			this.button50.Text = "Download";
			this.button50.TextAlign = ContentAlignment.MiddleRight;
			this.button50.UseVisualStyleBackColor = false;
			this.button50.Click += this.button50_Click;
			this.button51.BackColor = Color.FromArgb(38, 38, 38);
			this.button51.BackgroundImageLayout = ImageLayout.None;
			this.button51.Cursor = Cursors.Hand;
			this.button51.FlatAppearance.BorderSize = 0;
			this.button51.FlatStyle = FlatStyle.Flat;
			this.button51.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button51.ForeColor = Color.White;
			this.button51.Image = (Image)componentResourceManager.GetObject("button51.Image");
			this.button51.ImageAlign = ContentAlignment.MiddleLeft;
			this.button51.Location = new Point(753, 1611);
			this.button51.Margin = new Padding(1);
			this.button51.Name = "button51";
			this.button51.Size = new Size(120, 30);
			this.button51.TabIndex = 303;
			this.button51.TabStop = false;
			this.button51.Text = "Download";
			this.button51.TextAlign = ContentAlignment.MiddleRight;
			this.button51.UseVisualStyleBackColor = false;
			this.button51.Click += this.button51_Click;
			this.button52.BackColor = Color.FromArgb(38, 38, 38);
			this.button52.BackgroundImageLayout = ImageLayout.None;
			this.button52.Cursor = Cursors.Hand;
			this.button52.FlatAppearance.BorderSize = 0;
			this.button52.FlatStyle = FlatStyle.Flat;
			this.button52.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button52.ForeColor = Color.White;
			this.button52.Image = (Image)componentResourceManager.GetObject("button52.Image");
			this.button52.ImageAlign = ContentAlignment.MiddleLeft;
			this.button52.Location = new Point(753, 1571);
			this.button52.Margin = new Padding(1);
			this.button52.Name = "button52";
			this.button52.Size = new Size(120, 30);
			this.button52.TabIndex = 302;
			this.button52.TabStop = false;
			this.button52.Text = "Download";
			this.button52.TextAlign = ContentAlignment.MiddleRight;
			this.button52.UseVisualStyleBackColor = false;
			this.button52.Click += this.button52_Click;
			this.button53.BackColor = Color.FromArgb(38, 38, 38);
			this.button53.BackgroundImageLayout = ImageLayout.None;
			this.button53.Cursor = Cursors.Hand;
			this.button53.FlatAppearance.BorderSize = 0;
			this.button53.FlatStyle = FlatStyle.Flat;
			this.button53.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button53.ForeColor = Color.White;
			this.button53.Image = (Image)componentResourceManager.GetObject("button53.Image");
			this.button53.ImageAlign = ContentAlignment.MiddleLeft;
			this.button53.Location = new Point(753, 1531);
			this.button53.Margin = new Padding(1);
			this.button53.Name = "button53";
			this.button53.Size = new Size(120, 30);
			this.button53.TabIndex = 301;
			this.button53.TabStop = false;
			this.button53.Text = "Download";
			this.button53.TextAlign = ContentAlignment.MiddleRight;
			this.button53.UseVisualStyleBackColor = false;
			this.button53.Click += this.button53_Click;
			this.button54.BackColor = Color.FromArgb(38, 38, 38);
			this.button54.BackgroundImageLayout = ImageLayout.None;
			this.button54.Cursor = Cursors.Hand;
			this.button54.FlatAppearance.BorderSize = 0;
			this.button54.FlatStyle = FlatStyle.Flat;
			this.button54.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button54.ForeColor = Color.White;
			this.button54.Image = (Image)componentResourceManager.GetObject("button54.Image");
			this.button54.ImageAlign = ContentAlignment.MiddleLeft;
			this.button54.Location = new Point(753, 1491);
			this.button54.Margin = new Padding(1);
			this.button54.Name = "button54";
			this.button54.Size = new Size(120, 30);
			this.button54.TabIndex = 300;
			this.button54.TabStop = false;
			this.button54.Text = "Download";
			this.button54.TextAlign = ContentAlignment.MiddleRight;
			this.button54.UseVisualStyleBackColor = false;
			this.button54.Click += this.button54_Click;
			this.button55.BackColor = Color.FromArgb(38, 38, 38);
			this.button55.BackgroundImageLayout = ImageLayout.None;
			this.button55.Cursor = Cursors.Hand;
			this.button55.FlatAppearance.BorderSize = 0;
			this.button55.FlatStyle = FlatStyle.Flat;
			this.button55.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button55.ForeColor = Color.White;
			this.button55.Image = (Image)componentResourceManager.GetObject("button55.Image");
			this.button55.ImageAlign = ContentAlignment.MiddleLeft;
			this.button55.Location = new Point(753, 1451);
			this.button55.Margin = new Padding(1);
			this.button55.Name = "button55";
			this.button55.Size = new Size(120, 30);
			this.button55.TabIndex = 299;
			this.button55.TabStop = false;
			this.button55.Text = "Download";
			this.button55.TextAlign = ContentAlignment.MiddleRight;
			this.button55.UseVisualStyleBackColor = false;
			this.button55.Click += this.button55_Click;
			this.button20.BackColor = Color.FromArgb(38, 38, 38);
			this.button20.BackgroundImageLayout = ImageLayout.None;
			this.button20.Cursor = Cursors.Hand;
			this.button20.FlatAppearance.BorderSize = 0;
			this.button20.FlatStyle = FlatStyle.Flat;
			this.button20.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button20.ForeColor = Color.White;
			this.button20.Image = (Image)componentResourceManager.GetObject("button20.Image");
			this.button20.ImageAlign = ContentAlignment.MiddleLeft;
			this.button20.Location = new Point(753, 1411);
			this.button20.Margin = new Padding(1);
			this.button20.Name = "button20";
			this.button20.Size = new Size(120, 30);
			this.button20.TabIndex = 298;
			this.button20.TabStop = false;
			this.button20.Text = "Download";
			this.button20.TextAlign = ContentAlignment.MiddleRight;
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += this.button20_Click;
			this.button21.BackColor = Color.FromArgb(38, 38, 38);
			this.button21.BackgroundImageLayout = ImageLayout.None;
			this.button21.Cursor = Cursors.Hand;
			this.button21.FlatAppearance.BorderSize = 0;
			this.button21.FlatStyle = FlatStyle.Flat;
			this.button21.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button21.ForeColor = Color.White;
			this.button21.Image = (Image)componentResourceManager.GetObject("button21.Image");
			this.button21.ImageAlign = ContentAlignment.MiddleLeft;
			this.button21.Location = new Point(753, 1371);
			this.button21.Margin = new Padding(1);
			this.button21.Name = "button21";
			this.button21.Size = new Size(120, 30);
			this.button21.TabIndex = 297;
			this.button21.TabStop = false;
			this.button21.Text = "Download";
			this.button21.TextAlign = ContentAlignment.MiddleRight;
			this.button21.UseVisualStyleBackColor = false;
			this.button21.Click += this.button21_Click;
			this.button22.BackColor = Color.FromArgb(38, 38, 38);
			this.button22.BackgroundImageLayout = ImageLayout.None;
			this.button22.Cursor = Cursors.Hand;
			this.button22.FlatAppearance.BorderSize = 0;
			this.button22.FlatStyle = FlatStyle.Flat;
			this.button22.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button22.ForeColor = Color.White;
			this.button22.Image = (Image)componentResourceManager.GetObject("button22.Image");
			this.button22.ImageAlign = ContentAlignment.MiddleLeft;
			this.button22.Location = new Point(753, 1331);
			this.button22.Margin = new Padding(1);
			this.button22.Name = "button22";
			this.button22.Size = new Size(120, 30);
			this.button22.TabIndex = 296;
			this.button22.TabStop = false;
			this.button22.Text = "Download";
			this.button22.TextAlign = ContentAlignment.MiddleRight;
			this.button22.UseVisualStyleBackColor = false;
			this.button22.Click += this.button22_Click;
			this.button23.BackColor = Color.FromArgb(38, 38, 38);
			this.button23.BackgroundImageLayout = ImageLayout.None;
			this.button23.Cursor = Cursors.Hand;
			this.button23.FlatAppearance.BorderSize = 0;
			this.button23.FlatStyle = FlatStyle.Flat;
			this.button23.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button23.ForeColor = Color.White;
			this.button23.Image = (Image)componentResourceManager.GetObject("button23.Image");
			this.button23.ImageAlign = ContentAlignment.MiddleLeft;
			this.button23.Location = new Point(753, 1291);
			this.button23.Margin = new Padding(1);
			this.button23.Name = "button23";
			this.button23.Size = new Size(120, 30);
			this.button23.TabIndex = 295;
			this.button23.TabStop = false;
			this.button23.Text = "Download";
			this.button23.TextAlign = ContentAlignment.MiddleRight;
			this.button23.UseVisualStyleBackColor = false;
			this.button23.Click += this.button23_Click;
			this.button24.BackColor = Color.FromArgb(38, 38, 38);
			this.button24.BackgroundImageLayout = ImageLayout.None;
			this.button24.Cursor = Cursors.Hand;
			this.button24.FlatAppearance.BorderSize = 0;
			this.button24.FlatStyle = FlatStyle.Flat;
			this.button24.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button24.ForeColor = Color.White;
			this.button24.Image = (Image)componentResourceManager.GetObject("button24.Image");
			this.button24.ImageAlign = ContentAlignment.MiddleLeft;
			this.button24.Location = new Point(753, 1251);
			this.button24.Margin = new Padding(1);
			this.button24.Name = "button24";
			this.button24.Size = new Size(120, 30);
			this.button24.TabIndex = 294;
			this.button24.TabStop = false;
			this.button24.Text = "Download";
			this.button24.TextAlign = ContentAlignment.MiddleRight;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += this.button24_Click;
			this.button25.BackColor = Color.FromArgb(38, 38, 38);
			this.button25.BackgroundImageLayout = ImageLayout.None;
			this.button25.Cursor = Cursors.Hand;
			this.button25.FlatAppearance.BorderSize = 0;
			this.button25.FlatStyle = FlatStyle.Flat;
			this.button25.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button25.ForeColor = Color.White;
			this.button25.Image = (Image)componentResourceManager.GetObject("button25.Image");
			this.button25.ImageAlign = ContentAlignment.MiddleLeft;
			this.button25.Location = new Point(753, 1211);
			this.button25.Margin = new Padding(1);
			this.button25.Name = "button25";
			this.button25.Size = new Size(120, 30);
			this.button25.TabIndex = 293;
			this.button25.TabStop = false;
			this.button25.Text = "Download";
			this.button25.TextAlign = ContentAlignment.MiddleRight;
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += this.button25_Click;
			this.button26.BackColor = Color.FromArgb(38, 38, 38);
			this.button26.BackgroundImageLayout = ImageLayout.None;
			this.button26.Cursor = Cursors.Hand;
			this.button26.FlatAppearance.BorderSize = 0;
			this.button26.FlatStyle = FlatStyle.Flat;
			this.button26.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button26.ForeColor = Color.White;
			this.button26.Image = (Image)componentResourceManager.GetObject("button26.Image");
			this.button26.ImageAlign = ContentAlignment.MiddleLeft;
			this.button26.Location = new Point(753, 1171);
			this.button26.Margin = new Padding(1);
			this.button26.Name = "button26";
			this.button26.Size = new Size(120, 30);
			this.button26.TabIndex = 292;
			this.button26.TabStop = false;
			this.button26.Text = "Download";
			this.button26.TextAlign = ContentAlignment.MiddleRight;
			this.button26.UseVisualStyleBackColor = false;
			this.button26.Click += this.button26_Click;
			this.button27.BackColor = Color.FromArgb(38, 38, 38);
			this.button27.BackgroundImageLayout = ImageLayout.None;
			this.button27.Cursor = Cursors.Hand;
			this.button27.FlatAppearance.BorderSize = 0;
			this.button27.FlatStyle = FlatStyle.Flat;
			this.button27.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button27.ForeColor = Color.White;
			this.button27.Image = (Image)componentResourceManager.GetObject("button27.Image");
			this.button27.ImageAlign = ContentAlignment.MiddleLeft;
			this.button27.Location = new Point(753, 1131);
			this.button27.Margin = new Padding(1);
			this.button27.Name = "button27";
			this.button27.Size = new Size(120, 30);
			this.button27.TabIndex = 291;
			this.button27.TabStop = false;
			this.button27.Text = "Download";
			this.button27.TextAlign = ContentAlignment.MiddleRight;
			this.button27.UseVisualStyleBackColor = false;
			this.button27.Click += this.button27_Click;
			this.button28.BackColor = Color.FromArgb(38, 38, 38);
			this.button28.BackgroundImageLayout = ImageLayout.None;
			this.button28.Cursor = Cursors.Hand;
			this.button28.FlatAppearance.BorderSize = 0;
			this.button28.FlatStyle = FlatStyle.Flat;
			this.button28.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button28.ForeColor = Color.White;
			this.button28.Image = (Image)componentResourceManager.GetObject("button28.Image");
			this.button28.ImageAlign = ContentAlignment.MiddleLeft;
			this.button28.Location = new Point(753, 1091);
			this.button28.Margin = new Padding(1);
			this.button28.Name = "button28";
			this.button28.Size = new Size(120, 30);
			this.button28.TabIndex = 290;
			this.button28.TabStop = false;
			this.button28.Text = "Download";
			this.button28.TextAlign = ContentAlignment.MiddleRight;
			this.button28.UseVisualStyleBackColor = false;
			this.button28.Click += this.button28_Click;
			this.button29.BackColor = Color.FromArgb(38, 38, 38);
			this.button29.BackgroundImageLayout = ImageLayout.None;
			this.button29.Cursor = Cursors.Hand;
			this.button29.FlatAppearance.BorderSize = 0;
			this.button29.FlatStyle = FlatStyle.Flat;
			this.button29.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button29.ForeColor = Color.White;
			this.button29.Image = (Image)componentResourceManager.GetObject("button29.Image");
			this.button29.ImageAlign = ContentAlignment.MiddleLeft;
			this.button29.Location = new Point(753, 1051);
			this.button29.Margin = new Padding(1);
			this.button29.Name = "button29";
			this.button29.Size = new Size(120, 30);
			this.button29.TabIndex = 289;
			this.button29.TabStop = false;
			this.button29.Text = "Download";
			this.button29.TextAlign = ContentAlignment.MiddleRight;
			this.button29.UseVisualStyleBackColor = false;
			this.button29.Click += this.button29_Click;
			this.button30.BackColor = Color.FromArgb(38, 38, 38);
			this.button30.BackgroundImageLayout = ImageLayout.None;
			this.button30.Cursor = Cursors.Hand;
			this.button30.FlatAppearance.BorderSize = 0;
			this.button30.FlatStyle = FlatStyle.Flat;
			this.button30.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button30.ForeColor = Color.White;
			this.button30.Image = (Image)componentResourceManager.GetObject("button30.Image");
			this.button30.ImageAlign = ContentAlignment.MiddleLeft;
			this.button30.Location = new Point(753, 1011);
			this.button30.Margin = new Padding(1);
			this.button30.Name = "button30";
			this.button30.Size = new Size(120, 30);
			this.button30.TabIndex = 288;
			this.button30.TabStop = false;
			this.button30.Text = "Download";
			this.button30.TextAlign = ContentAlignment.MiddleRight;
			this.button30.UseVisualStyleBackColor = false;
			this.button30.Click += this.button30_Click;
			this.button31.BackColor = Color.FromArgb(38, 38, 38);
			this.button31.BackgroundImageLayout = ImageLayout.None;
			this.button31.Cursor = Cursors.Hand;
			this.button31.FlatAppearance.BorderSize = 0;
			this.button31.FlatStyle = FlatStyle.Flat;
			this.button31.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button31.ForeColor = Color.White;
			this.button31.Image = (Image)componentResourceManager.GetObject("button31.Image");
			this.button31.ImageAlign = ContentAlignment.MiddleLeft;
			this.button31.Location = new Point(753, 971);
			this.button31.Margin = new Padding(1);
			this.button31.Name = "button31";
			this.button31.Size = new Size(120, 30);
			this.button31.TabIndex = 287;
			this.button31.TabStop = false;
			this.button31.Text = "Download";
			this.button31.TextAlign = ContentAlignment.MiddleRight;
			this.button31.UseVisualStyleBackColor = false;
			this.button31.Click += this.button31_Click;
			this.button33.BackColor = Color.FromArgb(38, 38, 38);
			this.button33.BackgroundImageLayout = ImageLayout.None;
			this.button33.Cursor = Cursors.Hand;
			this.button33.FlatAppearance.BorderSize = 0;
			this.button33.FlatStyle = FlatStyle.Flat;
			this.button33.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button33.ForeColor = Color.White;
			this.button33.Image = (Image)componentResourceManager.GetObject("button33.Image");
			this.button33.ImageAlign = ContentAlignment.MiddleLeft;
			this.button33.Location = new Point(753, 931);
			this.button33.Margin = new Padding(1);
			this.button33.Name = "button33";
			this.button33.Size = new Size(120, 30);
			this.button33.TabIndex = 285;
			this.button33.TabStop = false;
			this.button33.Text = "Download";
			this.button33.TextAlign = ContentAlignment.MiddleRight;
			this.button33.UseVisualStyleBackColor = false;
			this.button33.Click += this.button33_Click;
			this.button34.BackColor = Color.FromArgb(38, 38, 38);
			this.button34.BackgroundImageLayout = ImageLayout.None;
			this.button34.Cursor = Cursors.Hand;
			this.button34.FlatAppearance.BorderSize = 0;
			this.button34.FlatStyle = FlatStyle.Flat;
			this.button34.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button34.ForeColor = Color.White;
			this.button34.Image = (Image)componentResourceManager.GetObject("button34.Image");
			this.button34.ImageAlign = ContentAlignment.MiddleLeft;
			this.button34.Location = new Point(753, 891);
			this.button34.Margin = new Padding(1);
			this.button34.Name = "button34";
			this.button34.Size = new Size(120, 30);
			this.button34.TabIndex = 284;
			this.button34.TabStop = false;
			this.button34.Text = "Download";
			this.button34.TextAlign = ContentAlignment.MiddleRight;
			this.button34.UseVisualStyleBackColor = false;
			this.button34.Click += this.button34_Click;
			this.button35.BackColor = Color.FromArgb(38, 38, 38);
			this.button35.BackgroundImageLayout = ImageLayout.None;
			this.button35.Cursor = Cursors.Hand;
			this.button35.FlatAppearance.BorderSize = 0;
			this.button35.FlatStyle = FlatStyle.Flat;
			this.button35.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button35.ForeColor = Color.White;
			this.button35.Image = (Image)componentResourceManager.GetObject("button35.Image");
			this.button35.ImageAlign = ContentAlignment.MiddleLeft;
			this.button35.Location = new Point(753, 811);
			this.button35.Margin = new Padding(1);
			this.button35.Name = "button35";
			this.button35.Size = new Size(120, 30);
			this.button35.TabIndex = 283;
			this.button35.TabStop = false;
			this.button35.Text = "Download";
			this.button35.TextAlign = ContentAlignment.MiddleRight;
			this.button35.UseVisualStyleBackColor = false;
			this.button35.Click += this.button35_Click;
			this.button36.BackColor = Color.FromArgb(38, 38, 38);
			this.button36.BackgroundImageLayout = ImageLayout.None;
			this.button36.Cursor = Cursors.Hand;
			this.button36.FlatAppearance.BorderSize = 0;
			this.button36.FlatStyle = FlatStyle.Flat;
			this.button36.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button36.ForeColor = Color.White;
			this.button36.Image = (Image)componentResourceManager.GetObject("button36.Image");
			this.button36.ImageAlign = ContentAlignment.MiddleLeft;
			this.button36.Location = new Point(753, 771);
			this.button36.Margin = new Padding(1);
			this.button36.Name = "button36";
			this.button36.Size = new Size(120, 30);
			this.button36.TabIndex = 282;
			this.button36.TabStop = false;
			this.button36.Text = "Download";
			this.button36.TextAlign = ContentAlignment.MiddleRight;
			this.button36.UseVisualStyleBackColor = false;
			this.button36.Click += this.button36_Click;
			this.button37.BackColor = Color.FromArgb(38, 38, 38);
			this.button37.BackgroundImageLayout = ImageLayout.None;
			this.button37.Cursor = Cursors.Hand;
			this.button37.FlatAppearance.BorderSize = 0;
			this.button37.FlatStyle = FlatStyle.Flat;
			this.button37.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button37.ForeColor = Color.White;
			this.button37.Image = (Image)componentResourceManager.GetObject("button37.Image");
			this.button37.ImageAlign = ContentAlignment.MiddleLeft;
			this.button37.Location = new Point(753, 731);
			this.button37.Margin = new Padding(1);
			this.button37.Name = "button37";
			this.button37.Size = new Size(120, 30);
			this.button37.TabIndex = 281;
			this.button37.TabStop = false;
			this.button37.Text = "Download";
			this.button37.TextAlign = ContentAlignment.MiddleRight;
			this.button37.UseVisualStyleBackColor = false;
			this.button37.Click += this.button37_Click;
			this.button11.BackColor = Color.FromArgb(38, 38, 38);
			this.button11.BackgroundImageLayout = ImageLayout.None;
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.Image = (Image)componentResourceManager.GetObject("button11.Image");
			this.button11.ImageAlign = ContentAlignment.MiddleLeft;
			this.button11.Location = new Point(753, 691);
			this.button11.Margin = new Padding(1);
			this.button11.Name = "button11";
			this.button11.Size = new Size(120, 30);
			this.button11.TabIndex = 280;
			this.button11.TabStop = false;
			this.button11.Text = "Download";
			this.button11.TextAlign = ContentAlignment.MiddleRight;
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += this.button11_Click;
			this.button12.BackColor = Color.FromArgb(38, 38, 38);
			this.button12.BackgroundImageLayout = ImageLayout.None;
			this.button12.Cursor = Cursors.Hand;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button12.ForeColor = Color.White;
			this.button12.Image = (Image)componentResourceManager.GetObject("button12.Image");
			this.button12.ImageAlign = ContentAlignment.MiddleLeft;
			this.button12.Location = new Point(753, 651);
			this.button12.Margin = new Padding(1);
			this.button12.Name = "button12";
			this.button12.Size = new Size(120, 30);
			this.button12.TabIndex = 279;
			this.button12.TabStop = false;
			this.button12.Text = "Download";
			this.button12.TextAlign = ContentAlignment.MiddleRight;
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += this.button12_Click;
			this.button13.BackColor = Color.FromArgb(38, 38, 38);
			this.button13.BackgroundImageLayout = ImageLayout.None;
			this.button13.Cursor = Cursors.Hand;
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button13.ForeColor = Color.White;
			this.button13.Image = (Image)componentResourceManager.GetObject("button13.Image");
			this.button13.ImageAlign = ContentAlignment.MiddleLeft;
			this.button13.Location = new Point(753, 611);
			this.button13.Margin = new Padding(1);
			this.button13.Name = "button13";
			this.button13.Size = new Size(120, 30);
			this.button13.TabIndex = 278;
			this.button13.TabStop = false;
			this.button13.Text = "Download";
			this.button13.TextAlign = ContentAlignment.MiddleRight;
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += this.button13_Click;
			this.button14.BackColor = Color.FromArgb(38, 38, 38);
			this.button14.BackgroundImageLayout = ImageLayout.None;
			this.button14.Cursor = Cursors.Hand;
			this.button14.FlatAppearance.BorderSize = 0;
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button14.ForeColor = Color.White;
			this.button14.Image = (Image)componentResourceManager.GetObject("button14.Image");
			this.button14.ImageAlign = ContentAlignment.MiddleLeft;
			this.button14.Location = new Point(753, 571);
			this.button14.Margin = new Padding(1);
			this.button14.Name = "button14";
			this.button14.Size = new Size(120, 30);
			this.button14.TabIndex = 277;
			this.button14.TabStop = false;
			this.button14.Text = "Download";
			this.button14.TextAlign = ContentAlignment.MiddleRight;
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += this.button14_Click;
			this.button15.BackColor = Color.FromArgb(38, 38, 38);
			this.button15.BackgroundImageLayout = ImageLayout.None;
			this.button15.Cursor = Cursors.Hand;
			this.button15.FlatAppearance.BorderSize = 0;
			this.button15.FlatStyle = FlatStyle.Flat;
			this.button15.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button15.ForeColor = Color.White;
			this.button15.Image = (Image)componentResourceManager.GetObject("button15.Image");
			this.button15.ImageAlign = ContentAlignment.MiddleLeft;
			this.button15.Location = new Point(753, 531);
			this.button15.Margin = new Padding(1);
			this.button15.Name = "button15";
			this.button15.Size = new Size(120, 30);
			this.button15.TabIndex = 276;
			this.button15.TabStop = false;
			this.button15.Text = "Download";
			this.button15.TextAlign = ContentAlignment.MiddleRight;
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += this.button15_Click;
			this.button16.BackColor = Color.FromArgb(38, 38, 38);
			this.button16.BackgroundImageLayout = ImageLayout.None;
			this.button16.Cursor = Cursors.Hand;
			this.button16.FlatAppearance.BorderSize = 0;
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button16.ForeColor = Color.White;
			this.button16.Image = (Image)componentResourceManager.GetObject("button16.Image");
			this.button16.ImageAlign = ContentAlignment.MiddleLeft;
			this.button16.Location = new Point(753, 491);
			this.button16.Margin = new Padding(1);
			this.button16.Name = "button16";
			this.button16.Size = new Size(120, 30);
			this.button16.TabIndex = 275;
			this.button16.TabStop = false;
			this.button16.Text = "Download";
			this.button16.TextAlign = ContentAlignment.MiddleRight;
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += this.button16_Click;
			this.button17.BackColor = Color.FromArgb(38, 38, 38);
			this.button17.BackgroundImageLayout = ImageLayout.None;
			this.button17.Cursor = Cursors.Hand;
			this.button17.FlatAppearance.BorderSize = 0;
			this.button17.FlatStyle = FlatStyle.Flat;
			this.button17.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button17.ForeColor = Color.White;
			this.button17.Image = (Image)componentResourceManager.GetObject("button17.Image");
			this.button17.ImageAlign = ContentAlignment.MiddleLeft;
			this.button17.Location = new Point(753, 451);
			this.button17.Margin = new Padding(1);
			this.button17.Name = "button17";
			this.button17.Size = new Size(120, 30);
			this.button17.TabIndex = 274;
			this.button17.TabStop = false;
			this.button17.Text = "Download";
			this.button17.TextAlign = ContentAlignment.MiddleRight;
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += this.button17_Click;
			this.button18.BackColor = Color.FromArgb(38, 38, 38);
			this.button18.BackgroundImageLayout = ImageLayout.None;
			this.button18.Cursor = Cursors.Hand;
			this.button18.FlatAppearance.BorderSize = 0;
			this.button18.FlatStyle = FlatStyle.Flat;
			this.button18.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button18.ForeColor = Color.White;
			this.button18.Image = (Image)componentResourceManager.GetObject("button18.Image");
			this.button18.ImageAlign = ContentAlignment.MiddleLeft;
			this.button18.Location = new Point(753, 411);
			this.button18.Margin = new Padding(1);
			this.button18.Name = "button18";
			this.button18.Size = new Size(120, 30);
			this.button18.TabIndex = 273;
			this.button18.TabStop = false;
			this.button18.Text = "Download";
			this.button18.TextAlign = ContentAlignment.MiddleRight;
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += this.button18_Click;
			this.button19.BackColor = Color.FromArgb(38, 38, 38);
			this.button19.BackgroundImageLayout = ImageLayout.None;
			this.button19.Cursor = Cursors.Hand;
			this.button19.FlatAppearance.BorderSize = 0;
			this.button19.FlatStyle = FlatStyle.Flat;
			this.button19.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button19.ForeColor = Color.White;
			this.button19.Image = (Image)componentResourceManager.GetObject("button19.Image");
			this.button19.ImageAlign = ContentAlignment.MiddleLeft;
			this.button19.Location = new Point(753, 371);
			this.button19.Margin = new Padding(1);
			this.button19.Name = "button19";
			this.button19.Size = new Size(120, 30);
			this.button19.TabIndex = 272;
			this.button19.TabStop = false;
			this.button19.Text = "Download";
			this.button19.TextAlign = ContentAlignment.MiddleRight;
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += this.button19_Click;
			this.button10.BackColor = Color.FromArgb(38, 38, 38);
			this.button10.BackgroundImageLayout = ImageLayout.None;
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.Image = (Image)componentResourceManager.GetObject("button10.Image");
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(753, 331);
			this.button10.Margin = new Padding(1);
			this.button10.Name = "button10";
			this.button10.Size = new Size(120, 30);
			this.button10.TabIndex = 271;
			this.button10.TabStop = false;
			this.button10.Text = "Download";
			this.button10.TextAlign = ContentAlignment.MiddleRight;
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click;
			this.button9.BackColor = Color.FromArgb(38, 38, 38);
			this.button9.BackgroundImageLayout = ImageLayout.None;
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button9.ForeColor = Color.White;
			this.button9.Image = (Image)componentResourceManager.GetObject("button9.Image");
			this.button9.ImageAlign = ContentAlignment.MiddleLeft;
			this.button9.Location = new Point(753, 291);
			this.button9.Margin = new Padding(1);
			this.button9.Name = "button9";
			this.button9.Size = new Size(120, 30);
			this.button9.TabIndex = 270;
			this.button9.TabStop = false;
			this.button9.Text = "Download";
			this.button9.TextAlign = ContentAlignment.MiddleRight;
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.BackgroundImageLayout = ImageLayout.None;
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.Image = (Image)componentResourceManager.GetObject("button8.Image");
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(753, 251);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(120, 30);
			this.button8.TabIndex = 269;
			this.button8.TabStop = false;
			this.button8.Text = "Download";
			this.button8.TextAlign = ContentAlignment.MiddleRight;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.BackgroundImageLayout = ImageLayout.None;
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.Image = (Image)componentResourceManager.GetObject("button7.Image");
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(753, 211);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(120, 30);
			this.button7.TabIndex = 268;
			this.button7.TabStop = false;
			this.button7.Text = "Download";
			this.button7.TextAlign = ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.BackgroundImageLayout = ImageLayout.None;
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.Image = (Image)componentResourceManager.GetObject("button6.Image");
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(753, 171);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(120, 30);
			this.button6.TabIndex = 267;
			this.button6.TabStop = false;
			this.button6.Text = "Download";
			this.button6.TextAlign = ContentAlignment.MiddleRight;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.BackgroundImageLayout = ImageLayout.None;
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.Image = (Image)componentResourceManager.GetObject("button5.Image");
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(753, 131);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(120, 30);
			this.button5.TabIndex = 266;
			this.button5.TabStop = false;
			this.button5.Text = "Download";
			this.button5.TextAlign = ContentAlignment.MiddleRight;
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.BackgroundImageLayout = ImageLayout.None;
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.Image = (Image)componentResourceManager.GetObject("button4.Image");
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(753, 91);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(120, 30);
			this.button4.TabIndex = 265;
			this.button4.TabStop = false;
			this.button4.Text = "Download";
			this.button4.TextAlign = ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.BackgroundImageLayout = ImageLayout.None;
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(753, 51);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(120, 30);
			this.button2.TabIndex = 264;
			this.button2.TabStop = false;
			this.button2.Text = "Download";
			this.button2.TextAlign = ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.BackgroundImageLayout = ImageLayout.None;
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(753, 11);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(120, 30);
			this.button1.TabIndex = 263;
			this.button1.TabStop = false;
			this.button1.Text = "Download";
			this.button1.TextAlign = ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.label264.AutoSize = true;
			this.label264.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label264.ForeColor = Color.White;
			this.label264.Location = new Point(580, 3652);
			this.label264.Name = "label264";
			this.label264.Size = new Size(130, 30);
			this.label264.TabIndex = 262;
			this.label264.Text = "| Size : 134MB";
			this.label265.AutoSize = true;
			this.label265.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label265.ForeColor = Color.White;
			this.label265.Location = new Point(407, 3652);
			this.label265.Name = "label265";
			this.label265.Size = new Size(94, 30);
			this.label265.TabIndex = 261;
			this.label265.Text = "| Cracked";
			this.label262.AutoSize = true;
			this.label262.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label262.ForeColor = Color.White;
			this.label262.Location = new Point(580, 3612);
			this.label262.Name = "label262";
			this.label262.Size = new Size(124, 30);
			this.label262.TabIndex = 260;
			this.label262.Text = "| Size : 88MB";
			this.label263.AutoSize = true;
			this.label263.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label263.ForeColor = Color.White;
			this.label263.Location = new Point(407, 3612);
			this.label263.Name = "label263";
			this.label263.Size = new Size(94, 30);
			this.label263.TabIndex = 259;
			this.label263.Text = "| Cracked";
			this.label260.AutoSize = true;
			this.label260.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label260.ForeColor = Color.White;
			this.label260.Location = new Point(580, 3572);
			this.label260.Name = "label260";
			this.label260.Size = new Size(133, 30);
			this.label260.TabIndex = 258;
			this.label260.Text = "| Size : 287MB";
			this.label261.AutoSize = true;
			this.label261.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label261.ForeColor = Color.White;
			this.label261.Location = new Point(407, 3572);
			this.label261.Name = "label261";
			this.label261.Size = new Size(94, 30);
			this.label261.TabIndex = 257;
			this.label261.Text = "| Cracked";
			this.label258.AutoSize = true;
			this.label258.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label258.ForeColor = Color.White;
			this.label258.Location = new Point(580, 3532);
			this.label258.Name = "label258";
			this.label258.Size = new Size(114, 30);
			this.label258.TabIndex = 256;
			this.label258.Text = "| Size : 3MB";
			this.label259.AutoSize = true;
			this.label259.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label259.ForeColor = Color.White;
			this.label259.Location = new Point(407, 3532);
			this.label259.Name = "label259";
			this.label259.Size = new Size(94, 30);
			this.label259.TabIndex = 255;
			this.label259.Text = "| Cracked";
			this.label256.AutoSize = true;
			this.label256.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label256.ForeColor = Color.White;
			this.label256.Location = new Point(580, 3492);
			this.label256.Name = "label256";
			this.label256.Size = new Size(134, 30);
			this.label256.TabIndex = 254;
			this.label256.Text = "| Size : 558MB";
			this.label257.AutoSize = true;
			this.label257.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label257.ForeColor = Color.White;
			this.label257.Location = new Point(407, 3492);
			this.label257.Name = "label257";
			this.label257.Size = new Size(94, 30);
			this.label257.TabIndex = 253;
			this.label257.Text = "| Cracked";
			this.label254.AutoSize = true;
			this.label254.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label254.ForeColor = Color.White;
			this.label254.Location = new Point(580, 3452);
			this.label254.Name = "label254";
			this.label254.Size = new Size(126, 30);
			this.label254.TabIndex = 252;
			this.label254.Text = "| Size : 40MB";
			this.label255.AutoSize = true;
			this.label255.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label255.ForeColor = Color.White;
			this.label255.Location = new Point(407, 3452);
			this.label255.Name = "label255";
			this.label255.Size = new Size(103, 30);
			this.label255.TabIndex = 251;
			this.label255.Text = "| Freeware";
			this.label252.AutoSize = true;
			this.label252.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label252.ForeColor = Color.White;
			this.label252.Location = new Point(580, 3412);
			this.label252.Name = "label252";
			this.label252.Size = new Size(139, 30);
			this.label252.TabIndex = 250;
			this.label252.Text = "| Size : 18.32GB";
			this.label253.AutoSize = true;
			this.label253.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label253.ForeColor = Color.White;
			this.label253.Location = new Point(407, 3412);
			this.label253.Name = "label253";
			this.label253.Size = new Size(94, 30);
			this.label253.TabIndex = 249;
			this.label253.Text = "| Cracked";
			this.label250.AutoSize = true;
			this.label250.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label250.ForeColor = Color.White;
			this.label250.Location = new Point(580, 3372);
			this.label250.Name = "label250";
			this.label250.Size = new Size(123, 30);
			this.label250.TabIndex = 248;
			this.label250.Text = "| Size : 3.8GB";
			this.label251.AutoSize = true;
			this.label251.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label251.ForeColor = Color.White;
			this.label251.Location = new Point(407, 3372);
			this.label251.Name = "label251";
			this.label251.Size = new Size(94, 30);
			this.label251.TabIndex = 247;
			this.label251.Text = "| Cracked";
			this.label248.AutoSize = true;
			this.label248.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label248.ForeColor = Color.White;
			this.label248.Location = new Point(580, 3332);
			this.label248.Name = "label248";
			this.label248.Size = new Size(114, 30);
			this.label248.TabIndex = 246;
			this.label248.Text = "| Size : 6MB";
			this.label249.AutoSize = true;
			this.label249.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label249.ForeColor = Color.White;
			this.label249.Location = new Point(407, 3332);
			this.label249.Name = "label249";
			this.label249.Size = new Size(94, 30);
			this.label249.TabIndex = 245;
			this.label249.Text = "| Cracked";
			this.label246.AutoSize = true;
			this.label246.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label246.ForeColor = Color.White;
			this.label246.Location = new Point(580, 3292);
			this.label246.Name = "label246";
			this.label246.Size = new Size(124, 30);
			this.label246.TabIndex = 244;
			this.label246.Text = "| Size : 46MB";
			this.label247.AutoSize = true;
			this.label247.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label247.ForeColor = Color.White;
			this.label247.Location = new Point(407, 3292);
			this.label247.Name = "label247";
			this.label247.Size = new Size(94, 30);
			this.label247.TabIndex = 243;
			this.label247.Text = "| Cracked";
			this.label244.AutoSize = true;
			this.label244.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label244.ForeColor = Color.White;
			this.label244.Location = new Point(580, 3252);
			this.label244.Name = "label244";
			this.label244.Size = new Size(124, 30);
			this.label244.TabIndex = 242;
			this.label244.Text = "| Size : 83MB";
			this.label245.AutoSize = true;
			this.label245.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label245.ForeColor = Color.White;
			this.label245.Location = new Point(407, 3252);
			this.label245.Name = "label245";
			this.label245.Size = new Size(131, 30);
			this.label245.TabIndex = 241;
			this.label245.Text = "| Free Version";
			this.label242.AutoSize = true;
			this.label242.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label242.ForeColor = Color.White;
			this.label242.Location = new Point(580, 3212);
			this.label242.Name = "label242";
			this.label242.Size = new Size(126, 30);
			this.label242.TabIndex = 240;
			this.label242.Text = "| Size : 20MB";
			this.label243.AutoSize = true;
			this.label243.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label243.ForeColor = Color.White;
			this.label243.Location = new Point(407, 3212);
			this.label243.Name = "label243";
			this.label243.Size = new Size(94, 30);
			this.label243.TabIndex = 239;
			this.label243.Text = "| Cracked";
			this.label240.AutoSize = true;
			this.label240.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label240.ForeColor = Color.White;
			this.label240.Location = new Point(580, 3172);
			this.label240.Name = "label240";
			this.label240.Size = new Size(110, 30);
			this.label240.TabIndex = 238;
			this.label240.Text = "| Size : 1MB";
			this.label241.AutoSize = true;
			this.label241.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label241.ForeColor = Color.White;
			this.label241.Location = new Point(407, 3172);
			this.label241.Name = "label241";
			this.label241.Size = new Size(94, 30);
			this.label241.TabIndex = 237;
			this.label241.Text = "| Cracked";
			this.label238.AutoSize = true;
			this.label238.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label238.ForeColor = Color.White;
			this.label238.Location = new Point(580, 3132);
			this.label238.Name = "label238";
			this.label238.Size = new Size(130, 30);
			this.label238.TabIndex = 236;
			this.label238.Text = "| Size : 182MB";
			this.label239.AutoSize = true;
			this.label239.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label239.ForeColor = Color.White;
			this.label239.Location = new Point(407, 3132);
			this.label239.Name = "label239";
			this.label239.Size = new Size(103, 30);
			this.label239.TabIndex = 235;
			this.label239.Text = "| Freeware";
			this.label236.AutoSize = true;
			this.label236.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label236.ForeColor = Color.White;
			this.label236.Location = new Point(580, 3092);
			this.label236.Name = "label236";
			this.label236.Size = new Size(120, 30);
			this.label236.TabIndex = 234;
			this.label236.Text = "| Size : 16MB";
			this.label237.AutoSize = true;
			this.label237.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label237.ForeColor = Color.White;
			this.label237.Location = new Point(407, 3092);
			this.label237.Name = "label237";
			this.label237.Size = new Size(94, 30);
			this.label237.TabIndex = 233;
			this.label237.Text = "| Cracked";
			this.label234.AutoSize = true;
			this.label234.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label234.ForeColor = Color.White;
			this.label234.Location = new Point(580, 3052);
			this.label234.Name = "label234";
			this.label234.Size = new Size(114, 30);
			this.label234.TabIndex = 232;
			this.label234.Text = "| Size : 6MB";
			this.label235.AutoSize = true;
			this.label235.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label235.ForeColor = Color.White;
			this.label235.Location = new Point(407, 3052);
			this.label235.Name = "label235";
			this.label235.Size = new Size(103, 30);
			this.label235.TabIndex = 231;
			this.label235.Text = "| Freeware";
			this.label232.AutoSize = true;
			this.label232.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label232.ForeColor = Color.White;
			this.label232.Location = new Point(580, 3012);
			this.label232.Name = "label232";
			this.label232.Size = new Size(114, 30);
			this.label232.TabIndex = 230;
			this.label232.Text = "| Size : 8MB";
			this.label233.AutoSize = true;
			this.label233.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label233.ForeColor = Color.White;
			this.label233.Location = new Point(407, 3012);
			this.label233.Name = "label233";
			this.label233.Size = new Size(94, 30);
			this.label233.TabIndex = 229;
			this.label233.Text = "| Cracked";
			this.label230.AutoSize = true;
			this.label230.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label230.ForeColor = Color.White;
			this.label230.Location = new Point(580, 2972);
			this.label230.Name = "label230";
			this.label230.Size = new Size(132, 30);
			this.label230.TabIndex = 228;
			this.label230.Text = "| Size : 106MB";
			this.label231.AutoSize = true;
			this.label231.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label231.ForeColor = Color.White;
			this.label231.Location = new Point(407, 2972);
			this.label231.Name = "label231";
			this.label231.Size = new Size(103, 30);
			this.label231.TabIndex = 227;
			this.label231.Text = "| Freeware";
			this.label228.AutoSize = true;
			this.label228.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label228.ForeColor = Color.White;
			this.label228.Location = new Point(580, 2932);
			this.label228.Name = "label228";
			this.label228.Size = new Size(134, 30);
			this.label228.TabIndex = 226;
			this.label228.Text = "| Size : 100MB";
			this.label229.AutoSize = true;
			this.label229.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label229.ForeColor = Color.White;
			this.label229.Location = new Point(407, 2932);
			this.label229.Name = "label229";
			this.label229.Size = new Size(103, 30);
			this.label229.TabIndex = 225;
			this.label229.Text = "| Freeware";
			this.label226.AutoSize = true;
			this.label226.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label226.ForeColor = Color.White;
			this.label226.Location = new Point(580, 2892);
			this.label226.Name = "label226";
			this.label226.Size = new Size(124, 30);
			this.label226.TabIndex = 224;
			this.label226.Text = "| Size : 85MB";
			this.label227.AutoSize = true;
			this.label227.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label227.ForeColor = Color.White;
			this.label227.Location = new Point(407, 2892);
			this.label227.Name = "label227";
			this.label227.Size = new Size(103, 30);
			this.label227.TabIndex = 223;
			this.label227.Text = "| Freeware";
			this.label224.AutoSize = true;
			this.label224.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label224.ForeColor = Color.White;
			this.label224.Location = new Point(581, 2812);
			this.label224.Name = "label224";
			this.label224.Size = new Size(114, 30);
			this.label224.TabIndex = 222;
			this.label224.Text = "| Size : 3MB";
			this.label225.AutoSize = true;
			this.label225.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label225.ForeColor = Color.White;
			this.label225.Location = new Point(408, 2812);
			this.label225.Name = "label225";
			this.label225.Size = new Size(103, 30);
			this.label225.TabIndex = 221;
			this.label225.Text = "| Freeware";
			this.label222.AutoSize = true;
			this.label222.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label222.ForeColor = Color.White;
			this.label222.Location = new Point(581, 2732);
			this.label222.Name = "label222";
			this.label222.Size = new Size(114, 30);
			this.label222.TabIndex = 220;
			this.label222.Text = "| Size : 5MB";
			this.label223.AutoSize = true;
			this.label223.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label223.ForeColor = Color.White;
			this.label223.Location = new Point(408, 2732);
			this.label223.Name = "label223";
			this.label223.Size = new Size(94, 30);
			this.label223.TabIndex = 219;
			this.label223.Text = "| Cracked";
			this.label220.AutoSize = true;
			this.label220.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label220.ForeColor = Color.White;
			this.label220.Location = new Point(581, 2692);
			this.label220.Name = "label220";
			this.label220.Size = new Size(124, 30);
			this.label220.TabIndex = 218;
			this.label220.Text = "| Size : 49MB";
			this.label221.AutoSize = true;
			this.label221.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label221.ForeColor = Color.White;
			this.label221.Location = new Point(408, 2692);
			this.label221.Name = "label221";
			this.label221.Size = new Size(103, 30);
			this.label221.TabIndex = 217;
			this.label221.Text = "| Freeware";
			this.label218.AutoSize = true;
			this.label218.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label218.ForeColor = Color.White;
			this.label218.Location = new Point(581, 2652);
			this.label218.Name = "label218";
			this.label218.Size = new Size(124, 30);
			this.label218.TabIndex = 216;
			this.label218.Text = "| Size : 53MB";
			this.label219.AutoSize = true;
			this.label219.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label219.ForeColor = Color.White;
			this.label219.Location = new Point(408, 2652);
			this.label219.Name = "label219";
			this.label219.Size = new Size(103, 30);
			this.label219.TabIndex = 215;
			this.label219.Text = "| Freeware";
			this.label216.AutoSize = true;
			this.label216.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label216.ForeColor = Color.White;
			this.label216.Location = new Point(581, 2612);
			this.label216.Name = "label216";
			this.label216.Size = new Size(135, 30);
			this.label216.TabIndex = 214;
			this.label216.Text = "| Size : 207MB";
			this.label217.AutoSize = true;
			this.label217.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label217.ForeColor = Color.White;
			this.label217.Location = new Point(408, 2612);
			this.label217.Name = "label217";
			this.label217.Size = new Size(94, 30);
			this.label217.TabIndex = 213;
			this.label217.Text = "| Cracked";
			this.label214.AutoSize = true;
			this.label214.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label214.ForeColor = Color.White;
			this.label214.Location = new Point(581, 2572);
			this.label214.Name = "label214";
			this.label214.Size = new Size(134, 30);
			this.label214.TabIndex = 212;
			this.label214.Text = "| Size : 486MB";
			this.label215.AutoSize = true;
			this.label215.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label215.ForeColor = Color.White;
			this.label215.Location = new Point(408, 2572);
			this.label215.Name = "label215";
			this.label215.Size = new Size(94, 30);
			this.label215.TabIndex = 211;
			this.label215.Text = "| Cracked";
			this.label212.AutoSize = true;
			this.label212.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label212.ForeColor = Color.White;
			this.label212.Location = new Point(581, 2532);
			this.label212.Name = "label212";
			this.label212.Size = new Size(123, 30);
			this.label212.TabIndex = 210;
			this.label212.Text = "| Size : 3.8GB";
			this.label213.AutoSize = true;
			this.label213.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label213.ForeColor = Color.White;
			this.label213.Location = new Point(408, 2532);
			this.label213.Name = "label213";
			this.label213.Size = new Size(94, 30);
			this.label213.TabIndex = 209;
			this.label213.Text = "| Cracked";
			this.label210.AutoSize = true;
			this.label210.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label210.ForeColor = Color.White;
			this.label210.Location = new Point(581, 2492);
			this.label210.Name = "label210";
			this.label210.Size = new Size(132, 30);
			this.label210.TabIndex = 208;
			this.label210.Text = "| Size : 5.76GB";
			this.label211.AutoSize = true;
			this.label211.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label211.ForeColor = Color.White;
			this.label211.Location = new Point(408, 2492);
			this.label211.Name = "label211";
			this.label211.Size = new Size(94, 30);
			this.label211.TabIndex = 207;
			this.label211.Text = "| Cracked";
			this.label208.AutoSize = true;
			this.label208.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label208.ForeColor = Color.White;
			this.label208.Location = new Point(581, 2452);
			this.label208.Name = "label208";
			this.label208.Size = new Size(129, 30);
			this.label208.TabIndex = 206;
			this.label208.Text = "| Size : 4.14GB";
			this.label209.AutoSize = true;
			this.label209.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label209.ForeColor = Color.White;
			this.label209.Location = new Point(408, 2452);
			this.label209.Name = "label209";
			this.label209.Size = new Size(94, 30);
			this.label209.TabIndex = 205;
			this.label209.Text = "| Cracked";
			this.label206.AutoSize = true;
			this.label206.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label206.ForeColor = Color.White;
			this.label206.Location = new Point(581, 2412);
			this.label206.Name = "label206";
			this.label206.Size = new Size(133, 30);
			this.label206.TabIndex = 204;
			this.label206.Text = "| Size : 2.55GB";
			this.label207.AutoSize = true;
			this.label207.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label207.ForeColor = Color.White;
			this.label207.Location = new Point(408, 2412);
			this.label207.Name = "label207";
			this.label207.Size = new Size(94, 30);
			this.label207.TabIndex = 203;
			this.label207.Text = "| Cracked";
			this.label204.AutoSize = true;
			this.label204.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label204.ForeColor = Color.White;
			this.label204.Location = new Point(581, 2372);
			this.label204.Name = "label204";
			this.label204.Size = new Size(132, 30);
			this.label204.TabIndex = 202;
			this.label204.Text = "| Size : 810MB";
			this.label205.AutoSize = true;
			this.label205.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label205.ForeColor = Color.White;
			this.label205.Location = new Point(408, 2372);
			this.label205.Name = "label205";
			this.label205.Size = new Size(94, 30);
			this.label205.TabIndex = 201;
			this.label205.Text = "| Cracked";
			this.label202.AutoSize = true;
			this.label202.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label202.ForeColor = Color.White;
			this.label202.Location = new Point(581, 2332);
			this.label202.Name = "label202";
			this.label202.Size = new Size(134, 30);
			this.label202.TabIndex = 200;
			this.label202.Text = "| Size : 558MB";
			this.label203.AutoSize = true;
			this.label203.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label203.ForeColor = Color.White;
			this.label203.Location = new Point(408, 2332);
			this.label203.Name = "label203";
			this.label203.Size = new Size(94, 30);
			this.label203.TabIndex = 199;
			this.label203.Text = "| Cracked";
			this.label200.AutoSize = true;
			this.label200.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label200.ForeColor = Color.White;
			this.label200.Location = new Point(581, 2292);
			this.label200.Name = "label200";
			this.label200.Size = new Size(116, 30);
			this.label200.TabIndex = 198;
			this.label200.Text = "| Size : 11MB";
			this.label201.AutoSize = true;
			this.label201.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label201.ForeColor = Color.White;
			this.label201.Location = new Point(408, 2292);
			this.label201.Name = "label201";
			this.label201.Size = new Size(103, 30);
			this.label201.TabIndex = 197;
			this.label201.Text = "| Freeware";
			this.label198.AutoSize = true;
			this.label198.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label198.ForeColor = Color.White;
			this.label198.Location = new Point(581, 2252);
			this.label198.Name = "label198";
			this.label198.Size = new Size(133, 30);
			this.label198.TabIndex = 196;
			this.label198.Text = "| Size : 753MB";
			this.label199.AutoSize = true;
			this.label199.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label199.ForeColor = Color.White;
			this.label199.Location = new Point(408, 2252);
			this.label199.Name = "label199";
			this.label199.Size = new Size(94, 30);
			this.label199.TabIndex = 195;
			this.label199.Text = "| Cracked";
			this.label196.AutoSize = true;
			this.label196.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label196.ForeColor = Color.White;
			this.label196.Location = new Point(581, 2212);
			this.label196.Name = "label196";
			this.label196.Size = new Size(133, 30);
			this.label196.TabIndex = 194;
			this.label196.Text = "| Size : 567MB";
			this.label197.AutoSize = true;
			this.label197.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label197.ForeColor = Color.White;
			this.label197.Location = new Point(408, 2212);
			this.label197.Name = "label197";
			this.label197.Size = new Size(94, 30);
			this.label197.TabIndex = 193;
			this.label197.Text = "| Cracked";
			this.label194.AutoSize = true;
			this.label194.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label194.ForeColor = Color.White;
			this.label194.Location = new Point(581, 2172);
			this.label194.Name = "label194";
			this.label194.Size = new Size(134, 30);
			this.label194.TabIndex = 192;
			this.label194.Text = "| Size : 534MB";
			this.label195.AutoSize = true;
			this.label195.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label195.ForeColor = Color.White;
			this.label195.Location = new Point(408, 2172);
			this.label195.Name = "label195";
			this.label195.Size = new Size(94, 30);
			this.label195.TabIndex = 191;
			this.label195.Text = "| Cracked";
			this.label192.AutoSize = true;
			this.label192.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label192.ForeColor = Color.White;
			this.label192.Location = new Point(581, 2132);
			this.label192.Name = "label192";
			this.label192.Size = new Size(124, 30);
			this.label192.TabIndex = 190;
			this.label192.Text = "| Size : 23MB";
			this.label193.AutoSize = true;
			this.label193.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label193.ForeColor = Color.White;
			this.label193.Location = new Point(408, 2132);
			this.label193.Name = "label193";
			this.label193.Size = new Size(103, 30);
			this.label193.TabIndex = 189;
			this.label193.Text = "| Freeware";
			this.label190.AutoSize = true;
			this.label190.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label190.ForeColor = Color.White;
			this.label190.Location = new Point(581, 2092);
			this.label190.Name = "label190";
			this.label190.Size = new Size(133, 30);
			this.label190.TabIndex = 188;
			this.label190.Text = "| Size : 578MB";
			this.label191.AutoSize = true;
			this.label191.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label191.ForeColor = Color.White;
			this.label191.Location = new Point(408, 2092);
			this.label191.Name = "label191";
			this.label191.Size = new Size(103, 30);
			this.label191.TabIndex = 187;
			this.label191.Text = "| Freeware";
			this.label188.AutoSize = true;
			this.label188.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label188.ForeColor = Color.White;
			this.label188.Location = new Point(581, 2052);
			this.label188.Name = "label188";
			this.label188.Size = new Size(124, 30);
			this.label188.TabIndex = 186;
			this.label188.Text = "| Size : 58MB";
			this.label189.AutoSize = true;
			this.label189.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label189.ForeColor = Color.White;
			this.label189.Location = new Point(408, 2052);
			this.label189.Name = "label189";
			this.label189.Size = new Size(103, 30);
			this.label189.TabIndex = 185;
			this.label189.Text = "| Freeware";
			this.label186.AutoSize = true;
			this.label186.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label186.ForeColor = Color.White;
			this.label186.Location = new Point(581, 2012);
			this.label186.Name = "label186";
			this.label186.Size = new Size(124, 30);
			this.label186.TabIndex = 184;
			this.label186.Text = "| Size : 48MB";
			this.label187.AutoSize = true;
			this.label187.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label187.ForeColor = Color.White;
			this.label187.Location = new Point(408, 2012);
			this.label187.Name = "label187";
			this.label187.Size = new Size(103, 30);
			this.label187.TabIndex = 183;
			this.label187.Text = "| Freeware";
			this.label184.AutoSize = true;
			this.label184.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label184.ForeColor = Color.White;
			this.label184.Location = new Point(581, 1972);
			this.label184.Name = "label184";
			this.label184.Size = new Size(124, 30);
			this.label184.TabIndex = 182;
			this.label184.Text = "| Size : 35MB";
			this.label185.AutoSize = true;
			this.label185.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label185.ForeColor = Color.White;
			this.label185.Location = new Point(408, 1972);
			this.label185.Name = "label185";
			this.label185.Size = new Size(103, 30);
			this.label185.TabIndex = 181;
			this.label185.Text = "| Freeware";
			this.label182.AutoSize = true;
			this.label182.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label182.ForeColor = Color.White;
			this.label182.Location = new Point(581, 1932);
			this.label182.Name = "label182";
			this.label182.Size = new Size(123, 30);
			this.label182.TabIndex = 180;
			this.label182.Text = "| Size : 73MB";
			this.label183.AutoSize = true;
			this.label183.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label183.ForeColor = Color.White;
			this.label183.Location = new Point(408, 1932);
			this.label183.Name = "label183";
			this.label183.Size = new Size(103, 30);
			this.label183.TabIndex = 179;
			this.label183.Text = "| Freeware";
			this.label180.AutoSize = true;
			this.label180.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label180.ForeColor = Color.White;
			this.label180.Location = new Point(581, 1892);
			this.label180.Name = "label180";
			this.label180.Size = new Size(124, 30);
			this.label180.TabIndex = 178;
			this.label180.Text = "| Size : 25MB";
			this.label181.AutoSize = true;
			this.label181.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label181.ForeColor = Color.White;
			this.label181.Location = new Point(408, 1892);
			this.label181.Name = "label181";
			this.label181.Size = new Size(103, 30);
			this.label181.TabIndex = 177;
			this.label181.Text = "| Freeware";
			this.label178.AutoSize = true;
			this.label178.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label178.ForeColor = Color.White;
			this.label178.Location = new Point(581, 1852);
			this.label178.Name = "label178";
			this.label178.Size = new Size(130, 30);
			this.label178.TabIndex = 176;
			this.label178.Text = "| Size : 241MB";
			this.label179.AutoSize = true;
			this.label179.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label179.ForeColor = Color.White;
			this.label179.Location = new Point(408, 1852);
			this.label179.Name = "label179";
			this.label179.Size = new Size(103, 30);
			this.label179.TabIndex = 175;
			this.label179.Text = "| Freeware";
			this.label176.AutoSize = true;
			this.label176.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label176.ForeColor = Color.White;
			this.label176.Location = new Point(581, 1812);
			this.label176.Name = "label176";
			this.label176.Size = new Size(126, 30);
			this.label176.TabIndex = 174;
			this.label176.Text = "| Size : 191MB";
			this.label177.AutoSize = true;
			this.label177.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label177.ForeColor = Color.White;
			this.label177.Location = new Point(408, 1812);
			this.label177.Name = "label177";
			this.label177.Size = new Size(131, 30);
			this.label177.TabIndex = 173;
			this.label177.Text = "| Free Version";
			this.label174.AutoSize = true;
			this.label174.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label174.ForeColor = Color.White;
			this.label174.Location = new Point(581, 1772);
			this.label174.Name = "label174";
			this.label174.Size = new Size(120, 30);
			this.label174.TabIndex = 172;
			this.label174.Text = "| Size : 15MB";
			this.label175.AutoSize = true;
			this.label175.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label175.ForeColor = Color.White;
			this.label175.Location = new Point(408, 1772);
			this.label175.Name = "label175";
			this.label175.Size = new Size(94, 30);
			this.label175.TabIndex = 171;
			this.label175.Text = "| Cracked";
			this.label172.AutoSize = true;
			this.label172.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label172.ForeColor = Color.White;
			this.label172.Location = new Point(581, 1692);
			this.label172.Name = "label172";
			this.label172.Size = new Size(129, 30);
			this.label172.TabIndex = 170;
			this.label172.Text = "| Size : 282KB";
			this.label173.AutoSize = true;
			this.label173.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label173.ForeColor = Color.White;
			this.label173.Location = new Point(408, 1692);
			this.label173.Name = "label173";
			this.label173.Size = new Size(103, 30);
			this.label173.TabIndex = 169;
			this.label173.Text = "| Freeware";
			this.label170.AutoSize = true;
			this.label170.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label170.ForeColor = Color.White;
			this.label170.Location = new Point(581, 1652);
			this.label170.Name = "label170";
			this.label170.Size = new Size(120, 30);
			this.label170.TabIndex = 168;
			this.label170.Text = "| Size : 12MB";
			this.label171.AutoSize = true;
			this.label171.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label171.ForeColor = Color.White;
			this.label171.Location = new Point(408, 1652);
			this.label171.Name = "label171";
			this.label171.Size = new Size(103, 30);
			this.label171.TabIndex = 167;
			this.label171.Text = "| Freeware";
			this.label168.AutoSize = true;
			this.label168.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label168.ForeColor = Color.White;
			this.label168.Location = new Point(581, 1612);
			this.label168.Name = "label168";
			this.label168.Size = new Size(124, 30);
			this.label168.TabIndex = 166;
			this.label168.Text = "| Size : 45MB";
			this.label169.AutoSize = true;
			this.label169.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label169.ForeColor = Color.White;
			this.label169.Location = new Point(408, 1612);
			this.label169.Name = "label169";
			this.label169.Size = new Size(94, 30);
			this.label169.TabIndex = 165;
			this.label169.Text = "| Cracked";
			this.label166.AutoSize = true;
			this.label166.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label166.ForeColor = Color.White;
			this.label166.Location = new Point(581, 1572);
			this.label166.Name = "label166";
			this.label166.Size = new Size(131, 30);
			this.label166.TabIndex = 164;
			this.label166.Text = "| Size : 1.03GB";
			this.label167.AutoSize = true;
			this.label167.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label167.ForeColor = Color.White;
			this.label167.Location = new Point(408, 1572);
			this.label167.Name = "label167";
			this.label167.Size = new Size(94, 30);
			this.label167.TabIndex = 163;
			this.label167.Text = "| Cracked";
			this.label164.AutoSize = true;
			this.label164.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label164.ForeColor = Color.White;
			this.label164.Location = new Point(581, 1532);
			this.label164.Name = "label164";
			this.label164.Size = new Size(124, 30);
			this.label164.TabIndex = 162;
			this.label164.Text = "| Size : 38MB";
			this.label165.AutoSize = true;
			this.label165.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label165.ForeColor = Color.White;
			this.label165.Location = new Point(408, 1532);
			this.label165.Name = "label165";
			this.label165.Size = new Size(94, 30);
			this.label165.TabIndex = 161;
			this.label165.Text = "| Cracked";
			this.label162.AutoSize = true;
			this.label162.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label162.ForeColor = Color.White;
			this.label162.Location = new Point(581, 1492);
			this.label162.Name = "label162";
			this.label162.Size = new Size(123, 30);
			this.label162.TabIndex = 160;
			this.label162.Text = "| Size : 47MB";
			this.label163.AutoSize = true;
			this.label163.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label163.ForeColor = Color.White;
			this.label163.Location = new Point(408, 1492);
			this.label163.Name = "label163";
			this.label163.Size = new Size(94, 30);
			this.label163.TabIndex = 159;
			this.label163.Text = "| Cracked";
			this.label160.AutoSize = true;
			this.label160.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label160.ForeColor = Color.White;
			this.label160.Location = new Point(581, 1452);
			this.label160.Name = "label160";
			this.label160.Size = new Size(123, 30);
			this.label160.TabIndex = 158;
			this.label160.Text = "| Size : 67MB";
			this.label161.AutoSize = true;
			this.label161.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label161.ForeColor = Color.White;
			this.label161.Location = new Point(408, 1452);
			this.label161.Name = "label161";
			this.label161.Size = new Size(103, 30);
			this.label161.TabIndex = 157;
			this.label161.Text = "| Freeware";
			this.label158.AutoSize = true;
			this.label158.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label158.ForeColor = Color.White;
			this.label158.Location = new Point(581, 1412);
			this.label158.Name = "label158";
			this.label158.Size = new Size(124, 30);
			this.label158.TabIndex = 156;
			this.label158.Text = "| Size : 29MB";
			this.label159.AutoSize = true;
			this.label159.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label159.ForeColor = Color.White;
			this.label159.Location = new Point(408, 1412);
			this.label159.Name = "label159";
			this.label159.Size = new Size(103, 30);
			this.label159.TabIndex = 155;
			this.label159.Text = "| Freeware";
			this.label156.AutoSize = true;
			this.label156.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label156.ForeColor = Color.White;
			this.label156.Location = new Point(581, 1372);
			this.label156.Name = "label156";
			this.label156.Size = new Size(131, 30);
			this.label156.TabIndex = 154;
			this.label156.Text = "| Size : 374MB";
			this.label157.AutoSize = true;
			this.label157.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label157.ForeColor = Color.White;
			this.label157.Location = new Point(408, 1372);
			this.label157.Name = "label157";
			this.label157.Size = new Size(94, 30);
			this.label157.TabIndex = 153;
			this.label157.Text = "| Cracked";
			this.label154.AutoSize = true;
			this.label154.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label154.ForeColor = Color.White;
			this.label154.Location = new Point(581, 1332);
			this.label154.Name = "label154";
			this.label154.Size = new Size(134, 30);
			this.label154.TabIndex = 152;
			this.label154.Text = "| Size : 386MB";
			this.label155.AutoSize = true;
			this.label155.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label155.ForeColor = Color.White;
			this.label155.Location = new Point(408, 1332);
			this.label155.Name = "label155";
			this.label155.Size = new Size(94, 30);
			this.label155.TabIndex = 151;
			this.label155.Text = "| Cracked";
			this.label152.AutoSize = true;
			this.label152.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label152.ForeColor = Color.White;
			this.label152.Location = new Point(581, 1292);
			this.label152.Name = "label152";
			this.label152.Size = new Size(136, 30);
			this.label152.TabIndex = 150;
			this.label152.Text = "| Size : 840MB";
			this.label153.AutoSize = true;
			this.label153.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label153.ForeColor = Color.White;
			this.label153.Location = new Point(408, 1292);
			this.label153.Name = "label153";
			this.label153.Size = new Size(94, 30);
			this.label153.TabIndex = 149;
			this.label153.Text = "| Cracked";
			this.label150.AutoSize = true;
			this.label150.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label150.ForeColor = Color.White;
			this.label150.Location = new Point(581, 1252);
			this.label150.Name = "label150";
			this.label150.Size = new Size(124, 30);
			this.label150.TabIndex = 148;
			this.label150.Text = "| Size : 35MB";
			this.label151.AutoSize = true;
			this.label151.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label151.ForeColor = Color.White;
			this.label151.Location = new Point(408, 1252);
			this.label151.Name = "label151";
			this.label151.Size = new Size(94, 30);
			this.label151.TabIndex = 147;
			this.label151.Text = "| Cracked";
			this.label148.AutoSize = true;
			this.label148.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label148.ForeColor = Color.White;
			this.label148.Location = new Point(581, 1212);
			this.label148.Name = "label148";
			this.label148.Size = new Size(133, 30);
			this.label148.TabIndex = 146;
			this.label148.Text = "| Size : 527MB";
			this.label149.AutoSize = true;
			this.label149.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label149.ForeColor = Color.White;
			this.label149.Location = new Point(408, 1212);
			this.label149.Name = "label149";
			this.label149.Size = new Size(94, 30);
			this.label149.TabIndex = 145;
			this.label149.Text = "| Cracked";
			this.label146.AutoSize = true;
			this.label146.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label146.ForeColor = Color.White;
			this.label146.Location = new Point(581, 1172);
			this.label146.Name = "label146";
			this.label146.Size = new Size(120, 30);
			this.label146.TabIndex = 144;
			this.label146.Text = "| Size : 81MB";
			this.label147.AutoSize = true;
			this.label147.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label147.ForeColor = Color.White;
			this.label147.Location = new Point(408, 1172);
			this.label147.Name = "label147";
			this.label147.Size = new Size(103, 30);
			this.label147.TabIndex = 143;
			this.label147.Text = "| Freeware";
			this.label144.AutoSize = true;
			this.label144.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label144.ForeColor = Color.White;
			this.label144.Location = new Point(581, 1132);
			this.label144.Name = "label144";
			this.label144.Size = new Size(124, 30);
			this.label144.TabIndex = 142;
			this.label144.Text = "| Size : 63MB";
			this.label145.AutoSize = true;
			this.label145.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label145.ForeColor = Color.White;
			this.label145.Location = new Point(408, 1132);
			this.label145.Name = "label145";
			this.label145.Size = new Size(103, 30);
			this.label145.TabIndex = 141;
			this.label145.Text = "| Freeware";
			this.label142.AutoSize = true;
			this.label142.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label142.ForeColor = Color.White;
			this.label142.Location = new Point(581, 1092);
			this.label142.Name = "label142";
			this.label142.Size = new Size(113, 30);
			this.label142.TabIndex = 140;
			this.label142.Text = "| Size : 7MB";
			this.label143.AutoSize = true;
			this.label143.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label143.ForeColor = Color.White;
			this.label143.Location = new Point(408, 1092);
			this.label143.Name = "label143";
			this.label143.Size = new Size(94, 30);
			this.label143.TabIndex = 139;
			this.label143.Text = "| Cracked";
			this.label140.AutoSize = true;
			this.label140.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label140.ForeColor = Color.White;
			this.label140.Location = new Point(581, 1052);
			this.label140.Name = "label140";
			this.label140.Size = new Size(114, 30);
			this.label140.TabIndex = 138;
			this.label140.Text = "| Size : 6MB";
			this.label141.AutoSize = true;
			this.label141.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label141.ForeColor = Color.White;
			this.label141.Location = new Point(408, 1052);
			this.label141.Name = "label141";
			this.label141.Size = new Size(94, 30);
			this.label141.TabIndex = 137;
			this.label141.Text = "| Cracked";
			this.label138.AutoSize = true;
			this.label138.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label138.ForeColor = Color.White;
			this.label138.Location = new Point(581, 1012);
			this.label138.Name = "label138";
			this.label138.Size = new Size(120, 30);
			this.label138.TabIndex = 136;
			this.label138.Text = "| Size : 21MB";
			this.label139.AutoSize = true;
			this.label139.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label139.ForeColor = Color.White;
			this.label139.Location = new Point(408, 1012);
			this.label139.Name = "label139";
			this.label139.Size = new Size(94, 30);
			this.label139.TabIndex = 135;
			this.label139.Text = "| Cracked";
			this.label136.AutoSize = true;
			this.label136.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label136.ForeColor = Color.White;
			this.label136.Location = new Point(581, 972);
			this.label136.Name = "label136";
			this.label136.Size = new Size(124, 30);
			this.label136.TabIndex = 134;
			this.label136.Text = "| Size : 25MB";
			this.label137.AutoSize = true;
			this.label137.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label137.ForeColor = Color.White;
			this.label137.Location = new Point(408, 972);
			this.label137.Name = "label137";
			this.label137.Size = new Size(103, 30);
			this.label137.TabIndex = 133;
			this.label137.Text = "| Freeware";
			this.label132.AutoSize = true;
			this.label132.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label132.ForeColor = Color.White;
			this.label132.Location = new Point(581, 932);
			this.label132.Name = "label132";
			this.label132.Size = new Size(126, 30);
			this.label132.TabIndex = 130;
			this.label132.Text = "| Size : 115MB";
			this.label133.AutoSize = true;
			this.label133.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label133.ForeColor = Color.White;
			this.label133.Location = new Point(408, 932);
			this.label133.Name = "label133";
			this.label133.Size = new Size(94, 30);
			this.label133.TabIndex = 129;
			this.label133.Text = "| Cracked";
			this.label130.AutoSize = true;
			this.label130.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label130.ForeColor = Color.White;
			this.label130.Location = new Point(581, 892);
			this.label130.Name = "label130";
			this.label130.Size = new Size(132, 30);
			this.label130.TabIndex = 128;
			this.label130.Text = "| Size : 401MB";
			this.label131.AutoSize = true;
			this.label131.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label131.ForeColor = Color.White;
			this.label131.Location = new Point(408, 892);
			this.label131.Name = "label131";
			this.label131.Size = new Size(94, 30);
			this.label131.TabIndex = 127;
			this.label131.Text = "| Cracked";
			this.label128.AutoSize = true;
			this.label128.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label128.ForeColor = Color.White;
			this.label128.Location = new Point(581, 812);
			this.label128.Name = "label128";
			this.label128.Size = new Size(124, 30);
			this.label128.TabIndex = 126;
			this.label128.Text = "| Size : 89MB";
			this.label129.AutoSize = true;
			this.label129.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label129.ForeColor = Color.White;
			this.label129.Location = new Point(408, 812);
			this.label129.Name = "label129";
			this.label129.Size = new Size(94, 30);
			this.label129.TabIndex = 125;
			this.label129.Text = "| Cracked";
			this.label126.AutoSize = true;
			this.label126.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label126.ForeColor = Color.White;
			this.label126.Location = new Point(581, 772);
			this.label126.Name = "label126";
			this.label126.Size = new Size(133, 30);
			this.label126.TabIndex = 124;
			this.label126.Text = "| Size : 379MB";
			this.label127.AutoSize = true;
			this.label127.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label127.ForeColor = Color.White;
			this.label127.Location = new Point(408, 772);
			this.label127.Name = "label127";
			this.label127.Size = new Size(94, 30);
			this.label127.TabIndex = 123;
			this.label127.Text = "| Cracked";
			this.label124.AutoSize = true;
			this.label124.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label124.ForeColor = Color.White;
			this.label124.Location = new Point(581, 732);
			this.label124.Name = "label124";
			this.label124.Size = new Size(134, 30);
			this.label124.TabIndex = 122;
			this.label124.Text = "| Size : 866MB";
			this.label125.AutoSize = true;
			this.label125.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label125.ForeColor = Color.White;
			this.label125.Location = new Point(408, 732);
			this.label125.Name = "label125";
			this.label125.Size = new Size(94, 30);
			this.label125.TabIndex = 121;
			this.label125.Text = "| Cracked";
			this.label122.AutoSize = true;
			this.label122.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label122.ForeColor = Color.White;
			this.label122.Location = new Point(581, 692);
			this.label122.Name = "label122";
			this.label122.Size = new Size(118, 30);
			this.label122.TabIndex = 120;
			this.label122.Text = "| Size : 1.7GB";
			this.label123.AutoSize = true;
			this.label123.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label123.ForeColor = Color.White;
			this.label123.Location = new Point(408, 692);
			this.label123.Name = "label123";
			this.label123.Size = new Size(94, 30);
			this.label123.TabIndex = 119;
			this.label123.Text = "| Cracked";
			this.label120.AutoSize = true;
			this.label120.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label120.ForeColor = Color.White;
			this.label120.Location = new Point(581, 652);
			this.label120.Name = "label120";
			this.label120.Size = new Size(134, 30);
			this.label120.TabIndex = 118;
			this.label120.Text = "| Size : 632MB";
			this.label121.AutoSize = true;
			this.label121.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label121.ForeColor = Color.White;
			this.label121.Location = new Point(408, 652);
			this.label121.Name = "label121";
			this.label121.Size = new Size(94, 30);
			this.label121.TabIndex = 117;
			this.label121.Text = "| Cracked";
			this.label118.AutoSize = true;
			this.label118.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label118.ForeColor = Color.White;
			this.label118.Location = new Point(581, 612);
			this.label118.Name = "label118";
			this.label118.Size = new Size(123, 30);
			this.label118.TabIndex = 116;
			this.label118.Text = "| Size : 2.5GB";
			this.label119.AutoSize = true;
			this.label119.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label119.ForeColor = Color.White;
			this.label119.Location = new Point(408, 612);
			this.label119.Name = "label119";
			this.label119.Size = new Size(94, 30);
			this.label119.TabIndex = 115;
			this.label119.Text = "| Cracked";
			this.label116.AutoSize = true;
			this.label116.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label116.ForeColor = Color.White;
			this.label116.Location = new Point(581, 572);
			this.label116.Name = "label116";
			this.label116.Size = new Size(106, 30);
			this.label116.TabIndex = 114;
			this.label116.Text = "| Size : 1GB";
			this.label117.AutoSize = true;
			this.label117.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label117.ForeColor = Color.White;
			this.label117.Location = new Point(408, 572);
			this.label117.Name = "label117";
			this.label117.Size = new Size(94, 30);
			this.label117.TabIndex = 113;
			this.label117.Text = "| Cracked";
			this.label114.AutoSize = true;
			this.label114.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label114.ForeColor = Color.White;
			this.label114.Location = new Point(581, 532);
			this.label114.Name = "label114";
			this.label114.Size = new Size(130, 30);
			this.label114.TabIndex = 112;
			this.label114.Text = "| Size : 681MB";
			this.label115.AutoSize = true;
			this.label115.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label115.ForeColor = Color.White;
			this.label115.Location = new Point(408, 532);
			this.label115.Name = "label115";
			this.label115.Size = new Size(94, 30);
			this.label115.TabIndex = 111;
			this.label115.Text = "| Cracked";
			this.label112.AutoSize = true;
			this.label112.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label112.ForeColor = Color.White;
			this.label112.Location = new Point(581, 492);
			this.label112.Name = "label112";
			this.label112.Size = new Size(121, 30);
			this.label112.TabIndex = 110;
			this.label112.Text = "| Size : 1.11GB";
			this.label113.AutoSize = true;
			this.label113.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label113.ForeColor = Color.White;
			this.label113.Location = new Point(408, 492);
			this.label113.Name = "label113";
			this.label113.Size = new Size(94, 30);
			this.label113.TabIndex = 109;
			this.label113.Text = "| Cracked";
			this.label110.AutoSize = true;
			this.label110.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label110.ForeColor = Color.White;
			this.label110.Location = new Point(581, 452);
			this.label110.Name = "label110";
			this.label110.Size = new Size(133, 30);
			this.label110.TabIndex = 108;
			this.label110.Text = "| Size : 739MB";
			this.label111.AutoSize = true;
			this.label111.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label111.ForeColor = Color.White;
			this.label111.Location = new Point(408, 452);
			this.label111.Name = "label111";
			this.label111.Size = new Size(94, 30);
			this.label111.TabIndex = 107;
			this.label111.Text = "| Cracked";
			this.label108.AutoSize = true;
			this.label108.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label108.ForeColor = Color.White;
			this.label108.Location = new Point(581, 412);
			this.label108.Name = "label108";
			this.label108.Size = new Size(119, 30);
			this.label108.TabIndex = 106;
			this.label108.Text = "| Size : 1.5GB";
			this.label109.AutoSize = true;
			this.label109.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label109.ForeColor = Color.White;
			this.label109.Location = new Point(408, 412);
			this.label109.Name = "label109";
			this.label109.Size = new Size(94, 30);
			this.label109.TabIndex = 105;
			this.label109.Text = "| Cracked";
			this.label106.AutoSize = true;
			this.label106.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label106.ForeColor = Color.White;
			this.label106.Location = new Point(581, 372);
			this.label106.Name = "label106";
			this.label106.Size = new Size(134, 30);
			this.label106.TabIndex = 104;
			this.label106.Text = "| Size : 555MB";
			this.label107.AutoSize = true;
			this.label107.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label107.ForeColor = Color.White;
			this.label107.Location = new Point(408, 372);
			this.label107.Name = "label107";
			this.label107.Size = new Size(94, 30);
			this.label107.TabIndex = 103;
			this.label107.Text = "| Cracked";
			this.label104.AutoSize = true;
			this.label104.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label104.ForeColor = Color.White;
			this.label104.Location = new Point(581, 332);
			this.label104.Name = "label104";
			this.label104.Size = new Size(134, 30);
			this.label104.TabIndex = 102;
			this.label104.Text = "| Size : 955MB";
			this.label105.AutoSize = true;
			this.label105.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label105.ForeColor = Color.White;
			this.label105.Location = new Point(408, 332);
			this.label105.Name = "label105";
			this.label105.Size = new Size(94, 30);
			this.label105.TabIndex = 101;
			this.label105.Text = "| Cracked";
			this.label102.AutoSize = true;
			this.label102.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label102.ForeColor = Color.White;
			this.label102.Location = new Point(581, 292);
			this.label102.Name = "label102";
			this.label102.Size = new Size(119, 30);
			this.label102.TabIndex = 100;
			this.label102.Text = "| Size : 1.8GB";
			this.label103.AutoSize = true;
			this.label103.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label103.ForeColor = Color.White;
			this.label103.Location = new Point(408, 292);
			this.label103.Name = "label103";
			this.label103.Size = new Size(94, 30);
			this.label103.TabIndex = 99;
			this.label103.Text = "| Cracked";
			this.label83.AutoSize = true;
			this.label83.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label83.ForeColor = Color.White;
			this.label83.Location = new Point(581, 252);
			this.label83.Name = "label83";
			this.label83.Size = new Size(136, 30);
			this.label83.TabIndex = 98;
			this.label83.Text = "| Size : 920MB";
			this.label101.AutoSize = true;
			this.label101.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label101.ForeColor = Color.White;
			this.label101.Location = new Point(408, 252);
			this.label101.Name = "label101";
			this.label101.Size = new Size(94, 30);
			this.label101.TabIndex = 97;
			this.label101.Text = "| Cracked";
			this.label81.AutoSize = true;
			this.label81.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label81.ForeColor = Color.White;
			this.label81.Location = new Point(581, 212);
			this.label81.Name = "label81";
			this.label81.Size = new Size(125, 30);
			this.label81.TabIndex = 96;
			this.label81.Text = "| Size : 1.19GB";
			this.label82.AutoSize = true;
			this.label82.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label82.ForeColor = Color.White;
			this.label82.Location = new Point(408, 212);
			this.label82.Name = "label82";
			this.label82.Size = new Size(94, 30);
			this.label82.TabIndex = 95;
			this.label82.Text = "| Cracked";
			this.label79.AutoSize = true;
			this.label79.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label79.ForeColor = Color.White;
			this.label79.Location = new Point(581, 172);
			this.label79.Name = "label79";
			this.label79.Size = new Size(119, 30);
			this.label79.TabIndex = 94;
			this.label79.Text = "| Size : 2.1GB";
			this.label80.AutoSize = true;
			this.label80.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label80.ForeColor = Color.White;
			this.label80.Location = new Point(408, 172);
			this.label80.Name = "label80";
			this.label80.Size = new Size(94, 30);
			this.label80.TabIndex = 93;
			this.label80.Text = "| Cracked";
			this.label77.AutoSize = true;
			this.label77.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label77.ForeColor = Color.White;
			this.label77.Location = new Point(581, 132);
			this.label77.Name = "label77";
			this.label77.Size = new Size(134, 30);
			this.label77.TabIndex = 92;
			this.label77.Text = "| Size : 445MB";
			this.label78.AutoSize = true;
			this.label78.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label78.ForeColor = Color.White;
			this.label78.Location = new Point(408, 132);
			this.label78.Name = "label78";
			this.label78.Size = new Size(94, 30);
			this.label78.TabIndex = 91;
			this.label78.Text = "| Cracked";
			this.label76.AutoSize = true;
			this.label76.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label76.ForeColor = Color.White;
			this.label76.Location = new Point(581, 92);
			this.label76.Name = "label76";
			this.label76.Size = new Size(133, 30);
			this.label76.TabIndex = 90;
			this.label76.Text = "| Size : 2.49GB";
			this.label75.AutoSize = true;
			this.label75.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label75.ForeColor = Color.White;
			this.label75.Location = new Point(408, 92);
			this.label75.Name = "label75";
			this.label75.Size = new Size(94, 30);
			this.label75.TabIndex = 89;
			this.label75.Text = "| Cracked";
			this.label84.AutoSize = true;
			this.label84.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label84.ForeColor = Color.White;
			this.label84.Location = new Point(17, 3651);
			this.label84.Name = "label84";
			this.label84.Size = new Size(127, 30);
			this.label84.TabIndex = 88;
			this.label84.Text = "• WPS Office";
			this.label85.AutoSize = true;
			this.label85.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label85.ForeColor = Color.White;
			this.label85.Location = new Point(17, 3611);
			this.label85.Name = "label85";
			this.label85.Size = new Size(304, 30);
			this.label85.TabIndex = 87;
			this.label85.Text = "• WonderFox HD Video Converter";
			this.label86.AutoSize = true;
			this.label86.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label86.ForeColor = Color.White;
			this.label86.Location = new Point(17, 3571);
			this.label86.Name = "label86";
			this.label86.Size = new Size(231, 30);
			this.label86.TabIndex = 86;
			this.label86.Text = "• Wondershare Filmora X";
			this.label87.AutoSize = true;
			this.label87.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label87.ForeColor = Color.White;
			this.label87.Location = new Point(17, 3531);
			this.label87.Name = "label87";
			this.label87.Size = new Size(102, 30);
			this.label87.TabIndex = 85;
			this.label87.Text = "• WinRAR";
			this.label88.AutoSize = true;
			this.label88.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label88.ForeColor = Color.White;
			this.label88.Location = new Point(17, 3491);
			this.label88.Name = "label88";
			this.label88.Size = new Size(241, 30);
			this.label88.TabIndex = 84;
			this.label88.Text = "• VM Ware Workstation 16";
			this.label89.AutoSize = true;
			this.label89.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label89.ForeColor = Color.White;
			this.label89.Location = new Point(17, 3451);
			this.label89.Name = "label89";
			this.label89.Size = new Size(187, 30);
			this.label89.TabIndex = 83;
			this.label89.Text = "• VLC Media Player";
			this.label90.AutoSize = true;
			this.label90.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label90.ForeColor = Color.White;
			this.label90.Location = new Point(17, 3411);
			this.label90.Name = "label90";
			this.label90.Size = new Size(184, 30);
			this.label90.TabIndex = 82;
			this.label90.Text = "• Visual Studio 2017";
			this.label91.AutoSize = true;
			this.label91.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label91.ForeColor = Color.White;
			this.label91.Location = new Point(17, 3371);
			this.label91.Name = "label91";
			this.label91.Size = new Size(185, 30);
			this.label91.TabIndex = 81;
			this.label91.Text = "• Visual Studio 2015";
			this.label92.AutoSize = true;
			this.label92.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label92.ForeColor = Color.White;
			this.label92.Location = new Point(17, 3331);
			this.label92.Name = "label92";
			this.label92.Size = new Size(99, 30);
			this.label92.TabIndex = 80;
			this.label92.Text = "• µTorrent";
			this.label93.AutoSize = true;
			this.label93.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label93.ForeColor = Color.White;
			this.label93.Location = new Point(17, 3291);
			this.label93.Name = "label93";
			this.label93.Size = new Size(133, 30);
			this.label93.TabIndex = 79;
			this.label93.Text = "• TeamViewer";
			this.label94.AutoSize = true;
			this.label94.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label94.ForeColor = Color.White;
			this.label94.Location = new Point(17, 3251);
			this.label94.Name = "label94";
			this.label94.Size = new Size(88, 30);
			this.label94.TabIndex = 78;
			this.label94.Text = "• Spotify";
			this.label95.AutoSize = true;
			this.label95.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label95.ForeColor = Color.White;
			this.label95.Location = new Point(17, 3211);
			this.label95.Name = "label95";
			this.label95.Size = new Size(137, 30);
			this.label95.TabIndex = 77;
			this.label95.Text = "• Sublime Text";
			this.label96.AutoSize = true;
			this.label96.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label96.ForeColor = Color.White;
			this.label96.Location = new Point(17, 3171);
			this.label96.Name = "label96";
			this.label96.Size = new Size(126, 30);
			this.label96.TabIndex = 76;
			this.label96.Text = "• StartIsBack";
			this.label97.AutoSize = true;
			this.label97.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label97.ForeColor = Color.White;
			this.label97.Location = new Point(17, 3131);
			this.label97.Name = "label97";
			this.label97.Size = new Size(177, 30);
			this.label97.TabIndex = 75;
			this.label97.Text = "• StreamLabs OBS";
			this.label98.AutoSize = true;
			this.label98.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label98.ForeColor = Color.White;
			this.label98.Location = new Point(17, 3091);
			this.label98.Name = "label98";
			this.label98.Size = new Size(170, 30);
			this.label98.TabIndex = 74;
			this.label98.Text = "• Revo Uninstaller";
			this.label99.AutoSize = true;
			this.label99.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label99.ForeColor = Color.White;
			this.label99.Location = new Point(17, 3051);
			this.label99.Name = "label99";
			this.label99.Size = new Size(140, 30);
			this.label99.TabIndex = 73;
			this.label99.Text = "• Razer Cortex";
			this.label100.AutoSize = true;
			this.label100.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label100.ForeColor = Color.White;
			this.label100.Location = new Point(17, 3011);
			this.label100.Name = "label100";
			this.label100.Size = new Size(112, 30);
			this.label100.TabIndex = 72;
			this.label100.Text = "• PowerISO";
			this.label39.AutoSize = true;
			this.label39.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label39.ForeColor = Color.White;
			this.label39.Location = new Point(17, 2971);
			this.label39.Name = "label39";
			this.label39.Size = new Size(188, 30);
			this.label39.TabIndex = 71;
			this.label39.Text = "• Oracle Virtual Box";
			this.label40.AutoSize = true;
			this.label40.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label40.ForeColor = Color.White;
			this.label40.Location = new Point(17, 2931);
			this.label40.Name = "label40";
			this.label40.Size = new Size(116, 30);
			this.label40.TabIndex = 70;
			this.label40.Text = "• Opera GX";
			this.label41.AutoSize = true;
			this.label41.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label41.ForeColor = Color.White;
			this.label41.Location = new Point(17, 2891);
			this.label41.Name = "label41";
			this.label41.Size = new Size(127, 30);
			this.label41.TabIndex = 69;
			this.label41.Text = "• OBS Studio";
			this.label42.AutoSize = true;
			this.label42.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label42.ForeColor = Color.White;
			this.label42.Location = new Point(18, 2811);
			this.label42.Name = "label42";
			this.label42.Size = new Size(130, 30);
			this.label42.TabIndex = 68;
			this.label42.Text = "• Notepad ++";
			this.label43.AutoSize = true;
			this.label43.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label43.ForeColor = Color.White;
			this.label43.Location = new Point(18, 2731);
			this.label43.Name = "label43";
			this.label43.Size = new Size(129, 30);
			this.label43.TabIndex = 67;
			this.label43.Text = "• Net Limiter";
			this.label44.AutoSize = true;
			this.label44.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label44.ForeColor = Color.White;
			this.label44.Location = new Point(18, 2691);
			this.label44.Name = "label44";
			this.label44.Size = new Size(202, 30);
			this.label44.TabIndex = 66;
			this.label44.Text = "• Mozilla Thunderbird";
			this.label45.AutoSize = true;
			this.label45.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label45.ForeColor = Color.White;
			this.label45.Location = new Point(18, 2651);
			this.label45.Name = "label45";
			this.label45.Size = new Size(156, 30);
			this.label45.TabIndex = 65;
			this.label45.Text = "• Mozilla Firefox";
			this.label46.AutoSize = true;
			this.label46.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label46.ForeColor = Color.White;
			this.label46.Location = new Point(17, 2611);
			this.label46.Name = "label46";
			this.label46.Size = new Size(288, 30);
			this.label46.TabIndex = 64;
			this.label46.Text = "• Minitool Power Data Recovery";
			this.label47.AutoSize = true;
			this.label47.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label47.ForeColor = Color.White;
			this.label47.Location = new Point(17, 2571);
			this.label47.Name = "label47";
			this.label47.Size = new Size(247, 30);
			this.label47.TabIndex = 63;
			this.label47.Text = "• Minitool Partition Wizard";
			this.label48.AutoSize = true;
			this.label48.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label48.ForeColor = Color.White;
			this.label48.Location = new Point(17, 2531);
			this.label48.Name = "label48";
			this.label48.Size = new Size(203, 30);
			this.label48.TabIndex = 62;
			this.label48.Text = "• Microsoft Office 365";
			this.label49.AutoSize = true;
			this.label49.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label49.ForeColor = Color.White;
			this.label49.Location = new Point(18, 2491);
			this.label49.Name = "label49";
			this.label49.Size = new Size(211, 30);
			this.label49.TabIndex = 61;
			this.label49.Text = "• Microsoft Office 2019";
			this.label50.AutoSize = true;
			this.label50.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label50.ForeColor = Color.White;
			this.label50.Location = new Point(18, 2451);
			this.label50.Name = "label50";
			this.label50.Size = new Size(211, 30);
			this.label50.TabIndex = 60;
			this.label50.Text = "• Microsoft Office 2016";
			this.label51.AutoSize = true;
			this.label51.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label51.ForeColor = Color.White;
			this.label51.Location = new Point(18, 2411);
			this.label51.Name = "label51";
			this.label51.Size = new Size(211, 30);
			this.label51.TabIndex = 59;
			this.label51.Text = "• Microsoft Office 2013";
			this.label52.AutoSize = true;
			this.label52.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label52.ForeColor = Color.White;
			this.label52.Location = new Point(18, 2371);
			this.label52.Name = "label52";
			this.label52.Size = new Size(213, 30);
			this.label52.TabIndex = 58;
			this.label52.Text = "• Microsoft Office 2010";
			this.label53.AutoSize = true;
			this.label53.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label53.ForeColor = Color.White;
			this.label53.Location = new Point(18, 2331);
			this.label53.Name = "label53";
			this.label53.Size = new Size(216, 30);
			this.label53.TabIndex = 57;
			this.label53.Text = "• Microsoft Office 2007";
			this.label54.AutoSize = true;
			this.label54.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label54.ForeColor = Color.White;
			this.label54.Location = new Point(18, 2291);
			this.label54.Name = "label54";
			this.label54.Size = new Size(223, 30);
			this.label54.TabIndex = 56;
			this.label54.Text = "• Media Player (Classic)";
			this.label55.AutoSize = true;
			this.label55.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label55.ForeColor = Color.White;
			this.label55.Location = new Point(18, 2251);
			this.label55.Name = "label55";
			this.label55.Size = new Size(205, 30);
			this.label55.TabIndex = 55;
			this.label55.Text = "• MAGIX Vegas Pro 18";
			this.label56.AutoSize = true;
			this.label56.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label56.ForeColor = Color.White;
			this.label56.Location = new Point(18, 2211);
			this.label56.Name = "label56";
			this.label56.Size = new Size(267, 30);
			this.label56.TabIndex = 54;
			this.label56.Text = "• MAGIX Vegas Movie Studio";
			this.label57.AutoSize = true;
			this.label57.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label57.ForeColor = Color.White;
			this.label57.Location = new Point(18, 2171);
			this.label57.Name = "label57";
			this.label57.Size = new Size(219, 30);
			this.label57.TabIndex = 53;
			this.label57.Text = "• MAGIX Acid Pro 2020";
			this.label58.AutoSize = true;
			this.label58.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label58.ForeColor = Color.White;
			this.label58.Location = new Point(18, 2131);
			this.label58.Name = "label58";
			this.label58.Size = new Size(111, 30);
			this.label58.TabIndex = 52;
			this.label58.Text = "• Lightcord";
			this.label59.AutoSize = true;
			this.label59.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label59.ForeColor = Color.White;
			this.label59.Location = new Point(18, 2091);
			this.label59.Name = "label59";
			this.label59.Size = new Size(181, 30);
			this.label59.TabIndex = 51;
			this.label59.Text = "• Libre Office 2020";
			this.label60.AutoSize = true;
			this.label60.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label60.ForeColor = Color.White;
			this.label60.Location = new Point(18, 2051);
			this.label60.Name = "label60";
			this.label60.Size = new Size(258, 30);
			this.label60.TabIndex = 50;
			this.label60.Text = "• K-Lite Codec Pack (Mega)";
			this.label61.AutoSize = true;
			this.label61.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label61.ForeColor = Color.White;
			this.label61.Location = new Point(18, 2011);
			this.label61.Name = "label61";
			this.label61.Size = new Size(239, 30);
			this.label61.TabIndex = 49;
			this.label61.Text = "• K-Lite Codec Pack (Full)";
			this.label62.AutoSize = true;
			this.label62.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label62.ForeColor = Color.White;
			this.label62.Location = new Point(18, 1971);
			this.label62.Name = "label62";
			this.label62.Size = new Size(237, 30);
			this.label62.TabIndex = 48;
			this.label62.Text = "• K-Lite Codec Pack (Std)";
			this.label63.AutoSize = true;
			this.label63.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label63.ForeColor = Color.White;
			this.label63.Location = new Point(18, 1931);
			this.label63.Name = "label63";
			this.label63.Size = new Size(161, 30);
			this.label63.TabIndex = 47;
			this.label63.Text = "• Google Chrome";
			this.label64.AutoSize = true;
			this.label64.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label64.ForeColor = Color.White;
			this.label64.Location = new Point(18, 1891);
			this.label64.Name = "label64";
			this.label64.Size = new Size(135, 30);
			this.label64.TabIndex = 46;
			this.label64.Text = "• GOM Player";
			this.label65.AutoSize = true;
			this.label65.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label65.ForeColor = Color.White;
			this.label65.Location = new Point(18, 1851);
			this.label65.Name = "label65";
			this.label65.Size = new Size(77, 30);
			this.label65.TabIndex = 45;
			this.label65.Text = "• GIMP";
			this.label66.AutoSize = true;
			this.label66.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label66.ForeColor = Color.White;
			this.label66.Location = new Point(18, 1811);
			this.label66.Name = "label66";
			this.label66.Size = new Size(82, 30);
			this.label66.TabIndex = 44;
			this.label66.Text = "• iTunes";
			this.label67.AutoSize = true;
			this.label67.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label67.ForeColor = Color.White;
			this.label67.Location = new Point(18, 1771);
			this.label67.Name = "label67";
			this.label67.Size = new Size(273, 30);
			this.label67.TabIndex = 43;
			this.label67.Text = "• Internet Download Manager";
			this.label68.AutoSize = true;
			this.label68.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label68.ForeColor = Color.White;
			this.label68.Location = new Point(18, 1691);
			this.label68.Name = "label68";
			this.label68.Size = new Size(184, 30);
			this.label68.TabIndex = 42;
			this.label68.Text = "• HTTP Downloader";
			this.label69.AutoSize = true;
			this.label69.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label69.ForeColor = Color.White;
			this.label69.Location = new Point(18, 1651);
			this.label69.Name = "label69";
			this.label69.Size = new Size(124, 30);
			this.label69.TabIndex = 41;
			this.label69.Text = "• Handbrake";
			this.label70.AutoSize = true;
			this.label70.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label70.ForeColor = Color.White;
			this.label70.Location = new Point(18, 1611);
			this.label70.Name = "label70";
			this.label70.Size = new Size(240, 30);
			this.label70.TabIndex = 40;
			this.label70.Text = "• F-Secure Freedome VPN";
			this.label71.AutoSize = true;
			this.label71.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label71.ForeColor = Color.White;
			this.label71.Location = new Point(18, 1571);
			this.label71.Name = "label71";
			this.label71.Size = new Size(104, 30);
			this.label71.TabIndex = 39;
			this.label71.Text = "• Fl Studio";
			this.label72.AutoSize = true;
			this.label72.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label72.ForeColor = Color.White;
			this.label72.Location = new Point(18, 1531);
			this.label72.Name = "label72";
			this.label72.Size = new Size(291, 30);
			this.label72.TabIndex = 38;
			this.label72.Text = "• EaseUS Partition Master 2020";
			this.label73.AutoSize = true;
			this.label73.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label73.ForeColor = Color.White;
			this.label73.Location = new Point(18, 1491);
			this.label73.Name = "label73";
			this.label73.Size = new Size(276, 30);
			this.label73.TabIndex = 37;
			this.label73.Text = "• EaseUS Data Recovery 2020";
			this.label74.AutoSize = true;
			this.label74.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label74.ForeColor = Color.White;
			this.label74.Location = new Point(18, 1451);
			this.label74.Name = "label74";
			this.label74.Size = new Size(92, 30);
			this.label74.TabIndex = 36;
			this.label74.Text = "• Discord";
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label21.ForeColor = Color.White;
			this.label21.Location = new Point(18, 1411);
			this.label21.Name = "label21";
			this.label21.Size = new Size(166, 30);
			this.label21.TabIndex = 35;
			this.label21.Text = "• Daum PotPlayer";
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label22.ForeColor = Color.White;
			this.label22.Location = new Point(18, 1371);
			this.label22.Name = "label22";
			this.label22.Size = new Size(261, 30);
			this.label22.TabIndex = 34;
			this.label22.Text = "• CorelDRAW Graphics Suite";
			this.label23.AutoSize = true;
			this.label23.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label23.ForeColor = Color.White;
			this.label23.Location = new Point(18, 1331);
			this.label23.Name = "label23";
			this.label23.Size = new Size(113, 30);
			this.label23.TabIndex = 33;
			this.label23.Text = "• CorelCAD";
			this.label24.AutoSize = true;
			this.label24.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label24.ForeColor = Color.White;
			this.label24.Location = new Point(18, 1291);
			this.label24.Name = "label24";
			this.label24.Size = new Size(124, 30);
			this.label24.TabIndex = 32;
			this.label24.Text = "• Cinema 4D";
			this.label25.AutoSize = true;
			this.label25.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label25.ForeColor = Color.White;
			this.label25.Location = new Point(18, 1251);
			this.label25.Name = "label25";
			this.label25.Size = new Size(108, 30);
			this.label25.TabIndex = 31;
			this.label25.Text = "• CCleaner";
			this.label26.AutoSize = true;
			this.label26.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label26.ForeColor = Color.White;
			this.label26.Location = new Point(18, 1211);
			this.label26.Name = "label26";
			this.label26.Size = new Size(110, 30);
			this.label26.TabIndex = 30;
			this.label26.Text = "• Camtasia";
			this.label27.AutoSize = true;
			this.label27.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label27.ForeColor = Color.White;
			this.label27.Location = new Point(18, 1171);
			this.label27.Name = "label27";
			this.label27.Size = new Size(150, 30);
			this.label27.TabIndex = 29;
			this.label27.Text = "• Brave Browser";
			this.label28.AutoSize = true;
			this.label28.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label28.ForeColor = Color.White;
			this.label28.Location = new Point(18, 1131);
			this.label28.Name = "label28";
			this.label28.Size = new Size(151, 30);
			this.label28.TabIndex = 28;
			this.label28.Text = "• Better Discord";
			this.label29.AutoSize = true;
			this.label29.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label29.ForeColor = Color.White;
			this.label29.Location = new Point(18, 1091);
			this.label29.Name = "label29";
			this.label29.Size = new Size(156, 30);
			this.label29.TabIndex = 27;
			this.label29.Text = "• Betternet VPN";
			this.label30.AutoSize = true;
			this.label30.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label30.ForeColor = Color.White;
			this.label30.Location = new Point(18, 1051);
			this.label30.Name = "label30";
			this.label30.Size = new Size(147, 30);
			this.label30.TabIndex = 26;
			this.label30.Text = "• BCUninstaller";
			this.label31.AutoSize = true;
			this.label31.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label31.ForeColor = Color.White;
			this.label31.Location = new Point(18, 1011);
			this.label31.Name = "label31";
			this.label31.Size = new Size(114, 30);
			this.label31.TabIndex = 25;
			this.label31.Text = "• Bandicam";
			this.label32.AutoSize = true;
			this.label32.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label32.ForeColor = Color.White;
			this.label32.Location = new Point(18, 971);
			this.label32.Name = "label32";
			this.label32.Size = new Size(103, 30);
			this.label32.TabIndex = 24;
			this.label32.Text = "• Audacity";
			this.label34.AutoSize = true;
			this.label34.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label34.ForeColor = Color.White;
			this.label34.Location = new Point(18, 931);
			this.label34.Name = "label34";
			this.label34.Size = new Size(238, 30);
			this.label34.TabIndex = 22;
			this.label34.Text = "• AOMEI Backupper 2020";
			this.label35.AutoSize = true;
			this.label35.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label35.ForeColor = Color.White;
			this.label35.Location = new Point(18, 891);
			this.label35.Name = "label35";
			this.label35.Size = new Size(293, 30);
			this.label35.TabIndex = 21;
			this.label35.Text = "• AOMEI Parition Assistant 2021";
			this.label36.AutoSize = true;
			this.label36.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label36.ForeColor = Color.White;
			this.label36.Location = new Point(18, 811);
			this.label36.Name = "label36";
			this.label36.Size = new Size(283, 30);
			this.label36.TabIndex = 20;
			this.label36.Text = "• Advanced System Care Pro 14";
			this.label37.AutoSize = true;
			this.label37.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label37.ForeColor = Color.White;
			this.label37.Location = new Point(18, 771);
			this.label37.Name = "label37";
			this.label37.Size = new Size(201, 30);
			this.label37.TabIndex = 19;
			this.label37.Text = "• Adobe XD v32.00.22";
			this.label38.AutoSize = true;
			this.label38.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label38.ForeColor = Color.White;
			this.label38.Location = new Point(18, 731);
			this.label38.Name = "label38";
			this.label38.Size = new Size(260, 30);
			this.label38.TabIndex = 18;
			this.label38.Text = "• Adobe Premiere Rush v1.5.8";
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label15.ForeColor = Color.White;
			this.label15.Location = new Point(18, 691);
			this.label15.Name = "label15";
			this.label15.Size = new Size(275, 30);
			this.label15.TabIndex = 17;
			this.label15.Text = "• Adobe Premiere Pro CC 2021";
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label16.ForeColor = Color.White;
			this.label16.Location = new Point(18, 651);
			this.label16.Name = "label16";
			this.label16.Size = new Size(229, 30);
			this.label16.TabIndex = 16;
			this.label16.Text = "• Adobe Prelude CC 2021";
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label17.ForeColor = Color.White;
			this.label17.Location = new Point(18, 611);
			this.label17.Name = "label17";
			this.label17.Size = new Size(254, 30);
			this.label17.TabIndex = 15;
			this.label17.Text = "• Adobe Photoshop CC 2021";
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label18.ForeColor = Color.White;
			this.label18.Location = new Point(18, 571);
			this.label18.Name = "label18";
			this.label18.Size = new Size(296, 30);
			this.label18.TabIndex = 14;
			this.label18.Text = "• Adobe Media Encoder CC 2021";
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label19.ForeColor = Color.White;
			this.label19.Location = new Point(18, 531);
			this.label19.Name = "label19";
			this.label19.Size = new Size(281, 30);
			this.label19.TabIndex = 13;
			this.label19.Text = "• Adobe Lightroom Classic v9.4";
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label20.ForeColor = Color.White;
			this.label20.Location = new Point(18, 491);
			this.label20.Name = "label20";
			this.label20.Size = new Size(247, 30);
			this.label20.TabIndex = 12;
			this.label20.Text = "• Adobe InDesign CC 2020";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(18, 451);
			this.label9.Name = "label9";
			this.label9.Size = new Size(231, 30);
			this.label9.TabIndex = 11;
			this.label9.Text = "• Adobe InCopy CC 2020";
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.White;
			this.label10.Location = new Point(18, 411);
			this.label10.Name = "label10";
			this.label10.Size = new Size(248, 30);
			this.label10.TabIndex = 10;
			this.label10.Text = "• Adobe Illustrator CC 2021";
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(18, 371);
			this.label11.Name = "label11";
			this.label11.Size = new Size(193, 30);
			this.label11.TabIndex = 9;
			this.label11.Text = "• Adobe Fresco v1.9.0";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.ForeColor = Color.White;
			this.label12.Location = new Point(18, 331);
			this.label12.Name = "label12";
			this.label12.Size = new Size(283, 30);
			this.label12.TabIndex = 8;
			this.label12.Text = "• Adobe Dreamveawer CC 2021";
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label13.ForeColor = Color.White;
			this.label13.Location = new Point(18, 291);
			this.label13.Name = "label13";
			this.label13.Size = new Size(217, 30);
			this.label13.TabIndex = 7;
			this.label13.Text = "• Adobe Dimension v3.3";
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label14.ForeColor = Color.White;
			this.label14.Location = new Point(18, 251);
			this.label14.Name = "label14";
			this.label14.Size = new Size(337, 30);
			this.label14.TabIndex = 6;
			this.label14.Text = "• Adobe Character Animator CC 2021";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(18, 211);
			this.label6.Name = "label6";
			this.label6.Size = new Size(221, 30);
			this.label6.TabIndex = 5;
			this.label6.Text = "• Adobe Bridge CC 2021";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(18, 171);
			this.label7.Name = "label7";
			this.label7.Size = new Size(238, 30);
			this.label7.TabIndex = 4;
			this.label7.Text = "• Adobe Animate CC 2021";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(18, 131);
			this.label8.Name = "label8";
			this.label8.Size = new Size(237, 30);
			this.label8.TabIndex = 3;
			this.label8.Text = "• Adobe Audition CC 2021";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(18, 91);
			this.label5.Name = "label5";
			this.label5.Size = new Size(274, 30);
			this.label5.TabIndex = 2;
			this.label5.Text = "• Adobe After Effects CC 2021";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(18, 51);
			this.label4.Name = "label4";
			this.label4.Size = new Size(692, 30);
			this.label4.TabIndex = 1;
			this.label4.Text = "• Adobe Acrobat Pro DC                              | Cracked               | Size : 913MB";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(18, 11);
			this.label3.Name = "label3";
			this.label3.Size = new Size(674, 30);
			this.label3.TabIndex = 0;
			this.label3.Text = "• 7-Zip                                                       | Freeware              | Size : 1MB";
			this.progressBar1.Location = new Point(27, 544);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(770, 23);
			this.progressBar1.Style = ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 6;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.BackgroundImageLayout = ImageLayout.None;
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(819, 546);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(84, 55);
			this.button3.TabIndex = 7;
			this.button3.TabStop = false;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(22, 578);
			this.label2.Name = "label2";
			this.label2.Size = new Size(112, 25);
			this.label2.TabIndex = 8;
			this.label2.Text = "Status : Idle....";
			this.lblDownload.AutoSize = true;
			this.lblDownload.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblDownload.ForeColor = Color.White;
			this.lblDownload.Location = new Point(581, 577);
			this.lblDownload.Name = "lblDownload";
			this.lblDownload.Size = new Size(0, 25);
			this.lblDownload.TabIndex = 9;
			this.lblSpeed.AutoSize = true;
			this.lblSpeed.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblSpeed.ForeColor = Color.White;
			this.lblSpeed.Location = new Point(408, 578);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new Size(0, 25);
			this.lblSpeed.TabIndex = 10;
			this.button74.BackColor = Color.FromArgb(38, 38, 38);
			this.button74.BackgroundImage = (Image)componentResourceManager.GetObject("button74.BackgroundImage");
			this.button74.BackgroundImageLayout = ImageLayout.Stretch;
			this.button74.Cursor = Cursors.Hand;
			this.button74.FlatAppearance.BorderSize = 0;
			this.button74.FlatStyle = FlatStyle.Flat;
			this.button74.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button74.ForeColor = Color.White;
			this.button74.Location = new Point(807, 5);
			this.button74.Margin = new Padding(1);
			this.button74.Name = "button74";
			this.button74.Size = new Size(32, 32);
			this.button74.TabIndex = 91;
			this.button74.TabStop = false;
			this.button74.UseVisualStyleBackColor = false;
			this.button74.Click += this.button74_Click;
			this.button92.BackColor = Color.FromArgb(38, 38, 38);
			this.button92.BackgroundImage = (Image)componentResourceManager.GetObject("button92.BackgroundImage");
			this.button92.BackgroundImageLayout = ImageLayout.Stretch;
			this.button92.Cursor = Cursors.Hand;
			this.button92.FlatAppearance.BorderSize = 0;
			this.button92.FlatStyle = FlatStyle.Flat;
			this.button92.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button92.ForeColor = Color.White;
			this.button92.Location = new Point(841, 5);
			this.button92.Margin = new Padding(1);
			this.button92.Name = "button92";
			this.button92.Size = new Size(32, 32);
			this.button92.TabIndex = 90;
			this.button92.TabStop = false;
			this.button92.UseVisualStyleBackColor = false;
			this.button92.Click += this.button92_Click;
			this.button93.BackColor = Color.FromArgb(38, 38, 38);
			this.button93.BackgroundImage = (Image)componentResourceManager.GetObject("button93.BackgroundImage");
			this.button93.BackgroundImageLayout = ImageLayout.Stretch;
			this.button93.Cursor = Cursors.Hand;
			this.button93.FlatAppearance.BorderSize = 0;
			this.button93.FlatStyle = FlatStyle.Flat;
			this.button93.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button93.ForeColor = Color.White;
			this.button93.Location = new Point(875, 5);
			this.button93.Margin = new Padding(1);
			this.button93.Name = "button93";
			this.button93.Size = new Size(32, 32);
			this.button93.TabIndex = 89;
			this.button93.TabStop = false;
			this.button93.UseVisualStyleBackColor = false;
			this.button93.Click += this.button93_Click;
			this.button94.BackColor = Color.FromArgb(38, 38, 38);
			this.button94.BackgroundImage = (Image)componentResourceManager.GetObject("button94.BackgroundImage");
			this.button94.BackgroundImageLayout = ImageLayout.Stretch;
			this.button94.Cursor = Cursors.Hand;
			this.button94.FlatAppearance.BorderSize = 0;
			this.button94.FlatStyle = FlatStyle.Flat;
			this.button94.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button94.ForeColor = Color.White;
			this.button94.Location = new Point(773, 5);
			this.button94.Margin = new Padding(1);
			this.button94.Name = "button94";
			this.button94.Size = new Size(32, 32);
			this.button94.TabIndex = 88;
			this.button94.TabStop = false;
			this.button94.UseVisualStyleBackColor = false;
			this.button94.Click += this.button94_Click;
			this.label266.AutoSize = true;
			this.label266.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label266.ForeColor = Color.Silver;
			this.label266.Location = new Point(23, 66);
			this.label266.Name = "label266";
			this.label266.Size = new Size(270, 19);
			this.label266.TabIndex = 92;
			this.label266.Text = "Download over 100+ software cracked/freeware";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.label266);
			base.Controls.Add(this.button74);
			base.Controls.Add(this.button92);
			base.Controls.Add(this.button93);
			base.Controls.Add(this.button94);
			base.Controls.Add(this.lblSpeed);
			base.Controls.Add(this.lblDownload);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Name = "downloads";
			base.Size = new Size(918, 619);
			base.Load += this.downloads_Load;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000A2 RID: 162
		private WebClient dl;

		// Token: 0x040000A3 RID: 163
		private Stopwatch sw = new Stopwatch();

		// Token: 0x040000A4 RID: 164
		private static downloads _instace;

		// Token: 0x040000A5 RID: 165
		private IContainer components = null;

		// Token: 0x040000A6 RID: 166
		private Label label1;

		// Token: 0x040000A7 RID: 167
		private Panel panel1;

		// Token: 0x040000A8 RID: 168
		private ProgressBar progressBar1;

		// Token: 0x040000A9 RID: 169
		private Button button3;

		// Token: 0x040000AA RID: 170
		private Label label2;

		// Token: 0x040000AB RID: 171
		private Label label3;

		// Token: 0x040000AC RID: 172
		private Label label15;

		// Token: 0x040000AD RID: 173
		private Label label16;

		// Token: 0x040000AE RID: 174
		private Label label17;

		// Token: 0x040000AF RID: 175
		private Label label18;

		// Token: 0x040000B0 RID: 176
		private Label label19;

		// Token: 0x040000B1 RID: 177
		private Label label20;

		// Token: 0x040000B2 RID: 178
		private Label label9;

		// Token: 0x040000B3 RID: 179
		private Label label10;

		// Token: 0x040000B4 RID: 180
		private Label label11;

		// Token: 0x040000B5 RID: 181
		private Label label12;

		// Token: 0x040000B6 RID: 182
		private Label label13;

		// Token: 0x040000B7 RID: 183
		private Label label14;

		// Token: 0x040000B8 RID: 184
		private Label label6;

		// Token: 0x040000B9 RID: 185
		private Label label7;

		// Token: 0x040000BA RID: 186
		private Label label8;

		// Token: 0x040000BB RID: 187
		private Label label5;

		// Token: 0x040000BC RID: 188
		private Label label4;

		// Token: 0x040000BD RID: 189
		private Label label21;

		// Token: 0x040000BE RID: 190
		private Label label22;

		// Token: 0x040000BF RID: 191
		private Label label23;

		// Token: 0x040000C0 RID: 192
		private Label label24;

		// Token: 0x040000C1 RID: 193
		private Label label25;

		// Token: 0x040000C2 RID: 194
		private Label label26;

		// Token: 0x040000C3 RID: 195
		private Label label27;

		// Token: 0x040000C4 RID: 196
		private Label label28;

		// Token: 0x040000C5 RID: 197
		private Label label29;

		// Token: 0x040000C6 RID: 198
		private Label label30;

		// Token: 0x040000C7 RID: 199
		private Label label31;

		// Token: 0x040000C8 RID: 200
		private Label label32;

		// Token: 0x040000C9 RID: 201
		private Label label33;

		// Token: 0x040000CA RID: 202
		private Label label34;

		// Token: 0x040000CB RID: 203
		private Label label35;

		// Token: 0x040000CC RID: 204
		private Label label36;

		// Token: 0x040000CD RID: 205
		private Label label37;

		// Token: 0x040000CE RID: 206
		private Label label38;

		// Token: 0x040000CF RID: 207
		private Label label39;

		// Token: 0x040000D0 RID: 208
		private Label label40;

		// Token: 0x040000D1 RID: 209
		private Label label41;

		// Token: 0x040000D2 RID: 210
		private Label label42;

		// Token: 0x040000D3 RID: 211
		private Label label43;

		// Token: 0x040000D4 RID: 212
		private Label label44;

		// Token: 0x040000D5 RID: 213
		private Label label45;

		// Token: 0x040000D6 RID: 214
		private Label label46;

		// Token: 0x040000D7 RID: 215
		private Label label47;

		// Token: 0x040000D8 RID: 216
		private Label label48;

		// Token: 0x040000D9 RID: 217
		private Label label49;

		// Token: 0x040000DA RID: 218
		private Label label50;

		// Token: 0x040000DB RID: 219
		private Label label51;

		// Token: 0x040000DC RID: 220
		private Label label52;

		// Token: 0x040000DD RID: 221
		private Label label53;

		// Token: 0x040000DE RID: 222
		private Label label54;

		// Token: 0x040000DF RID: 223
		private Label label55;

		// Token: 0x040000E0 RID: 224
		private Label label56;

		// Token: 0x040000E1 RID: 225
		private Label label57;

		// Token: 0x040000E2 RID: 226
		private Label label58;

		// Token: 0x040000E3 RID: 227
		private Label label59;

		// Token: 0x040000E4 RID: 228
		private Label label60;

		// Token: 0x040000E5 RID: 229
		private Label label61;

		// Token: 0x040000E6 RID: 230
		private Label label62;

		// Token: 0x040000E7 RID: 231
		private Label label63;

		// Token: 0x040000E8 RID: 232
		private Label label64;

		// Token: 0x040000E9 RID: 233
		private Label label65;

		// Token: 0x040000EA RID: 234
		private Label label66;

		// Token: 0x040000EB RID: 235
		private Label label67;

		// Token: 0x040000EC RID: 236
		private Label label68;

		// Token: 0x040000ED RID: 237
		private Label label69;

		// Token: 0x040000EE RID: 238
		private Label label70;

		// Token: 0x040000EF RID: 239
		private Label label71;

		// Token: 0x040000F0 RID: 240
		private Label label72;

		// Token: 0x040000F1 RID: 241
		private Label label73;

		// Token: 0x040000F2 RID: 242
		private Label label74;

		// Token: 0x040000F3 RID: 243
		private Label label84;

		// Token: 0x040000F4 RID: 244
		private Label label85;

		// Token: 0x040000F5 RID: 245
		private Label label86;

		// Token: 0x040000F6 RID: 246
		private Label label87;

		// Token: 0x040000F7 RID: 247
		private Label label88;

		// Token: 0x040000F8 RID: 248
		private Label label89;

		// Token: 0x040000F9 RID: 249
		private Label label90;

		// Token: 0x040000FA RID: 250
		private Label label91;

		// Token: 0x040000FB RID: 251
		private Label label92;

		// Token: 0x040000FC RID: 252
		private Label label93;

		// Token: 0x040000FD RID: 253
		private Label label94;

		// Token: 0x040000FE RID: 254
		private Label label95;

		// Token: 0x040000FF RID: 255
		private Label label96;

		// Token: 0x04000100 RID: 256
		private Label label97;

		// Token: 0x04000101 RID: 257
		private Label label98;

		// Token: 0x04000102 RID: 258
		private Label label99;

		// Token: 0x04000103 RID: 259
		private Label label100;

		// Token: 0x04000104 RID: 260
		private Label label76;

		// Token: 0x04000105 RID: 261
		private Label label75;

		// Token: 0x04000106 RID: 262
		private Label label77;

		// Token: 0x04000107 RID: 263
		private Label label78;

		// Token: 0x04000108 RID: 264
		private Label label130;

		// Token: 0x04000109 RID: 265
		private Label label131;

		// Token: 0x0400010A RID: 266
		private Label label128;

		// Token: 0x0400010B RID: 267
		private Label label129;

		// Token: 0x0400010C RID: 268
		private Label label126;

		// Token: 0x0400010D RID: 269
		private Label label127;

		// Token: 0x0400010E RID: 270
		private Label label124;

		// Token: 0x0400010F RID: 271
		private Label label125;

		// Token: 0x04000110 RID: 272
		private Label label122;

		// Token: 0x04000111 RID: 273
		private Label label123;

		// Token: 0x04000112 RID: 274
		private Label label120;

		// Token: 0x04000113 RID: 275
		private Label label121;

		// Token: 0x04000114 RID: 276
		private Label label118;

		// Token: 0x04000115 RID: 277
		private Label label119;

		// Token: 0x04000116 RID: 278
		private Label label116;

		// Token: 0x04000117 RID: 279
		private Label label117;

		// Token: 0x04000118 RID: 280
		private Label label114;

		// Token: 0x04000119 RID: 281
		private Label label115;

		// Token: 0x0400011A RID: 282
		private Label label112;

		// Token: 0x0400011B RID: 283
		private Label label113;

		// Token: 0x0400011C RID: 284
		private Label label110;

		// Token: 0x0400011D RID: 285
		private Label label111;

		// Token: 0x0400011E RID: 286
		private Label label108;

		// Token: 0x0400011F RID: 287
		private Label label109;

		// Token: 0x04000120 RID: 288
		private Label label106;

		// Token: 0x04000121 RID: 289
		private Label label107;

		// Token: 0x04000122 RID: 290
		private Label label104;

		// Token: 0x04000123 RID: 291
		private Label label105;

		// Token: 0x04000124 RID: 292
		private Label label102;

		// Token: 0x04000125 RID: 293
		private Label label103;

		// Token: 0x04000126 RID: 294
		private Label label83;

		// Token: 0x04000127 RID: 295
		private Label label101;

		// Token: 0x04000128 RID: 296
		private Label label81;

		// Token: 0x04000129 RID: 297
		private Label label82;

		// Token: 0x0400012A RID: 298
		private Label label79;

		// Token: 0x0400012B RID: 299
		private Label label80;

		// Token: 0x0400012C RID: 300
		private Label label160;

		// Token: 0x0400012D RID: 301
		private Label label161;

		// Token: 0x0400012E RID: 302
		private Label label158;

		// Token: 0x0400012F RID: 303
		private Label label159;

		// Token: 0x04000130 RID: 304
		private Label label156;

		// Token: 0x04000131 RID: 305
		private Label label157;

		// Token: 0x04000132 RID: 306
		private Label label154;

		// Token: 0x04000133 RID: 307
		private Label label155;

		// Token: 0x04000134 RID: 308
		private Label label152;

		// Token: 0x04000135 RID: 309
		private Label label153;

		// Token: 0x04000136 RID: 310
		private Label label150;

		// Token: 0x04000137 RID: 311
		private Label label151;

		// Token: 0x04000138 RID: 312
		private Label label148;

		// Token: 0x04000139 RID: 313
		private Label label149;

		// Token: 0x0400013A RID: 314
		private Label label146;

		// Token: 0x0400013B RID: 315
		private Label label147;

		// Token: 0x0400013C RID: 316
		private Label label144;

		// Token: 0x0400013D RID: 317
		private Label label145;

		// Token: 0x0400013E RID: 318
		private Label label142;

		// Token: 0x0400013F RID: 319
		private Label label143;

		// Token: 0x04000140 RID: 320
		private Label label140;

		// Token: 0x04000141 RID: 321
		private Label label141;

		// Token: 0x04000142 RID: 322
		private Label label138;

		// Token: 0x04000143 RID: 323
		private Label label139;

		// Token: 0x04000144 RID: 324
		private Label label136;

		// Token: 0x04000145 RID: 325
		private Label label137;

		// Token: 0x04000146 RID: 326
		private Label label134;

		// Token: 0x04000147 RID: 327
		private Label label135;

		// Token: 0x04000148 RID: 328
		private Label label132;

		// Token: 0x04000149 RID: 329
		private Label label133;

		// Token: 0x0400014A RID: 330
		private Label label216;

		// Token: 0x0400014B RID: 331
		private Label label217;

		// Token: 0x0400014C RID: 332
		private Label label214;

		// Token: 0x0400014D RID: 333
		private Label label215;

		// Token: 0x0400014E RID: 334
		private Label label212;

		// Token: 0x0400014F RID: 335
		private Label label213;

		// Token: 0x04000150 RID: 336
		private Label label210;

		// Token: 0x04000151 RID: 337
		private Label label211;

		// Token: 0x04000152 RID: 338
		private Label label208;

		// Token: 0x04000153 RID: 339
		private Label label209;

		// Token: 0x04000154 RID: 340
		private Label label206;

		// Token: 0x04000155 RID: 341
		private Label label207;

		// Token: 0x04000156 RID: 342
		private Label label204;

		// Token: 0x04000157 RID: 343
		private Label label205;

		// Token: 0x04000158 RID: 344
		private Label label202;

		// Token: 0x04000159 RID: 345
		private Label label203;

		// Token: 0x0400015A RID: 346
		private Label label200;

		// Token: 0x0400015B RID: 347
		private Label label201;

		// Token: 0x0400015C RID: 348
		private Label label198;

		// Token: 0x0400015D RID: 349
		private Label label199;

		// Token: 0x0400015E RID: 350
		private Label label196;

		// Token: 0x0400015F RID: 351
		private Label label197;

		// Token: 0x04000160 RID: 352
		private Label label194;

		// Token: 0x04000161 RID: 353
		private Label label195;

		// Token: 0x04000162 RID: 354
		private Label label192;

		// Token: 0x04000163 RID: 355
		private Label label193;

		// Token: 0x04000164 RID: 356
		private Label label190;

		// Token: 0x04000165 RID: 357
		private Label label191;

		// Token: 0x04000166 RID: 358
		private Label label188;

		// Token: 0x04000167 RID: 359
		private Label label189;

		// Token: 0x04000168 RID: 360
		private Label label186;

		// Token: 0x04000169 RID: 361
		private Label label187;

		// Token: 0x0400016A RID: 362
		private Label label184;

		// Token: 0x0400016B RID: 363
		private Label label185;

		// Token: 0x0400016C RID: 364
		private Label label182;

		// Token: 0x0400016D RID: 365
		private Label label183;

		// Token: 0x0400016E RID: 366
		private Label label180;

		// Token: 0x0400016F RID: 367
		private Label label181;

		// Token: 0x04000170 RID: 368
		private Label label178;

		// Token: 0x04000171 RID: 369
		private Label label179;

		// Token: 0x04000172 RID: 370
		private Label label176;

		// Token: 0x04000173 RID: 371
		private Label label177;

		// Token: 0x04000174 RID: 372
		private Label label174;

		// Token: 0x04000175 RID: 373
		private Label label175;

		// Token: 0x04000176 RID: 374
		private Label label172;

		// Token: 0x04000177 RID: 375
		private Label label173;

		// Token: 0x04000178 RID: 376
		private Label label170;

		// Token: 0x04000179 RID: 377
		private Label label171;

		// Token: 0x0400017A RID: 378
		private Label label168;

		// Token: 0x0400017B RID: 379
		private Label label169;

		// Token: 0x0400017C RID: 380
		private Label label166;

		// Token: 0x0400017D RID: 381
		private Label label167;

		// Token: 0x0400017E RID: 382
		private Label label164;

		// Token: 0x0400017F RID: 383
		private Label label165;

		// Token: 0x04000180 RID: 384
		private Label label162;

		// Token: 0x04000181 RID: 385
		private Label label163;

		// Token: 0x04000182 RID: 386
		private Label label264;

		// Token: 0x04000183 RID: 387
		private Label label265;

		// Token: 0x04000184 RID: 388
		private Label label262;

		// Token: 0x04000185 RID: 389
		private Label label263;

		// Token: 0x04000186 RID: 390
		private Label label260;

		// Token: 0x04000187 RID: 391
		private Label label261;

		// Token: 0x04000188 RID: 392
		private Label label258;

		// Token: 0x04000189 RID: 393
		private Label label259;

		// Token: 0x0400018A RID: 394
		private Label label256;

		// Token: 0x0400018B RID: 395
		private Label label257;

		// Token: 0x0400018C RID: 396
		private Label label254;

		// Token: 0x0400018D RID: 397
		private Label label255;

		// Token: 0x0400018E RID: 398
		private Label label252;

		// Token: 0x0400018F RID: 399
		private Label label253;

		// Token: 0x04000190 RID: 400
		private Label label250;

		// Token: 0x04000191 RID: 401
		private Label label251;

		// Token: 0x04000192 RID: 402
		private Label label248;

		// Token: 0x04000193 RID: 403
		private Label label249;

		// Token: 0x04000194 RID: 404
		private Label label246;

		// Token: 0x04000195 RID: 405
		private Label label247;

		// Token: 0x04000196 RID: 406
		private Label label244;

		// Token: 0x04000197 RID: 407
		private Label label245;

		// Token: 0x04000198 RID: 408
		private Label label242;

		// Token: 0x04000199 RID: 409
		private Label label243;

		// Token: 0x0400019A RID: 410
		private Label label240;

		// Token: 0x0400019B RID: 411
		private Label label241;

		// Token: 0x0400019C RID: 412
		private Label label238;

		// Token: 0x0400019D RID: 413
		private Label label239;

		// Token: 0x0400019E RID: 414
		private Label label236;

		// Token: 0x0400019F RID: 415
		private Label label237;

		// Token: 0x040001A0 RID: 416
		private Label label234;

		// Token: 0x040001A1 RID: 417
		private Label label235;

		// Token: 0x040001A2 RID: 418
		private Label label232;

		// Token: 0x040001A3 RID: 419
		private Label label233;

		// Token: 0x040001A4 RID: 420
		private Label label230;

		// Token: 0x040001A5 RID: 421
		private Label label231;

		// Token: 0x040001A6 RID: 422
		private Label label228;

		// Token: 0x040001A7 RID: 423
		private Label label229;

		// Token: 0x040001A8 RID: 424
		private Label label226;

		// Token: 0x040001A9 RID: 425
		private Label label227;

		// Token: 0x040001AA RID: 426
		private Label label224;

		// Token: 0x040001AB RID: 427
		private Label label225;

		// Token: 0x040001AC RID: 428
		private Label label222;

		// Token: 0x040001AD RID: 429
		private Label label223;

		// Token: 0x040001AE RID: 430
		private Label label220;

		// Token: 0x040001AF RID: 431
		private Label label221;

		// Token: 0x040001B0 RID: 432
		private Label label218;

		// Token: 0x040001B1 RID: 433
		private Label label219;

		// Token: 0x040001B2 RID: 434
		private Button button1;

		// Token: 0x040001B3 RID: 435
		private Button button10;

		// Token: 0x040001B4 RID: 436
		private Button button9;

		// Token: 0x040001B5 RID: 437
		private Button button8;

		// Token: 0x040001B6 RID: 438
		private Button button7;

		// Token: 0x040001B7 RID: 439
		private Button button6;

		// Token: 0x040001B8 RID: 440
		private Button button5;

		// Token: 0x040001B9 RID: 441
		private Button button4;

		// Token: 0x040001BA RID: 442
		private Button button2;

		// Token: 0x040001BB RID: 443
		private Button button75;

		// Token: 0x040001BC RID: 444
		private Button button76;

		// Token: 0x040001BD RID: 445
		private Button button77;

		// Token: 0x040001BE RID: 446
		private Button button78;

		// Token: 0x040001BF RID: 447
		private Button button79;

		// Token: 0x040001C0 RID: 448
		private Button button80;

		// Token: 0x040001C1 RID: 449
		private Button button81;

		// Token: 0x040001C2 RID: 450
		private Button button82;

		// Token: 0x040001C3 RID: 451
		private Button button83;

		// Token: 0x040001C4 RID: 452
		private Button button84;

		// Token: 0x040001C5 RID: 453
		private Button button85;

		// Token: 0x040001C6 RID: 454
		private Button button86;

		// Token: 0x040001C7 RID: 455
		private Button button87;

		// Token: 0x040001C8 RID: 456
		private Button button88;

		// Token: 0x040001C9 RID: 457
		private Button button89;

		// Token: 0x040001CA RID: 458
		private Button button90;

		// Token: 0x040001CB RID: 459
		private Button button91;

		// Token: 0x040001CC RID: 460
		private Button button56;

		// Token: 0x040001CD RID: 461
		private Button button57;

		// Token: 0x040001CE RID: 462
		private Button button58;

		// Token: 0x040001CF RID: 463
		private Button button59;

		// Token: 0x040001D0 RID: 464
		private Button button60;

		// Token: 0x040001D1 RID: 465
		private Button button61;

		// Token: 0x040001D2 RID: 466
		private Button button62;

		// Token: 0x040001D3 RID: 467
		private Button button63;

		// Token: 0x040001D4 RID: 468
		private Button button64;

		// Token: 0x040001D5 RID: 469
		private Button button65;

		// Token: 0x040001D6 RID: 470
		private Button button66;

		// Token: 0x040001D7 RID: 471
		private Button button67;

		// Token: 0x040001D8 RID: 472
		private Button button68;

		// Token: 0x040001D9 RID: 473
		private Button button69;

		// Token: 0x040001DA RID: 474
		private Button button70;

		// Token: 0x040001DB RID: 475
		private Button button71;

		// Token: 0x040001DC RID: 476
		private Button button72;

		// Token: 0x040001DD RID: 477
		private Button button73;

		// Token: 0x040001DE RID: 478
		private Button button38;

		// Token: 0x040001DF RID: 479
		private Button button39;

		// Token: 0x040001E0 RID: 480
		private Button button40;

		// Token: 0x040001E1 RID: 481
		private Button button41;

		// Token: 0x040001E2 RID: 482
		private Button button42;

		// Token: 0x040001E3 RID: 483
		private Button button43;

		// Token: 0x040001E4 RID: 484
		private Button button44;

		// Token: 0x040001E5 RID: 485
		private Button button45;

		// Token: 0x040001E6 RID: 486
		private Button button46;

		// Token: 0x040001E7 RID: 487
		private Button button47;

		// Token: 0x040001E8 RID: 488
		private Button button48;

		// Token: 0x040001E9 RID: 489
		private Button button49;

		// Token: 0x040001EA RID: 490
		private Button button50;

		// Token: 0x040001EB RID: 491
		private Button button51;

		// Token: 0x040001EC RID: 492
		private Button button52;

		// Token: 0x040001ED RID: 493
		private Button button53;

		// Token: 0x040001EE RID: 494
		private Button button54;

		// Token: 0x040001EF RID: 495
		private Button button55;

		// Token: 0x040001F0 RID: 496
		private Button button20;

		// Token: 0x040001F1 RID: 497
		private Button button21;

		// Token: 0x040001F2 RID: 498
		private Button button22;

		// Token: 0x040001F3 RID: 499
		private Button button23;

		// Token: 0x040001F4 RID: 500
		private Button button24;

		// Token: 0x040001F5 RID: 501
		private Button button25;

		// Token: 0x040001F6 RID: 502
		private Button button26;

		// Token: 0x040001F7 RID: 503
		private Button button27;

		// Token: 0x040001F8 RID: 504
		private Button button28;

		// Token: 0x040001F9 RID: 505
		private Button button29;

		// Token: 0x040001FA RID: 506
		private Button button30;

		// Token: 0x040001FB RID: 507
		private Button button31;

		// Token: 0x040001FC RID: 508
		private Button button32;

		// Token: 0x040001FD RID: 509
		private Button button33;

		// Token: 0x040001FE RID: 510
		private Button button34;

		// Token: 0x040001FF RID: 511
		private Button button35;

		// Token: 0x04000200 RID: 512
		private Button button36;

		// Token: 0x04000201 RID: 513
		private Button button37;

		// Token: 0x04000202 RID: 514
		private Button button11;

		// Token: 0x04000203 RID: 515
		private Button button12;

		// Token: 0x04000204 RID: 516
		private Button button13;

		// Token: 0x04000205 RID: 517
		private Button button14;

		// Token: 0x04000206 RID: 518
		private Button button15;

		// Token: 0x04000207 RID: 519
		private Button button16;

		// Token: 0x04000208 RID: 520
		private Button button17;

		// Token: 0x04000209 RID: 521
		private Button button18;

		// Token: 0x0400020A RID: 522
		private Button button19;

		// Token: 0x0400020B RID: 523
		private Label lblDownload;

		// Token: 0x0400020C RID: 524
		private Label lblSpeed;

		// Token: 0x0400020D RID: 525
		private Button button74;

		// Token: 0x0400020E RID: 526
		private Button button92;

		// Token: 0x0400020F RID: 527
		private Button button93;

		// Token: 0x04000210 RID: 528
		private Button button94;

		// Token: 0x04000211 RID: 529
		private Label label266;

		// Token: 0x04000212 RID: 530
		private Button button96;

		// Token: 0x04000213 RID: 531
		private Label label267;

		// Token: 0x04000214 RID: 532
		private Label label268;

		// Token: 0x04000215 RID: 533
		private Label label269;

		// Token: 0x04000216 RID: 534
		private Button button97;

		// Token: 0x04000217 RID: 535
		private Label label270;

		// Token: 0x04000218 RID: 536
		private Label label271;

		// Token: 0x04000219 RID: 537
		private Label label272;

		// Token: 0x0400021A RID: 538
		private Button button98;

		// Token: 0x0400021B RID: 539
		private Label label273;

		// Token: 0x0400021C RID: 540
		private Label label274;

		// Token: 0x0400021D RID: 541
		private Label label275;
	}
}
