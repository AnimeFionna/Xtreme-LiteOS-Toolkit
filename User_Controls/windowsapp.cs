using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Windows.Forms;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x02000010 RID: 16
	public class windowsapp : UserControl
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0002EE14 File Offset: 0x0002D014
		public static windowsapp Instance
		{
			get
			{
				bool flag = windowsapp._instace == null;
				if (flag)
				{
					windowsapp._instace = new windowsapp();
				}
				return windowsapp._instace;
			}
		}

		// Token: 0x06000137 RID: 311 RVA: 0x0002EE41 File Offset: 0x0002D041
		public windowsapp()
		{
			this.InitializeComponent();
		}

		// Token: 0x06000138 RID: 312 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button23_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x06000139 RID: 313 RVA: 0x000020AF File Offset: 0x000002AF
		private void button22_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x0600013A RID: 314 RVA: 0x000020BD File Offset: 0x000002BD
		private void button24_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x0600013B RID: 315 RVA: 0x0002EE64 File Offset: 0x0002D064
		private void button34_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading DirectX 9c...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/DirectX_9.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\DirectX_9c.rar");
			this.sw.Start();
		}

		// Token: 0x0600013C RID: 316 RVA: 0x0002EEF4 File Offset: 0x0002D0F4
		private void dl_DownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
		{
			this.lblSpeed.Text = string.Format("{0} kb/s", ((double)e.BytesReceived / 1024.0 / this.sw.Elapsed.TotalSeconds).ToString("0.00"));
			this.lblDownload.Text = string.Format("{0} MB / {1} MB", ((double)e.BytesReceived / 1024.0 / 1024.0).ToString("0.00"), ((double)e.TotalBytesToReceive / 1024.0 / 1024.0).ToString("0.00"));
			this.progressBar1.Value = e.ProgressPercentage;
		}

		// Token: 0x0600013D RID: 317 RVA: 0x0002EFC4 File Offset: 0x0002D1C4
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

		// Token: 0x0600013E RID: 318 RVA: 0x0002F0E8 File Offset: 0x0002D2E8
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

		// Token: 0x0600013F RID: 319 RVA: 0x0002F168 File Offset: 0x0002D368
		private void button35_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading DirectX 11...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/DirectX_11.rar"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\DirectX_11.rar");
			this.sw.Start();
		}

		// Token: 0x06000140 RID: 320 RVA: 0x0002F1F8 File Offset: 0x0002D3F8
		private void button36_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading DirectX Web Installer...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/dxwebsetup.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\dxwebsetup.exe");
			this.sw.Start();
		}

		// Token: 0x06000141 RID: 321 RVA: 0x0002F288 File Offset: 0x0002D488
		private void button37_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Calculator (Classic)...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/Old%20Calculator%20for%20Windows%2010.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Old.Calculator.for.Win10.exe");
			this.sw.Start();
		}

		// Token: 0x06000142 RID: 322 RVA: 0x0002F318 File Offset: 0x0002D518
		private void button38_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Edge Chromium...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/MicrosoftEdgeEnterpriseX64.msi"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\MicrosoftEdgeEnterpriseX64.msi");
			this.sw.Start();
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0002F3A8 File Offset: 0x0002D5A8
		private void button39_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Paint (Classic)...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://nexusliteos.epubg691.workers.dev/0:/Toolkit/ClassicPaint-1.0-setup.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\Microsoft.Paint.Classic.exe");
			this.sw.Start();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0002F438 File Offset: 0x0002D638
		private void button40_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Visual C++ AIO Redist...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/VisualCppRedist_AIO_x86_x64.exe"), "C:\\Xtreme_LiteOS_Toolkit\\Downloads\\VisualCppRedist_AIO_x86_x64.exe");
			this.sw.Start();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0002F4C8 File Offset: 0x0002D6C8
		private void button7_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Cortana...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.549981C3F5F10_2.2003.27748.0_neutral_~_8wekyb3d8bbwe.Msixbundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.549981C3F5F10.Msixbundle");
			this.sw.Start();
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0002F558 File Offset: 0x0002D758
		private void button1_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.549981C3F5F10.Msixbundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.549981C3F5F10.Msixbundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000147 RID: 327 RVA: 0x0002F5E8 File Offset: 0x0002D7E8
		private void button8_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Groove Music...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.ZuneMusic_2019.21061.10126.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.ZuneMusic.AppxBundle");
			this.sw.Start();
		}

		// Token: 0x06000148 RID: 328 RVA: 0x0002F678 File Offset: 0x0002D878
		private void button6_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.ZuneMusic.AppxBundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.ZuneMusic.AppxBundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0002F708 File Offset: 0x0002D908
		private void button11_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Intel Command Center...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/AppUp.IntelGraphicsExperience_1.100.3370.0_neutral_~_8j3eq9eme6ctt.AppxBundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\AppUp.IntelGraphicsExperience.AppxBundle");
			this.sw.Start();
		}

		// Token: 0x0600014A RID: 330 RVA: 0x0002F798 File Offset: 0x0002D998
		private void button10_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\AppUp.IntelGraphicsExperience.AppxBundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\AppUp.IntelGraphicsExperience.AppxBundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0002F828 File Offset: 0x0002DA28
		private void button14_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Calculator...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.WindowsCalculator_2020.2103.8.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.WindowsCalculator.AppxBundle");
			this.sw.Start();
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0002F8B8 File Offset: 0x0002DAB8
		private void button13_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.WindowsCalculator.AppxBundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.WindowsCalculator.AppxBundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x0600014D RID: 333 RVA: 0x0002F948 File Offset: 0x0002DB48
		private void button17_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Photos...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.Windows.Photos_2021.21060.9012.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.Windows.Photos.AppxBundle");
			this.sw.Start();
		}

		// Token: 0x0600014E RID: 334 RVA: 0x0002F9D8 File Offset: 0x0002DBD8
		private void button16_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.Windows.Photos.AppxBundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.Windows.Photos.AppxBundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x0600014F RID: 335 RVA: 0x0002FA68 File Offset: 0x0002DC68
		private void button20_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Microsoft Store...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.WindowsStore_12107.1001.15.0_neutral_~_8wekyb3d8bbwe.AppxBundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.WindowsStore.AppxBundle");
			this.sw.Start();
		}

		// Token: 0x06000150 RID: 336 RVA: 0x0002FAF8 File Offset: 0x0002DCF8
		private void button19_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.WindowsStore.AppxBundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.WindowsStore.AppxBundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0002FB88 File Offset: 0x0002DD88
		private void button27_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading NVIDIA Control Panel...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/NVIDIACorp.NVIDIAControlPanel_8.1.961.0_x64__56jybvy8sckqj.Appx"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\NVIDIACorp.NVIDIAControlPanel.Appx");
			this.sw.Start();
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0002FC18 File Offset: 0x0002DE18
		private void button26_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\NVIDIACorp.NVIDIAControlPanel.Appx");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\NVIDIACorp.NVIDIAControlPanel.Appx",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0002FCA8 File Offset: 0x0002DEA8
		private void button30_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Windows Terminal...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.WindowsTerminal_2021.713.2134.0_neutral_~_8wekyb3d8bbwe.Msixbundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.WindowsTerminal.Msixbundle");
			this.sw.Start();
		}

		// Token: 0x06000154 RID: 340 RVA: 0x0002FD38 File Offset: 0x0002DF38
		private void button29_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.WindowsTerminal.Msixbundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.WindowsTerminal.Msixbundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000155 RID: 341 RVA: 0x0002FDC8 File Offset: 0x0002DFC8
		private void button33_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading Xbox Game Bar...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/Microsoft.GamingApp_2108.1001.8.0_neutral_~_8wekyb3d8bbwe.Msixbundle"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.GamingApp.Msixbundle");
			this.sw.Start();
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0002FE58 File Offset: 0x0002E058
		private void button32_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\Microsoft.GamingApp.Msixbundle");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\Microsoft.GamingApp.Msixbundle",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0002FEE8 File Offset: 0x0002E0E8
		private void button4_Click(object sender, EventArgs e)
		{
			this.label2.Text = "Downloading AMD Radeon Software...";
			this.label2.Refresh();
			this.dl = new WebClient();
			this.dl.DownloadFileCompleted += this.dl_DownloadFileCompleted;
			this.dl.DownloadProgressChanged += this.dl_DownloadProgressChanged;
			this.dl.DownloadFileAsync(new Uri("https://wpc.epubg691.workers.dev/0:/Toolkit/UWP/AdvancedMicroDevicesInc-2.AMDRadeonSoftware_10.21.30016.0_x64__0a9344xs7nr4m.Appx"), "C:\\Xtreme_LiteOS_Toolkit\\Packages\\AdvancedMicroDevicesInc-2.AMDRadeonSoftware.Appx");
			this.sw.Start();
		}

		// Token: 0x06000158 RID: 344 RVA: 0x0002FF78 File Offset: 0x0002E178
		private void button2_Click(object sender, EventArgs e)
		{
			bool flag = File.Exists("C:\\\\Xtreme_LiteOS_Toolkit\\\\Packages\\\\AdvancedMicroDevicesInc-2.AMDRadeonSoftware.Appx");
			if (flag)
			{
				new Process
				{
					StartInfo = new ProcessStartInfo
					{
						FileName = "powershell.exe",
						Arguments = "add-appxpackage -p C:\\Xtreme_LiteOS_Toolkit\\Packages\\AdvancedMicroDevicesInc-2.AMDRadeonSoftware.Appx",
						Verb = "runas"
					}
				}.Start();
			}
			else
			{
				using (_404notfound 404notfound = new _404notfound())
				{
					404notfound.ShowDialog(this);
				}
			}
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00002370 File Offset: 0x00000570
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00030008 File Offset: 0x0002E208
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00030040 File Offset: 0x0002E240
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(windowsapp));
			this.label1 = new Label();
			this.lblSpeed = new Label();
			this.lblDownload = new Label();
			this.label2 = new Label();
			this.button3 = new Button();
			this.progressBar1 = new ProgressBar();
			this.panel1 = new Panel();
			this.button2 = new Button();
			this.button4 = new Button();
			this.label35 = new Label();
			this.label36 = new Label();
			this.button40 = new Button();
			this.label33 = new Label();
			this.label34 = new Label();
			this.button39 = new Button();
			this.label31 = new Label();
			this.label32 = new Label();
			this.button38 = new Button();
			this.label29 = new Label();
			this.label30 = new Label();
			this.button37 = new Button();
			this.label27 = new Label();
			this.label28 = new Label();
			this.button36 = new Button();
			this.label25 = new Label();
			this.label26 = new Label();
			this.button35 = new Button();
			this.label23 = new Label();
			this.label24 = new Label();
			this.button34 = new Button();
			this.label21 = new Label();
			this.label22 = new Label();
			this.label20 = new Label();
			this.button32 = new Button();
			this.button33 = new Button();
			this.label18 = new Label();
			this.label19 = new Label();
			this.button29 = new Button();
			this.button30 = new Button();
			this.label16 = new Label();
			this.label17 = new Label();
			this.button26 = new Button();
			this.button27 = new Button();
			this.label14 = new Label();
			this.label15 = new Label();
			this.button19 = new Button();
			this.button20 = new Button();
			this.label12 = new Label();
			this.label13 = new Label();
			this.button16 = new Button();
			this.button17 = new Button();
			this.label10 = new Label();
			this.label11 = new Label();
			this.button13 = new Button();
			this.button14 = new Button();
			this.label8 = new Label();
			this.label9 = new Label();
			this.button10 = new Button();
			this.button11 = new Button();
			this.label5 = new Label();
			this.label7 = new Label();
			this.button6 = new Button();
			this.button8 = new Button();
			this.label3 = new Label();
			this.label4 = new Label();
			this.button1 = new Button();
			this.button7 = new Button();
			this.label81 = new Label();
			this.label6 = new Label();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.label37 = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 0);
			this.label1.Name = "label1";
			this.label1.Size = new Size(251, 53);
			this.label1.TabIndex = 4;
			this.label1.Text = "Windows Apps";
			this.lblSpeed.AutoSize = true;
			this.lblSpeed.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblSpeed.ForeColor = Color.White;
			this.lblSpeed.Location = new Point(408, 578);
			this.lblSpeed.Name = "lblSpeed";
			this.lblSpeed.Size = new Size(0, 25);
			this.lblSpeed.TabIndex = 102;
			this.lblDownload.AutoSize = true;
			this.lblDownload.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblDownload.ForeColor = Color.White;
			this.lblDownload.Location = new Point(581, 577);
			this.lblDownload.Name = "lblDownload";
			this.lblDownload.Size = new Size(0, 25);
			this.lblDownload.TabIndex = 101;
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans SemiBold", 12f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(22, 578);
			this.label2.Name = "label2";
			this.label2.Size = new Size(112, 25);
			this.label2.TabIndex = 100;
			this.label2.Text = "Status : Idle....";
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
			this.button3.TabIndex = 99;
			this.button3.TabStop = false;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.progressBar1.Location = new Point(27, 544);
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new Size(770, 23);
			this.progressBar1.Style = ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 98;
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.label35);
			this.panel1.Controls.Add(this.label36);
			this.panel1.Controls.Add(this.button40);
			this.panel1.Controls.Add(this.label33);
			this.panel1.Controls.Add(this.label34);
			this.panel1.Controls.Add(this.button39);
			this.panel1.Controls.Add(this.label31);
			this.panel1.Controls.Add(this.label32);
			this.panel1.Controls.Add(this.button38);
			this.panel1.Controls.Add(this.label29);
			this.panel1.Controls.Add(this.label30);
			this.panel1.Controls.Add(this.button37);
			this.panel1.Controls.Add(this.label27);
			this.panel1.Controls.Add(this.label28);
			this.panel1.Controls.Add(this.button36);
			this.panel1.Controls.Add(this.label25);
			this.panel1.Controls.Add(this.label26);
			this.panel1.Controls.Add(this.button35);
			this.panel1.Controls.Add(this.label23);
			this.panel1.Controls.Add(this.label24);
			this.panel1.Controls.Add(this.button34);
			this.panel1.Controls.Add(this.label21);
			this.panel1.Controls.Add(this.label22);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Controls.Add(this.button32);
			this.panel1.Controls.Add(this.button33);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.button29);
			this.panel1.Controls.Add(this.button30);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.button26);
			this.panel1.Controls.Add(this.button27);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.button19);
			this.panel1.Controls.Add(this.button20);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.button16);
			this.panel1.Controls.Add(this.button17);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.button13);
			this.panel1.Controls.Add(this.button14);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label9);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.label81);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new Point(0, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(903, 449);
			this.panel1.TabIndex = 103;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.BackgroundImageLayout = ImageLayout.None;
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.Image = (Image)componentResourceManager.GetObject("button2.Image");
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(769, 17);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(99, 30);
			this.button2.TabIndex = 340;
			this.button2.TabStop = false;
			this.button2.Text = "Install";
			this.button2.TextAlign = ContentAlignment.MiddleRight;
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.BackgroundImageLayout = ImageLayout.None;
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.Image = (Image)componentResourceManager.GetObject("button4.Image");
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(615, 17);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(120, 30);
			this.button4.TabIndex = 339;
			this.button4.TabStop = false;
			this.button4.Text = "Download";
			this.button4.TextAlign = ContentAlignment.MiddleRight;
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.label35.AutoSize = true;
			this.label35.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label35.ForeColor = Color.White;
			this.label35.Location = new Point(457, 15);
			this.label35.Name = "label35";
			this.label35.Size = new Size(130, 30);
			this.label35.TabIndex = 338;
			this.label35.Text = "| Size : 188MB";
			this.label36.AutoSize = true;
			this.label36.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label36.ForeColor = Color.White;
			this.label36.Location = new Point(14, 15);
			this.label36.Name = "label36";
			this.label36.Size = new Size(227, 30);
			this.label36.TabIndex = 337;
			this.label36.Text = "• AMD Radeon Software";
			this.button40.BackColor = Color.FromArgb(38, 38, 38);
			this.button40.BackgroundImageLayout = ImageLayout.None;
			this.button40.Cursor = Cursors.Hand;
			this.button40.FlatAppearance.BorderSize = 0;
			this.button40.FlatStyle = FlatStyle.Flat;
			this.button40.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button40.ForeColor = Color.White;
			this.button40.Image = (Image)componentResourceManager.GetObject("button40.Image");
			this.button40.ImageAlign = ContentAlignment.MiddleLeft;
			this.button40.Location = new Point(749, 835);
			this.button40.Margin = new Padding(1);
			this.button40.Name = "button40";
			this.button40.Size = new Size(120, 30);
			this.button40.TabIndex = 336;
			this.button40.TabStop = false;
			this.button40.Text = "Download";
			this.button40.TextAlign = ContentAlignment.MiddleRight;
			this.button40.UseVisualStyleBackColor = false;
			this.button40.Click += this.button40_Click;
			this.label33.AutoSize = true;
			this.label33.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label33.ForeColor = Color.White;
			this.label33.Location = new Point(472, 833);
			this.label33.Name = "label33";
			this.label33.Size = new Size(123, 30);
			this.label33.TabIndex = 335;
			this.label33.Text = "| Size : 27MB";
			this.label34.AutoSize = true;
			this.label34.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label34.ForeColor = Color.White;
			this.label34.Location = new Point(14, 833);
			this.label34.Name = "label34";
			this.label34.Size = new Size(306, 30);
			this.label34.TabIndex = 334;
			this.label34.Text = "• Visual C++ AIO Redistributables";
			this.button39.BackColor = Color.FromArgb(38, 38, 38);
			this.button39.BackgroundImageLayout = ImageLayout.None;
			this.button39.Cursor = Cursors.Hand;
			this.button39.FlatAppearance.BorderSize = 0;
			this.button39.FlatStyle = FlatStyle.Flat;
			this.button39.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button39.ForeColor = Color.White;
			this.button39.Image = (Image)componentResourceManager.GetObject("button39.Image");
			this.button39.ImageAlign = ContentAlignment.MiddleLeft;
			this.button39.Location = new Point(749, 791);
			this.button39.Margin = new Padding(1);
			this.button39.Name = "button39";
			this.button39.Size = new Size(120, 30);
			this.button39.TabIndex = 333;
			this.button39.TabStop = false;
			this.button39.Text = "Download";
			this.button39.TextAlign = ContentAlignment.MiddleRight;
			this.button39.UseVisualStyleBackColor = false;
			this.button39.Click += this.button39_Click;
			this.label31.AutoSize = true;
			this.label31.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label31.ForeColor = Color.White;
			this.label31.Location = new Point(472, 789);
			this.label31.Name = "label31";
			this.label31.Size = new Size(114, 30);
			this.label31.TabIndex = 332;
			this.label31.Text = "| Size : 3MB";
			this.label32.AutoSize = true;
			this.label32.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label32.ForeColor = Color.White;
			this.label32.Location = new Point(14, 789);
			this.label32.Name = "label32";
			this.label32.Size = new Size(241, 30);
			this.label32.TabIndex = 331;
			this.label32.Text = "• Microsoft Paint (Classic)";
			this.button38.BackColor = Color.FromArgb(38, 38, 38);
			this.button38.BackgroundImageLayout = ImageLayout.None;
			this.button38.Cursor = Cursors.Hand;
			this.button38.FlatAppearance.BorderSize = 0;
			this.button38.FlatStyle = FlatStyle.Flat;
			this.button38.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button38.ForeColor = Color.White;
			this.button38.Image = (Image)componentResourceManager.GetObject("button38.Image");
			this.button38.ImageAlign = ContentAlignment.MiddleLeft;
			this.button38.Location = new Point(749, 747);
			this.button38.Margin = new Padding(1);
			this.button38.Name = "button38";
			this.button38.Size = new Size(120, 30);
			this.button38.TabIndex = 330;
			this.button38.TabStop = false;
			this.button38.Text = "Download";
			this.button38.TextAlign = ContentAlignment.MiddleRight;
			this.button38.UseVisualStyleBackColor = false;
			this.button38.Click += this.button38_Click;
			this.label29.AutoSize = true;
			this.label29.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label29.ForeColor = Color.White;
			this.label29.Location = new Point(472, 745);
			this.label29.Name = "label29";
			this.label29.Size = new Size(132, 30);
			this.label29.TabIndex = 329;
			this.label29.Text = "| Size : 104MB";
			this.label30.AutoSize = true;
			this.label30.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label30.ForeColor = Color.White;
			this.label30.Location = new Point(14, 745);
			this.label30.Name = "label30";
			this.label30.Size = new Size(253, 30);
			this.label30.TabIndex = 328;
			this.label30.Text = "• Microsoft Edge Chromium";
			this.button37.BackColor = Color.FromArgb(38, 38, 38);
			this.button37.BackgroundImageLayout = ImageLayout.None;
			this.button37.Cursor = Cursors.Hand;
			this.button37.FlatAppearance.BorderSize = 0;
			this.button37.FlatStyle = FlatStyle.Flat;
			this.button37.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button37.ForeColor = Color.White;
			this.button37.Image = (Image)componentResourceManager.GetObject("button37.Image");
			this.button37.ImageAlign = ContentAlignment.MiddleLeft;
			this.button37.Location = new Point(749, 703);
			this.button37.Margin = new Padding(1);
			this.button37.Name = "button37";
			this.button37.Size = new Size(120, 30);
			this.button37.TabIndex = 327;
			this.button37.TabStop = false;
			this.button37.Text = "Download";
			this.button37.TextAlign = ContentAlignment.MiddleRight;
			this.button37.UseVisualStyleBackColor = false;
			this.button37.Click += this.button37_Click;
			this.label27.AutoSize = true;
			this.label27.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label27.ForeColor = Color.White;
			this.label27.Location = new Point(472, 701);
			this.label27.Name = "label27";
			this.label27.Size = new Size(110, 30);
			this.label27.TabIndex = 326;
			this.label27.Text = "| Size : 1MB";
			this.label28.AutoSize = true;
			this.label28.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label28.ForeColor = Color.White;
			this.label28.Location = new Point(14, 701);
			this.label28.Name = "label28";
			this.label28.Size = new Size(284, 30);
			this.label28.TabIndex = 325;
			this.label28.Text = "• Microsoft Calculator (Classic)";
			this.button36.BackColor = Color.FromArgb(38, 38, 38);
			this.button36.BackgroundImageLayout = ImageLayout.None;
			this.button36.Cursor = Cursors.Hand;
			this.button36.FlatAppearance.BorderSize = 0;
			this.button36.FlatStyle = FlatStyle.Flat;
			this.button36.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button36.ForeColor = Color.White;
			this.button36.Image = (Image)componentResourceManager.GetObject("button36.Image");
			this.button36.ImageAlign = ContentAlignment.MiddleLeft;
			this.button36.Location = new Point(749, 659);
			this.button36.Margin = new Padding(1);
			this.button36.Name = "button36";
			this.button36.Size = new Size(120, 30);
			this.button36.TabIndex = 324;
			this.button36.TabStop = false;
			this.button36.Text = "Download";
			this.button36.TextAlign = ContentAlignment.MiddleRight;
			this.button36.UseVisualStyleBackColor = false;
			this.button36.Click += this.button36_Click;
			this.label25.AutoSize = true;
			this.label25.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label25.ForeColor = Color.White;
			this.label25.Location = new Point(472, 657);
			this.label25.Name = "label25";
			this.label25.Size = new Size(129, 30);
			this.label25.TabIndex = 323;
			this.label25.Text = "| Size : 285KB";
			this.label26.AutoSize = true;
			this.label26.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label26.ForeColor = Color.White;
			this.label26.Location = new Point(14, 657);
			this.label26.Name = "label26";
			this.label26.Size = new Size(213, 30);
			this.label26.TabIndex = 322;
			this.label26.Text = "• DirectX Web Installer";
			this.button35.BackColor = Color.FromArgb(38, 38, 38);
			this.button35.BackgroundImageLayout = ImageLayout.None;
			this.button35.Cursor = Cursors.Hand;
			this.button35.FlatAppearance.BorderSize = 0;
			this.button35.FlatStyle = FlatStyle.Flat;
			this.button35.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button35.ForeColor = Color.White;
			this.button35.Image = (Image)componentResourceManager.GetObject("button35.Image");
			this.button35.ImageAlign = ContentAlignment.MiddleLeft;
			this.button35.Location = new Point(749, 615);
			this.button35.Margin = new Padding(1);
			this.button35.Name = "button35";
			this.button35.Size = new Size(120, 30);
			this.button35.TabIndex = 321;
			this.button35.TabStop = false;
			this.button35.Text = "Download";
			this.button35.TextAlign = ContentAlignment.MiddleRight;
			this.button35.UseVisualStyleBackColor = false;
			this.button35.Click += this.button35_Click;
			this.label23.AutoSize = true;
			this.label23.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label23.ForeColor = Color.White;
			this.label23.Location = new Point(472, 613);
			this.label23.Name = "label23";
			this.label23.Size = new Size(124, 30);
			this.label23.TabIndex = 320;
			this.label23.Text = "| Size : 96MB";
			this.label24.AutoSize = true;
			this.label24.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label24.ForeColor = Color.White;
			this.label24.Location = new Point(14, 613);
			this.label24.Name = "label24";
			this.label24.Size = new Size(111, 30);
			this.label24.TabIndex = 319;
			this.label24.Text = "• DirectX 11";
			this.button34.BackColor = Color.FromArgb(38, 38, 38);
			this.button34.BackgroundImageLayout = ImageLayout.None;
			this.button34.Cursor = Cursors.Hand;
			this.button34.FlatAppearance.BorderSize = 0;
			this.button34.FlatStyle = FlatStyle.Flat;
			this.button34.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button34.ForeColor = Color.White;
			this.button34.Image = (Image)componentResourceManager.GetObject("button34.Image");
			this.button34.ImageAlign = ContentAlignment.MiddleLeft;
			this.button34.Location = new Point(749, 571);
			this.button34.Margin = new Padding(1);
			this.button34.Name = "button34";
			this.button34.Size = new Size(120, 30);
			this.button34.TabIndex = 318;
			this.button34.TabStop = false;
			this.button34.Text = "Download";
			this.button34.TextAlign = ContentAlignment.MiddleRight;
			this.button34.UseVisualStyleBackColor = false;
			this.button34.Click += this.button34_Click;
			this.label21.AutoSize = true;
			this.label21.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label21.ForeColor = Color.White;
			this.label21.Location = new Point(472, 569);
			this.label21.Name = "label21";
			this.label21.Size = new Size(124, 30);
			this.label21.TabIndex = 317;
			this.label21.Text = "| Size : 96MB";
			this.label22.AutoSize = true;
			this.label22.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label22.ForeColor = Color.White;
			this.label22.Location = new Point(14, 569);
			this.label22.Name = "label22";
			this.label22.Size = new Size(118, 30);
			this.label22.TabIndex = 316;
			this.label22.Text = "• DirectX 9c";
			this.label20.AutoSize = true;
			this.label20.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label20.ForeColor = Color.White;
			this.label20.Location = new Point(14, 499);
			this.label20.Name = "label20";
			this.label20.Size = new Size(121, 53);
			this.label20.TabIndex = 315;
			this.label20.Text = "Extras";
			this.button32.BackColor = Color.FromArgb(38, 38, 38);
			this.button32.BackgroundImageLayout = ImageLayout.None;
			this.button32.Cursor = Cursors.Hand;
			this.button32.FlatAppearance.BorderSize = 0;
			this.button32.FlatStyle = FlatStyle.Flat;
			this.button32.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button32.ForeColor = Color.White;
			this.button32.Image = (Image)componentResourceManager.GetObject("button32.Image");
			this.button32.ImageAlign = ContentAlignment.MiddleLeft;
			this.button32.Location = new Point(769, 449);
			this.button32.Margin = new Padding(1);
			this.button32.Name = "button32";
			this.button32.Size = new Size(99, 30);
			this.button32.TabIndex = 313;
			this.button32.TabStop = false;
			this.button32.Text = "Install";
			this.button32.TextAlign = ContentAlignment.MiddleRight;
			this.button32.UseVisualStyleBackColor = false;
			this.button32.Click += this.button32_Click;
			this.button33.BackColor = Color.FromArgb(38, 38, 38);
			this.button33.BackgroundImageLayout = ImageLayout.None;
			this.button33.Cursor = Cursors.Hand;
			this.button33.FlatAppearance.BorderSize = 0;
			this.button33.FlatStyle = FlatStyle.Flat;
			this.button33.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button33.ForeColor = Color.White;
			this.button33.Image = (Image)componentResourceManager.GetObject("button33.Image");
			this.button33.ImageAlign = ContentAlignment.MiddleLeft;
			this.button33.Location = new Point(615, 449);
			this.button33.Margin = new Padding(1);
			this.button33.Name = "button33";
			this.button33.Size = new Size(120, 30);
			this.button33.TabIndex = 312;
			this.button33.TabStop = false;
			this.button33.Text = "Download";
			this.button33.TextAlign = ContentAlignment.MiddleRight;
			this.button33.UseVisualStyleBackColor = false;
			this.button33.Click += this.button33_Click;
			this.label18.AutoSize = true;
			this.label18.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label18.ForeColor = Color.White;
			this.label18.Location = new Point(457, 447);
			this.label18.Name = "label18";
			this.label18.Size = new Size(124, 30);
			this.label18.TabIndex = 311;
			this.label18.Text = "| Size : 49MB";
			this.label19.AutoSize = true;
			this.label19.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label19.ForeColor = Color.White;
			this.label19.Location = new Point(14, 447);
			this.label19.Name = "label19";
			this.label19.Size = new Size(164, 30);
			this.label19.TabIndex = 310;
			this.label19.Text = "• Xbox Game Bar";
			this.button29.BackColor = Color.FromArgb(38, 38, 38);
			this.button29.BackgroundImageLayout = ImageLayout.None;
			this.button29.Cursor = Cursors.Hand;
			this.button29.FlatAppearance.BorderSize = 0;
			this.button29.FlatStyle = FlatStyle.Flat;
			this.button29.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button29.ForeColor = Color.White;
			this.button29.Image = (Image)componentResourceManager.GetObject("button29.Image");
			this.button29.ImageAlign = ContentAlignment.MiddleLeft;
			this.button29.Location = new Point(769, 401);
			this.button29.Margin = new Padding(1);
			this.button29.Name = "button29";
			this.button29.Size = new Size(99, 30);
			this.button29.TabIndex = 308;
			this.button29.TabStop = false;
			this.button29.Text = "Install";
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
			this.button30.Location = new Point(615, 401);
			this.button30.Margin = new Padding(1);
			this.button30.Name = "button30";
			this.button30.Size = new Size(120, 30);
			this.button30.TabIndex = 307;
			this.button30.TabStop = false;
			this.button30.Text = "Download";
			this.button30.TextAlign = ContentAlignment.MiddleRight;
			this.button30.UseVisualStyleBackColor = false;
			this.button30.Click += this.button30_Click;
			this.label16.AutoSize = true;
			this.label16.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label16.ForeColor = Color.White;
			this.label16.Location = new Point(457, 399);
			this.label16.Name = "label16";
			this.label16.Size = new Size(124, 30);
			this.label16.TabIndex = 306;
			this.label16.Text = "| Size : 28MB";
			this.label17.AutoSize = true;
			this.label17.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label17.ForeColor = Color.White;
			this.label17.Location = new Point(14, 399);
			this.label17.Name = "label17";
			this.label17.Size = new Size(185, 30);
			this.label17.TabIndex = 305;
			this.label17.Text = "• Windows Terminal";
			this.button26.BackColor = Color.FromArgb(38, 38, 38);
			this.button26.BackgroundImageLayout = ImageLayout.None;
			this.button26.Cursor = Cursors.Hand;
			this.button26.FlatAppearance.BorderSize = 0;
			this.button26.FlatStyle = FlatStyle.Flat;
			this.button26.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button26.ForeColor = Color.White;
			this.button26.Image = (Image)componentResourceManager.GetObject("button26.Image");
			this.button26.ImageAlign = ContentAlignment.MiddleLeft;
			this.button26.Location = new Point(769, 353);
			this.button26.Margin = new Padding(1);
			this.button26.Name = "button26";
			this.button26.Size = new Size(99, 30);
			this.button26.TabIndex = 303;
			this.button26.TabStop = false;
			this.button26.Text = "Install";
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
			this.button27.Location = new Point(615, 353);
			this.button27.Margin = new Padding(1);
			this.button27.Name = "button27";
			this.button27.Size = new Size(120, 30);
			this.button27.TabIndex = 302;
			this.button27.TabStop = false;
			this.button27.Text = "Download";
			this.button27.TextAlign = ContentAlignment.MiddleRight;
			this.button27.UseVisualStyleBackColor = false;
			this.button27.Click += this.button27_Click;
			this.label14.AutoSize = true;
			this.label14.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label14.ForeColor = Color.White;
			this.label14.Location = new Point(457, 351);
			this.label14.Name = "label14";
			this.label14.Size = new Size(114, 30);
			this.label14.TabIndex = 301;
			this.label14.Text = "| Size : 8MB";
			this.label15.AutoSize = true;
			this.label15.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label15.ForeColor = Color.White;
			this.label15.Location = new Point(14, 351);
			this.label15.Name = "label15";
			this.label15.Size = new Size(220, 30);
			this.label15.TabIndex = 300;
			this.label15.Text = "• NVIDIA Control Panel";
			this.button19.BackColor = Color.FromArgb(38, 38, 38);
			this.button19.BackgroundImageLayout = ImageLayout.None;
			this.button19.Cursor = Cursors.Hand;
			this.button19.FlatAppearance.BorderSize = 0;
			this.button19.FlatStyle = FlatStyle.Flat;
			this.button19.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button19.ForeColor = Color.White;
			this.button19.Image = (Image)componentResourceManager.GetObject("button19.Image");
			this.button19.ImageAlign = ContentAlignment.MiddleLeft;
			this.button19.Location = new Point(769, 305);
			this.button19.Margin = new Padding(1);
			this.button19.Name = "button19";
			this.button19.Size = new Size(99, 30);
			this.button19.TabIndex = 298;
			this.button19.TabStop = false;
			this.button19.Text = "Install";
			this.button19.TextAlign = ContentAlignment.MiddleRight;
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += this.button19_Click;
			this.button20.BackColor = Color.FromArgb(38, 38, 38);
			this.button20.BackgroundImageLayout = ImageLayout.None;
			this.button20.Cursor = Cursors.Hand;
			this.button20.FlatAppearance.BorderSize = 0;
			this.button20.FlatStyle = FlatStyle.Flat;
			this.button20.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button20.ForeColor = Color.White;
			this.button20.Image = (Image)componentResourceManager.GetObject("button20.Image");
			this.button20.ImageAlign = ContentAlignment.MiddleLeft;
			this.button20.Location = new Point(615, 305);
			this.button20.Margin = new Padding(1);
			this.button20.Name = "button20";
			this.button20.Size = new Size(120, 30);
			this.button20.TabIndex = 297;
			this.button20.TabStop = false;
			this.button20.Text = "Download";
			this.button20.TextAlign = ContentAlignment.MiddleRight;
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += this.button20_Click;
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.ForeColor = Color.White;
			this.label12.Location = new Point(457, 303);
			this.label12.Name = "label12";
			this.label12.Size = new Size(124, 30);
			this.label12.TabIndex = 296;
			this.label12.Text = "| Size : 55MB";
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label13.ForeColor = Color.White;
			this.label13.Location = new Point(14, 303);
			this.label13.Name = "label13";
			this.label13.Size = new Size(160, 30);
			this.label13.TabIndex = 295;
			this.label13.Text = "• Microsoft Store";
			this.button16.BackColor = Color.FromArgb(38, 38, 38);
			this.button16.BackgroundImageLayout = ImageLayout.None;
			this.button16.Cursor = Cursors.Hand;
			this.button16.FlatAppearance.BorderSize = 0;
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button16.ForeColor = Color.White;
			this.button16.Image = (Image)componentResourceManager.GetObject("button16.Image");
			this.button16.ImageAlign = ContentAlignment.MiddleLeft;
			this.button16.Location = new Point(769, 257);
			this.button16.Margin = new Padding(1);
			this.button16.Name = "button16";
			this.button16.Size = new Size(99, 30);
			this.button16.TabIndex = 293;
			this.button16.TabStop = false;
			this.button16.Text = "Install";
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
			this.button17.Location = new Point(615, 257);
			this.button17.Margin = new Padding(1);
			this.button17.Name = "button17";
			this.button17.Size = new Size(120, 30);
			this.button17.TabIndex = 292;
			this.button17.TabStop = false;
			this.button17.Text = "Download";
			this.button17.TextAlign = ContentAlignment.MiddleRight;
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += this.button17_Click;
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.White;
			this.label10.Location = new Point(457, 255);
			this.label10.Name = "label10";
			this.label10.Size = new Size(130, 30);
			this.label10.TabIndex = 291;
			this.label10.Text = "| Size : 316MB";
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(14, 255);
			this.label11.Name = "label11";
			this.label11.Size = new Size(172, 30);
			this.label11.TabIndex = 290;
			this.label11.Text = "• Microsoft Photos";
			this.button13.BackColor = Color.FromArgb(38, 38, 38);
			this.button13.BackgroundImageLayout = ImageLayout.None;
			this.button13.Cursor = Cursors.Hand;
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button13.ForeColor = Color.White;
			this.button13.Image = (Image)componentResourceManager.GetObject("button13.Image");
			this.button13.ImageAlign = ContentAlignment.MiddleLeft;
			this.button13.Location = new Point(769, 209);
			this.button13.Margin = new Padding(1);
			this.button13.Name = "button13";
			this.button13.Size = new Size(99, 30);
			this.button13.TabIndex = 288;
			this.button13.TabStop = false;
			this.button13.Text = "Install";
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
			this.button14.Location = new Point(615, 209);
			this.button14.Margin = new Padding(1);
			this.button14.Name = "button14";
			this.button14.Size = new Size(120, 30);
			this.button14.TabIndex = 287;
			this.button14.TabStop = false;
			this.button14.Text = "Download";
			this.button14.TextAlign = ContentAlignment.MiddleRight;
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += this.button14_Click;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(457, 207);
			this.label8.Name = "label8";
			this.label8.Size = new Size(120, 30);
			this.label8.TabIndex = 286;
			this.label8.Text = "| Size : 16MB";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.White;
			this.label9.Location = new Point(14, 207);
			this.label9.Name = "label9";
			this.label9.Size = new Size(203, 30);
			this.label9.TabIndex = 285;
			this.label9.Text = "• Microsoft Calculator";
			this.button10.BackColor = Color.FromArgb(38, 38, 38);
			this.button10.BackgroundImageLayout = ImageLayout.None;
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.Image = (Image)componentResourceManager.GetObject("button10.Image");
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(769, 161);
			this.button10.Margin = new Padding(1);
			this.button10.Name = "button10";
			this.button10.Size = new Size(99, 30);
			this.button10.TabIndex = 283;
			this.button10.TabStop = false;
			this.button10.Text = "Install";
			this.button10.TextAlign = ContentAlignment.MiddleRight;
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click;
			this.button11.BackColor = Color.FromArgb(38, 38, 38);
			this.button11.BackgroundImageLayout = ImageLayout.None;
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.Image = (Image)componentResourceManager.GetObject("button11.Image");
			this.button11.ImageAlign = ContentAlignment.MiddleLeft;
			this.button11.Location = new Point(615, 161);
			this.button11.Margin = new Padding(1);
			this.button11.Name = "button11";
			this.button11.Size = new Size(120, 30);
			this.button11.TabIndex = 282;
			this.button11.TabStop = false;
			this.button11.Text = "Download";
			this.button11.TextAlign = ContentAlignment.MiddleRight;
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += this.button11_Click;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(457, 159);
			this.label5.Name = "label5";
			this.label5.Size = new Size(124, 30);
			this.label5.TabIndex = 281;
			this.label5.Text = "| Size : 96MB";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(14, 159);
			this.label7.Name = "label7";
			this.label7.Size = new Size(225, 30);
			this.label7.TabIndex = 280;
			this.label7.Text = "• Intel Command Center";
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.BackgroundImageLayout = ImageLayout.None;
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.Image = (Image)componentResourceManager.GetObject("button6.Image");
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(769, 113);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(99, 30);
			this.button6.TabIndex = 278;
			this.button6.TabStop = false;
			this.button6.Text = "Install";
			this.button6.TextAlign = ContentAlignment.MiddleRight;
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.BackgroundImageLayout = ImageLayout.None;
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.Image = (Image)componentResourceManager.GetObject("button8.Image");
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(615, 113);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(120, 30);
			this.button8.TabIndex = 277;
			this.button8.TabStop = false;
			this.button8.Text = "Download";
			this.button8.TextAlign = ContentAlignment.MiddleRight;
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(457, 111);
			this.label3.Name = "label3";
			this.label3.Size = new Size(126, 30);
			this.label3.TabIndex = 276;
			this.label3.Text = "| Size : 40MB";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(14, 111);
			this.label4.Name = "label4";
			this.label4.Size = new Size(144, 30);
			this.label4.TabIndex = 275;
			this.label4.Text = "• Groove Music";
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.BackgroundImageLayout = ImageLayout.None;
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.Image = (Image)componentResourceManager.GetObject("button1.Image");
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(769, 65);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(99, 30);
			this.button1.TabIndex = 272;
			this.button1.TabStop = false;
			this.button1.Text = "Install";
			this.button1.TextAlign = ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.BackgroundImageLayout = ImageLayout.None;
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.Image = (Image)componentResourceManager.GetObject("button7.Image");
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(615, 65);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(120, 30);
			this.button7.TabIndex = 271;
			this.button7.TabStop = false;
			this.button7.Text = "Download";
			this.button7.TextAlign = ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.label81.AutoSize = true;
			this.label81.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label81.ForeColor = Color.White;
			this.label81.Location = new Point(457, 63);
			this.label81.Name = "label81";
			this.label81.Size = new Size(124, 30);
			this.label81.TabIndex = 270;
			this.label81.Text = "| Size : 55MB";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(14, 63);
			this.label6.Name = "label6";
			this.label6.Size = new Size(98, 30);
			this.label6.TabIndex = 269;
			this.label6.Text = "• Cortana";
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
			this.button21.TabIndex = 95;
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
			this.button22.TabIndex = 94;
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
			this.button23.TabIndex = 93;
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
			this.button24.TabIndex = 92;
			this.button24.TabStop = false;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += this.button24_Click;
			this.label37.AutoSize = true;
			this.label37.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label37.ForeColor = Color.Silver;
			this.label37.Location = new Point(23, 53);
			this.label37.Name = "label37";
			this.label37.Size = new Size(559, 19);
			this.label37.TabIndex = 104;
			this.label37.Text = "Download Microsoft Store and some UWP Apps with essential software like DirectX, VC++ and more";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.label37);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.lblSpeed);
			base.Controls.Add(this.lblDownload);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.button3);
			base.Controls.Add(this.progressBar1);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.label1);
			base.Name = "windowsapp";
			base.Size = new Size(918, 619);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400029A RID: 666
		private WebClient dl;

		// Token: 0x0400029B RID: 667
		private Stopwatch sw = new Stopwatch();

		// Token: 0x0400029C RID: 668
		private static windowsapp _instace;

		// Token: 0x0400029D RID: 669
		private IContainer components = null;

		// Token: 0x0400029E RID: 670
		private Label label1;

		// Token: 0x0400029F RID: 671
		private Button button21;

		// Token: 0x040002A0 RID: 672
		private Button button22;

		// Token: 0x040002A1 RID: 673
		private Button button23;

		// Token: 0x040002A2 RID: 674
		private Button button24;

		// Token: 0x040002A3 RID: 675
		private Label lblSpeed;

		// Token: 0x040002A4 RID: 676
		private Label lblDownload;

		// Token: 0x040002A5 RID: 677
		private Label label2;

		// Token: 0x040002A6 RID: 678
		private Button button3;

		// Token: 0x040002A7 RID: 679
		private ProgressBar progressBar1;

		// Token: 0x040002A8 RID: 680
		private Panel panel1;

		// Token: 0x040002A9 RID: 681
		private Button button7;

		// Token: 0x040002AA RID: 682
		private Label label81;

		// Token: 0x040002AB RID: 683
		private Label label6;

		// Token: 0x040002AC RID: 684
		private Button button1;

		// Token: 0x040002AD RID: 685
		private Button button6;

		// Token: 0x040002AE RID: 686
		private Button button8;

		// Token: 0x040002AF RID: 687
		private Label label3;

		// Token: 0x040002B0 RID: 688
		private Label label4;

		// Token: 0x040002B1 RID: 689
		private Button button10;

		// Token: 0x040002B2 RID: 690
		private Button button11;

		// Token: 0x040002B3 RID: 691
		private Label label5;

		// Token: 0x040002B4 RID: 692
		private Label label7;

		// Token: 0x040002B5 RID: 693
		private Button button13;

		// Token: 0x040002B6 RID: 694
		private Button button14;

		// Token: 0x040002B7 RID: 695
		private Label label8;

		// Token: 0x040002B8 RID: 696
		private Label label9;

		// Token: 0x040002B9 RID: 697
		private Button button16;

		// Token: 0x040002BA RID: 698
		private Button button17;

		// Token: 0x040002BB RID: 699
		private Label label10;

		// Token: 0x040002BC RID: 700
		private Label label11;

		// Token: 0x040002BD RID: 701
		private Button button19;

		// Token: 0x040002BE RID: 702
		private Button button20;

		// Token: 0x040002BF RID: 703
		private Label label12;

		// Token: 0x040002C0 RID: 704
		private Label label13;

		// Token: 0x040002C1 RID: 705
		private Button button26;

		// Token: 0x040002C2 RID: 706
		private Button button27;

		// Token: 0x040002C3 RID: 707
		private Label label14;

		// Token: 0x040002C4 RID: 708
		private Label label15;

		// Token: 0x040002C5 RID: 709
		private Button button29;

		// Token: 0x040002C6 RID: 710
		private Button button30;

		// Token: 0x040002C7 RID: 711
		private Label label16;

		// Token: 0x040002C8 RID: 712
		private Label label17;

		// Token: 0x040002C9 RID: 713
		private Button button32;

		// Token: 0x040002CA RID: 714
		private Button button33;

		// Token: 0x040002CB RID: 715
		private Label label18;

		// Token: 0x040002CC RID: 716
		private Label label19;

		// Token: 0x040002CD RID: 717
		private Label label20;

		// Token: 0x040002CE RID: 718
		private Button button34;

		// Token: 0x040002CF RID: 719
		private Label label21;

		// Token: 0x040002D0 RID: 720
		private Label label22;

		// Token: 0x040002D1 RID: 721
		private Button button35;

		// Token: 0x040002D2 RID: 722
		private Label label23;

		// Token: 0x040002D3 RID: 723
		private Label label24;

		// Token: 0x040002D4 RID: 724
		private Button button36;

		// Token: 0x040002D5 RID: 725
		private Label label25;

		// Token: 0x040002D6 RID: 726
		private Label label26;

		// Token: 0x040002D7 RID: 727
		private Button button37;

		// Token: 0x040002D8 RID: 728
		private Label label27;

		// Token: 0x040002D9 RID: 729
		private Label label28;

		// Token: 0x040002DA RID: 730
		private Button button38;

		// Token: 0x040002DB RID: 731
		private Label label29;

		// Token: 0x040002DC RID: 732
		private Label label30;

		// Token: 0x040002DD RID: 733
		private Button button39;

		// Token: 0x040002DE RID: 734
		private Label label31;

		// Token: 0x040002DF RID: 735
		private Label label32;

		// Token: 0x040002E0 RID: 736
		private Button button40;

		// Token: 0x040002E1 RID: 737
		private Label label33;

		// Token: 0x040002E2 RID: 738
		private Label label34;

		// Token: 0x040002E3 RID: 739
		private Button button2;

		// Token: 0x040002E4 RID: 740
		private Button button4;

		// Token: 0x040002E5 RID: 741
		private Label label35;

		// Token: 0x040002E6 RID: 742
		private Label label36;

		// Token: 0x040002E7 RID: 743
		private Label label37;
	}
}
