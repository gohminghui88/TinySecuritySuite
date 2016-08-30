/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 12:32 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;


namespace AESCrypto
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		void CanButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void BrowseButtonClick(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Multiselect = false;
			
			DialogResult res = fd.ShowDialog();
			
			if(res == DialogResult.OK) {
				
				string inFile = fd.FileName;
				string ext = Path.GetExtension(inFile);
				
				string outFile = inFile;
				
				if(ext.ToLower().Contains("aes")) {
					cryptButton.Text = "Decrypt";
					
					outFile = inFile.Replace(ext, "");
				}
				
				else {
					outFile += ".aes";
					cryptButton.Text = "Encrypt";
				}
				
				inFileTextBox.Text = inFile;
				outFileLabel.Text = outFile;
				
				//MessageBox.Show(ext);
			}
		}
		void CryptButtonClick(object sender, EventArgs e)
		{
			if(inFileTextBox.Text != "")
			{
				if(pass1TextBox.Text != "" && pass2TextBox.Text != "")
				{
					if(pass1TextBox.Text == pass2TextBox.Text)
					{
						if(pass1TextBox.Text.ToCharArray().Length == 8)
						{
							if(cryptButton.Text.ToLower() == "encrypt")
							{
								AES crypto = new AES();
								crypto.EncryptFile(inFileTextBox.Text, outFileLabel.Text, pass1TextBox.Text);
							}
						
							else {
								AES crypto = new AES();
								crypto.DecryptFile(inFileTextBox.Text, outFileLabel.Text, pass1TextBox.Text);
							}
						
							MessageBox.Show("Operation executed. ");
						}
						
						else
							MessageBox.Show("Passwords must contain only 8 characters. ");
					}
					else
						MessageBox.Show("Both Passwords are different from each other. ");
				}
				
				else
					MessageBox.Show("Both passwords fields cannot be empty. ");
			}
			
			else
				MessageBox.Show("Please select a file first. ");
		}
		
		
	}
}
