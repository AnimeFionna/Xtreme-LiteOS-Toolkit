namespace WindowsFormsApplication2.User_Controls
{
	// Token: 0x0200000E RID: 14
	public partial class custom : global::System.Windows.Forms.Form
	{
		// Token: 0x06000116 RID: 278 RVA: 0x0002B464 File Offset: 0x00029664
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000117 RID: 279 RVA: 0x0002B49C File Offset: 0x0002969C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.User_Controls.custom));
			this.label1 = new global::System.Windows.Forms.Label();
			this.button7 = new global::System.Windows.Forms.Button();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(78, 32);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(236, 34);
			this.label1.TabIndex = 1;
			this.label1.Text = "Download Completed!";
			this.button7.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.button7.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button7.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button7.FlatAppearance.BorderSize = 0;
			this.button7.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button7.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button7.ForeColor = global::System.Drawing.Color.White;
			this.button7.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button7.Image");
			this.button7.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button7.Location = new global::System.Drawing.Point(34, 95);
			this.button7.Margin = new global::System.Windows.Forms.Padding(1);
			this.button7.Name = "button7";
			this.button7.Size = new global::System.Drawing.Size(134, 30);
			this.button7.TabIndex = 269;
			this.button7.TabStop = false;
			this.button7.Text = "Open Folder";
			this.button7.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button7.UseVisualStyleBackColor = false;
			this.button7.Click += new global::System.EventHandler(this.button7_Click);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(22, 18);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			this.button1.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			this.button1.BackgroundImageLayout = global::System.Windows.Forms.ImageLayout.None;
			this.button1.Cursor = global::System.Windows.Forms.Cursors.Hand;
			this.button1.FlatAppearance.BorderSize = 0;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 11.25f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("button1.Image");
			this.button1.ImageAlign = global::System.Drawing.ContentAlignment.MiddleLeft;
			this.button1.Location = new global::System.Drawing.Point(227, 95);
			this.button1.Margin = new global::System.Windows.Forms.Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(85, 30);
			this.button1.TabIndex = 270;
			this.button1.TabStop = false;
			this.button1.Text = "Close";
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel1.Location = new global::System.Drawing.Point(1, -8);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(388, 32);
			this.panel1.TabIndex = 271;
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			base.ClientSize = new global::System.Drawing.Size(361, 146);
			base.ControlBox = false;
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.button7);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "custom";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "msgbox";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400026B RID: 619
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400026C RID: 620
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x0400026D RID: 621
		private global::System.Windows.Forms.Label label1;

		// Token: 0x0400026E RID: 622
		private global::System.Windows.Forms.Button button7;

		// Token: 0x0400026F RID: 623
		private global::System.Windows.Forms.Button button1;

		// Token: 0x04000270 RID: 624
		private global::System.Windows.Forms.Panel panel1;
	}
}
