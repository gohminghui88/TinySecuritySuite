/*
 * Created by SharpDevelop.
 * User: IRU-RA1
 * Date: 25/08/2016
 * Time: 2:00 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 * 
 * References: http://sciguyryan.com/2011/07/23/file-shredder-code-sample-c-4-0/
 * 
 */
using System;
using System.IO;
using System.Linq;

namespace SimplyShred
{
	/// <summary>
	/// Description of Shredder.
	/// </summary>
	public class Shredder
	{
		public Shredder()
		{
		}
		
		private Random Randomizer = new Random();

		public bool Shred(string directoryPath, bool shouldDelete = true)
		{
			bool success = true;
			try {
				string[] files = Directory.GetFiles(directoryPath, "*", SearchOption.AllDirectories);
				foreach (string file in files) {
					success &= this.ShredFile(file, shouldDelete);
				}

				string[] directories = Directory.GetDirectories(directoryPath,
					                               "*",
					                               SearchOption.AllDirectories).OrderByDescending(str =>
                                                                                                           str.Split('\\').Length - 1).ToArray();
				foreach (string directory in directories) {
					success &= this.ShredDirectory(directory, shouldDelete);
				}

				success &= this.ShredDirectory(directoryPath, shouldDelete);
			} catch {
				success = false;
			}
			return success;
		}

		public bool ShredDirectory(string directoryPath, bool shouldDelete = true)
		{
			bool success = true;
			try {
				DirectoryInfo directoryInfo = new DirectoryInfo(directoryPath);

				string[] directoryBits = directoryPath.Split('\\');
				directoryBits[directoryBits.Length - 1] = this.RandomName(directoryInfo.Name.Length);

				string newDirectoryPath = String.Join("\\", directoryBits);
				directoryInfo.MoveTo(newDirectoryPath);

				if (shouldDelete) {
					directoryInfo.Delete();
				}
			} catch {
				success = false;
			}
			return success;
		}

		public bool ShredFile(string filePath, bool shouldDelete = true)
		{
			bool success = true;
			try {
				FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Write);
				for (long i = 0; i < fs.Length; i++) {
					fs.WriteByte((byte)Randomizer.Next(0, 255));
				}
				fs.Close();

				FileInfo fileInfo = new FileInfo(filePath);
				fileInfo.MoveTo(fileInfo.DirectoryName + @"\" + this.RandomName(fileInfo.Name.Length));

				if (shouldDelete) {
					fileInfo.Delete();
				}
			} catch {
				success = false;
			}
			return success;
		}

		private string RandomName(int length)
		{
			string fileNameChars = "abcdefghijklmnopqrstuvwxyz1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZ~!@¤#$£§%^&()+`={}][;,";
			string newFileName = String.Empty;
			for (int i = 0; i < length; i++) {
				newFileName += fileNameChars[Randomizer.Next(0, fileNameChars.Length)];
			}
			return newFileName;
		}
	}
}
