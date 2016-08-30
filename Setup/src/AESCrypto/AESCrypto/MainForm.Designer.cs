/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace AESCrypto
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox inFileTextBox;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.TextBox pass1TextBox;
		private System.Windows.Forms.TextBox pass2TextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label outFileLabel;
		private System.Windows.Forms.Button cryptButton;
		private System.Windows.Forms.Button canButton;
		
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
			this.label1 = new System.Windows.Forms.Label();
			this.inFileTextBox = new System.Windows.Forms.TextBox();
			this.browseButton = new System.Windows.Forms.Button();
			this.pass1TextBox = new System.Windows.Forms.TextBox();
			this.pass2TextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label4 = new System.Windows.Forms.Label();
			this.outFileLabel = new System.Windows.Forms.Label();
			this.cryptButton = new System.Windows.Forms.Button();
			this.canButton = new System.Windows.Forms.Button();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(58, 43);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(61, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "File: ";
			// 
			// inFileTextBox
			// 
			this.inFileTextBox.Location = new System.Drawing.Point(94, 40);
			this.inFileTextBox.Name = "inFileTextBox";
			this.inFileTextBox.Size = new System.Drawing.Size(417, 20);
			this.inFileTextBox.TabIndex = 1;
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(517, 38);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(28, 23);
			this.browseButton.TabIndex = 2;
			this.browseButton.Text = "...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// pass1TextBox
			// 
			this.pass1TextBox.Location = new System.Drawing.Point(130, 31);
			this.pass1TextBox.Name = "pass1TextBox";
			this.pass1TextBox.Size = new System.Drawing.Size(295, 20);
			this.pass1TextBox.TabIndex = 3;
			this.pass1TextBox.UseSystemPasswordChar = true;
			// 
			// pass2TextBox
			// 
			this.pass2TextBox.Location = new System.Drawing.Point(130, 57);
			this.pass2TextBox.Name = "pass2TextBox";
			this.pass2TextBox.Size = new System.Drawing.Size(295, 20);
			this.pass2TextBox.TabIndex = 4;
			this.pass2TextBox.UseSystemPasswordChar = true;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(19, 34);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(61, 23);
			this.label2.TabIndex = 5;
			this.label2.Text = "Passwords: ";
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(19, 60);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(105, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Confirm Passwords: ";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.pass1TextBox);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.pass2TextBox);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Location = new System.Drawing.Point(58, 121);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(487, 100);
			this.groupBox1.TabIndex = 7;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Settings";
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(58, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(80, 23);
			this.label4.TabIndex = 8;
			this.label4.Text = "Output File: ";
			// 
			// outFileLabel
			// 
			this.outFileLabel.AutoEllipsis = true;
			this.outFileLabel.Location = new System.Drawing.Point(126, 82);
			this.outFileLabel.Name = "outFileLabel";
			this.outFileLabel.Size = new System.Drawing.Size(385, 23);
			this.outFileLabel.TabIndex = 9;
			this.outFileLabel.Text = "...";
			// 
			// cryptButton
			// 
			this.cryptButton.Location = new System.Drawing.Point(602, 37);
			this.cryptButton.Name = "cryptButton";
			this.cryptButton.Size = new System.Drawing.Size(75, 23);
			this.cryptButton.TabIndex = 10;
			this.cryptButton.Text = "Encrypt";
			this.cryptButton.UseVisualStyleBackColor = true;
			this.cryptButton.Click += new System.EventHandler(this.CryptButtonClick);
			// 
			// canButton
			// 
			this.canButton.Location = new System.Drawing.Point(602, 66);
			this.canButton.Name = "canButton";
			this.canButton.Size = new System.Drawing.Size(75, 23);
			this.canButton.TabIndex = 11;
			this.canButton.Text = "Cancel";
			this.canButton.UseVisualStyleBackColor = true;
			this.canButton.Click += new System.EventHandler(this.CanButtonClick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(700, 254);
			this.Controls.Add(this.canButton);
			this.Controls.Add(this.cryptButton);
			this.Controls.Add(this.outFileLabel);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.inFileTextBox);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "AESCrypto v1.0 beta";
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
