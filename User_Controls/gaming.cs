using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using WindowsFormsApplication2.Classes;
using WindowsFormsApplication2.Dialog_Boxes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000C RID: 12
	public class gaming : UserControl
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x060000E2 RID: 226 RVA: 0x000261B4 File Offset: 0x000243B4
		public static gaming Instance
		{
			get
			{
				bool flag = gaming._instace == null;
				if (flag)
				{
					gaming._instace = new gaming();
				}
				return gaming._instace;
			}
		}

		// Token: 0x060000E3 RID: 227 RVA: 0x000261E1 File Offset: 0x000243E1
		public gaming()
		{
			this.InitializeComponent();
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button23_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x000020AF File Offset: 0x000002AF
		private void button22_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x000020BD File Offset: 0x000002BD
		private void button24_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x000261F9 File Offset: 0x000243F9
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://bitsum.com/parkcontrol/");
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x00026207 File Offset: 0x00024407
		private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://bitsum.com/");
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x00026215 File Offset: 0x00024415
		private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://www.henrypp.org/product/memreduct");
		}

		// Token: 0x060000EA RID: 234 RVA: 0x00026224 File Offset: 0x00024424
		private void button5_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "DisableTaggedEnergyLogging", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "TelemetryMaxApplication", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "TelemetryMaxTagPerApplication", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000EB RID: 235 RVA: 0x000262A4 File Offset: 0x000244A4
		private void button19_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 26, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x000262F8 File Offset: 0x000244F8
		private void button18_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 20, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x0002634C File Offset: 0x0002454C
		private void button17_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 21, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000EE RID: 238 RVA: 0x000263A0 File Offset: 0x000245A0
		private void button15_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 22, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000EF RID: 239 RVA: 0x000263F4 File Offset: 0x000245F4
		private void button14_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 24, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x00026448 File Offset: 0x00024648
		private void button16_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 25, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x0002649C File Offset: 0x0002469C
		private void button29_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 42, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x000264F0 File Offset: 0x000246F0
		private void button28_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 36, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00026544 File Offset: 0x00024744
		private void button27_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 37, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00026598 File Offset: 0x00024798
		private void button25_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 38, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x000265EC File Offset: 0x000247EC
		private void button20_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 40, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x00026640 File Offset: 0x00024840
		private void button26_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\PriorityControl", "Win32PrioritySeparation", 41, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x00026694 File Offset: 0x00024894
		private void button12_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", 68764420, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000266EC File Offset: 0x000248EC
		private void button11_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", 103355478, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x00026744 File Offset: 0x00024944
		private void button10_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", 137922056, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000FA RID: 250 RVA: 0x0002679C File Offset: 0x0002499C
		private void button8_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", 307767570, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000267F4 File Offset: 0x000249F4
		private void button7_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", 376926742, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0002684C File Offset: 0x00024A4C
		private void button9_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control", "SvcHostSplitThresholdInKB", 861226034, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000FD RID: 253 RVA: 0x000268A4 File Offset: 0x00024AA4
		private void button1_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "DisableTaggedEnergyLogging", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "TelemetryMaxApplication", 250, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power\\EnergyEstimation\\TaggedEnergy", "TelemetryMaxTagPerApplication", 50, RegistryValueKind.DWord);
			using (reverted reverted = new reverted())
			{
				reverted.ShowDialog(this);
			}
		}

		// Token: 0x060000FE RID: 254 RVA: 0x0002692C File Offset: 0x00024B2C
		private void button3_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power", "LowLatencyScalingPercentage", 64, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePageCombining", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MMCSS", "Start", 4, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000269B0 File Offset: 0x00024BB0
		private void button2_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Power", "LowLatencyScalingPercentage", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Memory Management", "DisablePageCombining", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\MMCSS", "Start", 2, RegistryValueKind.DWord);
			using (reverted reverted = new reverted())
			{
				reverted.ShowDialog(this);
			}
		}

		// Token: 0x06000100 RID: 256 RVA: 0x00026A30 File Offset: 0x00024C30
		private void button6_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TcpAckFrequency", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TCPNoDelay", 0, RegistryValueKind.DWord);
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C netsh int tcp set global rsc=disabled";
			processStartInfo.Verb = "runas";
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C netsh int tcp set global rss=disabled";
			processStartInfo.Verb = "runas";
			process.StartInfo = processStartInfo;
			process.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x00026B2C File Offset: 0x00024D2C
		private void button4_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TcpAckFrequency", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Tcpip\\Parameters\\Interfaces", "TCPNoDelay", 1, RegistryValueKind.DWord);
			Process process = new Process();
			ProcessStartInfo processStartInfo = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C netsh int tcp set global rsc=enabled";
			processStartInfo.Verb = "runas";
			process.StartInfo = processStartInfo;
			process.Start();
			Process process2 = new Process();
			ProcessStartInfo processStartInfo2 = new ProcessStartInfo();
			processStartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			processStartInfo.FileName = "cmd.exe";
			processStartInfo.Arguments = "/C netsh int tcp set global rss=enabled";
			processStartInfo.Verb = "runas";
			process.StartInfo = processStartInfo;
			process.Start();
			using (reverted reverted = new reverted())
			{
				reverted.ShowDialog(this);
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x00002370 File Offset: 0x00000570
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00026C28 File Offset: 0x00024E28
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x00026C60 File Offset: 0x00024E60
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(gaming));
			this.label1 = new Label();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.label9 = new Label();
			this.label2 = new Label();
			this.panel1 = new Panel();
			this.label13 = new Label();
			this.label12 = new Label();
			this.linkLabel3 = new LinkLabel();
			this.linkLabel2 = new LinkLabel();
			this.linkLabel1 = new LinkLabel();
			this.button20 = new Button();
			this.button25 = new Button();
			this.button26 = new Button();
			this.button27 = new Button();
			this.button28 = new Button();
			this.button29 = new Button();
			this.button14 = new Button();
			this.button15 = new Button();
			this.button16 = new Button();
			this.button17 = new Button();
			this.button18 = new Button();
			this.button19 = new Button();
			this.label11 = new Label();
			this.button7 = new Button();
			this.button8 = new Button();
			this.button9 = new Button();
			this.button10 = new Button();
			this.button11 = new Button();
			this.button12 = new Button();
			this.label8 = new Label();
			this.label10 = new Label();
			this.label7 = new Label();
			this.button4 = new Button();
			this.button6 = new Button();
			this.button2 = new Button();
			this.button3 = new Button();
			this.button1 = new Button();
			this.button5 = new Button();
			this.label5 = new Label();
			this.label4 = new Label();
			this.label3 = new Label();
			this.label6 = new Label();
			this.panel1.SuspendLayout();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(270, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Gaming Tweaks";
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
			this.button21.TabIndex = 83;
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
			this.button22.TabIndex = 82;
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
			this.button23.TabIndex = 81;
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
			this.button24.TabIndex = 80;
			this.button24.TabStop = false;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += this.button24_Click;
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(23, 75);
			this.label9.Name = "label9";
			this.label9.Size = new Size(354, 19);
			this.label9.TabIndex = 84;
			this.label9.Text = "Special Tweaks for gamers (Restart required to apply changes)";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.Silver;
			this.label2.Location = new Point(383, 75);
			this.label2.Name = "label2";
			this.label2.Size = new Size(440, 19);
			this.label2.TabIndex = 85;
			this.label2.Text = "Note : Before applying these tweaks make sure to make a system restore point.";
			this.panel1.AutoScroll = true;
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.linkLabel3);
			this.panel1.Controls.Add(this.linkLabel2);
			this.panel1.Controls.Add(this.linkLabel1);
			this.panel1.Controls.Add(this.button20);
			this.panel1.Controls.Add(this.button25);
			this.panel1.Controls.Add(this.button26);
			this.panel1.Controls.Add(this.button27);
			this.panel1.Controls.Add(this.button28);
			this.panel1.Controls.Add(this.button29);
			this.panel1.Controls.Add(this.button14);
			this.panel1.Controls.Add(this.button15);
			this.panel1.Controls.Add(this.button16);
			this.panel1.Controls.Add(this.button17);
			this.panel1.Controls.Add(this.button18);
			this.panel1.Controls.Add(this.button19);
			this.panel1.Controls.Add(this.label11);
			this.panel1.Controls.Add(this.button7);
			this.panel1.Controls.Add(this.button8);
			this.panel1.Controls.Add(this.button9);
			this.panel1.Controls.Add(this.button10);
			this.panel1.Controls.Add(this.button11);
			this.panel1.Controls.Add(this.button12);
			this.panel1.Controls.Add(this.label8);
			this.panel1.Controls.Add(this.label10);
			this.panel1.Controls.Add(this.label7);
			this.panel1.Controls.Add(this.button4);
			this.panel1.Controls.Add(this.button6);
			this.panel1.Controls.Add(this.button2);
			this.panel1.Controls.Add(this.button3);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.button5);
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label6);
			this.panel1.Location = new Point(0, 133);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(907, 459);
			this.panel1.TabIndex = 86;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label13.ForeColor = Color.Silver;
			this.label13.Location = new Point(42, 457);
			this.label13.Name = "label13";
			this.label13.Size = new Size(131, 19);
			this.label13.TabIndex = 115;
			this.label13.Text = "(Xtreme default is 26)";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label12.ForeColor = Color.White;
			this.label12.Location = new Point(23, 602);
			this.label12.Name = "label12";
			this.label12.Size = new Size(82, 30);
			this.label12.TabIndex = 114;
			this.label12.Text = "• Extras";
			this.linkLabel3.ActiveLinkColor = Color.SteelBlue;
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Font = new Font("Josefin Sans", 14.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
			this.linkLabel3.LinkColor = Color.DeepSkyBlue;
			this.linkLabel3.Location = new Point(435, 663);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new Size(151, 24);
			this.linkLabel3.TabIndex = 113;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "Get MemReduct";
			this.linkLabel3.VisitedLinkColor = Color.DeepSkyBlue;
			this.linkLabel3.LinkClicked += this.linkLabel3_LinkClicked;
			this.linkLabel2.ActiveLinkColor = Color.SteelBlue;
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Font = new Font("Josefin Sans", 14.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
			this.linkLabel2.LinkColor = Color.DeepSkyBlue;
			this.linkLabel2.Location = new Point(233, 663);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new Size(165, 24);
			this.linkLabel2.TabIndex = 112;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "Get Process Lasso";
			this.linkLabel2.VisitedLinkColor = Color.DeepSkyBlue;
			this.linkLabel2.LinkClicked += this.linkLabel2_LinkClicked;
			this.linkLabel1.ActiveLinkColor = Color.SteelBlue;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new Font("Josefin Sans", 14.25f, FontStyle.Italic, GraphicsUnit.Point, 0);
			this.linkLabel1.LinkColor = Color.DeepSkyBlue;
			this.linkLabel1.Location = new Point(42, 663);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new Size(154, 24);
			this.linkLabel1.TabIndex = 111;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Get Park Control";
			this.linkLabel1.VisitedLinkColor = Color.DeepSkyBlue;
			this.linkLabel1.LinkClicked += this.linkLabel1_LinkClicked;
			this.button20.BackColor = Color.FromArgb(38, 38, 38);
			this.button20.Cursor = Cursors.Hand;
			this.button20.FlatAppearance.BorderSize = 0;
			this.button20.FlatStyle = FlatStyle.Flat;
			this.button20.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button20.ForeColor = Color.White;
			this.button20.ImageAlign = ContentAlignment.MiddleLeft;
			this.button20.Location = new Point(610, 536);
			this.button20.Margin = new Padding(1);
			this.button20.Name = "button20";
			this.button20.Size = new Size(121, 32);
			this.button20.TabIndex = 109;
			this.button20.TabStop = false;
			this.button20.Text = "28 (Hex)";
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += this.button20_Click;
			this.button25.BackColor = Color.FromArgb(38, 38, 38);
			this.button25.Cursor = Cursors.Hand;
			this.button25.FlatAppearance.BorderSize = 0;
			this.button25.FlatStyle = FlatStyle.Flat;
			this.button25.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button25.ForeColor = Color.White;
			this.button25.ImageAlign = ContentAlignment.MiddleLeft;
			this.button25.Location = new Point(464, 536);
			this.button25.Margin = new Padding(1);
			this.button25.Name = "button25";
			this.button25.Size = new Size(121, 32);
			this.button25.TabIndex = 108;
			this.button25.TabStop = false;
			this.button25.Text = "26 (Hex)";
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += this.button25_Click;
			this.button26.BackColor = Color.FromArgb(38, 38, 38);
			this.button26.Cursor = Cursors.Hand;
			this.button26.FlatAppearance.BorderSize = 0;
			this.button26.FlatStyle = FlatStyle.Flat;
			this.button26.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button26.ForeColor = Color.White;
			this.button26.ImageAlign = ContentAlignment.MiddleLeft;
			this.button26.Location = new Point(756, 536);
			this.button26.Margin = new Padding(1);
			this.button26.Name = "button26";
			this.button26.Size = new Size(121, 32);
			this.button26.TabIndex = 107;
			this.button26.TabStop = false;
			this.button26.Text = "29 (Hex)";
			this.button26.UseVisualStyleBackColor = false;
			this.button26.Click += this.button26_Click;
			this.button27.BackColor = Color.FromArgb(38, 38, 38);
			this.button27.Cursor = Cursors.Hand;
			this.button27.FlatAppearance.BorderSize = 0;
			this.button27.FlatStyle = FlatStyle.Flat;
			this.button27.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button27.ForeColor = Color.White;
			this.button27.ImageAlign = ContentAlignment.MiddleLeft;
			this.button27.Location = new Point(318, 536);
			this.button27.Margin = new Padding(1);
			this.button27.Name = "button27";
			this.button27.Size = new Size(121, 32);
			this.button27.TabIndex = 106;
			this.button27.TabStop = false;
			this.button27.Text = "25 (Hex)";
			this.button27.UseVisualStyleBackColor = false;
			this.button27.Click += this.button27_Click;
			this.button28.BackColor = Color.FromArgb(38, 38, 38);
			this.button28.Cursor = Cursors.Hand;
			this.button28.FlatAppearance.BorderSize = 0;
			this.button28.FlatStyle = FlatStyle.Flat;
			this.button28.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button28.ForeColor = Color.White;
			this.button28.ImageAlign = ContentAlignment.MiddleLeft;
			this.button28.Location = new Point(172, 536);
			this.button28.Margin = new Padding(1);
			this.button28.Name = "button28";
			this.button28.Size = new Size(121, 32);
			this.button28.TabIndex = 105;
			this.button28.TabStop = false;
			this.button28.Text = "24 (Hex)";
			this.button28.UseVisualStyleBackColor = false;
			this.button28.Click += this.button28_Click;
			this.button29.BackColor = Color.FromArgb(38, 38, 38);
			this.button29.Cursor = Cursors.Hand;
			this.button29.FlatAppearance.BorderSize = 0;
			this.button29.FlatStyle = FlatStyle.Flat;
			this.button29.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button29.ForeColor = Color.White;
			this.button29.ImageAlign = ContentAlignment.MiddleLeft;
			this.button29.Location = new Point(26, 536);
			this.button29.Margin = new Padding(1);
			this.button29.Name = "button29";
			this.button29.Size = new Size(121, 32);
			this.button29.TabIndex = 104;
			this.button29.TabStop = false;
			this.button29.Text = "2A (Hex)";
			this.button29.UseVisualStyleBackColor = false;
			this.button29.Click += this.button29_Click;
			this.button14.BackColor = Color.FromArgb(38, 38, 38);
			this.button14.Cursor = Cursors.Hand;
			this.button14.FlatAppearance.BorderSize = 0;
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button14.ForeColor = Color.White;
			this.button14.ImageAlign = ContentAlignment.MiddleLeft;
			this.button14.Location = new Point(610, 487);
			this.button14.Margin = new Padding(1);
			this.button14.Name = "button14";
			this.button14.Size = new Size(121, 32);
			this.button14.TabIndex = 103;
			this.button14.TabStop = false;
			this.button14.Text = "18 (Hex)";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += this.button14_Click;
			this.button15.BackColor = Color.FromArgb(38, 38, 38);
			this.button15.Cursor = Cursors.Hand;
			this.button15.FlatAppearance.BorderSize = 0;
			this.button15.FlatStyle = FlatStyle.Flat;
			this.button15.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button15.ForeColor = Color.White;
			this.button15.ImageAlign = ContentAlignment.MiddleLeft;
			this.button15.Location = new Point(464, 487);
			this.button15.Margin = new Padding(1);
			this.button15.Name = "button15";
			this.button15.Size = new Size(121, 32);
			this.button15.TabIndex = 102;
			this.button15.TabStop = false;
			this.button15.Text = "16 (Hex)";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += this.button15_Click;
			this.button16.BackColor = Color.FromArgb(38, 38, 38);
			this.button16.Cursor = Cursors.Hand;
			this.button16.FlatAppearance.BorderSize = 0;
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button16.ForeColor = Color.White;
			this.button16.ImageAlign = ContentAlignment.MiddleLeft;
			this.button16.Location = new Point(756, 487);
			this.button16.Margin = new Padding(1);
			this.button16.Name = "button16";
			this.button16.Size = new Size(121, 32);
			this.button16.TabIndex = 101;
			this.button16.TabStop = false;
			this.button16.Text = "19 (Hex)";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += this.button16_Click;
			this.button17.BackColor = Color.FromArgb(38, 38, 38);
			this.button17.Cursor = Cursors.Hand;
			this.button17.FlatAppearance.BorderSize = 0;
			this.button17.FlatStyle = FlatStyle.Flat;
			this.button17.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button17.ForeColor = Color.White;
			this.button17.ImageAlign = ContentAlignment.MiddleLeft;
			this.button17.Location = new Point(318, 487);
			this.button17.Margin = new Padding(1);
			this.button17.Name = "button17";
			this.button17.Size = new Size(121, 32);
			this.button17.TabIndex = 100;
			this.button17.TabStop = false;
			this.button17.Text = "15 (Hex)";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += this.button17_Click;
			this.button18.BackColor = Color.FromArgb(38, 38, 38);
			this.button18.Cursor = Cursors.Hand;
			this.button18.FlatAppearance.BorderSize = 0;
			this.button18.FlatStyle = FlatStyle.Flat;
			this.button18.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button18.ForeColor = Color.White;
			this.button18.ImageAlign = ContentAlignment.MiddleLeft;
			this.button18.Location = new Point(172, 487);
			this.button18.Margin = new Padding(1);
			this.button18.Name = "button18";
			this.button18.Size = new Size(121, 32);
			this.button18.TabIndex = 99;
			this.button18.TabStop = false;
			this.button18.Text = "14 (Hex)";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += this.button18_Click;
			this.button19.BackColor = Color.FromArgb(38, 38, 38);
			this.button19.Cursor = Cursors.Hand;
			this.button19.FlatAppearance.BorderSize = 0;
			this.button19.FlatStyle = FlatStyle.Flat;
			this.button19.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button19.ForeColor = Color.White;
			this.button19.ImageAlign = ContentAlignment.MiddleLeft;
			this.button19.Location = new Point(26, 487);
			this.button19.Margin = new Padding(1);
			this.button19.Name = "button19";
			this.button19.Size = new Size(121, 32);
			this.button19.TabIndex = 98;
			this.button19.TabStop = false;
			this.button19.Text = "1A (Hex)";
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += this.button19_Click;
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(23, 427);
			this.label11.Name = "label11";
			this.label11.Size = new Size(250, 30);
			this.label11.TabIndex = 97;
			this.label11.Text = "• Win32 Priority Separation";
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(611, 358);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(121, 32);
			this.button7.TabIndex = 95;
			this.button7.TabStop = false;
			this.button7.Text = "16GB RAM";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(465, 358);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(121, 32);
			this.button8.TabIndex = 94;
			this.button8.TabStop = false;
			this.button8.Text = "12GB RAM";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button9.BackColor = Color.FromArgb(38, 38, 38);
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button9.ForeColor = Color.White;
			this.button9.ImageAlign = ContentAlignment.MiddleLeft;
			this.button9.Location = new Point(757, 358);
			this.button9.Margin = new Padding(1);
			this.button9.Name = "button9";
			this.button9.Size = new Size(121, 32);
			this.button9.TabIndex = 93;
			this.button9.TabStop = false;
			this.button9.Text = "32GB RAM";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.button10.BackColor = Color.FromArgb(38, 38, 38);
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(319, 358);
			this.button10.Margin = new Padding(1);
			this.button10.Name = "button10";
			this.button10.Size = new Size(121, 32);
			this.button10.TabIndex = 92;
			this.button10.TabStop = false;
			this.button10.Text = "8GB RAM";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click;
			this.button11.BackColor = Color.FromArgb(38, 38, 38);
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.ImageAlign = ContentAlignment.MiddleLeft;
			this.button11.Location = new Point(173, 358);
			this.button11.Margin = new Padding(1);
			this.button11.Name = "button11";
			this.button11.Size = new Size(121, 32);
			this.button11.TabIndex = 91;
			this.button11.TabStop = false;
			this.button11.Text = "6GB RAM";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += this.button11_Click;
			this.button12.BackColor = Color.FromArgb(38, 38, 38);
			this.button12.Cursor = Cursors.Hand;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button12.ForeColor = Color.White;
			this.button12.ImageAlign = ContentAlignment.MiddleLeft;
			this.button12.Location = new Point(27, 358);
			this.button12.Margin = new Padding(1);
			this.button12.Name = "button12";
			this.button12.Size = new Size(121, 32);
			this.button12.TabIndex = 90;
			this.button12.TabStop = false;
			this.button12.Text = "4GB RAM";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += this.button12_Click;
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(21, 305);
			this.label8.Name = "label8";
			this.label8.Size = new Size(191, 30);
			this.label8.TabIndex = 89;
			this.label8.Text = "• RAM Optimization";
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Gill Sans MT", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.Silver;
			this.label10.Location = new Point(25, 205);
			this.label10.Name = "label10";
			this.label10.Size = new Size(862, 18);
			this.label10.TabIndex = 88;
			this.label10.Text = "__________________________________________________________________________________________________________________________";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans", 16f, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(21, 244);
			this.label7.Name = "label7";
			this.label7.Size = new Size(149, 28);
			this.label7.TabIndex = 63;
			this.label7.Text = "Miscellaneous";
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(581, 159);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(121, 32);
			this.button4.TabIndex = 62;
			this.button4.TabStop = false;
			this.button4.Text = "Revert";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(435, 159);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(121, 32);
			this.button6.TabIndex = 61;
			this.button6.TabStop = false;
			this.button6.Text = "Apply";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(581, 114);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(121, 32);
			this.button2.TabIndex = 60;
			this.button2.TabStop = false;
			this.button2.Text = "Revert";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(435, 114);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(121, 32);
			this.button3.TabIndex = 59;
			this.button3.TabStop = false;
			this.button3.Text = "Apply";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(581, 69);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 32);
			this.button1.TabIndex = 58;
			this.button1.TabStop = false;
			this.button1.Text = "Revert";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(435, 69);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(121, 32);
			this.button5.TabIndex = 57;
			this.button5.TabStop = false;
			this.button5.Text = "Apply";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(22, 113);
			this.label5.Name = "label5";
			this.label5.Size = new Size(148, 30);
			this.label5.TabIndex = 9;
			this.label5.Text = "Latency Tweaks";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(23, 68);
			this.label4.Name = "label4";
			this.label4.Size = new Size(178, 30);
			this.label4.TabIndex = 8;
			this.label4.Text = "CPU Optimizations";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans", 16f, FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(23, 13);
			this.label3.Name = "label3";
			this.label3.Size = new Size(156, 28);
			this.label3.TabIndex = 7;
			this.label3.Text = "Recommended";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans", 14f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(22, 158);
			this.label6.Name = "label6";
			this.label6.Size = new Size(212, 30);
			this.label6.TabIndex = 6;
			this.label6.Text = "Network Optimizations";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.label1);
			base.Name = "gaming";
			base.Size = new Size(918, 664);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400021E RID: 542
		private static gaming _instace;

		// Token: 0x0400021F RID: 543
		private IContainer components = null;

		// Token: 0x04000220 RID: 544
		private Label label1;

		// Token: 0x04000221 RID: 545
		private Button button21;

		// Token: 0x04000222 RID: 546
		private Button button22;

		// Token: 0x04000223 RID: 547
		private Button button23;

		// Token: 0x04000224 RID: 548
		private Button button24;

		// Token: 0x04000225 RID: 549
		private Label label9;

		// Token: 0x04000226 RID: 550
		private Label label2;

		// Token: 0x04000227 RID: 551
		private Panel panel1;

		// Token: 0x04000228 RID: 552
		private Label label6;

		// Token: 0x04000229 RID: 553
		private Label label3;

		// Token: 0x0400022A RID: 554
		private Label label4;

		// Token: 0x0400022B RID: 555
		private Label label5;

		// Token: 0x0400022C RID: 556
		private Button button5;

		// Token: 0x0400022D RID: 557
		private Button button1;

		// Token: 0x0400022E RID: 558
		private Button button4;

		// Token: 0x0400022F RID: 559
		private Button button6;

		// Token: 0x04000230 RID: 560
		private Button button2;

		// Token: 0x04000231 RID: 561
		private Button button3;

		// Token: 0x04000232 RID: 562
		private Label label7;

		// Token: 0x04000233 RID: 563
		private Label label10;

		// Token: 0x04000234 RID: 564
		private Label label8;

		// Token: 0x04000235 RID: 565
		private Button button7;

		// Token: 0x04000236 RID: 566
		private Button button8;

		// Token: 0x04000237 RID: 567
		private Button button9;

		// Token: 0x04000238 RID: 568
		private Button button10;

		// Token: 0x04000239 RID: 569
		private Button button11;

		// Token: 0x0400023A RID: 570
		private Button button12;

		// Token: 0x0400023B RID: 571
		private Label label11;

		// Token: 0x0400023C RID: 572
		private Button button14;

		// Token: 0x0400023D RID: 573
		private Button button15;

		// Token: 0x0400023E RID: 574
		private Button button16;

		// Token: 0x0400023F RID: 575
		private Button button17;

		// Token: 0x04000240 RID: 576
		private Button button18;

		// Token: 0x04000241 RID: 577
		private Button button19;

		// Token: 0x04000242 RID: 578
		private Button button20;

		// Token: 0x04000243 RID: 579
		private Button button25;

		// Token: 0x04000244 RID: 580
		private Button button26;

		// Token: 0x04000245 RID: 581
		private Button button27;

		// Token: 0x04000246 RID: 582
		private Button button28;

		// Token: 0x04000247 RID: 583
		private Button button29;

		// Token: 0x04000248 RID: 584
		private LinkLabel linkLabel1;

		// Token: 0x04000249 RID: 585
		private LinkLabel linkLabel2;

		// Token: 0x0400024A RID: 586
		private LinkLabel linkLabel3;

		// Token: 0x0400024B RID: 587
		private Label label12;

		// Token: 0x0400024C RID: 588
		private Label label13;
	}
}
