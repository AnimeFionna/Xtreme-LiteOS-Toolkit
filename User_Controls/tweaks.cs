using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;
using WindowsFormsApplication2.Classes;

namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000F RID: 15
	public class tweaks : UserControl
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0002BA3C File Offset: 0x00029C3C
		public static tweaks Instance
		{
			get
			{
				bool flag = tweaks._instace == null;
				if (flag)
				{
					tweaks._instace = new tweaks();
				}
				return tweaks._instace;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0002BA69 File Offset: 0x00029C69
		public tweaks()
		{
			this.InitializeComponent();
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0002BA84 File Offset: 0x00029C84
		private void button5_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0002BAD8 File Offset: 0x00029CD8
		private void button11_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Policies\\Microsoft\\Windows\\Explorer", "DisableNotificationCenter", 1, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0002BB2C File Offset: 0x00029D2C
		private void button1_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\CLIP.reg");
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0002BB78 File Offset: 0x00029D78
		private void button12_Click(object sender, EventArgs e)
		{
			Process.Start("regedit.exe", "/s C:\\Windows\\System32\\lv-LV\\RCLIP.reg");
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0002BBC4 File Offset: 0x00029DC4
		private void button2_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 1, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Search", "SearchboxTaskbar", 1, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0002BC30 File Offset: 0x00029E30
		private void button13_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Windows Search", "AllowCortana", 0, RegistryValueKind.DWord);
			Registry.SetValue("HKEY_CURRENT_USER\\Software\\Microsoft\\Windows\\CurrentVersion\\Search", "SearchboxTaskbar", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0002BC9C File Offset: 0x00029E9C
		private void button3_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe powercfg -hibernate on"
				}
			}.Start();
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", 1, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0002BD2C File Offset: 0x00029F2C
		private void button14_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Control\\Session Manager\\Power", "HiberbootEnabled", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0002BD80 File Offset: 0x00029F80
		private void button4_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe powercfg -hibernate on"
				}
			}.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0002BDF8 File Offset: 0x00029FF8
		private void button15_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe powercfg -hibernate off"
				}
			}.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0002BE70 File Offset: 0x0002A070
		private void button6_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe bcdedit /set useplatformclock true"
				}
			}.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0002BEE8 File Offset: 0x0002A0E8
		private void button16_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe bcdedit /deletevalue useplatformclock"
				}
			}.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0002BF60 File Offset: 0x0002A160
		private void button7_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", 1, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0002BFB4 File Offset: 0x0002A1B4
		private void button17_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Policies\\Microsoft\\Windows\\Personalization", "NoLockScreen", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0002C008 File Offset: 0x0002A208
		private void button8_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 2, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0002C05C File Offset: 0x0002A25C
		private void button18_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SYSTEM\\CurrentControlSet\\Services\\Spooler", "Start", 4, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0002C0B0 File Offset: 0x0002A2B0
		private void button9_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "ValidateAdminCodeSignatures", 1, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0002C104 File Offset: 0x0002A304
		private void button19_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "ValidateAdminCodeSignatures", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0002C158 File Offset: 0x0002A358
		private void button10_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 1, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0002C1AC File Offset: 0x0002A3AC
		private void button20_Click(object sender, EventArgs e)
		{
			Registry.SetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Policies\\System", "EnableLUA", 0, RegistryValueKind.DWord);
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x0600012E RID: 302 RVA: 0x000020A1 File Offset: 0x000002A1
		private void button23_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.paypal.com/paypalme/supportme7147");
		}

		// Token: 0x0600012F RID: 303 RVA: 0x000020AF File Offset: 0x000002AF
		private void button22_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.instagram.com/theworldofpc.yt");
		}

		// Token: 0x06000130 RID: 304 RVA: 0x000020BD File Offset: 0x000002BD
		private void button24_Click_1(object sender, EventArgs e)
		{
			Process.Start("https://www.youtube.com/theworldofpc");
		}

		// Token: 0x06000131 RID: 305 RVA: 0x00002370 File Offset: 0x00000570
		private void button21_Click(object sender, EventArgs e)
		{
			Process.Start("https://www.theworldofpc.tk/discord");
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0002C200 File Offset: 0x0002A400
		private void button26_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe net user administrator /active:yes"
				}
			}.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0002C278 File Offset: 0x0002A478
		private void button25_Click(object sender, EventArgs e)
		{
			new Process
			{
				StartInfo = new ProcessStartInfo
				{
					WindowStyle = ProcessWindowStyle.Hidden,
					FileName = "cmd.exe",
					Arguments = "/C cmd.exe net user administrator /active:no"
				}
			}.Start();
			using (applied applied = new applied())
			{
				applied.ShowDialog(this);
			}
		}

		// Token: 0x06000134 RID: 308 RVA: 0x0002C2F0 File Offset: 0x0002A4F0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x0002C328 File Offset: 0x0002A528
		private void InitializeComponent()
		{
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(tweaks));
			this.label1 = new Label();
			this.label9 = new Label();
			this.label3 = new Label();
			this.label2 = new Label();
			this.label4 = new Label();
			this.label5 = new Label();
			this.label6 = new Label();
			this.label7 = new Label();
			this.label8 = new Label();
			this.label10 = new Label();
			this.label11 = new Label();
			this.label12 = new Label();
			this.button5 = new Button();
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
			this.button15 = new Button();
			this.button16 = new Button();
			this.button17 = new Button();
			this.button18 = new Button();
			this.button19 = new Button();
			this.button20 = new Button();
			this.button21 = new Button();
			this.button22 = new Button();
			this.button23 = new Button();
			this.button24 = new Button();
			this.button25 = new Button();
			this.button26 = new Button();
			this.label13 = new Label();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new Font("Josefin Sans SemiBold", 25f, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
			this.label1.ForeColor = Color.White;
			this.label1.Location = new Point(18, 13);
			this.label1.Name = "label1";
			this.label1.Size = new Size(136, 53);
			this.label1.TabIndex = 1;
			this.label1.Text = "Tweaks";
			this.label9.AutoSize = true;
			this.label9.Font = new Font("Josefin Sans", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.label9.ForeColor = Color.Silver;
			this.label9.Location = new Point(23, 75);
			this.label9.Name = "label9";
			this.label9.Size = new Size(355, 19);
			this.label9.TabIndex = 45;
			this.label9.Text = "Enable/Disable Windows feature and configure hidden settings";
			this.label3.AutoSize = true;
			this.label3.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label3.ForeColor = Color.White;
			this.label3.Location = new Point(23, 167);
			this.label3.Name = "label3";
			this.label3.Size = new Size(133, 30);
			this.label3.TabIndex = 46;
			this.label3.Text = "Action Center";
			this.label2.AutoSize = true;
			this.label2.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label2.ForeColor = Color.White;
			this.label2.Location = new Point(23, 209);
			this.label2.Name = "label2";
			this.label2.Size = new Size(101, 30);
			this.label2.TabIndex = 47;
			this.label2.Text = "Clipboard";
			this.label4.AutoSize = true;
			this.label4.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label4.ForeColor = Color.White;
			this.label4.Location = new Point(23, 293);
			this.label4.Name = "label4";
			this.label4.Size = new Size(121, 30);
			this.label4.TabIndex = 48;
			this.label4.Text = "Fast Startup";
			this.label5.AutoSize = true;
			this.label5.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label5.ForeColor = Color.White;
			this.label5.Location = new Point(23, 377);
			this.label5.Name = "label5";
			this.label5.Size = new Size(325, 30);
			this.label5.TabIndex = 49;
			this.label5.Text = "High Precision Event Timer (HPET)";
			this.label6.AutoSize = true;
			this.label6.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label6.ForeColor = Color.White;
			this.label6.Location = new Point(23, 335);
			this.label6.Name = "label6";
			this.label6.Size = new Size(118, 30);
			this.label6.TabIndex = 50;
			this.label6.Text = "Hibernation";
			this.label7.AutoSize = true;
			this.label7.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label7.ForeColor = Color.White;
			this.label7.Location = new Point(22, 419);
			this.label7.Name = "label7";
			this.label7.Size = new Size(119, 30);
			this.label7.TabIndex = 51;
			this.label7.Text = "Lock Screen";
			this.label8.AutoSize = true;
			this.label8.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label8.ForeColor = Color.White;
			this.label8.Location = new Point(22, 461);
			this.label8.Name = "label8";
			this.label8.Size = new Size(128, 30);
			this.label8.TabIndex = 52;
			this.label8.Text = "Print Spooler";
			this.label10.AutoSize = true;
			this.label10.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label10.ForeColor = Color.White;
			this.label10.Location = new Point(23, 251);
			this.label10.Name = "label10";
			this.label10.Size = new Size(201, 30);
			this.label10.TabIndex = 53;
			this.label10.Text = "Cortana (Search Bar)";
			this.label11.AutoSize = true;
			this.label11.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label11.ForeColor = Color.White;
			this.label11.Location = new Point(22, 545);
			this.label11.Name = "label11";
			this.label11.Size = new Size(261, 30);
			this.label11.TabIndex = 54;
			this.label11.Text = "User Account Control (UAC)";
			this.label12.AutoSize = true;
			this.label12.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label12.ForeColor = Color.White;
			this.label12.Location = new Point(22, 503);
			this.label12.Name = "label12";
			this.label12.Size = new Size(226, 30);
			this.label12.TabIndex = 55;
			this.label12.Text = "UAC For Admin Account";
			this.button5.BackColor = Color.FromArgb(38, 38, 38);
			this.button5.Cursor = Cursors.Hand;
			this.button5.FlatAppearance.BorderSize = 0;
			this.button5.FlatStyle = FlatStyle.Flat;
			this.button5.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button5.ForeColor = Color.White;
			this.button5.ImageAlign = ContentAlignment.MiddleLeft;
			this.button5.Location = new Point(422, 168);
			this.button5.Margin = new Padding(1);
			this.button5.Name = "button5";
			this.button5.Size = new Size(121, 32);
			this.button5.TabIndex = 56;
			this.button5.TabStop = false;
			this.button5.Text = "Enable";
			this.button5.UseVisualStyleBackColor = false;
			this.button5.Click += this.button5_Click;
			this.button1.BackColor = Color.FromArgb(38, 38, 38);
			this.button1.Cursor = Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = FlatStyle.Flat;
			this.button1.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button1.ForeColor = Color.White;
			this.button1.ImageAlign = ContentAlignment.MiddleLeft;
			this.button1.Location = new Point(422, 210);
			this.button1.Margin = new Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new Size(121, 32);
			this.button1.TabIndex = 57;
			this.button1.TabStop = false;
			this.button1.Text = "Enable";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += this.button1_Click;
			this.button2.BackColor = Color.FromArgb(38, 38, 38);
			this.button2.Cursor = Cursors.Hand;
			this.button2.FlatAppearance.BorderSize = 0;
			this.button2.FlatStyle = FlatStyle.Flat;
			this.button2.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button2.ForeColor = Color.White;
			this.button2.ImageAlign = ContentAlignment.MiddleLeft;
			this.button2.Location = new Point(422, 252);
			this.button2.Margin = new Padding(1);
			this.button2.Name = "button2";
			this.button2.Size = new Size(121, 32);
			this.button2.TabIndex = 58;
			this.button2.TabStop = false;
			this.button2.Text = "Enable";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += this.button2_Click;
			this.button3.BackColor = Color.FromArgb(38, 38, 38);
			this.button3.Cursor = Cursors.Hand;
			this.button3.FlatAppearance.BorderSize = 0;
			this.button3.FlatStyle = FlatStyle.Flat;
			this.button3.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button3.ForeColor = Color.White;
			this.button3.ImageAlign = ContentAlignment.MiddleLeft;
			this.button3.Location = new Point(422, 294);
			this.button3.Margin = new Padding(1);
			this.button3.Name = "button3";
			this.button3.Size = new Size(121, 32);
			this.button3.TabIndex = 59;
			this.button3.TabStop = false;
			this.button3.Text = "Enable";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += this.button3_Click;
			this.button4.BackColor = Color.FromArgb(38, 38, 38);
			this.button4.Cursor = Cursors.Hand;
			this.button4.FlatAppearance.BorderSize = 0;
			this.button4.FlatStyle = FlatStyle.Flat;
			this.button4.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button4.ForeColor = Color.White;
			this.button4.ImageAlign = ContentAlignment.MiddleLeft;
			this.button4.Location = new Point(422, 336);
			this.button4.Margin = new Padding(1);
			this.button4.Name = "button4";
			this.button4.Size = new Size(121, 32);
			this.button4.TabIndex = 60;
			this.button4.TabStop = false;
			this.button4.Text = "Enable";
			this.button4.UseVisualStyleBackColor = false;
			this.button4.Click += this.button4_Click;
			this.button6.BackColor = Color.FromArgb(38, 38, 38);
			this.button6.Cursor = Cursors.Hand;
			this.button6.FlatAppearance.BorderSize = 0;
			this.button6.FlatStyle = FlatStyle.Flat;
			this.button6.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button6.ForeColor = Color.White;
			this.button6.ImageAlign = ContentAlignment.MiddleLeft;
			this.button6.Location = new Point(422, 378);
			this.button6.Margin = new Padding(1);
			this.button6.Name = "button6";
			this.button6.Size = new Size(121, 32);
			this.button6.TabIndex = 61;
			this.button6.TabStop = false;
			this.button6.Text = "Enable";
			this.button6.UseVisualStyleBackColor = false;
			this.button6.Click += this.button6_Click;
			this.button7.BackColor = Color.FromArgb(38, 38, 38);
			this.button7.Cursor = Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = FlatStyle.Flat;
			this.button7.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button7.ForeColor = Color.White;
			this.button7.ImageAlign = ContentAlignment.MiddleLeft;
			this.button7.Location = new Point(422, 420);
			this.button7.Margin = new Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new Size(121, 32);
			this.button7.TabIndex = 62;
			this.button7.TabStop = false;
			this.button7.Text = "Enable";
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += this.button7_Click;
			this.button8.BackColor = Color.FromArgb(38, 38, 38);
			this.button8.Cursor = Cursors.Hand;
			this.button8.FlatAppearance.BorderSize = 0;
			this.button8.FlatStyle = FlatStyle.Flat;
			this.button8.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button8.ForeColor = Color.White;
			this.button8.ImageAlign = ContentAlignment.MiddleLeft;
			this.button8.Location = new Point(421, 462);
			this.button8.Margin = new Padding(1);
			this.button8.Name = "button8";
			this.button8.Size = new Size(121, 32);
			this.button8.TabIndex = 63;
			this.button8.TabStop = false;
			this.button8.Text = "Enable";
			this.button8.UseVisualStyleBackColor = false;
			this.button8.Click += this.button8_Click;
			this.button9.BackColor = Color.FromArgb(38, 38, 38);
			this.button9.Cursor = Cursors.Hand;
			this.button9.FlatAppearance.BorderSize = 0;
			this.button9.FlatStyle = FlatStyle.Flat;
			this.button9.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button9.ForeColor = Color.White;
			this.button9.ImageAlign = ContentAlignment.MiddleLeft;
			this.button9.Location = new Point(421, 504);
			this.button9.Margin = new Padding(1);
			this.button9.Name = "button9";
			this.button9.Size = new Size(121, 32);
			this.button9.TabIndex = 64;
			this.button9.TabStop = false;
			this.button9.Text = "Enable";
			this.button9.UseVisualStyleBackColor = false;
			this.button9.Click += this.button9_Click;
			this.button10.BackColor = Color.FromArgb(38, 38, 38);
			this.button10.Cursor = Cursors.Hand;
			this.button10.FlatAppearance.BorderSize = 0;
			this.button10.FlatStyle = FlatStyle.Flat;
			this.button10.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button10.ForeColor = Color.White;
			this.button10.ImageAlign = ContentAlignment.MiddleLeft;
			this.button10.Location = new Point(421, 546);
			this.button10.Margin = new Padding(1);
			this.button10.Name = "button10";
			this.button10.Size = new Size(121, 32);
			this.button10.TabIndex = 65;
			this.button10.TabStop = false;
			this.button10.Text = "Enable";
			this.button10.UseVisualStyleBackColor = false;
			this.button10.Click += this.button10_Click;
			this.button11.BackColor = Color.FromArgb(38, 38, 38);
			this.button11.Cursor = Cursors.Hand;
			this.button11.FlatAppearance.BorderSize = 0;
			this.button11.FlatStyle = FlatStyle.Flat;
			this.button11.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button11.ForeColor = Color.White;
			this.button11.ImageAlign = ContentAlignment.MiddleLeft;
			this.button11.Location = new Point(599, 168);
			this.button11.Margin = new Padding(1);
			this.button11.Name = "button11";
			this.button11.Size = new Size(121, 32);
			this.button11.TabIndex = 66;
			this.button11.TabStop = false;
			this.button11.Text = "Disable";
			this.button11.UseVisualStyleBackColor = false;
			this.button11.Click += this.button11_Click;
			this.button12.BackColor = Color.FromArgb(38, 38, 38);
			this.button12.Cursor = Cursors.Hand;
			this.button12.FlatAppearance.BorderSize = 0;
			this.button12.FlatStyle = FlatStyle.Flat;
			this.button12.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button12.ForeColor = Color.White;
			this.button12.ImageAlign = ContentAlignment.MiddleLeft;
			this.button12.Location = new Point(599, 210);
			this.button12.Margin = new Padding(1);
			this.button12.Name = "button12";
			this.button12.Size = new Size(121, 32);
			this.button12.TabIndex = 67;
			this.button12.TabStop = false;
			this.button12.Text = "Disable";
			this.button12.UseVisualStyleBackColor = false;
			this.button12.Click += this.button12_Click;
			this.button13.BackColor = Color.FromArgb(38, 38, 38);
			this.button13.Cursor = Cursors.Hand;
			this.button13.FlatAppearance.BorderSize = 0;
			this.button13.FlatStyle = FlatStyle.Flat;
			this.button13.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button13.ForeColor = Color.White;
			this.button13.ImageAlign = ContentAlignment.MiddleLeft;
			this.button13.Location = new Point(599, 252);
			this.button13.Margin = new Padding(1);
			this.button13.Name = "button13";
			this.button13.Size = new Size(121, 32);
			this.button13.TabIndex = 68;
			this.button13.TabStop = false;
			this.button13.Text = "Disable";
			this.button13.UseVisualStyleBackColor = false;
			this.button13.Click += this.button13_Click;
			this.button14.BackColor = Color.FromArgb(38, 38, 38);
			this.button14.Cursor = Cursors.Hand;
			this.button14.FlatAppearance.BorderSize = 0;
			this.button14.FlatStyle = FlatStyle.Flat;
			this.button14.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button14.ForeColor = Color.White;
			this.button14.ImageAlign = ContentAlignment.MiddleLeft;
			this.button14.Location = new Point(599, 294);
			this.button14.Margin = new Padding(1);
			this.button14.Name = "button14";
			this.button14.Size = new Size(121, 32);
			this.button14.TabIndex = 69;
			this.button14.TabStop = false;
			this.button14.Text = "Disable";
			this.button14.UseVisualStyleBackColor = false;
			this.button14.Click += this.button14_Click;
			this.button15.BackColor = Color.FromArgb(38, 38, 38);
			this.button15.Cursor = Cursors.Hand;
			this.button15.FlatAppearance.BorderSize = 0;
			this.button15.FlatStyle = FlatStyle.Flat;
			this.button15.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button15.ForeColor = Color.White;
			this.button15.ImageAlign = ContentAlignment.MiddleLeft;
			this.button15.Location = new Point(599, 336);
			this.button15.Margin = new Padding(1);
			this.button15.Name = "button15";
			this.button15.Size = new Size(121, 32);
			this.button15.TabIndex = 70;
			this.button15.TabStop = false;
			this.button15.Text = "Disable";
			this.button15.UseVisualStyleBackColor = false;
			this.button15.Click += this.button15_Click;
			this.button16.BackColor = Color.FromArgb(38, 38, 38);
			this.button16.Cursor = Cursors.Hand;
			this.button16.FlatAppearance.BorderSize = 0;
			this.button16.FlatStyle = FlatStyle.Flat;
			this.button16.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button16.ForeColor = Color.White;
			this.button16.ImageAlign = ContentAlignment.MiddleLeft;
			this.button16.Location = new Point(599, 378);
			this.button16.Margin = new Padding(1);
			this.button16.Name = "button16";
			this.button16.Size = new Size(121, 32);
			this.button16.TabIndex = 71;
			this.button16.TabStop = false;
			this.button16.Text = "Disable";
			this.button16.UseVisualStyleBackColor = false;
			this.button16.Click += this.button16_Click;
			this.button17.BackColor = Color.FromArgb(38, 38, 38);
			this.button17.Cursor = Cursors.Hand;
			this.button17.FlatAppearance.BorderSize = 0;
			this.button17.FlatStyle = FlatStyle.Flat;
			this.button17.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button17.ForeColor = Color.White;
			this.button17.ImageAlign = ContentAlignment.MiddleLeft;
			this.button17.Location = new Point(599, 420);
			this.button17.Margin = new Padding(1);
			this.button17.Name = "button17";
			this.button17.Size = new Size(121, 32);
			this.button17.TabIndex = 72;
			this.button17.TabStop = false;
			this.button17.Text = "Disable";
			this.button17.UseVisualStyleBackColor = false;
			this.button17.Click += this.button17_Click;
			this.button18.BackColor = Color.FromArgb(38, 38, 38);
			this.button18.Cursor = Cursors.Hand;
			this.button18.FlatAppearance.BorderSize = 0;
			this.button18.FlatStyle = FlatStyle.Flat;
			this.button18.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button18.ForeColor = Color.White;
			this.button18.ImageAlign = ContentAlignment.MiddleLeft;
			this.button18.Location = new Point(598, 462);
			this.button18.Margin = new Padding(1);
			this.button18.Name = "button18";
			this.button18.Size = new Size(121, 32);
			this.button18.TabIndex = 73;
			this.button18.TabStop = false;
			this.button18.Text = "Disable";
			this.button18.UseVisualStyleBackColor = false;
			this.button18.Click += this.button18_Click;
			this.button19.BackColor = Color.FromArgb(38, 38, 38);
			this.button19.Cursor = Cursors.Hand;
			this.button19.FlatAppearance.BorderSize = 0;
			this.button19.FlatStyle = FlatStyle.Flat;
			this.button19.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button19.ForeColor = Color.White;
			this.button19.ImageAlign = ContentAlignment.MiddleLeft;
			this.button19.Location = new Point(598, 504);
			this.button19.Margin = new Padding(1);
			this.button19.Name = "button19";
			this.button19.Size = new Size(121, 32);
			this.button19.TabIndex = 74;
			this.button19.TabStop = false;
			this.button19.Text = "Disable";
			this.button19.UseVisualStyleBackColor = false;
			this.button19.Click += this.button19_Click;
			this.button20.BackColor = Color.FromArgb(38, 38, 38);
			this.button20.Cursor = Cursors.Hand;
			this.button20.FlatAppearance.BorderSize = 0;
			this.button20.FlatStyle = FlatStyle.Flat;
			this.button20.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button20.ForeColor = Color.White;
			this.button20.ImageAlign = ContentAlignment.MiddleLeft;
			this.button20.Location = new Point(598, 546);
			this.button20.Margin = new Padding(1);
			this.button20.Name = "button20";
			this.button20.Size = new Size(121, 32);
			this.button20.TabIndex = 75;
			this.button20.TabStop = false;
			this.button20.Text = "Disable";
			this.button20.UseVisualStyleBackColor = false;
			this.button20.Click += this.button20_Click;
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
			this.button21.TabIndex = 79;
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
			this.button22.TabIndex = 78;
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
			this.button23.TabIndex = 77;
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
			this.button24.TabIndex = 76;
			this.button24.TabStop = false;
			this.button24.UseVisualStyleBackColor = false;
			this.button24.Click += this.button24_Click_1;
			this.button25.BackColor = Color.FromArgb(38, 38, 38);
			this.button25.Cursor = Cursors.Hand;
			this.button25.FlatAppearance.BorderSize = 0;
			this.button25.FlatStyle = FlatStyle.Flat;
			this.button25.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button25.ForeColor = Color.White;
			this.button25.ImageAlign = ContentAlignment.MiddleLeft;
			this.button25.Location = new Point(599, 126);
			this.button25.Margin = new Padding(1);
			this.button25.Name = "button25";
			this.button25.Size = new Size(121, 32);
			this.button25.TabIndex = 82;
			this.button25.TabStop = false;
			this.button25.Text = "Disable";
			this.button25.UseVisualStyleBackColor = false;
			this.button25.Click += this.button25_Click;
			this.button26.BackColor = Color.FromArgb(38, 38, 38);
			this.button26.Cursor = Cursors.Hand;
			this.button26.FlatAppearance.BorderSize = 0;
			this.button26.FlatStyle = FlatStyle.Flat;
			this.button26.Font = new Font("Josefin Sans SemiBold", 11.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.button26.ForeColor = Color.White;
			this.button26.ImageAlign = ContentAlignment.MiddleLeft;
			this.button26.Location = new Point(422, 126);
			this.button26.Margin = new Padding(1);
			this.button26.Name = "button26";
			this.button26.Size = new Size(121, 32);
			this.button26.TabIndex = 81;
			this.button26.TabStop = false;
			this.button26.Text = "Enable";
			this.button26.UseVisualStyleBackColor = false;
			this.button26.Click += this.button26_Click;
			this.label13.AutoSize = true;
			this.label13.Font = new Font("Josefin Sans SemiBold", 14.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.label13.ForeColor = Color.White;
			this.label13.Location = new Point(23, 125);
			this.label13.Name = "label13";
			this.label13.Size = new Size(210, 30);
			this.label13.TabIndex = 80;
			this.label13.Text = "Administrator Account";
			base.AutoScaleDimensions = new SizeF(6f, 13f);
			base.AutoScaleMode = AutoScaleMode.Font;
			this.BackColor = Color.FromArgb(38, 38, 38);
			base.Controls.Add(this.button25);
			base.Controls.Add(this.button26);
			base.Controls.Add(this.label13);
			base.Controls.Add(this.button21);
			base.Controls.Add(this.button22);
			base.Controls.Add(this.button23);
			base.Controls.Add(this.button24);
			base.Controls.Add(this.button20);
			base.Controls.Add(this.button19);
			base.Controls.Add(this.button18);
			base.Controls.Add(this.button17);
			base.Controls.Add(this.button16);
			base.Controls.Add(this.button15);
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
			base.Controls.Add(this.button5);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.label1);
			base.Name = "tweaks";
			base.Size = new Size(918, 664);
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000271 RID: 625
		private static tweaks _instace;

		// Token: 0x04000272 RID: 626
		private IContainer components = null;

		// Token: 0x04000273 RID: 627
		private Label label1;

		// Token: 0x04000274 RID: 628
		private Label label9;

		// Token: 0x04000275 RID: 629
		private Label label3;

		// Token: 0x04000276 RID: 630
		private Label label2;

		// Token: 0x04000277 RID: 631
		private Label label4;

		// Token: 0x04000278 RID: 632
		private Label label5;

		// Token: 0x04000279 RID: 633
		private Label label6;

		// Token: 0x0400027A RID: 634
		private Label label7;

		// Token: 0x0400027B RID: 635
		private Label label8;

		// Token: 0x0400027C RID: 636
		private Label label10;

		// Token: 0x0400027D RID: 637
		private Label label11;

		// Token: 0x0400027E RID: 638
		private Label label12;

		// Token: 0x0400027F RID: 639
		private Button button5;

		// Token: 0x04000280 RID: 640
		private Button button1;

		// Token: 0x04000281 RID: 641
		private Button button2;

		// Token: 0x04000282 RID: 642
		private Button button3;

		// Token: 0x04000283 RID: 643
		private Button button4;

		// Token: 0x04000284 RID: 644
		private Button button6;

		// Token: 0x04000285 RID: 645
		private Button button7;

		// Token: 0x04000286 RID: 646
		private Button button8;

		// Token: 0x04000287 RID: 647
		private Button button9;

		// Token: 0x04000288 RID: 648
		private Button button10;

		// Token: 0x04000289 RID: 649
		private Button button11;

		// Token: 0x0400028A RID: 650
		private Button button12;

		// Token: 0x0400028B RID: 651
		private Button button13;

		// Token: 0x0400028C RID: 652
		private Button button14;

		// Token: 0x0400028D RID: 653
		private Button button15;

		// Token: 0x0400028E RID: 654
		private Button button16;

		// Token: 0x0400028F RID: 655
		private Button button17;

		// Token: 0x04000290 RID: 656
		private Button button18;

		// Token: 0x04000291 RID: 657
		private Button button19;

		// Token: 0x04000292 RID: 658
		private Button button20;

		// Token: 0x04000293 RID: 659
		private Button button21;

		// Token: 0x04000294 RID: 660
		private Button button22;

		// Token: 0x04000295 RID: 661
		private Button button23;

		// Token: 0x04000296 RID: 662
		private Button button24;

		// Token: 0x04000297 RID: 663
		private Button button25;

		// Token: 0x04000298 RID: 664
		private Button button26;

		// Token: 0x04000299 RID: 665
		private Label label13;
	}
}
