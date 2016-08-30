/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 2:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace TinySecuritySuite
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		private string curDir = System.IO.Directory.GetCurrentDirectory();
		
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
		
		void CancelButtonClick(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void AvButtonClick(object sender, EventArgs e)
		{
			try { System.Diagnostics.Process.Start(curDir + "\\ClamWinPortable\\ClamWinPortable.exe"); }
			catch(Exception ex) {MessageBox.Show(ex.Message);}
		}
		
		void FwButtonClick(object sender, EventArgs e)
		{
			try {System.Diagnostics.Process.Start(curDir + "\\Firewall\\Firewall.exe"); }
			catch(Exception ex) {MessageBox.Show(ex.Message);}
		}
		
		void SfButtonClick(object sender, EventArgs e)
		{
			try {System.Diagnostics.Process.Start(curDir + "\\YASF.exe"); }
			catch(Exception ex) {MessageBox.Show(ex.Message);}
		}
		
		void FeButtonClick(object sender, EventArgs e)
		{
			try { System.Diagnostics.Process.Start(curDir + "\\AESCrypto.exe");}
			catch(Exception ex) {MessageBox.Show(ex.Message);}
		}
		
		void ShredButtonClick(object sender, EventArgs e)
		{
			try { System.Diagnostics.Process.Start(curDir + "\\SimplyShred.exe"); } 
			catch(Exception ex) {MessageBox.Show(ex.Message);}
		}
		void Label1Click(object sender, EventArgs e)
		{
			try {
				AboutForm ab = new AboutForm();
				ab.ShowDialog();
			}
			
			catch(Exception ex) {MessageBox.Show(ex.Message);}
		}
		
		
		
	}
}
