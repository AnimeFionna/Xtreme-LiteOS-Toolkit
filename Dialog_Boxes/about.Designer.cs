namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000012 RID: 18
	public partial class about : global::System.Windows.Forms.Form
	{
		// Token: 0x0600016E RID: 366 RVA: 0x0003564C File Offset: 0x0003384C
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00035684 File Offset: 0x00033884
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.about));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label3 = new global::System.Windows.Forms.Label();
			this.pictureBox4 = new global::System.Windows.Forms.PictureBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.label2 = new global::System.Windows.Forms.Label();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.label6 = new global::System.Windows.Forms.Label();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.label7 = new global::System.Windows.Forms.Label();
			this.label8 = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.label9 = new global::System.Windows.Forms.Label();
			this.label10 = new global::System.Windows.Forms.Label();
			this.label11 = new global::System.Windows.Forms.Label();
			this.label12 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).BeginInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.Location = new global::System.Drawing.Point(-9, -8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(398, 38);
			this.panel1.TabIndex = 272;
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(289, 399);
			this.button1.Margin = new global::System.Windows.Forms.Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(85, 30);
			this.button1.TabIndex = 273;
			this.button1.TabStop = false;
			this.button1.Text = "Close";
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 18f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.White;
			this.label3.Location = new global::System.Drawing.Point(66, 28);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(84, 38);
			this.label3.TabIndex = 274;
			this.label3.Text = "About";
			this.pictureBox4.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox4.Image");
			this.pictureBox4.Location = new global::System.Drawing.Point(12, 16);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new global::System.Drawing.Size(64, 64);
			this.pictureBox4.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 275;
			this.pictureBox4.TabStop = false;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.Silver;
			this.label1.Location = new global::System.Drawing.Point(22, 83);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(325, 19);
			this.label1.TabIndex = 277;
			this.label1.Text = "This tool is made by The World Of PC and specifically for";
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Silver;
			this.label2.Location = new global::System.Drawing.Point(33, 102);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(308, 19);
			this.label2.TabIndex = 278;
			this.label2.Text = "Xtreme LiteOS, hence it can't be used on any other OS";
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.Color.Silver;
			this.label5.Location = new global::System.Drawing.Point(8, 411);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(147, 19);
			this.label5.TabIndex = 279;
			this.label5.Text = "© The World Of PC 2021";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.Color.Silver;
			this.label4.Location = new global::System.Drawing.Point(25, 154);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(318, 19);
			this.label4.TabIndex = 280;
			this.label4.Text = "you are reading this, thank you for downloading the OS";
			this.label6.AutoSize = true;
			this.label6.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label6.ForeColor = global::System.Drawing.Color.Silver;
			this.label6.Location = new global::System.Drawing.Point(36, 173);
			this.label6.Name = "label6";
			this.label6.Size = new global::System.Drawing.Size(296, 19);
			this.label6.TabIndex = 281;
			this.label6.Text = "and believing in this project! I'm less likely to provide";
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(12, 254);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(136, 136);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 282;
			this.pictureBox1.TabStop = false;
			this.label7.AutoSize = true;
			this.label7.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label7.ForeColor = global::System.Drawing.Color.Silver;
			this.label7.Location = new global::System.Drawing.Point(217, 289);
			this.label7.Name = "label7";
			this.label7.Size = new global::System.Drawing.Size(79, 19);
			this.label7.TabIndex = 283;
			this.label7.Text = "Version : 4.10";
			this.label8.AutoSize = true;
			this.label8.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label8.ForeColor = global::System.Drawing.Color.Silver;
			this.label8.Location = new global::System.Drawing.Point(182, 308);
			this.label8.Name = "label8";
			this.label8.Size = new global::System.Drawing.Size(154, 19);
			this.label8.TabIndex = 284;
			this.label8.Text = "Last Updated : 08/24/2021";
			this.linkLabel1.ActiveLinkColor = global::System.Drawing.Color.SteelBlue;
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.LinkColor = global::System.Drawing.Color.DeepSkyBlue;
			this.linkLabel1.Location = new global::System.Drawing.Point(159, 342);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(208, 13);
			this.linkLabel1.TabIndex = 286;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "https://www.youtube.com/TheWorldOfPC";
			this.linkLabel1.VisitedLinkColor = global::System.Drawing.Color.DeepSkyBlue;
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.label9.AutoSize = true;
			this.label9.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label9.ForeColor = global::System.Drawing.Color.Silver;
			this.label9.Location = new global::System.Drawing.Point(29, 135);
			this.label9.Name = "label9";
			this.label9.Size = new global::System.Drawing.Size(310, 19);
			this.label9.TabIndex = 287;
			this.label9.Text = "Hi there! Hope you are enjoying this software so far, If";
			this.label10.AutoSize = true;
			this.label10.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label10.ForeColor = global::System.Drawing.Color.Silver;
			this.label10.Location = new global::System.Drawing.Point(23, 192);
			this.label10.Name = "label10";
			this.label10.Size = new global::System.Drawing.Size(323, 19);
			this.label10.TabIndex = 288;
			this.label10.Text = "frequent updates to this tool, however download links will";
			this.label11.AutoSize = true;
			this.label11.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label11.ForeColor = global::System.Drawing.Color.Silver;
			this.label11.Location = new global::System.Drawing.Point(19, 211);
			this.label11.Name = "label11";
			this.label11.Size = new global::System.Drawing.Size(331, 19);
			this.label11.TabIndex = 289;
			this.label11.Text = "be updated automatically, IDK what else to write ¯\\_(ツ)_/¯";
			this.label12.AutoSize = true;
			this.label12.Font = new global::System.Drawing.Font("Josefin Sans", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label12.ForeColor = global::System.Drawing.Color.Silver;
			this.label12.Location = new global::System.Drawing.Point(158, 230);
			this.label12.Name = "label12";
			this.label12.Size = new global::System.Drawing.Size(53, 19);
			this.label12.TabIndex = 290;
			this.label12.Text = "Enjoy :P";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			base.ClientSize = new global::System.Drawing.Size(384, 439);
			base.Controls.Add(this.label12);
			base.Controls.Add(this.label11);
			base.Controls.Add(this.label10);
			base.Controls.Add(this.label9);
			base.Controls.Add(this.linkLabel1);
			base.Controls.Add(this.label8);
			base.Controls.Add(this.label7);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.label6);
			base.Controls.Add(this.label4);
			base.Controls.Add(this.label5);
			base.Controls.Add(this.label2);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label3);
			base.Controls.Add(this.pictureBox4);
			base.Controls.Add(this.button1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "about";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "about";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox4).EndInit();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040002F7 RID: 759
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x040002F8 RID: 760
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x040002F9 RID: 761
		private global::System.Windows.Forms.Button button1;

		// Token: 0x040002FA RID: 762
		private global::System.Windows.Forms.Label label3;

		// Token: 0x040002FB RID: 763
		private global::System.Windows.Forms.PictureBox pictureBox4;

		// Token: 0x040002FC RID: 764
		private global::System.Windows.Forms.Label label1;

		// Token: 0x040002FD RID: 765
		private global::System.Windows.Forms.Label label2;

		// Token: 0x040002FE RID: 766
		private global::System.Windows.Forms.Label label5;

		// Token: 0x040002FF RID: 767
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000300 RID: 768
		private global::System.Windows.Forms.Label label6;

		// Token: 0x04000301 RID: 769
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000302 RID: 770
		private global::System.Windows.Forms.Label label7;

		// Token: 0x04000303 RID: 771
		private global::System.Windows.Forms.Label label8;

		// Token: 0x04000304 RID: 772
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000305 RID: 773
		private global::System.Windows.Forms.Label label9;

		// Token: 0x04000306 RID: 774
		private global::System.Windows.Forms.Label label10;

		// Token: 0x04000307 RID: 775
		private global::System.Windows.Forms.Label label11;

		// Token: 0x04000308 RID: 776
		private global::System.Windows.Forms.Label label12;
	}
}
