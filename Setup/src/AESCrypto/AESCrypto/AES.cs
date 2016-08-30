/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 12:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * References: http://www.codeproject.com/Articles/26085/File-Encryption-and-Decryption-in-C
 * 
 */
using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace AESCrypto
{
	/// <summary>
	/// Description of AES.
	/// </summary>
	public class AES
	{
		public AES()
		{
		}
		
		///<summary>
		/// Steve Lydford - 12/05/2008.
		///
		/// Encrypts a file using Rijndael algorithm.
		///</summary>
		///<param name="inputFile"></param>
		///<param name="outputFile"></param>
		public void EncryptFile(string inputFile, string outputFile, string pass)
		{

			try {
				string password = pass;
				UnicodeEncoding UE = new UnicodeEncoding();
				byte[] key = UE.GetBytes(password);

				string cryptFile = outputFile;
				FileStream fsCrypt = new FileStream(cryptFile, FileMode.Create);

				RijndaelManaged RMCrypto = new RijndaelManaged();

				CryptoStream cs = new CryptoStream(fsCrypt,
					                      RMCrypto.CreateEncryptor(key, key),
					                      CryptoStreamMode.Write);

				FileStream fsIn = new FileStream(inputFile, FileMode.Open);

				int data;
				while ((data = fsIn.ReadByte()) != -1)
					cs.WriteByte((byte)data);

        
				fsIn.Close();
				cs.Close();
				fsCrypt.Close();
			} catch {
				MessageBox.Show("Encryption failed!", "Error");
			}
		}
		///<summary>
		/// Steve Lydford - 12/05/2008.
		///
		/// Decrypts a file using Rijndael algorithm.
		///</summary>
		///<param name="inputFile"></param>
		///<param name="outputFile"></param>
		public void DecryptFile(string inputFile, string outputFile, string pass)
		{

			{
				string password = pass;

				UnicodeEncoding UE = new UnicodeEncoding();
				byte[] key = UE.GetBytes(password);

				FileStream fsCrypt = new FileStream(inputFile, FileMode.Open);

				RijndaelManaged RMCrypto = new RijndaelManaged();

				CryptoStream cs = new CryptoStream(fsCrypt,
					                      RMCrypto.CreateDecryptor(key, key),
					                      CryptoStreamMode.Read);

				FileStream fsOut = new FileStream(outputFile, FileMode.Create);

				int data;
				while ((data = cs.ReadByte()) != -1)
					fsOut.WriteByte((byte)data);

				fsOut.Close();
				cs.Close();
				fsCrypt.Close();

			}
		}
	}
}
