/**
 * WinDxArchive FileManager(Application entrypoint).
 * Author:  tk-xleader.
 * License: MIT License.
 * */
using System;
using System.Windows.Forms;

namespace WinDxArchive{
	class FileManager{
		/// Application entrypoint.
		public static void Main(string[] args){
			Application.Run(new MainForm());
		}
	}
}
