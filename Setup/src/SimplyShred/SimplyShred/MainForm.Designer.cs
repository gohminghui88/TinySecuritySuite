/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 1:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace SimplyShred
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button browseButton;
		private System.Windows.Forms.Button shredButton;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox inFileTextBox;
		
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
			this.browseButton = new System.Windows.Forms.Button();
			this.shredButton = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.inFileTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(38, 51);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(75, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "File to Shred: ";
			// 
			// browseButton
			// 
			this.browseButton.Location = new System.Drawing.Point(462, 48);
			this.browseButton.Name = "browseButton";
			this.browseButton.Size = new System.Drawing.Size(34, 23);
			this.browseButton.TabIndex = 1;
			this.browseButton.Text = "...";
			this.browseButton.UseVisualStyleBackColor = true;
			this.browseButton.Click += new System.EventHandler(this.BrowseButtonClick);
			// 
			// shredButton
			// 
			this.shredButton.Location = new System.Drawing.Point(340, 90);
			this.shredButton.Name = "shredButton";
			this.shredButton.Size = new System.Drawing.Size(75, 23);
			this.shredButton.TabIndex = 2;
			this.shredButton.Text = "Shred";
			this.shredButton.UseVisualStyleBackColor = true;
			this.shredButton.Click += new System.EventHandler(this.ShredButtonClick);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(421, 90);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(75, 23);
			this.button3.TabIndex = 3;
			this.button3.Text = "Cancel";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.Button3Click);
			// 
			// inFileTextBox
			// 
			this.inFileTextBox.Location = new System.Drawing.Point(119, 48);
			this.inFileTextBox.Name = "inFileTextBox";
			this.inFileTextBox.Size = new System.Drawing.Size(337, 20);
			this.inFileTextBox.TabIndex = 4;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(546, 156);
			this.Controls.Add(this.inFileTextBox);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.shredButton);
			this.Controls.Add(this.browseButton);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "SimplyShred";
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
