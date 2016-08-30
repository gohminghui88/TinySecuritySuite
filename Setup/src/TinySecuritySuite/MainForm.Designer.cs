/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace TinySecuritySuite
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button avButton;
		private System.Windows.Forms.Button fwButton;
		private System.Windows.Forms.Button sfButton;
		private System.Windows.Forms.Button feButton;
		private System.Windows.Forms.Button shredButton;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Button cancelButton;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.avButton = new System.Windows.Forms.Button();
			this.fwButton = new System.Windows.Forms.Button();
			this.sfButton = new System.Windows.Forms.Button();
			this.feButton = new System.Windows.Forms.Button();
			this.shredButton = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.cancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// avButton
			// 
			this.avButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.avButton.Location = new System.Drawing.Point(118, 41);
			this.avButton.Name = "avButton";
			this.avButton.Size = new System.Drawing.Size(550, 65);
			this.avButton.TabIndex = 0;
			this.avButton.Text = "Antivirus";
			this.avButton.UseVisualStyleBackColor = true;
			this.avButton.Click += new System.EventHandler(this.AvButtonClick);
			// 
			// fwButton
			// 
			this.fwButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.fwButton.Location = new System.Drawing.Point(118, 112);
			this.fwButton.Name = "fwButton";
			this.fwButton.Size = new System.Drawing.Size(550, 65);
			this.fwButton.TabIndex = 1;
			this.fwButton.Text = "Firewall";
			this.fwButton.UseVisualStyleBackColor = true;
			this.fwButton.Click += new System.EventHandler(this.FwButtonClick);
			// 
			// sfButton
			// 
			this.sfButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.sfButton.Location = new System.Drawing.Point(118, 183);
			this.sfButton.Name = "sfButton";
			this.sfButton.Size = new System.Drawing.Size(550, 65);
			this.sfButton.TabIndex = 2;
			this.sfButton.Text = "Secure Folder";
			this.sfButton.UseVisualStyleBackColor = true;
			this.sfButton.Click += new System.EventHandler(this.SfButtonClick);
			// 
			// feButton
			// 
			this.feButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.feButton.Location = new System.Drawing.Point(118, 254);
			this.feButton.Name = "feButton";
			this.feButton.Size = new System.Drawing.Size(550, 65);
			this.feButton.TabIndex = 3;
			this.feButton.Text = "File Encryption";
			this.feButton.UseVisualStyleBackColor = true;
			this.feButton.Click += new System.EventHandler(this.FeButtonClick);
			// 
			// shredButton
			// 
			this.shredButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.shredButton.Location = new System.Drawing.Point(118, 325);
			this.shredButton.Name = "shredButton";
			this.shredButton.Size = new System.Drawing.Size(550, 65);
			this.shredButton.TabIndex = 4;
			this.shredButton.Text = "File Shredder";
			this.shredButton.UseVisualStyleBackColor = true;
			this.shredButton.Click += new System.EventHandler(this.ShredButtonClick);
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(603, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 23);
			this.label1.TabIndex = 5;
			this.label1.Text = "About";
			this.label1.Click += new System.EventHandler(this.Label1Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(12, 41);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(100, 65);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 6;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
			this.pictureBox2.Location = new System.Drawing.Point(12, 112);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(100, 65);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 7;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
			this.pictureBox3.Location = new System.Drawing.Point(12, 183);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(100, 65);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 8;
			this.pictureBox3.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
			this.pictureBox4.Location = new System.Drawing.Point(12, 254);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(100, 65);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox4.TabIndex = 9;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
			this.pictureBox5.Location = new System.Drawing.Point(12, 325);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(100, 65);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox5.TabIndex = 10;
			this.pictureBox5.TabStop = false;
			// 
			// cancelButton
			// 
			this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.cancelButton.Location = new System.Drawing.Point(593, 415);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 23);
			this.cancelButton.TabIndex = 11;
			this.cancelButton.Text = "Cancel";
			this.cancelButton.UseVisualStyleBackColor = true;
			this.cancelButton.Click += new System.EventHandler(this.CancelButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.cancelButton;
			this.ClientSize = new System.Drawing.Size(683, 450);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.pictureBox5);
			this.Controls.Add(this.pictureBox4);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.shredButton);
			this.Controls.Add(this.feButton);
			this.Controls.Add(this.sfButton);
			this.Controls.Add(this.fwButton);
			this.Controls.Add(this.avButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Tiny Security Suite v1.0.0 beta";
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
