using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Code.Data.Config.Editor
{
	public static class FilesWorker
	{
		private const string DirectoryPath = "DataModel/Dll";

		// Copy all the dll files and pdb files to the project folder.
		public static void CopyDlls(string pathToDlls)
		{
			CopyFilesWithExtension("*.dll", from: pathToDlls);
			CopyFilesWithExtension("*.pdb", from: pathToDlls);
		}

		private static void CopyFilesWithExtension(string extension, string from) 
			=> CopyFilesToProject(Directory.GetFiles(from, extension, SearchOption.AllDirectories));

		private static void CopyFilesToProject(IEnumerable<string> files)
		{
			foreach (var file in files)
			{
				var fileName = Path.GetFileName(file);
				
				if (fileName == null)
				{
					continue;
				}

				var destination = Path.Combine(Application.dataPath, DirectoryPath, fileName);
				File.Copy(file, destination, overwrite: true);
			}
		}
	}
}