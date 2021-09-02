namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000015 RID: 21
	public partial class Error : global::System.Windows.Forms.Form
	{
		// Token: 0x0600018A RID: 394 RVA: 0x00036F44 File Offset: 0x00035144
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600018B RID: 395 RVA: 0x00036F7C File Offset: 0x0003517C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.Error));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label9 = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label3 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.Location = new global::System.Drawing.Point(-4, -6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(524, 32);
			this.panel1.TabIndex = 276;
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(43, 15);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 277;
			this.pictureBox1.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(99, 29);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(254, 34);
			this.label1.TabIndex = 278;
			this.label1.Text = "Couldn't Download File!";
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(345, 143);
			this.button1.Margin = new global::System.Windows.Forms.Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(85, 30);
			this.button1.TabIndex = 279;
			this.button1.TabStop = false;
			this.button1.Text = "Close";
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click_1);
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.Silver;
			this.label9.Location = new global::System.Drawing.Point(6, 78);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(430, 19);
			this.label9.TabIndex = 280;
			this.label9.Text = "Toolkit was unable to download the file, please try again. Make sure that you";
			this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.SteelBlue;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.DeepSkyBlue;
			this.linkLabel1.Location = new global::System.Drawing.Point(9, 154);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(172, 13);
			this.linkLabel1.TabIndex = 282;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Report a broken link discord server";
			this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.DeepSkyBlue;
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Silver;
			this.label2.Location = new global::System.Drawing.Point(16, 97);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(407, 19);
			this.label2.TabIndex = 281;
			this.label2.Text = " are connected to internet, or use Cloudflare/Google DNS if the problem";
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Silver;
			this.label3.Location = new global::System.Drawing.Point(195, 113);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(60, 19);
			this.label3.TabIndex = 283;
			this.label3.Text = "still exists";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			base.ClientSize = new global::System.Drawing.Size(440, 183);
			base.ControlBox = false;
			base.Controls.Add(this.label3);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "Error";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Error";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400031F RID: 799
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000320 RID: 800
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000321 RID: 801
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000322 RID: 802
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000323 RID: 803
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000324 RID: 804
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000325 RID: 805
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000326 RID: 806
		private global::System.Windows.Forms.Label label2;

		// Token: 0x04000327 RID: 807
		private global::System.Windows.Forms.Label label3;
	}
}
