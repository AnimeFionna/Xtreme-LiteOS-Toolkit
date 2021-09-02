namespace WindowsFormsApplication2.Dialog_Boxes
{
	// Token: 0x02000014 RID: 20
	public partial class cleared : global::System.Windows.Forms.Form
	{
		// Token: 0x06000180 RID: 384 RVA: 0x00036A34 File Offset: 0x00034C34
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000181 RID: 385 RVA: 0x00036A6C File Offset: 0x00034C6C
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::WindowsFormsApplication2.Dialog_Boxes.cleared));
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.pictureBox1 = new global::System.Windows.Forms.PictureBox();
			this.button1 = new global::System.Windows.Forms.Button();
			this.label1 = new global::System.Windows.Forms.Label();
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).BeginInit();
			base.SuspendLayout();
			this.panel1.Location = new global::System.Drawing.Point(-4, -6);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(388, 32);
			this.panel1.TabIndex = 278;
			this.panel1.MouseMove += new global::System.Windows.Forms.MouseEventHandler(this.panel1_Paint);
			this.pictureBox1.Image = (global::System.Drawing.Image)componentResourceManager.GetObject("pictureBox1.Image");
			this.pictureBox1.Location = new global::System.Drawing.Point(18, 17);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new global::System.Drawing.Size(60, 60);
			this.pictureBox1.SizeMode = global::System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 285;
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
			this.button1.Location = new global::System.Drawing.Point(165, 79);
			this.button1.Margin = new global::System.Windows.Forms.Padding(1);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(85, 30);
			this.button1.TabIndex = 284;
			this.button1.TabStop = false;
			this.button1.Text = "Close";
			this.button1.TextAlign = global::System.Drawing.ContentAlignment.MiddleRight;
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Josefin Sans SemiBold", 16f, global::System.Drawing.FontStyle.Bold, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.Color.White;
			this.label1.Location = new global::System.Drawing.Point(74, 31);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(99, 34);
			this.label1.TabIndex = 283;
			this.label1.Text = "Cleared!";
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = global::System.Drawing.Color.FromArgb(28, 28, 28);
			base.ClientSize = new global::System.Drawing.Size(265, 123);
			base.Controls.Add(this.pictureBox1);
			base.Controls.Add(this.button1);
			base.Controls.Add(this.label1);
			base.Controls.Add(this.panel1);
			base.FormBorderStyle = global::System.Windows.Forms.FormBorderStyle.None;
			base.Name = "cleared";
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			base.StartPosition = global::System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "cleared";
			((global::System.ComponentModel.ISupportInitialize)this.pictureBox1).EndInit();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x04000316 RID: 790
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x04000317 RID: 791
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x04000318 RID: 792
		private global::System.Windows.Forms.PictureBox pictureBox1;

		// Token: 0x04000319 RID: 793
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400031A RID: 794
		private global::System.Windows.Forms.Label label1;
	}
}
