/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 1:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace SimplyShred
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
		
		void BrowseButtonClick(object sender, EventArgs e)
		{
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Multiselect = false;
			
			DialogResult res = ofd.ShowDialog();
			
			if(res == DialogResult.OK)
			{
				inFileTextBox.Text = ofd.FileName;
			}
		}
		
		void Button3Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void ShredButtonClick(object sender, EventArgs e)
		{
			try {
				
				if(inFileTextBox.Text != "")
				{
					DialogResult res = MessageBox.Show("Shredded File cannot be Recovered. Are you sure?", "Confirm?", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
			
					if(res == DialogResult.Yes)
					{
						Shredder shredderObj = new Shredder();
				
						bool sres = shredderObj.ShredFile(inFileTextBox.Text);
					
						if(sres) 
						{
							MessageBox.Show("Shredded Successfully. ");
							inFileTextBox.Text = "";
						}
						else MessageBox.Show("Failed. ");
					}
				}
				
				else MessageBox.Show("Please select a file first. ");
			
			}
			
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		
		
		
	}
}
